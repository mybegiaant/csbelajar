namespace futsal
{
    partial class Formjadwallatihanpeserta
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
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(78, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(539, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(223, 41);
            label1.Name = "label1";
            label1.Size = new Size(222, 30);
            label1.TabIndex = 2;
            label1.Text = "Jadwal Latihan Peserta";
            // 
            // button1
            // 
            button1.Location = new Point(513, 352);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Formjadwallatihanpeserta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 430);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Formjadwallatihanpeserta";
            Text = "Jadwal Latihan";
            Load += Formjadwallatihanpeserta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
    }
}