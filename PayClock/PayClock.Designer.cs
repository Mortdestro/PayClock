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
            this.labelDollar = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelRate = new System.Windows.Forms.Panel();
            this.tableLayoutPanel.SuspendLayout();
            this.panelRate.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(3, 53);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "&Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(264, 53);
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
            this.buttonSave.Location = new System.Drawing.Point(90, 53);
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
            this.labelTotal.Location = new System.Drawing.Point(229, 0);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTotal.Size = new System.Drawing.Size(119, 50);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "$0.00";
            // 
            // labelDollar
            // 
            this.labelDollar.AutoSize = true;
            this.labelDollar.Location = new System.Drawing.Point(3, 19);
            this.labelDollar.Name = "labelDollar";
            this.labelDollar.Size = new System.Drawing.Size(13, 13);
            this.labelDollar.TabIndex = 6;
            this.labelDollar.Text = "$";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(177, 53);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 7;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Controls.Add(this.panelRate, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelTotal, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonReset, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonStartStop, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonClose, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.buttonSave, 1, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(348, 84);
            this.tableLayoutPanel.TabIndex = 8;
            // 
            // panelRate
            // 
            this.panelRate.Controls.Add(this.labelRate);
            this.panelRate.Controls.Add(this.labelDollar);
            this.panelRate.Controls.Add(this.textBoxRate);
            this.panelRate.Location = new System.Drawing.Point(3, 3);
            this.panelRate.Name = "panelRate";
            this.panelRate.Size = new System.Drawing.Size(80, 44);
            this.panelRate.TabIndex = 8;
            // 
            // PayClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 85);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(365, 124);
            this.MinimizeBox = false;
            this.Name = "PayClock";
            this.Text = "Pay Clock";
            this.TopMost = true;
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.panelRate.ResumeLayout(false);
            this.panelRate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonStartStop;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Label labelRate;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelDollar;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panelRate;
    }
}

