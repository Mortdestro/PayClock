using System;
using System.IO;
using System.Windows.Forms;
using WMPLib;

namespace PayClock
{
    public partial class PayClock : Form
    {
        private const string SAVE_PATH = "%APPDATA%\\PayClock\\";
        private const string SAVE_FILE = "data.txt";
        private const string KACHING_PATH = "kaching.mp3";
        private const int KACHING_INTERVAL = 10;

        private WindowsMediaPlayer player;

        public Timer Timer { get; set; }
        public bool Running { get; set; }
        public bool GoalMet { get; set; }
        public double Rate { get; set; }
        public double? Goal { get; set; }
        public double Total { get; set; }
        public double NextKaChing { get; set; }

        public string SavePath { get => Environment.ExpandEnvironmentVariables(SAVE_PATH); }
        
        public PayClock()
        {
            InitializeComponent();
            player = new WindowsMediaPlayer
            {
                URL = KACHING_PATH
            };

            player.controls.stop();

            Reset();
            SetTotalText();

            Timer = new Timer();
            Timer.Tick += new EventHandler(OnTick);
            Timer.Interval = 50;
        }

        #region Event handlers

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save(SavePath, SAVE_FILE, DateTime.Now, Rate, Total);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (Running)
            {
                Stop();
            }
            else
            {
                Start();
            }
        }

