namespace PayClock
{
    partial class PayClock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.labelRate = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelDollarRate = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelRate = new System.Windows.Forms.Panel();
            this.panelGoal = new System.Windows.Forms.Panel();
            this.labelGoal = new System.Windows.Forms.Label();
            this.labelDollarGoal = new System.Windows.Forms.Label();
            this.textBoxGoal = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.panelRate.SuspendLayout();
            this.panelGoal.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(5, 55);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(305, 55);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStartStop.TabIndex = 3;
            this.buttonStartStop.Text = "Start";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // textBoxRate
            // 
            this.textBoxRate.Location = new System.Drawing.Point(16, 16);
            this.textBoxRate.MaxLength = 8;
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(62, 20);
            this.textBoxRate.TabIndex = 0;
            this.textBoxRate.TextChanged += new System.EventHandler(this.textBoxRate_TextChanged);
            // 
            // labelRate
            // 
            this.labelRate.AutoSize = true;
            this.labelRate.Location = new System.Drawing.Point(3, 0);
            this.labelRate.Name = "labelRate";
            this.labelRate.Size = new System.Drawing.Size(59, 13);
            this.labelRate.TabIndex = 3;
            this.labelRate.Text = "Rate /hour";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(95, 55);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.labelTotal, 3);
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(273, 2);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTotal.Size = new System.Drawing.Size(119, 50);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "$0.00";
            // 
            // labelDollarRate
            // 
            this.labelDollarRate.AutoSize = true;
            this.labelDollarRate.Location = new System.Drawing.Point(3, 19);
            this.labelDollarRate.Name = "labelDollarRate";
            this.labelDollarRate.Size = new System.Drawing.Size(13, 13);
            this.labelDollarRate.TabIndex = 6;
            this.labelDollarRate.Text = "$";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(215, 55);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "&Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel.Controls.Add(this.panelRate, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelTotal, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonReset, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonStartStop, 4, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonClose, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.panelGoal, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonSave, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(386, 87);
            this.tableLayoutPanel.TabIndex = 8;
            // 
            // panelRate
            // 
            this.panelRate.Controls.Add(this.labelRate);
            this.panelRate.Controls.Add(this.labelDollarRate);
            this.panelRate.Controls.Add(this.textBoxRate);
            this.panelRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRate.Location = new System.Drawing.Point(5, 5);
            this.panelRate.Name = "panelRate";
            this.panelRate.Size = new System.Drawing.Size(84, 44);
            this.panelRate.TabIndex = 8;
            // 
            // panelGoal
            // 
            this.panelGoal.Controls.Add(this.labelGoal);
            this.panelGoal.Controls.Add(this.labelDollarGoal);
            this.panelGoal.Controls.Add(this.textBoxGoal);
            this.panelGoal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGoal.Location = new System.Drawing.Point(95, 5);
            this.panelGoal.Name = "panelGoal";
            this.panelGoal.Size = new System.Drawing.Size(84, 44);
            this.panelGoal.TabIndex = 9;
            // 
            // labelGoal
            // 
            this.labelGoal.AutoSize = true;
            this.labelGoal.Location = new System.Drawing.Point(3, 0);
            this.labelGoal.Name = "labelGoal";
            this.labelGoal.Size = new System.Drawing.Size(29, 13);
            this.labelGoal.TabIndex = 3;
            this.labelGoal.Text = "Goal";
            // 
            // labelDollarGoal
            // 
            this.labelDollarGoal.AutoSize = true;
            this.labelDollarGoal.Location = new System.Drawing.Point(3, 19);
            this.labelDollarGoal.Name = "labelDollarGoal";
            this.labelDollarGoal.Size = new System.Drawing.Size(13, 13);
            this.labelDollarGoal.TabIndex = 6;
            this.labelDollarGoal.Text = "$";
            // 
            // textBoxGoal
            // 
            this.textBoxGoal.Location = new System.Drawing.Point(16, 16);
            this.textBoxGoal.MaxLength = 8;
            this.textBoxGoal.Name = "textBoxGoal";
            this.textBoxGoal.Size = new System.Drawing.Size(62, 20);
            this.textBoxGoal.TabIndex = 0;
            this.textBoxGoal.TextChanged += new System.EventHandler(this.textBoxGoal_TextChanged);
            // 
            // PayClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 87);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 500);
            this.MinimizeBox = false;
            this.Name = "PayClock";
            this.Text = "Pay Clock";
            this.TopMost = true;
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.panelRate.ResumeLayout(false);
            this.panelRate.PerformLayout();
            this.panelGoal.ResumeLayout(false);
            this.panelGoal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelDollarRate;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelRate;
        private System.Windows.Forms.Panel panelGoal;
        private System.Windows.Forms.Label labelGoal;
        private System.Windows.Forms.Label labelDollarGoal;
        private System.Windows.Forms.TextBox textBoxGoal;
    }
}

