﻿namespace futsal
{
    partial class Formnavigasipeserta
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(280, 205);
            button3.Name = "button3";
            button3.Size = new Size(129, 23);
            button3.TabIndex = 6;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(280, 176);
            button2.Name = "button2";
            button2.Size = new Size(129, 23);
            button2.TabIndex = 5;
            button2.Text = "Peserta Latihan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(280, 118);
            button1.Name = "button1";
            button1.Size = new Size(129, 23);
            button1.TabIndex = 4;
            button1.Text = "Edit Profile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(279, 147);
            button4.Name = "button4";
            button4.Size = new Size(129, 23);
            button4.TabIndex = 7;
            button4.Text = "Jadwal Latihan";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Formnavigasipeserta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(667, 339);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Formnavigasipeserta";
            Text = "Form Peserta";
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
    }
}