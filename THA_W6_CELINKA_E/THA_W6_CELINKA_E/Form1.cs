using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W6_CELINKA_E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int input;
        private void btn_next_Click(object sender, EventArgs e)
        {
            int trial = Convert.ToInt32(tb_inputangka.Text);
            if (tb_inputangka.Text == "" || trial <= 3)
            {
                MessageBox.Show("Input must greater than 3","", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Form2 form = new Form2();
                input = Convert.ToInt32(tb_inputangka.Text);
                form.Show();
            }
        }

        private void tb_inputangka_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_inputangka_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }
    }
}