        private void textBoxRate_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxRate.Text, out double rate))
            {
                buttonStartStop.Enabled = true;
                Rate = rate;
            }
            else
            {
                buttonStartStop.Enabled = false;
            }
        }

        private void textBoxGoal_TextChanged(object sender, EventArgs e)
        {
            GoalMet = false;

            if (string.IsNullOrEmpty(textBoxGoal.Text.Trim()))
            {
                buttonStartStop.Enabled = true;
                Goal = null;
            }
            else if (double.TryParse(textBoxGoal.Text, out double goal))
            {
                buttonStartStop.Enabled = true;
                Goal = goal;
            }
            else
            {
                buttonStartStop.Enabled = false;
            }
        }

        #endregion

        #region Overrides

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
                ConfirmClose(e);
        }

        #endregion

        #region Save file

        private void Save(string savePath, string saveFile, DateTime date, double rate, double total)
        {
            // Check for save file and do some processing
            if (!Directory.Exists(savePath))
            {
                Directory.CreateDirectory(savePath);
            }

            string[] data = ReadFile(savePath + saveFile);
            StreamWriter sw = new StreamWriter(savePath + saveFile);

            // If it's an empty file, just write this entry
            bool updated = false;
            for (int i = 0; i < data.Length; i++)
            {
                string line = data[i];

                CheckFormat(line);

                var sections = line.Split(new char[] { ';' });
                switch (sections[0])
                {
                    case "v1":
                        // version;MM/yyyy;total
                        string[] dateParts = sections[1].Split('/');

                        if (int.Parse(dateParts[0]) == date.Month && int.Parse(dateParts[1]) == date.Year)
                        {
                            line = SaveEntry(date, rate, total);
                            updated = true;
                        }
                        break;
                    default:
                        throw new FormatException("Invalid version specified in save file");
                }
                sw.WriteLine(line);
            }
            if (!updated)
            {
                sw.WriteLine(SaveEntry(date, rate, total));
                updated = true;
            }

            sw.Close();
        }

        private string GetSaved(string savePath, string saveFile, DateTime date)
        {
            string[] data = ReadFile(savePath + saveFile);

            if (data == null)
            {
                return null;
            }
            foreach (string line in data)
            {
                CheckFormat(line);

                var sections = line.Split(new char[] { ';' });
                // Check the formatting version
                switch (sections[0])
                {
                    case "v1":
                        // version;MM/yyyy;total
                        string[] dateParts = sections[1].Split('/');

                        if (int.Parse(dateParts[0]) == date.Month && int.Parse(dateParts[1]) == date.Year)
                        {
                            return line;
                        }
                        break;
                    default:
                        throw new FormatException("Invalid version specified in save file");
                }
            }
            // If we fall out of the for loop, assume the entry hasn't been added yet
            return null;
        }

        private double GetTotal(string entry)
        {
            if (string.IsNullOrEmpty(entry))
            {
                return 0;
            }
            string[] sections = entry.Split(';');
            // Check formatting version
            switch (sections[0])
            {
                case "v1":
                    // v1;MM/yyyy;rate;total
                    return double.Parse(sections[3]);
                default:
                    // Shouldn't ever hit here
                    return 0;
            }
        }

        private double GetRate(string entry)
        {
            if (string.IsNullOrEmpty(entry))
            {
                return 0;
            }
            string[] sections = entry.Split(';');
            // Check formatting version
            switch (sections[0])
            {
                case "v1":
                    // v1;MM/yyyy;rate;total
                    return double.Parse(sections[2]);
                default:
                    // Shouldn't ever hit here
                    return 0;
            }
        }

        private string[] ReadFile(string path)
        {
            try
            {
                StreamReader sr = new StreamReader(path);
                string[] data = sr.ReadToEnd().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                sr.Close();
                return data;
            }
            catch (Exception e)
            {
                if (e is FileNotFoundException || e is DirectoryNotFoundException)
                {
                    return null;
                }

                throw e;
            }
        }

        private void CheckFormat(string entry)
        {
            var sections = entry.Split(';');

            if (sections.Length <= 0) throw new FormatException("Invalid entry format in save file.");

            string version = sections[0];

            switch (version)
            {
                case "v1":
                    // version;MM/yyyy;total
                    CheckFormatV1(sections);
                    break;
                default:
                    throw new FormatException("Invalid version specified in save file");
            }
        }

        private void CheckFormatV1(string entry)
        {
            CheckFormatV1(entry.Split(';'));
        }

        private void CheckFormatV1(string[] sections)
        {
            if (sections.Length != 4) throw new FormatException("Invalid entry format in save file.");

            string[] dateParts = sections[1].Split('/');
            if (dateParts.Length != 2) throw new FormatException("Invalid date format in save file.");

            if (!int.TryParse(dateParts[0], out int month) || !int.TryParse(dateParts[1], out int year)) throw new FormatException("Invalid date format in save file.");
            if (!double.TryParse(sections[2], out double rate)) throw new FormatException("Invalid rate format in save file");
            if (!double.TryParse(sections[3], out double total)) throw new FormatException("Invalid total format in save file");
        }

        private string SaveEntry(DateTime date, double rate, double total)
        {
            return $"v1;{date.Month.ToString("00")}/{date.Year.ToString("0000")};{rate};{total}";
        }

        #endregion

        #region Timer

        private void Start()
        {
            // Disable controls
            textBoxRate.Enabled = false;
            textBoxGoal.Enabled = false;
            buttonClose.Enabled = false;
            buttonSave.Enabled = false;
            buttonReset.Enabled = false;

            // Change text
            buttonStartStop.Text = "Stop";

            Timer.Start();
            Running = true;
        }

        private void Stop()
        {
            // Enable controls
            textBoxRate.Enabled = true;
            textBoxGoal.Enabled = true;
            buttonClose.Enabled = true;
            buttonSave.Enabled = true;
            buttonReset.Enabled = true;

            // Change text
            buttonStartStop.Text = "Start";

            Timer.Stop();
            Running = false;
        }

        private void Reset()
        {
            string entry = GetSaved(SavePath, SAVE_FILE, DateTime.Now);

            Rate = GetRate(entry);
            Total = GetTotal(entry);
            Goal = null;
            GoalMet = false;
            NextKaChing = (int)Total / KACHING_INTERVAL * KACHING_INTERVAL + KACHING_INTERVAL;

            textBoxRate.Text = Rate.ToString("F");
            textBoxGoal.Text = "";
            SetTotalText();
        }
        
        private void OnTick(object obj, EventArgs eventArgs)
        {
            Total += Rate * Timer.Interval / 1000 / 60 / 60;
            if (Total >= Goal && !GoalMet) {
                player.controls.play();
                GoalMet = true;
            }
            SetTotalText();
        }
        #endregion

        private void ConfirmClose(FormClosingEventArgs e)
        {
            switch (MessageBox.Show("Are you sure you want to close the clock?", "Confirm Close", MessageBoxButtons.OKCancel))
            {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        private void SetTotalText()
        {
            labelTotal.Text = Total.ToString("C");
        }
    }
}
