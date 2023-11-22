using MealKitPro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeakKitProject
{
    public partial class Form4 : Form
    {
        //UserInformation myuser = new UserInformation();
        public Form4()
        {
            InitializeComponent();

            if (UserDataManager.loginUser != null)
            {
                textBox1_ID.Text = UserDataManager.loginUser.ID;
                textBox2_PW.Text = UserDataManager.loginUser.Password;
                textBox3_Name.Text = UserDataManager.loginUser.Name;
                textBox4_ZipCode.Text = UserDataManager.loginUser.ZipCode;
                textBox5_Adress.Text = UserDataManager.loginUser.Address;
                textBox6_Detail_Adress.Text = UserDataManager.loginUser.DetailAddress;
                textBox7_Reference_Adress.Text = UserDataManager.loginUser.ReferenceAddress;
                textBox8_Phone_Number.Text = UserDataManager.loginUser.PhoneNumber;
            }
        }

        private void WithdrowButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("예) 클릭 시 해당 유저의 모든 정보가 삭제 됩니다.");
            Form6 form = new Form6();
            form.ShowDialog();
            if(Form6.withdrowCheck==true)
                this.Close();

        }
    
    }
}
