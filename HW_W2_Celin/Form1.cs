using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_W2_Celin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_nama(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string isiBodi =  "Name   : " + txt_nama.Text ;
            string isiBodi2 = "Age    : " + txt_age.Text ;
            string isiBodi3 = "Email  : " + txt_email.Text ;
            string isiBodi4 = "Phone  : " + txt_phone.Text ;
            if(Convert.ToInt32(txt_age.Text) < 18)
            {
                MessageBox.Show(isiBodi + "\n" + isiBodi2 + "\n" + isiBodi3 + "\n " + isiBodi4 + "\n" +  "Is Minor");
            }
            else if (Convert.ToInt32(txt_age.Text) > 18)
            {
                MessageBox.Show(isiBodi + "\n" + isiBodi2 + "\n" + isiBodi3 + "\n " + isiBodi4 + "\n" + "Is Adult");
            }
        }

        private void txt_age_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_nama.Clear();       
            txt_age.Clear();
            txt_email.Clear();
            txt_phone.Clear();
        }
    }
}
