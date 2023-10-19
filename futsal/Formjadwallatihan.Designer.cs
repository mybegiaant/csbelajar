namespace futsal
{
    partial class Formjadwallatihan
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
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(90, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(528, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(90, 45);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(528, 150);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(270, 17);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 2;
            label1.Text = "Jadwal Latihan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(243, 212);
            label2.Name = "label2";
            label2.Size = new Size(197, 25);
            label2.TabIndex = 3;
            label2.Text = "Daftar Peserta Latihan";
            // 
            // button1
            // 
            button1.Location = new Point(521, 406);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Formjadwallatihan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Formjadwallatihan";
            Text = "Jadwal Dan Peserta Latihan";
            Load += Formjadwallatihan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}