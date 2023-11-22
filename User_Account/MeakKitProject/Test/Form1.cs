using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Test;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();

            if (frm.Tag == null) { return; }
            DataRow dr = (DataRow)frm.Tag;

            textBox1.Text = dr["zonecode"].ToString();
            textBox2.Text = dr["ADDR1"].ToString();
            textBox3.Text = "";
            textBox4.Text = dr["EX"].ToString();

            textBox3.Focus();
        }
    }
}


