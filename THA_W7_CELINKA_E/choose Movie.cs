using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W7_CELINKA_E
{
    public partial class choose_Movie : Form
    {
        public choose_Movie()
        {
            InitializeComponent();
        }

        private void choose_Movie_Load(object sender, EventArgs e)
        {
            //film 1
            Button button1 = new Button();
            button1.Size = new Size(40, 40);
            button1.Location = new Point(35, 145);
            button1.Text = "Book";
            this.Controls.Add(button1);

            button1.Click += Button1_Click;

            PictureBox picture1 = new PictureBox();
            picture1.Image = Image.FromFile("C:\\Users\\Celinka\\OneDrive\\Pictures\\avenger movie\\Aquietplace.jpg");
            picture1.Location = new Point(0, 5);
            picture1.Size = new Size(120,120);
            picture1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture1);

            Label label1 = new Label();
            label1.Size = new Size(80, 80);
            label1.Location = new Point(25, 130);
            label1.Text = "A quiet place";
            this.Controls.Add(label1);

            // film 2

            Button button2 = new Button();
            button2.Size = new Size(40, 40);
            button2.Location = new Point(180,145);
            button2.Text = "Book";
            this.Controls.Add(button2);

            button2.Click += Button2_Click;

            PictureBox picture2 = new PictureBox();
            picture2.Image = Image.FromFile("C:\\Users\\Celinka\\OneDrive\\Pictures\\avenger movie\\AvengerAgeofUltron.jpg");
            picture2.Location = new Point(150, 5);
            picture2.Size = new Size(120, 120);
            picture2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture2);

            Label label2 = new Label();
            label2.Size = new Size(150, 50);
            label2.Location = new Point(150, 130);
            label2.Text = "Avenger Age of Ultron";
            this.Controls.Add(label2);

            //film 3
            Button button3 = new Button();
            button3.Size = new Size(40, 40);
            button3.Location = new Point(350, 145);
            button3.Text = "Book";
            this.Controls.Add(button3);

            button3.Click += Button3_Click;

            PictureBox picture3 = new PictureBox();
            picture3.Image = Image.FromFile("C:\\Users\\Celinka\\OneDrive\\Pictures\\avenger movie\\Avengerinfinitywar.jpg");
            picture3.Location = new Point(310, 5);
            picture3.Size = new Size(120, 120);
            picture3.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture3);

            Label label3 = new Label();
            label3.Size = new Size(150, 50);
            label3.Location = new Point(320, 130);
            label3.Text = "Avenger Infinity War";
            this.Controls.Add(label3);

            //film 4
            Button button4 = new Button();
            button4.Size = new Size(40, 40);
            button4.Location = new Point(500, 145);
            button4.Text = "Book";
            this.Controls.Add(button4);

            button4.Click += Button4_Click;

            PictureBox picture4 = new PictureBox();
            picture4.Image = Image.FromFile("C:\\Users\\Celinka\\OneDrive\\Pictures\\avenger movie\\CaptainMarvel.jpg");
            picture4.Location = new Point(470, 5);
            picture4.Size = new Size(120, 120);
            picture4.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture4);

            Label label4 = new Label();
            label4.Size = new Size(150, 50);
            label4.Location = new Point(490, 130);
            label4.Text = "Captain Marvel";
            this.Controls.Add(label4);

            //film 5
            Button button5 = new Button();
            button5.Size = new Size(40, 40);
            button5.Location = new Point(35, 355);
            button5.Text = "Book";
            this.Controls.Add(button5);

            button5.Click += Button5_Click;

            PictureBox picture5 = new PictureBox();
            picture5.Image = Image.FromFile("C:\\Users\\Celinka\\OneDrive\\Pictures\\avenger movie\\IronMan1.jpg");
            picture5.Location = new Point(0, 210);
            picture5.Size = new Size(120, 120);
            picture5.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture5);

            Label label5 = new Label();
            label5.Size = new Size(100, 20);
            label5.Location = new Point(25, 340);
            label5.Text = "Iron Man 1";
            this.Controls.Add(label5);

            //film  6
            Button button6 = new Button();
            button6.Size = new Size(40, 40);
            button6.Location = new Point(180, 355);
            button6.Text = "Book";
            this.Controls.Add(button6);

            button6.Click += Button6_Click;

            PictureBox picture6 = new PictureBox();
            picture6.Image = Image.FromFile("C:\\Users\\Celinka\\OneDrive\\Pictures\\avenger movie\\Spidermannowayhome.jpg");
            picture6.Location = new Point(150, 210);
            picture6.Size = new Size(120, 120);
            picture6.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture6);

            Label label6 = new Label();
            label6.Size = new Size(100, 20);
            label6.Location = new Point(160, 340);
            label6.Text = "Spiderman No Way Home";
            this.Controls.Add(label6);

            // film 7
            Button button7 = new Button();
            button7.Size = new Size(40, 40);
            button7.Location = new Point(350, 355);
            button7.Text = "Book";
            this.Controls.Add(button7);

            button7.Click += Button7_Click;

            PictureBox picture7 = new PictureBox();
            picture7.Image = Image.FromFile("C:\\Users\\Celinka\\OneDrive\\Pictures\\avenger movie\\Temantapimenikah.jpg");
            picture7.Location = new Point(310, 210);
            picture7.Size = new Size(120, 120);
            picture7.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture7);

            Label label7 = new Label();
            label7.Size = new Size(110, 70);
            label7.Location = new Point(315, 340);
            label7.Text = "Teman Tapi Menikah";
            this.Controls.Add(label7);

            //film 8
            Button button8 = new Button();
            button8.Size = new Size(40, 40);
            button8.Location = new Point(500, 355);
            button8.Text = "Book";
            this.Controls.Add(button8);

            button8.Click += Button8_Click;

            PictureBox picture8 = new PictureBox();
            picture8.Image = Image.FromFile("C:\\Users\\Celinka\\OneDrive\\Pictures\\avenger movie\\TraintoBusan.jpg");
            picture8.Location = new Point(470, 210);
            picture8.Size = new Size(120, 120);
            picture8.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(picture8);

            Label label8 = new Label();
            label8.Size = new Size(100, 50);
            label8.Location = new Point(490, 340);
            label8.Text = "Train to Busan";
            this.Controls.Add(label8);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            train_to_busan film = new train_to_busan();
            film.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            teman_tapi_menikah film = new teman_tapi_menikah();
            film.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            spiderman film = new spiderman();
            film.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            iron_man_1 film = new iron_man_1();
            film.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            captain_america film = new  captain_america();
            film.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            infinity_war film = new infinity_war();
            film.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            age_of_ultron film = new age_of_ultron();
            film.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            JamTayang jamTayang = new JamTayang();
            jamTayang.Show();
        }

        
    }
}
