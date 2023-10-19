namespace futsal
{
    partial class ManageLapangan
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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(589, 327);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 40;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(470, 370);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 39;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(351, 327);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 38;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(240, 370);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 37;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(134, 327);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 36;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(305, 225);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(313, 23);
            textBox2.TabIndex = 35;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(305, 196);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 23);
            textBox1.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(151, 228);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 32;
            label3.Text = "nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(151, 199);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 31;
            label2.Text = "id_lapangan";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(132, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(546, 105);
            dataGridView1.TabIndex = 30;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 30);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 29;
            label1.Text = "Form Lapangan";
            // 
            // ManageLapangan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "ManageLapangan";
            Text = "ManageLapangan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label1;
    }
}