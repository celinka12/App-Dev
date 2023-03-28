using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W3_CELINKA_E
{
    public partial class Main_Window_Form : Form
    {
        public static Main_Window_Form formInstance;
        public TextBox tbx;

            public Main_Window_Form()
            {
            InitializeComponent();
            formInstance = this;
            tbx = textBox_Name;       
            }

        private void button_Submit_Click(object sender, EventArgs e)
        {     
            if (textBox_Name.Text == "")
            {
                string errorText = "Please input name!";
                MessageBox.Show(errorText, "Name is empty ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (textBox_Fav_artist.Text == "")
            {
                string errorText = "Please input Artist!";
                MessageBox.Show(errorText, "Artist is empty ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {
                Second_Window_Form.Instance.lbl.Text = "Hi, my name is " + textBox_Name.Text + "and my Favorite artist is " + textBox_Fav_artist.Text;      
            }
        }

        private void checkBox_TermsCondition_CheckedChanged(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Second_Window_Form>().Any() && checkBox_TermsCondition.Checked)
            {
                button_Submit.Enabled = true;
            }
            else
            {
                button_Submit.Enabled = false;
            }
        }

        private void button_OpenNextForm_Click(object sender, EventArgs e)
        {
            Second_Window_Form form2 = new Second_Window_Form();
            form2.Show();         
        }
           
        private void Main_Window_Form_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox_Name_Click(object sender, EventArgs e)
        {

        }     
    }
}
