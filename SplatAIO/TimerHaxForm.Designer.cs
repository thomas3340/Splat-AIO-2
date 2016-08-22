﻿namespace SplatAIO
{
    partial class TimerHaxForm
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
            System.ComponentModel.ComponentResourceManager resources = new SingleAssemblyComponentResourceManager(typeof(TimerHaxForm));
            this.BattleDojoRadioButton = new System.Windows.Forms.RadioButton();
            this.ReconRadioButton = new System.Windows.Forms.RadioButton();
            this.AmiiboRadioButton = new System.Windows.Forms.RadioButton();
            this.TimerBox = new System.Windows.Forms.NumericUpDown();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.ControlsGroupBox = new System.Windows.Forms.GroupBox();
            this.FreezeCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TimerBox)).BeginInit();
            this.ControlsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BattleDojoRadioButton
            // 
            resources.ApplyResources(this.BattleDojoRadioButton, "BattleDojoRadioButton");
            this.BattleDojoRadioButton.Name = "BattleDojoRadioButton";
            this.BattleDojoRadioButton.TabStop = true;
            this.BattleDojoRadioButton.UseVisualStyleBackColor = true;
            // 
            // ReconRadioButton
            // 
            resources.ApplyResources(this.ReconRadioButton, "ReconRadioButton");
            this.ReconRadioButton.Name = "ReconRadioButton";
            this.ReconRadioButton.TabStop = true;
            this.ReconRadioButton.UseVisualStyleBackColor = true;
            // 
            // AmiiboRadioButton
            // 
            resources.ApplyResources(this.AmiiboRadioButton, "AmiiboRadioButton");
            this.AmiiboRadioButton.Name = "AmiiboRadioButton";
            this.AmiiboRadioButton.TabStop = true;
            this.AmiiboRadioButton.UseVisualStyleBackColor = true;
            // 
            // TimerBox
            // 
            resources.ApplyResources(this.TimerBox, "TimerBox");
            this.TimerBox.Maximum = new decimal(new int[] {
            6039,
            0,
            0,
            0});
            this.TimerBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimerBox.Name = "TimerBox";
            this.TimerBox.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // ApplyButton
            // 
            resources.ApplyResources(this.ApplyButton, "ApplyButton");
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // TimerLabel
            // 
            resources.ApplyResources(this.TimerLabel, "TimerLabel");
            this.TimerLabel.Name = "TimerLabel";
            // 
            // ControlsGroupBox
            // 
            resources.ApplyResources(this.ControlsGroupBox, "ControlsGroupBox");
            this.ControlsGroupBox.Controls.Add(this.FreezeCheckBox);
            this.ControlsGroupBox.Controls.Add(this.ReconRadioButton);
            this.ControlsGroupBox.Controls.Add(this.TimerLabel);
            this.ControlsGroupBox.Controls.Add(this.BattleDojoRadioButton);
            this.ControlsGroupBox.Controls.Add(this.AmiiboRadioButton);
            this.ControlsGroupBox.Controls.Add(this.TimerBox);
            this.ControlsGroupBox.Name = "ControlsGroupBox";
            this.ControlsGroupBox.TabStop = false;
            // 
            // FreezeCheckBox
            // 
            resources.ApplyResources(this.FreezeCheckBox, "FreezeCheckBox");
            this.FreezeCheckBox.Name = "FreezeCheckBox";
            this.FreezeCheckBox.UseVisualStyleBackColor = true;
            this.FreezeCheckBox.CheckedChanged += new System.EventHandler(this.FreezeCheckBox_CheckedChanged);
            // 
            // TimerHaxForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ControlsGroupBox);
            this.Controls.Add(this.ApplyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TimerHaxForm";
            ((System.ComponentModel.ISupportInitialize)(this.TimerBox)).EndInit();
            this.ControlsGroupBox.ResumeLayout(false);
            this.ControlsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton BattleDojoRadioButton;
        private System.Windows.Forms.RadioButton ReconRadioButton;
        private System.Windows.Forms.RadioButton AmiiboRadioButton;
        private System.Windows.Forms.NumericUpDown TimerBox;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.GroupBox ControlsGroupBox;
        private System.Windows.Forms.CheckBox FreezeCheckBox;
    }
}