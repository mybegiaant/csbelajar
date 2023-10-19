namespace futsal
{
    partial class ManagePeserta
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
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(299, 20);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Form Peserta";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(85, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(546, 105);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 180);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "id peserta";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 209);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 3;
            label3.Text = "nama peserta";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(258, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(258, 206);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(313, 23);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(87, 324);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(193, 367);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(304, 324);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 10;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(423, 367);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 11;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(542, 324);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 12;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 238);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 13;
            label5.Text = "alamat";
            label5.Click += label5_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(258, 235);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(313, 23);
            textBox3.TabIndex = 14;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(104, 267);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 17;
            label6.Text = "id user";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(258, 264);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(313, 23);
            textBox5.TabIndex = 18;
            // 
            // ManagePeserta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 416);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label5);
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
            Name = "ManagePeserta";
            Text = "ManagePeserta";
            Load += ManagePeserta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox5;
    }
}