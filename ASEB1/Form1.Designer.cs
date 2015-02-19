namespace ASEB1
{
    partial class Form1
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdMph = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.lbTotalDist = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbMaxAlt = new System.Windows.Forms.Label();
            this.lbAvgAlt = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbMaxPower = new System.Windows.Forms.Label();
            this.lblAvgPower = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbMaxSpeed = new System.Windows.Forms.Label();
            this.lbAvgSpeed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbAvgHR = new System.Windows.Forms.Label();
            this.lbMaxHR = new System.Windows.Forms.Label();
            this.lbMinHR = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.aspeed = new System.Windows.Forms.Label();
            this.mspeed = new System.Windows.Forms.Label();
            this.ahrate = new System.Windows.Forms.Label();
            this.mhrate = new System.Windows.Forms.Label();
            this.mnhrate = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(746, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem1.Text = "Open";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(746, 470);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mnhrate);
            this.tabPage1.Controls.Add(this.mhrate);
            this.tabPage1.Controls.Add(this.ahrate);
            this.tabPage1.Controls.Add(this.mspeed);
            this.tabPage1.Controls.Add(this.aspeed);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.radioButton2);
            this.tabPage1.Controls.Add(this.rdMph);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.lbTotalDist);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.lbMaxAlt);
            this.tabPage1.Controls.Add(this.lbAvgAlt);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.lbMaxPower);
            this.tabPage1.Controls.Add(this.lblAvgPower);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.lbMaxSpeed);
            this.tabPage1.Controls.Add(this.lbAvgSpeed);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbAvgHR);
            this.tabPage1.Controls.Add(this.lbMaxHR);
            this.tabPage1.Controls.Add(this.lbMinHR);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(738, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Summary";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 20;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(583, 326);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Kilometres";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdMph
            // 
            this.rdMph.AutoSize = true;
            this.rdMph.Location = new System.Drawing.Point(583, 295);
            this.rdMph.Name = "rdMph";
            this.rdMph.Size = new System.Drawing.Size(49, 17);
            this.rdMph.TabIndex = 18;
            this.rdMph.TabStop = true;
            this.rdMph.Text = "Miles";
            this.rdMph.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(581, 269);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Units";
            // 
            // lbTotalDist
            // 
            this.lbTotalDist.AutoSize = true;
            this.lbTotalDist.Location = new System.Drawing.Point(580, 112);
            this.lbTotalDist.Name = "lbTotalDist";
            this.lbTotalDist.Size = new System.Drawing.Size(34, 13);
            this.lbTotalDist.TabIndex = 16;
            this.lbTotalDist.Text = "Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(581, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Distance";
            // 
            // lbMaxAlt
            // 
            this.lbMaxAlt.AutoSize = true;
            this.lbMaxAlt.Location = new System.Drawing.Point(358, 326);
            this.lbMaxAlt.Name = "lbMaxAlt";
            this.lbMaxAlt.Size = new System.Drawing.Size(54, 13);
            this.lbMaxAlt.TabIndex = 14;
            this.lbMaxAlt.Text = "Maximum:";
            // 
            // lbAvgAlt
            // 
            this.lbAvgAlt.AutoSize = true;
            this.lbAvgAlt.Location = new System.Drawing.Point(358, 299);
            this.lbAvgAlt.Name = "lbAvgAlt";
            this.lbAvgAlt.Size = new System.Drawing.Size(50, 13);
            this.lbAvgAlt.TabIndex = 13;
            this.lbAvgAlt.Text = "Average:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(358, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Altitude";
            // 
            // lbMaxPower
            // 
            this.lbMaxPower.AutoSize = true;
            this.lbMaxPower.Location = new System.Drawing.Point(358, 179);
            this.lbMaxPower.Name = "lbMaxPower";
            this.lbMaxPower.Size = new System.Drawing.Size(54, 13);
            this.lbMaxPower.TabIndex = 11;
            this.lbMaxPower.Text = "Maximum:";
            // 
            // lblAvgPower
            // 
            this.lblAvgPower.AutoSize = true;
            this.lblAvgPower.Location = new System.Drawing.Point(358, 124);
            this.lblAvgPower.Name = "lblAvgPower";
            this.lblAvgPower.Size = new System.Drawing.Size(50, 13);
            this.lblAvgPower.TabIndex = 10;
            this.lblAvgPower.Text = "Average:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Power";
            // 
            // lbMaxSpeed
            // 
            this.lbMaxSpeed.AutoSize = true;
            this.lbMaxSpeed.Location = new System.Drawing.Point(76, 326);
            this.lbMaxSpeed.Name = "lbMaxSpeed";
            this.lbMaxSpeed.Size = new System.Drawing.Size(54, 13);
            this.lbMaxSpeed.TabIndex = 8;
            this.lbMaxSpeed.Text = "Maximum:";
            // 
            // lbAvgSpeed
            // 
            this.lbAvgSpeed.AutoSize = true;
            this.lbAvgSpeed.Location = new System.Drawing.Point(76, 299);
            this.lbAvgSpeed.Name = "lbAvgSpeed";
            this.lbAvgSpeed.Size = new System.Drawing.Size(50, 13);
            this.lbAvgSpeed.TabIndex = 7;
            this.lbAvgSpeed.Text = "Average:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Heart Rate";
            // 
            // lbAvgHR
            // 
            this.lbAvgHR.AutoSize = true;
            this.lbAvgHR.Location = new System.Drawing.Point(76, 112);
            this.lbAvgHR.Name = "lbAvgHR";
            this.lbAvgHR.Size = new System.Drawing.Size(56, 13);
            this.lbAvgHR.TabIndex = 3;
            this.lbAvgHR.Text = "Average : ";
            // 
            // lbMaxHR
            // 
            this.lbMaxHR.AutoSize = true;
            this.lbMaxHR.Location = new System.Drawing.Point(76, 146);
            this.lbMaxHR.Name = "lbMaxHR";
            this.lbMaxHR.Size = new System.Drawing.Size(54, 13);
            this.lbMaxHR.TabIndex = 4;
            this.lbMaxHR.Text = "Maximum:";
            // 
            // lbMinHR
            // 
            this.lbMinHR.AutoSize = true;
            this.lbMinHR.Location = new System.Drawing.Point(76, 179);
            this.lbMinHR.Name = "lbMinHR";
            this.lbMinHR.Size = new System.Drawing.Size(51, 13);
            this.lbMinHR.TabIndex = 5;
            this.lbMinHR.Text = "Minimum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Speed";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(738, 444);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graph";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // aspeed
            // 
            this.aspeed.AutoSize = true;
            this.aspeed.Location = new System.Drawing.Point(166, 299);
            this.aspeed.Name = "aspeed";
            this.aspeed.Size = new System.Drawing.Size(0, 13);
            this.aspeed.TabIndex = 21;
            // 
            // mspeed
            // 
            this.mspeed.AutoSize = true;
            this.mspeed.Location = new System.Drawing.Point(166, 326);
            this.mspeed.Name = "mspeed";
            this.mspeed.Size = new System.Drawing.Size(0, 13);
            this.mspeed.TabIndex = 22;
            // 
            // ahrate
            // 
            this.ahrate.AutoSize = true;
            this.ahrate.Location = new System.Drawing.Point(166, 112);
            this.ahrate.Name = "ahrate";
            this.ahrate.Size = new System.Drawing.Size(0, 13);
            this.ahrate.TabIndex = 23;
            // 
            // mhrate
            // 
            this.mhrate.AutoSize = true;
            this.mhrate.Location = new System.Drawing.Point(166, 146);
            this.mhrate.Name = "mhrate";
            this.mhrate.Size = new System.Drawing.Size(0, 13);
            this.mhrate.TabIndex = 24;
            // 
            // mnhrate
            // 
            this.mnhrate.AutoSize = true;
            this.mnhrate.Location = new System.Drawing.Point(166, 179);
            this.mnhrate.Name = "mnhrate";
            this.mnhrate.Size = new System.Drawing.Size(0, 13);
            this.mnhrate.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 495);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbAvgHR;
        private System.Windows.Forms.Label lbMaxHR;
        private System.Windows.Forms.Label lbMinHR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbAvgSpeed;
        private System.Windows.Forms.Label lbMaxSpeed;
        private System.Windows.Forms.Label lblAvgPower;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbMaxPower;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbAvgAlt;
        private System.Windows.Forms.Label lbMaxAlt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbTotalDist;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rdMph;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label aspeed;
        private System.Windows.Forms.Label mspeed;
        private System.Windows.Forms.Label ahrate;
        private System.Windows.Forms.Label mhrate;
        private System.Windows.Forms.Label mnhrate;
    }
}

