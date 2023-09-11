namespace KetNoiMySql
{
    partial class Form1
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
            txt_dbname = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btnLoad = new Button();
            button1 = new Button();
            btn_Add = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txt_dbname
            // 
            txt_dbname.Location = new Point(345, 5);
            txt_dbname.Name = "txt_dbname";
            txt_dbname.Size = new Size(380, 23);
            txt_dbname.TabIndex = 0;
            txt_dbname.Text = "mulan_auto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 8);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Database Name";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1035, 297);
            dataGridView1.TabIndex = 8;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(484, 337);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(92, 43);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "Load Data";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // button1
            // 
            button1.Location = new Point(955, 337);
            button1.Name = "button1";
            button1.Size = new Size(92, 43);
            button1.TabIndex = 10;
            button1.Text = "Open From 2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(582, 337);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(75, 43);
            btn_Add.TabIndex = 11;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 392);
            Controls.Add(btn_Add);
            Controls.Add(button1);
            Controls.Add(btnLoad);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(txt_dbname);
            Name = "Form1";
            Text = "Kết nối DATABASE";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_dbname;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btnLoad;
        private Button button1;
        private Button btn_Add;
    }
}