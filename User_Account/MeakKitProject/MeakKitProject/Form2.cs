using MealKitPro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MeakKitProject
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }

        enum ButtonChecked
        {
            DUPLICATED,
            CHECKED,
            NODUPLICATED,
            NOCHECKED           
        }
        ButtonChecked isduplicated = ButtonChecked.DUPLICATED;
        ButtonChecked ischecked = ButtonChecked.NOCHECKED;
       
        private void ZipCode_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();

            if (frm.Tag == null) { return; }
            DataRow dr = (DataRow)frm.Tag;

            textBox4_ZipCode.Text = dr["zonecode"].ToString();
            textBox5_Adress.Text = dr["ADDR1"].ToString();
            textBox6_Detail_Adress.Text = "";
            textBox7_Reference_Adress.Text = dr["EX"].ToString();
            textBox6_Detail_Adress.Focus();
        }

        private void WriteLog(string connents)
        {
            string log =
                $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}]";
            log += connents;
            UserDataManager.UserAccountLog(log);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //중복 체크하기전 duplicate = 0, check = 1, noDuplicate = 2, noCheck = 3 
            if (ischecked == ButtonChecked.NOCHECKED)
            {
                MessageBox.Show("중복 체크를 안 했습니다.");
                return;
            }
            if (isduplicated == ButtonChecked.DUPLICATED)
            {
                MessageBox.Show("ID가 중복이므로 진행할 수 없습니다.");
                return;
            }

            if (textBox1_ID.Text.Trim() == "" || textBox2_PW.Text.Trim() == "" || textBox3_Name.Text.Trim() == "" || textBox4_ZipCode.Text.Trim() == "" ||
                textBox5_Adress.Text.Trim()==""|| textBox6_Detail_Adress.Text.Trim()=="" || textBox8_PhoneNumber.Text.Trim()=="" )
                MessageBox.Show("현재 페이지에서 입력하지 않은 정보가 있습니다. ");           
            else
            {
                try
                {
                    UserInformation user = new UserInformation();
                                        
                    user.ID = textBox1_ID.Text;
                    user.Password = textBox2_PW.Text;
                    user.Name = textBox3_Name.Text;
                    user.ZipCode = textBox4_ZipCode.Text;
                    user.Address = textBox5_Adress.Text;
                    user.DetailAddress = textBox6_Detail_Adress.Text;
                    user.ReferenceAddress = textBox7_Reference_Adress.Text;
                    user.PhoneNumber = textBox8_PhoneNumber.Text;
                    user.AccountDate = DateTime.Now;

                    //DB에 입력한 정보저장
                    InsertUser(textBox1_ID.Text, textBox2_PW.Text, textBox3_Name.Text, textBox4_ZipCode.Text, textBox5_Adress.Text, textBox6_Detail_Adress.Text, 
                        textBox7_Reference_Adress.Text, textBox8_PhoneNumber.Text, "insert");
                }
                catch (Exception)
                { }
                Hide();
            }
        }

        private void InsertUser(string id, string pw, string name, string zipCode, string adress,
            string detailAdress, string referenceAdress, string phoneNumber, string cmd)
        {
            id = id.Trim();
            pw = pw.Trim();

            zipCode = zipCode.Trim();  
            adress = adress.Trim();
            name = name.Trim();
            detailAdress = detailAdress.Trim();
            referenceAdress = referenceAdress.Trim();
            phoneNumber = phoneNumber.Trim();
            string contents = "";
            UserDataManager.Save(id, pw, name, zipCode, adress, detailAdress, referenceAdress, phoneNumber, cmd, out contents);
            MessageBox.Show("가입을 환영합니다.");
            WriteLog(contents);
        }
        
        private void IdDuplicate_Click(object sender, EventArgs e)
        {
            //중복 체크하기전 duplicate = 0, check = 1, noDuplicate = 2, noCheck = 3 
            //중복버튼을 체크했으니 
            isduplicated = ButtonChecked.DUPLICATED;
            ischecked = ButtonChecked.CHECKED;

            if (textBox1_ID.Text.Trim() == "")
                MessageBox.Show("ID를 입력하세요");
            else
                DuplicateCheck(textBox1_ID.Text);
        }

        public void DuplicateCheck(string ps)
        {
            ps = ps.Trim();
            string contents = "";            
            if(!UserDataManager.isUserDuplicated(ps, out contents))
            {
                isduplicated = ButtonChecked.NODUPLICATED;
            }
            MessageBox.Show(contents);
            WriteLog(contents);            
        }

        private void IDTextBox_TextChanged(object sender, EventArgs e)
        {
            ischecked = ButtonChecked.NOCHECKED;
        }
    }
}