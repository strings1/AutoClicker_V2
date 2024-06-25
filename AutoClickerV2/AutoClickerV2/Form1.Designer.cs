namespace AutoClickerV2
{
    partial class AutoClickerV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoClickerV2));
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.nearPointClick_checkbox = new System.Windows.Forms.CheckBox();
            this.timerDuration_Numeric = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveConfigTSButton = new System.Windows.Forms.ToolStripButton();
            this.settingsTSButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.clickspers = new System.Windows.Forms.TextBox();
            this.ClickTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TimerDuration = new System.Windows.Forms.Timer(this.components);
            this.helpButton = new System.Windows.Forms.ToolStripButton();
            this.LoadConfigTSButton = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nearPointClicks_radius_trackbar = new System.Windows.Forms.TrackBar();
            this.nearPointClicks_radius_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timerDuration_Numeric)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nearPointClicks_radius_trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(6, 38);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(6, 77);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // nearPointClick_checkbox
            // 
            this.nearPointClick_checkbox.AutoSize = true;
            this.nearPointClick_checkbox.Location = new System.Drawing.Point(6, 124);
            this.nearPointClick_checkbox.Name = "nearPointClick_checkbox";
            this.nearPointClick_checkbox.Size = new System.Drawing.Size(100, 17);
            this.nearPointClick_checkbox.TabIndex = 2;
            this.nearPointClick_checkbox.Text = "Near point click";
            this.nearPointClick_checkbox.UseVisualStyleBackColor = true;
            this.nearPointClick_checkbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timerDuration_Numeric
            // 
            this.timerDuration_Numeric.Location = new System.Drawing.Point(98, 38);
            this.timerDuration_Numeric.Name = "timerDuration_Numeric";
            this.timerDuration_Numeric.Size = new System.Drawing.Size(64, 20);
            this.timerDuration_Numeric.TabIndex = 3;
            this.timerDuration_Numeric.ValueChanged += new System.EventHandler(this.timerDuration_Numeric_ValueChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveConfigTSButton,
            this.LoadConfigTSButton,
            this.settingsTSButton,
            this.helpButton,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(230, 39);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // saveConfigTSButton
            // 
            this.saveConfigTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveConfigTSButton.Image = ((System.Drawing.Image)(resources.GetObject("saveConfigTSButton.Image")));
            this.saveConfigTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveConfigTSButton.Name = "saveConfigTSButton";
            this.saveConfigTSButton.Size = new System.Drawing.Size(36, 36);
            this.saveConfigTSButton.Text = "Save Configuration";
            this.saveConfigTSButton.ToolTipText = "Save Configuration";
            this.saveConfigTSButton.Click += new System.EventHandler(this.SaveConfig_Click);
            // 
            // settingsTSButton
            // 
            this.settingsTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingsTSButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsTSButton.Image")));
            this.settingsTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsTSButton.Name = "settingsTSButton";
            this.settingsTSButton.Size = new System.Drawing.Size(36, 36);
            this.settingsTSButton.Text = "Settings";
            this.settingsTSButton.Click += new System.EventHandler(this.settingsTSButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(46, 36);
            this.toolStripLabel1.Text = "Toolbar";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // clickspers
            // 
            this.clickspers.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clickspers.Location = new System.Drawing.Point(98, 80);
            this.clickspers.Name = "clickspers";
            this.clickspers.Size = new System.Drawing.Size(64, 20);
            this.clickspers.TabIndex = 6;
            this.clickspers.TextChanged += new System.EventHandler(this.clickspers_TextChanged);
            // 
            // ClickTimer
            // 
            this.ClickTimer.Tick += new System.EventHandler(this.ClickTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Duration (Seconds)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Clicks Per Second";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TimerDuration
            // 
            this.TimerDuration.Interval = 1000;
            this.TimerDuration.Tick += new System.EventHandler(this.TimerDuration_Tick);
            // 
            // helpButton
            // 
            this.helpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
            this.helpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(36, 36);
            this.helpButton.Text = "Help";
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // LoadConfigTSButton
            // 
            this.LoadConfigTSButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LoadConfigTSButton.Image = ((System.Drawing.Image)(resources.GetObject("LoadConfigTSButton.Image")));
            this.LoadConfigTSButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadConfigTSButton.Name = "LoadConfigTSButton";
            this.LoadConfigTSButton.Size = new System.Drawing.Size(36, 36);
            this.LoadConfigTSButton.Text = "Load Configuration";
            this.LoadConfigTSButton.Click += new System.EventHandler(this.LoadConfigTSButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nearPointClicks_radius_label);
            this.groupBox1.Controls.Add(this.nearPointClicks_radius_trackbar);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.stopButton);
            this.groupBox1.Controls.Add(this.clickspers);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nearPointClick_checkbox);
            this.groupBox1.Controls.Add(this.timerDuration_Numeric);
            this.groupBox1.Location = new System.Drawing.Point(0, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 147);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nearPointClicks_radius_trackbar
            // 
            this.nearPointClicks_radius_trackbar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nearPointClicks_radius_trackbar.Location = new System.Drawing.Point(98, 115);
            this.nearPointClicks_radius_trackbar.Maximum = 100;
            this.nearPointClicks_radius_trackbar.Minimum = 1;
            this.nearPointClicks_radius_trackbar.Name = "nearPointClicks_radius_trackbar";
            this.nearPointClicks_radius_trackbar.Size = new System.Drawing.Size(104, 45);
            this.nearPointClicks_radius_trackbar.TabIndex = 9;
            this.nearPointClicks_radius_trackbar.Value = 5;
            this.nearPointClicks_radius_trackbar.Scroll += new System.EventHandler(this.nearPointClicks_radius_trackbar_Scroll);
            // 
            // nearPointClicks_radius_label
            // 
            this.nearPointClicks_radius_label.AutoSize = true;
            this.nearPointClicks_radius_label.Location = new System.Drawing.Point(198, 115);
            this.nearPointClicks_radius_label.Name = "nearPointClicks_radius_label";
            this.nearPointClicks_radius_label.Size = new System.Drawing.Size(13, 13);
            this.nearPointClicks_radius_label.TabIndex = 10;
            this.nearPointClicks_radius_label.Text = "1";
            this.nearPointClicks_radius_label.Click += new System.EventHandler(this.radius_label_Click);
            // 
            // AutoClickerV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(230, 187);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AutoClickerV2";
            this.Text = "AutoClicker V2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.AutoClickerV2_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.timerDuration_Numeric)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nearPointClicks_radius_trackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.CheckBox nearPointClick_checkbox;
        private System.Windows.Forms.NumericUpDown timerDuration_Numeric;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveConfigTSButton;
        private System.Windows.Forms.ToolStripButton settingsTSButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.TextBox clickspers;
        private System.Windows.Forms.Timer ClickTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer TimerDuration;
        private System.Windows.Forms.ToolStripButton helpButton;
        private System.Windows.Forms.ToolStripButton LoadConfigTSButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar nearPointClicks_radius_trackbar;
        private System.Windows.Forms.Label nearPointClicks_radius_label;
    }
}

