﻿namespace BoarTrackerPlugin
{
    partial class BoarDisplay
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
            this.label1 = new System.Windows.Forms.Label();
            this.displayedCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boar Count:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // displayedCount
            // 
            this.displayedCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayedCount.ForeColor = System.Drawing.SystemColors.Control;
            this.displayedCount.Location = new System.Drawing.Point(0, 33);
            this.displayedCount.Margin = new System.Windows.Forms.Padding(0);
            this.displayedCount.Name = "displayedCount";
            this.displayedCount.Size = new System.Drawing.Size(70, 32);
            this.displayedCount.TabIndex = 1;
            this.displayedCount.Text = "0 | 7";
            this.displayedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.displayedCount.Click += new System.EventHandler(this.label2_Click);
            // 
            // BoarDisplay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(70, 65);
            this.ControlBox = false;
            this.Controls.Add(this.displayedCount);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BoarDisplay";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "BoarDisplay";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayedCount;
    }
}