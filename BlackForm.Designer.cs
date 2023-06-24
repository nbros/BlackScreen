﻿namespace BlackScreen {
    partial class BlackForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackForm));
            Timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // BlackForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BlackForm";
            Text = "BlackForm";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            DoubleClick += BlackForm_DoubleClick;
            KeyDown += BlackForm_KeyDown;
            MouseMove += BlackForm_MouseMove;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer Timer;
    }
}