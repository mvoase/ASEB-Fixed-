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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdMph = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.malt = new System.Windows.Forms.Label();
            this.aalt = new System.Windows.Forms.Label();
            this.lbMaxAlt = new System.Windows.Forms.Label();
            this.lbAvgAlt = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbTotalDist = new System.Windows.Forms.Label();
            this.tdist = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.apower = new System.Windows.Forms.Label();
            this.maxpowerproo = new System.Windows.Forms.Label();
            this.lbMaxPower = new System.Windows.Forms.Label();
            this.lblAvgPower = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mspeed = new System.Windows.Forms.Label();
            this.aspeed = new System.Windows.Forms.Label();
            this.lbMaxSpeed = new System.Windows.Forms.Label();
            this.lbAvgSpeed = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mnnhrate = new System.Windows.Forms.Label();
            this.mnhrate = new System.Windows.Forms.Label();
            this.mhrate = new System.Windows.Forms.Label();
            this.ahrate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAvgHR = new System.Windows.Forms.Label();
            this.lbMaxHR = new System.Windows.Forms.Label();
            this.lbMinHR = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(738, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Summary";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.radioButton2);
            this.groupBox6.Controls.Add(this.rdMph);
            this.groupBox6.Location = new System.Drawing.Point(583, 274);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(147, 95);
            this.groupBox6.TabIndex = 46;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Units";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 48;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Kilometres";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdMph
            // 
            this.rdMph.AutoSize = true;
            this.rdMph.Location = new System.Drawing.Point(14, 25);
            this.rdMph.Name = "rdMph";
            this.rdMph.Size = new System.Drawing.Size(49, 17);
            this.rdMph.TabIndex = 47;
            this.rdMph.TabStop = true;
            this.rdMph.Text = "Miles";
            this.rdMph.UseVisualStyleBackColor = true;
            this.rdMph.CheckedChanged += new System.EventHandler(this.rdMph_CheckedChanged_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.malt);
            this.groupBox5.Controls.Add(this.aalt);
            this.groupBox5.Controls.Add(this.lbMaxAlt);
            this.groupBox5.Controls.Add(this.lbAvgAlt);
            this.groupBox5.Location = new System.Drawing.Point(349, 269);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 45;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Altitude";
            // 
            // malt
            // 
            this.malt.AutoSize = true;
            this.malt.Location = new System.Drawing.Point(69, 57);
            this.malt.Name = "malt";
            this.malt.Size = new System.Drawing.Size(0, 13);
            this.malt.TabIndex = 35;
            // 
            // aalt
            // 
            this.aalt.AutoSize = true;
            this.aalt.Location = new System.Drawing.Point(69, 30);
            this.aalt.Name = "aalt";
            this.aalt.Size = new System.Drawing.Size(0, 13);
            this.aalt.TabIndex = 34;
            // 
            // lbMaxAlt
            // 
            this.lbMaxAlt.AutoSize = true;
            this.lbMaxAlt.Location = new System.Drawing.Point(9, 57);
            this.lbMaxAlt.Name = "lbMaxAlt";
            this.lbMaxAlt.Size = new System.Drawing.Size(54, 13);
            this.lbMaxAlt.TabIndex = 33;
            this.lbMaxAlt.Text = "Maximum:";
            // 
            // lbAvgAlt
            // 
            this.lbAvgAlt.AutoSize = true;
            this.lbAvgAlt.Location = new System.Drawing.Point(9, 30);
            this.lbAvgAlt.Name = "lbAvgAlt";
            this.lbAvgAlt.Size = new System.Drawing.Size(50, 13);
            this.lbAvgAlt.TabIndex = 32;
            this.lbAvgAlt.Text = "Average:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbTotalDist);
            this.groupBox4.Controls.Add(this.tdist);
            this.groupBox4.Location = new System.Drawing.Point(583, 75);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(120, 54);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Distance";
            // 
            // lbTotalDist
            // 
            this.lbTotalDist.AutoSize = true;
            this.lbTotalDist.Location = new System.Drawing.Point(11, 20);
            this.lbTotalDist.Name = "lbTotalDist";
            this.lbTotalDist.Size = new System.Drawing.Size(34, 13);
            this.lbTotalDist.TabIndex = 16;
            this.lbTotalDist.Text = "Total:";
            // 
            // tdist
            // 
            this.tdist.AutoSize = true;
            this.tdist.Location = new System.Drawing.Point(51, 20);
            this.tdist.Name = "tdist";
            this.tdist.Size = new System.Drawing.Size(0, 13);
            this.tdist.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.apower);
            this.groupBox3.Controls.Add(this.maxpowerproo);
            this.groupBox3.Controls.Add(this.lbMaxPower);
            this.groupBox3.Controls.Add(this.lblAvgPower);
            this.groupBox3.Location = new System.Drawing.Point(349, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 117);
            this.groupBox3.TabIndex = 43;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Power";
            // 
            // apower
            // 
            this.apower.AutoSize = true;
            this.apower.Location = new System.Drawing.Point(82, 25);
            this.apower.Name = "apower";
            this.apower.Size = new System.Drawing.Size(0, 13);
            this.apower.TabIndex = 32;
            // 
            // maxpowerproo
            // 
            this.maxpowerproo.AutoSize = true;
            this.maxpowerproo.Location = new System.Drawing.Point(82, 80);
            this.maxpowerproo.Name = "maxpowerproo";
            this.maxpowerproo.Size = new System.Drawing.Size(0, 13);
            this.maxpowerproo.TabIndex = 31;
            // 
            // lbMaxPower
            // 
            this.lbMaxPower.AutoSize = true;
            this.lbMaxPower.Location = new System.Drawing.Point(9, 80);
            this.lbMaxPower.Name = "lbMaxPower";
            this.lbMaxPower.Size = new System.Drawing.Size(54, 13);
            this.lbMaxPower.TabIndex = 30;
            this.lbMaxPower.Text = "Maximum:";
            // 
            // lblAvgPower
            // 
            this.lblAvgPower.AutoSize = true;
            this.lblAvgPower.Location = new System.Drawing.Point(9, 25);
            this.lblAvgPower.Name = "lblAvgPower";
            this.lblAvgPower.Size = new System.Drawing.Size(50, 13);
            this.lblAvgPower.TabIndex = 29;
            this.lblAvgPower.Text = "Average:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mspeed);
            this.groupBox2.Controls.Add(this.aspeed);
            this.groupBox2.Controls.Add(this.lbMaxSpeed);
            this.groupBox2.Controls.Add(this.lbAvgSpeed);
            this.groupBox2.Location = new System.Drawing.Point(79, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 115);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Speed";
            // 
            // mspeed
            // 
            this.mspeed.AutoSize = true;
            this.mspeed.Location = new System.Drawing.Point(96, 67);
            this.mspeed.Name = "mspeed";
            this.mspeed.Size = new System.Drawing.Size(0, 13);
            this.mspeed.TabIndex = 27;
            // 
            // aspeed
            // 
            this.aspeed.AutoSize = true;
            this.aspeed.Location = new System.Drawing.Point(96, 40);
            this.aspeed.Name = "aspeed";
            this.aspeed.Size = new System.Drawing.Size(0, 13);
            this.aspeed.TabIndex = 26;
            // 
            // lbMaxSpeed
            // 
            this.lbMaxSpeed.AutoSize = true;
            this.lbMaxSpeed.Location = new System.Drawing.Point(18, 69);
            this.lbMaxSpeed.Name = "lbMaxSpeed";
            this.lbMaxSpeed.Size = new System.Drawing.Size(54, 13);
            this.lbMaxSpeed.TabIndex = 25;
            this.lbMaxSpeed.Text = "Maximum:";
            // 
            // lbAvgSpeed
            // 
            this.lbAvgSpeed.AutoSize = true;
            this.lbAvgSpeed.Location = new System.Drawing.Point(22, 36);
            this.lbAvgSpeed.Name = "lbAvgSpeed";
            this.lbAvgSpeed.Size = new System.Drawing.Size(50, 13);
            this.lbAvgSpeed.TabIndex = 24;
            this.lbAvgSpeed.Text = "Average:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mnnhrate);
            this.groupBox1.Controls.Add(this.mnhrate);
            this.groupBox1.Controls.Add(this.mhrate);
            this.groupBox1.Controls.Add(this.ahrate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbAvgHR);
            this.groupBox1.Controls.Add(this.lbMaxHR);
            this.groupBox1.Controls.Add(this.lbMinHR);
            this.groupBox1.Location = new System.Drawing.Point(79, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 163);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Heart Rate";
            // 
            // mnnhrate
            // 
            this.mnnhrate.AutoSize = true;
            this.mnnhrate.Location = new System.Drawing.Point(112, 104);
            this.mnnhrate.Name = "mnnhrate";
            this.mnnhrate.Size = new System.Drawing.Size(0, 13);
            this.mnnhrate.TabIndex = 49;
            // 
            // mnhrate
            // 
            this.mnhrate.AutoSize = true;
            this.mnhrate.Location = new System.Drawing.Point(112, 104);
            this.mnhrate.Name = "mnhrate";
            this.mnhrate.Size = new System.Drawing.Size(0, 13);
            this.mnhrate.TabIndex = 48;
            // 
            // mhrate
            // 
            this.mhrate.AutoSize = true;
            this.mhrate.Location = new System.Drawing.Point(112, 71);
            this.mhrate.Name = "mhrate";
            this.mhrate.Size = new System.Drawing.Size(0, 13);
            this.mhrate.TabIndex = 47;
            // 
            // ahrate
            // 
            this.ahrate.AutoSize = true;
            this.ahrate.Location = new System.Drawing.Point(112, 37);
            this.ahrate.Name = "ahrate";
            this.ahrate.Size = new System.Drawing.Size(0, 13);
            this.ahrate.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 45;
            // 
            // lbAvgHR
            // 
            this.lbAvgHR.AutoSize = true;
            this.lbAvgHR.Location = new System.Drawing.Point(22, 37);
            this.lbAvgHR.Name = "lbAvgHR";
            this.lbAvgHR.Size = new System.Drawing.Size(56, 13);
            this.lbAvgHR.TabIndex = 42;
            this.lbAvgHR.Text = "Average : ";
            // 
            // lbMaxHR
            // 
            this.lbMaxHR.AutoSize = true;
            this.lbMaxHR.Location = new System.Drawing.Point(22, 71);
            this.lbMaxHR.Name = "lbMaxHR";
            this.lbMaxHR.Size = new System.Drawing.Size(54, 13);
            this.lbMaxHR.TabIndex = 43;
            this.lbMaxHR.Text = "Maximum:";
            // 
            // lbMinHR
            // 
            this.lbMinHR.AutoSize = true;
            this.lbMinHR.Location = new System.Drawing.Point(22, 104);
            this.lbMinHR.Name = "lbMinHR";
            this.lbMinHR.Size = new System.Drawing.Size(51, 13);
            this.lbMinHR.TabIndex = 44;
            this.lbMinHR.Text = "Minimum:";
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
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Label lbTotalDist;
        private System.Windows.Forms.Label tdist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label mnnhrate;
        private System.Windows.Forms.Label mnhrate;
        private System.Windows.Forms.Label mhrate;
        private System.Windows.Forms.Label ahrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAvgHR;
        private System.Windows.Forms.Label lbMaxHR;
        private System.Windows.Forms.Label lbMinHR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label mspeed;
        private System.Windows.Forms.Label aspeed;
        private System.Windows.Forms.Label lbMaxSpeed;
        private System.Windows.Forms.Label lbAvgSpeed;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label apower;
        private System.Windows.Forms.Label maxpowerproo;
        private System.Windows.Forms.Label lbMaxPower;
        private System.Windows.Forms.Label lblAvgPower;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label malt;
        private System.Windows.Forms.Label aalt;
        private System.Windows.Forms.Label lbMaxAlt;
        private System.Windows.Forms.Label lbAvgAlt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdMph;
    }
}

