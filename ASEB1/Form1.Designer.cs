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
            this.components = new System.ComponentModel.Container();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polarDataSet = new ASEB1.polarDataSet();
            this.polarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.radBrowseEditor1 = new Telerik.WinControls.UI.RadBrowseEditor();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radPageViewPage3 = new Telerik.WinControls.UI.RadPageViewPage();
            this.radPageViewPage1 = new Telerik.WinControls.UI.RadPageViewPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.heartRateCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadenceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altitudeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressureCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.powerCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.polarDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.polarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polarDataSetBindingSource)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radBrowseEditor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.radPageViewPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polarDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
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
            // polarDataSet
            // 
            this.polarDataSet.DataSetName = "polarDataSet";
            this.polarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // polarDataSetBindingSource
            // 
            this.polarDataSetBindingSource.DataSource = this.polarDataSet;
            this.polarDataSetBindingSource.Position = 0;
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
            this.radioButton2.Text = "Kilometres";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdMph
            // 
            this.rdMph.Location = new System.Drawing.Point(0, 0);
            this.rdMph.Name = "rdMph";
            this.rdMph.Size = new System.Drawing.Size(104, 24);
            this.rdMph.TabIndex = 49;
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
            // radBrowseEditor1
            // 
            this.radBrowseEditor1.Location = new System.Drawing.Point(133, 11);
            this.radBrowseEditor1.Name = "radBrowseEditor1";
            this.radBrowseEditor1.Size = new System.Drawing.Size(237, 20);
            this.radBrowseEditor1.TabIndex = 4;
            this.radBrowseEditor1.Text = "radBrowseEditor1";
            this.radBrowseEditor1.ValueChanged += new System.EventHandler(this.radBrowseEditor1_ValueChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 11);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(103, 18);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "Add HRM File here:";
            this.radLabel2.ThemeName = "ControlDefault";
            // 
            // radPageViewPage3
            // 
            this.radPageViewPage3.ItemSize = new System.Drawing.SizeF(75F, 25F);
            this.radPageViewPage3.Location = new System.Drawing.Point(5, 31);
            this.radPageViewPage3.Name = "radPageViewPage3";
            this.radPageViewPage3.Size = new System.Drawing.Size(978, 399);
            this.radPageViewPage3.Text = "Graph Data";
            // 
            // radPageViewPage1
            // 
            this.radPageViewPage1.Controls.Add(this.richTextBox1);
            this.radPageViewPage1.Controls.Add(this.dataGridView1);
            this.radPageViewPage1.ItemSize = new System.Drawing.SizeF(64F, 25F);
            this.radPageViewPage1.Location = new System.Drawing.Point(5, 31);
            this.radPageViewPage1.Name = "radPageViewPage1";
            this.radPageViewPage1.Size = new System.Drawing.Size(982, 437);
            this.radPageViewPage1.Text = "Raw Data";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Location = new System.Drawing.Point(765, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(210, 205);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.heartRateCol,
            this.speedCol,
            this.cadenceCol,
            this.altitudeCol,
            this.pressureCol,
            this.powerCol,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(7, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 391);
            this.dataGridView1.TabIndex = 2;
            // 
            // heartRateCol
            // 
            this.heartRateCol.HeaderText = "HeartRate";
            this.heartRateCol.Name = "heartRateCol";
            // 
            // speedCol
            // 
            this.speedCol.HeaderText = "Speed";
            this.speedCol.Name = "speedCol";
            // 
            // cadenceCol
            // 
            this.cadenceCol.HeaderText = "Cadence";
            this.cadenceCol.Name = "cadenceCol";
            // 
            // altitudeCol
            // 
            this.altitudeCol.HeaderText = "Altitude";
            this.altitudeCol.Name = "altitudeCol";
            // 
            // pressureCol
            // 
            this.pressureCol.HeaderText = "Pressure";
            this.pressureCol.Name = "pressureCol";
            // 
            // powerCol
            // 
            this.powerCol.HeaderText = "Power";
            this.powerCol.Name = "powerCol";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date/Time";
            this.Date.Name = "Date";
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.radPageViewPage1);
            this.radPageView1.Controls.Add(this.radPageViewPage3);
            this.radPageView1.DefaultPage = this.radPageViewPage1;
            this.radPageView1.Location = new System.Drawing.Point(0, 36);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.radPageViewPage1;
            this.radPageView1.Size = new System.Drawing.Size(992, 473);
            this.radPageView1.TabIndex = 1;
            this.radPageView1.Text = "radPageView1";
            this.radPageView1.ThemeName = "EvalFormTheme";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Near;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).ItemFitMode = Telerik.WinControls.UI.StripViewItemFitMode.None;
            // 
            // polarDataSetBindingSource1
            // 
            this.polarDataSetBindingSource1.DataSource = this.polarDataSet;
            this.polarDataSetBindingSource1.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 506);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radBrowseEditor1);
            this.Controls.Add(this.radPageView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.polarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polarDataSetBindingSource)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.radBrowseEditor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.radPageViewPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.polarDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.BindingSource polarDataSetBindingSource;
        private polarDataSet polarDataSet;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdMph;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label malt;
        private System.Windows.Forms.Label aalt;
        private System.Windows.Forms.Label lbMaxAlt;
        private System.Windows.Forms.Label lbAvgAlt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbTotalDist;
        private System.Windows.Forms.Label tdist;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label apower;
        private System.Windows.Forms.Label maxpowerproo;
        private System.Windows.Forms.Label lbMaxPower;
        private System.Windows.Forms.Label lblAvgPower;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label mspeed;
        private System.Windows.Forms.Label aspeed;
        private System.Windows.Forms.Label lbMaxSpeed;
        private System.Windows.Forms.Label lbAvgSpeed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label mnnhrate;
        private System.Windows.Forms.Label mnhrate;
        private System.Windows.Forms.Label mhrate;
        private System.Windows.Forms.Label ahrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbAvgHR;
        private System.Windows.Forms.Label lbMaxHR;
        private System.Windows.Forms.Label lbMinHR;
        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.UI.RadBrowseEditor radBrowseEditor1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage3;
        private Telerik.WinControls.UI.RadPageViewPage radPageViewPage1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn heartRateCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cadenceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn altitudeCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressureCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn powerCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private System.Windows.Forms.BindingSource polarDataSetBindingSource1;
    }
}

