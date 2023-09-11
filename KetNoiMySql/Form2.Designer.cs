namespace KetNoiMySql
{
    partial class Form2
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
            btnLoad = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txt_dbname = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(484, 341);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(92, 43);
            btnLoad.TabIndex = 14;
            btnLoad.Text = "Load Data";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 38);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1035, 297);
            dataGridView1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 12);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 12;
            label1.Text = "Database Name";
            // 
            // txt_dbname
            // 
            txt_dbname.Location = new Point(345, 9);
            txt_dbname.Name = "txt_dbname";
            txt_dbname.Size = new Size(380, 23);
            txt_dbname.TabIndex = 11;
            txt_dbname.Text = "mulan_auto";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 392);
            Controls.Add(btnLoad);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(txt_dbname);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txt_dbname;
    }
}