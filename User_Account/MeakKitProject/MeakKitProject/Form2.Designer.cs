namespace MeakKitProject
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
            this.textBox1_ID = new System.Windows.Forms.TextBox();
            this.textBox2_PW = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.PwLAbel = new System.Windows.Forms.Label();
            this.button1_ID_Duplicate = new System.Windows.Forms.Button();
            this.textBox5_Adress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4_ZipCode = new System.Windows.Forms.TextBox();
            this.button2_ZipCode_Search = new System.Windows.Forms.Button();
            this.textBox6_Detail_Adress = new System.Windows.Forms.TextBox();
            this.textBox8_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7_Reference_Adress = new System.Windows.Forms.TextBox();
            this.button3_SaveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1_ID
            // 
            this.textBox1_ID.Location = new System.Drawing.Point(138, 68);
            this.textBox1_ID.Name = "textBox1_ID";
            this.textBox1_ID.Size = new System.Drawing.Size(205, 21);
            this.textBox1_ID.TabIndex = 0;
            this.textBox1_ID.TextChanged += new System.EventHandler(this.IDTextBox_TextChanged);
            // 
            // textBox2_PW
            // 
            this.textBox2_PW.Location = new System.Drawing.Point(138, 114);
            this.textBox2_PW.Name = "textBox2_PW";
            this.textBox2_PW.Size = new System.Drawing.Size(205, 21);
            this.textBox2_PW.TabIndex = 1;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(73, 71);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(41, 12);
            this.IdLabel.TabIndex = 2;
            this.IdLabel.Text = "아이디";
            // 
            // PwLAbel
            // 
            this.PwLAbel.AutoSize = true;
            this.PwLAbel.Location = new System.Drawing.Point(73, 123);
            this.PwLAbel.Name = "PwLAbel";
            this.PwLAbel.Size = new System.Drawing.Size(53, 12);
            this.PwLAbel.TabIndex = 3;
            this.PwLAbel.Text = "비밀번호";
            // 
            // button1_ID_Duplicate
            // 
            this.button1_ID_Duplicate.Location = new System.Drawing.Point(363, 68);
            this.button1_ID_Duplicate.Name = "button1_ID_Duplicate";
            this.button1_ID_Duplicate.Size = new System.Drawing.Size(113, 23);
            this.button1_ID_Duplicate.TabIndex = 4;
            this.button1_ID_Duplicate.Text = "중복체크";
            this.button1_ID_Duplicate.UseVisualStyleBackColor = true;
            this.button1_ID_Duplicate.Click += new System.EventHandler(this.IdDuplicate_Click);
            // 
            // textBox5_Adress
            // 
            this.textBox5_Adress.Location = new System.Drawing.Point(138, 251);
            this.textBox5_Adress.Name = "textBox5_Adress";
            this.textBox5_Adress.Size = new System.Drawing.Size(171, 21);
            this.textBox5_Adress.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "주소";
            // 
            // textBox4_ZipCode
            // 
            this.textBox4_ZipCode.Location = new System.Drawing.Point(138, 214);
            this.textBox4_ZipCode.Name = "textBox4_ZipCode";
            this.textBox4_ZipCode.Size = new System.Drawing.Size(171, 21);
            this.textBox4_ZipCode.TabIndex = 12;
            // 
            // button2_ZipCode_Search
            // 
            this.button2_ZipCode_Search.Location = new System.Drawing.Point(328, 212);
            this.button2_ZipCode_Search.Name = "button2_ZipCode_Search";
            this.button2_ZipCode_Search.Size = new System.Drawing.Size(148, 23);
            this.button2_ZipCode_Search.TabIndex = 13;
            this.button2_ZipCode_Search.Text = "우편번호찾기";
            this.button2_ZipCode_Search.UseVisualStyleBackColor = true;
            this.button2_ZipCode_Search.Click += new System.EventHandler(this.ZipCode_Click);
            // 
            // textBox6_Detail_Adress
            // 
            this.textBox6_Detail_Adress.Location = new System.Drawing.Point(138, 291);
            this.textBox6_Detail_Adress.Name = "textBox6_Detail_Adress";
            this.textBox6_Detail_Adress.Size = new System.Drawing.Size(171, 21);
            this.textBox6_Detail_Adress.TabIndex = 14;
            // 
            // textBox8_PhoneNumber
            // 
            this.textBox8_PhoneNumber.Location = new System.Drawing.Point(138, 333);
            this.textBox8_PhoneNumber.Name = "textBox8_PhoneNumber";
            this.textBox8_PhoneNumber.Size = new System.Drawing.Size(216, 21);
            this.textBox8_PhoneNumber.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "휴대전화";
            // 
            // textBox7_Reference_Adress
            // 
            this.textBox7_Reference_Adress.Location = new System.Drawing.Point(328, 291);
            this.textBox7_Reference_Adress.Name = "textBox7_Reference_Adress";
            this.textBox7_Reference_Adress.Size = new System.Drawing.Size(148, 21);
            this.textBox7_Reference_Adress.TabIndex = 17;
            // 
            // button3_SaveButton
            // 
            this.button3_SaveButton.Location = new System.Drawing.Point(328, 397);
            this.button3_SaveButton.Name = "button3_SaveButton";
            this.button3_SaveButton.Size = new System.Drawing.Size(75, 23);
            this.button3_SaveButton.TabIndex = 18;
            this.button3_SaveButton.Text = "저장하기";
            this.button3_SaveButton.UseVisualStyleBackColor = true;
            this.button3_SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "이름";
            // 
            // textBox3_Name
            // 
            this.textBox3_Name.Location = new System.Drawing.Point(138, 170);
            this.textBox3_Name.Name = "textBox3_Name";
            this.textBox3_Name.Size = new System.Drawing.Size(121, 21);
            this.textBox3_Name.TabIndex = 20;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 468);
            this.Controls.Add(this.textBox3_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3_SaveButton);
            this.Controls.Add(this.textBox7_Reference_Adress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox8_PhoneNumber);
            this.Controls.Add(this.textBox6_Detail_Adress);
            this.Controls.Add(this.button2_ZipCode_Search);
            this.Controls.Add(this.textBox4_ZipCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5_Adress);
            this.Controls.Add(this.button1_ID_Duplicate);
            this.Controls.Add(this.PwLAbel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.textBox2_PW);
            this.Controls.Add(this.textBox1_ID);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_ID;
        private System.Windows.Forms.TextBox textBox2_PW;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label PwLAbel;
        private System.Windows.Forms.Button button1_ID_Duplicate;
        private System.Windows.Forms.TextBox textBox5_Adress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4_ZipCode;
        private System.Windows.Forms.Button button2_ZipCode_Search;
        private System.Windows.Forms.TextBox textBox6_Detail_Adress;
        private System.Windows.Forms.TextBox textBox8_PhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox7_Reference_Adress;
        private System.Windows.Forms.Button button3_SaveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3_Name;
    }
}