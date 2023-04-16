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

namespace THA_W7_CELINKA_E
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            choose_Movie choose_Movie = new choose_Movie();
            choose_Movie.Dock = DockStyle.Fill;
            choose_Movie.TopLevel = false;
            panel1.Controls.Clear();
            choose_Movie.Show();
            this.panel1.Controls.Add(choose_Movie);

            Label judul = new Label();
            judul.Text = "Movie List";
            judul.Size = new Size(1000, 1000);
            judul.Location = new Point(5, 15);
            this.Controls.Add(judul);

        }
    }
}
