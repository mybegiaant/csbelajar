namespace futsal
{
    partial class ManageHari
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
            button5.Location = new Point(584, 341);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 51;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(465, 384);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 50;
            button4.Text = "Cancel";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(346, 341);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 49;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(235, 384);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 48;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(129, 341);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 47;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(300, 239);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(313, 23);
            textBox2.TabIndex = 46;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(300, 210);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 23);
            textBox1.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 242);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 44;
            label3.Text = "nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 213);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 43;
            label2.Text = "id_hari";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(127, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(546, 105);
            dataGridView1.TabIndex = 42;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 44);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 41;
            label1.Text = "Form Hari";
            // 
            // ManageHari
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
            Name = "ManageHari";
            Text = "ManageHari";
            Load += ManageHari_Load;
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