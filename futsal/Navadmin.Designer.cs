namespace futsal
{
    partial class Navadmin
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
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(284, 134);
            button3.Name = "button3";
            button3.Size = new Size(209, 23);
            button3.TabIndex = 6;
            button3.Text = "Manajemen Group";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(284, 105);
            button2.Name = "button2";
            button2.Size = new Size(209, 23);
            button2.TabIndex = 5;
            button2.Text = "Manajemen Pelatih";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(284, 76);
            button1.Name = "button1";
            button1.Size = new Size(209, 23);
            button1.TabIndex = 4;
            button1.Text = "Manajemen Peserta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(284, 221);
            button4.Name = "button4";
            button4.Size = new Size(209, 23);
            button4.TabIndex = 9;
            button4.Text = "Manajemen Lapangan";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(284, 192);
            button5.Name = "button5";
            button5.Size = new Size(209, 23);
            button5.TabIndex = 8;
            button5.Text = "Manajemen Peserta Latihan";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(284, 163);
            button6.Name = "button6";
            button6.Size = new Size(209, 23);
            button6.TabIndex = 7;
            button6.Text = "Manajemen Identitas Punggung";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(284, 337);
            button7.Name = "button7";
            button7.Size = new Size(209, 23);
            button7.TabIndex = 13;
            button7.Text = "Logout";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(284, 308);
            button8.Name = "button8";
            button8.Size = new Size(209, 23);
            button8.TabIndex = 12;
            button8.Text = "Manajemen Jadwal Latihan";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(284, 279);
            button9.Name = "button9";
            button9.Size = new Size(209, 23);
            button9.TabIndex = 11;
            button9.Text = "Manajemen Hari";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(284, 250);
            button10.Name = "button10";
            button10.Size = new Size(209, 23);
            button10.TabIndex = 10;
            button10.Text = "Manajemen Waktu";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 46);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 14;
            label1.Text = "Welcome ,";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 46);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 15;
            label2.Text = "admin";
            label2.TextChanged += label2_TextChanged;
            label2.Click += label2_Click;
            // 
            // Navadmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Navadmin";
            Text = "Navadmin";
            Load += Navadmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label1;
        private Label label2;
    }
}