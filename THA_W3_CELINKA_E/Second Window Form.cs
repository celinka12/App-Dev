using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace THA_W3_CELINKA_E
{
    public partial class Second_Window_Form : Form
    {

        public static Second_Window_Form Instance;
        public Label lbl;
        public Second_Window_Form()
        {
            InitializeComponent();
            Instance = this;
            lbl = label_Mynameis;
        }

       

        private void button_Magic_Click(object sender, EventArgs e)
        {
            if (!radioButton_Green.Checked && !radioButton_Pink.Checked && !radioButton_Blue.Checked && !radioButton_Khaki.Checked && !radioButton_Brown.Checked)
            {
                string errorText = "choose from the radio buttons Favorite color";
                MessageBox.Show(errorText, "Radio button is empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!radioButton_Gold.Checked && !radioButton_Red.Checked && !radioButton_BlueViolet.Checked)
            {
                string errorText = "choose from the radio buttons";
                MessageBox.Show(errorText, "Radio button is empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (radioButton_Green.Checked)
                {
                    Main_Window_Form.formInstance.BackColor = Color.Green;
                }
                if (radioButton_Pink.Checked)
                {
                    Main_Window_Form.formInstance.BackColor = Color.Pink;
                }
                if (radioButton_Blue.Checked)
                {
                    Main_Window_Form.formInstance.BackColor = Color.Blue;
                }
                if (radioButton_Khaki.Checked)
                {
                    Main_Window_Form.formInstance.BackColor = Color.Khaki;
                }
                if (radioButton_Brown.Checked)
                {
                    Main_Window_Form.formInstance.BackColor = Color.Brown;
                }
                if (radioButton_BlueViolet.Checked)
                {
                    Main_Window_Form.formInstance.ForeColor = Color.BlueViolet;
                }
                if (radioButton_Red.Checked)
                {
                    Main_Window_Form.formInstance.ForeColor = Color.Red;
                }
                if(radioButton_Gold.Checked)
                {
                    Main_Window_Form.formInstance.ForeColor = Color.Gold;
                }
            }     
        }
        private void radioButton_Green_Click(object sender, EventArgs e)
        {

        }

        private void label_Mynameis_Click(object sender, EventArgs e)
        {
            Main_Window_Form frm = new Main_Window_Form();
            frm.Show();

        }

        private void checkBox_TermsForm2_Click(object sender, EventArgs e)
        {
            if (checkBox_TermsForm2.Checked && checkBox_AllChoiceForm2.Checked)
            {
                button_Magic.Enabled = true;
            }
            else
            {
                button_Magic.Enabled = false;
            } 
        }

        private void checkBox_AllChoiceForm2_Click(object sender, EventArgs e)
        {
           if (checkBox_AllChoiceForm2.Checked && checkBox_TermsForm2.Checked)
            {
                button_Magic.Enabled = true;
            }
           else
            {
                button_Magic.Enabled = false;
            }
        }

        private void radioButton_Green_CheckedChanged(object sender, EventArgs e)
        {

          
        }

        private void radioButton_Pink_CheckedChanged(object sender, EventArgs e)
        {

          
        }

        private void radioButton_Blue_CheckedChanged(object sender, EventArgs e)
        {

           
        }

        private void radioButton_Khaki_CheckedChanged(object sender, EventArgs e)
        {

          
        }

        private void radioButton_Brown_CheckedChanged(object sender, EventArgs e)
        {

           
            
        }

        private void radioButton_BlueViolet_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox_AllChoiceForm2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
