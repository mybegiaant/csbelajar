namespace futsal
{
    partial class Formeditprofile
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(302, 39);
            label1.Name = "label1";
            label1.Size = new Size(115, 25);
            label1.TabIndex = 3;
            label1.Text = "Form Profile";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(263, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 152);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 265);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Id Peserta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(82, 294);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 6;
            label3.Text = "Nama Peserta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 323);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 7;
            label4.Text = "Alamat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(82, 355);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 8;
            label5.Text = "Tanggal Lahir";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(248, 262);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(324, 23);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(248, 291);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(324, 23);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(248, 320);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(324, 23);
            textBox3.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(248, 349);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(324, 23);
            dateTimePicker1.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(151, 415);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 13;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(443, 415);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 14;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Formeditprofile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(686, 463);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Formeditprofile";
            Text = "Edit Profile";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
    }
}