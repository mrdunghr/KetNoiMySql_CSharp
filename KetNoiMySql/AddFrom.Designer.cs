namespace KetNoiMySql
{
    partial class AddFrom
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
            btn_Ok = new Button();
            label2 = new Label();
            txt_authenType = new TextBox();
            label4 = new Label();
            txt_Email = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txt_Money = new TextBox();
            label7 = new Label();
            txt_Otp = new TextBox();
            label8 = new Label();
            txt_Password = new TextBox();
            label9 = new Label();
            txt_Phone = new TextBox();
            label10 = new Label();
            txt_Username = new TextBox();
            checkBoxEnabled = new CheckBox();
            SuspendLayout();
            // 
            // btn_Ok
            // 
            btn_Ok.Location = new Point(338, 366);
            btn_Ok.Name = "btn_Ok";
            btn_Ok.Size = new Size(108, 72);
            btn_Ok.TabIndex = 0;
            btn_Ok.Text = "Ok";
            btn_Ok.UseVisualStyleBackColor = true;
            btn_Ok.Click += btn_Ok_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 73);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 4;
            label2.Text = "type";
            // 
            // txt_authenType
            // 
            txt_authenType.Location = new Point(289, 70);
            txt_authenType.Name = "txt_authenType";
            txt_authenType.Size = new Size(273, 23);
            txt_authenType.TabIndex = 3;
            txt_authenType.Text = "DATABASE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 102);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 8;
            label4.Text = "mail";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(289, 99);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(273, 23);
            txt_Email.TabIndex = 7;
            txt_Email.Text = "test@gmail.com";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 131);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 10;
            label5.Text = "enabled";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(196, 160);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 12;
            label6.Text = "money";
            // 
            // txt_Money
            // 
            txt_Money.Location = new Point(289, 157);
            txt_Money.Name = "txt_Money";
            txt_Money.Size = new Size(273, 23);
            txt_Money.TabIndex = 11;
            txt_Money.Text = "50000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(196, 189);
            label7.Name = "label7";
            label7.Size = new Size(25, 15);
            label7.TabIndex = 14;
            label7.Text = "opt";
            // 
            // txt_Otp
            // 
            txt_Otp.Location = new Point(289, 186);
            txt_Otp.Name = "txt_Otp";
            txt_Otp.Size = new Size(273, 23);
            txt_Otp.TabIndex = 13;
            txt_Otp.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(196, 218);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 16;
            label8.Text = "pass";
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(289, 215);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(273, 23);
            txt_Password.TabIndex = 15;
            txt_Password.Text = "123123123";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(196, 247);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 18;
            label9.Text = "phone";
            // 
            // txt_Phone
            // 
            txt_Phone.Location = new Point(289, 244);
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(273, 23);
            txt_Phone.TabIndex = 17;
            txt_Phone.Text = "0382564621";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(196, 276);
            label10.Name = "label10";
            label10.Size = new Size(29, 15);
            label10.TabIndex = 20;
            label10.Text = "user";
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(289, 273);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(273, 23);
            txt_Username.TabIndex = 19;
            txt_Username.Text = "tess123123123";
            // 
            // checkBoxEnabled
            // 
            checkBoxEnabled.AutoSize = true;
            checkBoxEnabled.Location = new Point(289, 132);
            checkBoxEnabled.Name = "checkBoxEnabled";
            checkBoxEnabled.Size = new Size(68, 19);
            checkBoxEnabled.TabIndex = 21;
            checkBoxEnabled.Text = "Enabled";
            checkBoxEnabled.UseVisualStyleBackColor = true;
            // 
            // AddFrom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxEnabled);
            Controls.Add(label10);
            Controls.Add(txt_Username);
            Controls.Add(label9);
            Controls.Add(txt_Phone);
            Controls.Add(label8);
            Controls.Add(txt_Password);
            Controls.Add(label7);
            Controls.Add(txt_Otp);
            Controls.Add(label6);
            Controls.Add(txt_Money);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_Email);
            Controls.Add(label2);
            Controls.Add(txt_authenType);
            Controls.Add(btn_Ok);
            Name = "AddFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddFrom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Ok;
        private Label label2;
        private TextBox txt_authenType;
        private Label label4;
        private TextBox txt_Email;
        private Label label5;
        private Label label6;
        private TextBox txt_Money;
        private Label label7;
        private TextBox txt_Otp;
        private Label label8;
        private TextBox txt_Password;
        private Label label9;
        private TextBox txt_Phone;
        private Label label10;
        private TextBox txt_Username;
        private CheckBox checkBoxEnabled;
    }
}