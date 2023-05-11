using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography; // new syntax buat bikin securityny biar nyambung

namespace w13_CA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string coba = textBox1.Text;

            MD5 md5 = new MD5CryptoServiceProvider();

            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(coba));

            byte[] result = md5.Hash;

            StringBuilder stringBuilder = new StringBuilder();

            for(int a =0; a < result.Length; a++)
            {
                stringBuilder.Append(result[a].ToString("x2"));
            }
            textBox2.Text = (stringBuilder.ToString());
        }
        
    }
}
