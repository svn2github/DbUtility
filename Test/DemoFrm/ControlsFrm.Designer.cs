﻿namespace Test.DemoFrm
{
    partial class ControlsFrm
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
            this.maskedDateTimePicker1 = new hwj.UserControls.Other.MaskedDateTimePicker();
            this.SuspendLayout();
            // 
            // maskedDateTimePicker1
            // 
            this.maskedDateTimePicker1.BackColor = System.Drawing.SystemColors.Window;
            this.maskedDateTimePicker1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedDateTimePicker1.Checked = false;
            this.maskedDateTimePicker1.Format = "yyyy-MM-dd";
            this.maskedDateTimePicker1.Location = new System.Drawing.Point(167, 125);
            this.maskedDateTimePicker1.MinimumSize = new System.Drawing.Size(50, 21);
            this.maskedDateTimePicker1.Name = "maskedDateTimePicker1";
            this.maskedDateTimePicker1.SetValueToControl = null;
            this.maskedDateTimePicker1.Size = new System.Drawing.Size(90, 21);
            this.maskedDateTimePicker1.TabIndex = 0;
            // 
            // ControlsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 385);
            this.Controls.Add(this.maskedDateTimePicker1);
            this.Name = "ControlsFrm";
            this.Text = "ControlsFrm";
            this.ResumeLayout(false);

        }

        #endregion

        private hwj.UserControls.Other.MaskedDateTimePicker maskedDateTimePicker1;













    }
}