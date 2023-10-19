namespace futsal
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(140, 76);
            label1.Name = "label1";
            label1.Size = new Size(274, 30);
            label1.TabIndex = 0;
            label1.Text = "Pusat Pelatihan Dasar Futsal";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(196, 158);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(196, 225);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(221, 306);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 166);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 233);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "password";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 387);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "loginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnLogin;
        private Label label2;
        private Label label3;
    }
}