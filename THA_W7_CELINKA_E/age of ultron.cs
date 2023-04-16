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
    public partial class age_of_ultron : Form
    {
        Panel ageofultron = new Panel();
        List<Button> buttonlistjam1 = new List<Button>();
        List<Button> buttonlistjam2 = new List<Button>();
        List<Button> buttonlistjam3 = new List<Button>();
        int nambah = 0;
        int b = 0;
        int c = 0;
        int milih = 0;
        int nyoba = 0;
        Random seat = new Random();
        Label gatau = new Label();
        public age_of_ultron()
        {
            InitializeComponent();
        }

        private void age_of_ultron_Load(object sender, EventArgs e)
        {
            //Label judul 2
            Label movie1 = new Label();
            movie1.AutoSize = true;
            movie1.Location = new Point(5, 20);
            movie1.Name = "Avenger Age of Ultron";
            movie1.Size = new Size(300, 300);
            movie1.TabIndex = 1;
            movie1.Text = "Avenger Age of Ultron";
            Controls.Add(movie1);
            movie1.Click += Movie1_Click;

            //poster
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = Properties.Resources.Avenger_Age_of_Ultron;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Location = new Point(5, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 320);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            Controls.Add(pictureBox1);
            pictureBox1.Click += PictureBox1_Click;

            //Label tampil
            gatau.AutoSize = true;
            gatau.Location = new Point(390, 380);
            gatau.Name = "Seat Choose ";
            gatau.Size = new Size(300, 300);
            gatau.TabIndex = 1;
            gatau.Text = "Seat Choose ";
            Controls.Add(gatau);
            gatau.Click += Gatau_Click;

            //button oke
            Button reset = new Button();
            reset.Location = new Point(390, 330);
            reset.Size = new Size(150, 24);
            reset.BackColor = Color.LightSlateGray;
            reset.TabIndex = 5;
            reset.Text = "OK";
            reset.UseVisualStyleBackColor = false;
            Controls.Add(reset);
            reset.Click += Reset_Click;

            //button reset
            Button oke = new Button();
            oke.Location = new Point(390, 350);
            oke.Size = new Size(150, 24);
            oke.BackColor = Color.LightSlateGray;
            oke.TabIndex = 5;
            oke.Text = "Reset";
            oke.UseVisualStyleBackColor = false;
            Controls.Add(oke);
            oke.Click += Oke_Click;

            // film jam 11.00
            Button jam1 = new Button();
            jam1.Location = new Point(230, 100);
            jam1.Name = "Avenger Age of Ultron";
            jam1.Size = new Size(100, 55);
            jam1.TabIndex = 2;
            jam1.Text = "11.00";
            jam1.UseVisualStyleBackColor = false;
            Controls.Add(jam1);
            jam1.Click += Jam1_Click;

            //film  jam 13.00
            Button jam2 = new Button();
            jam2.Location = new Point(230, 160);
            jam2.Name = "Avenger Age of Ultron";
            jam2.Size = new Size(100, 55);
            jam2.TabIndex = 3;
            jam2.Text = "13.00";
            jam2.UseVisualStyleBackColor = false;
            Controls.Add(jam2);
            jam2.Click += Jam2_Click;

            //film  jam 15.00
            Button jam3 = new Button();
            jam3.Location = new Point(230, 220);
            jam3.Name = "Avenger Age of Ultron";
            jam3.Size = new Size(100, 55);
            jam3.TabIndex = 4;
            jam3.Text = "15.00";
            jam3.UseVisualStyleBackColor = false;
            Controls.Add(jam3);
            jam3.Click += Jam3_Click;

            //button kembali
            Button back = new Button();
            back.Location = new Point(30, 370);
            back.Size = new Size(150, 24);
            back.BackColor = Color.LightSlateGray;
            back.TabIndex = 5;
            back.Text = "<- Go to Choose Movie";
            back.UseVisualStyleBackColor = false;
            Controls.Add(back);
            back.Click += Back_Click;


            //panel milih kursi
            ageofultron.Location = new Point(340, 25);
            ageofultron.Name = "panel1";
            ageofultron.Size = new Size(280, 300);
            ageofultron.TabIndex = 0;
            ageofultron.BackColor = Color.BurlyWood;
            Controls.Add(ageofultron);

            //jam 15.00
            ageofultron.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10; a++)
                {
                    Button button3 = new Button();
                    button3.Tag = "(" + a.ToString() + "," + i.ToString() + ") ";
                    button3.Size = new Size(27, 27);
                    button3.Location = new Point(4 + b, 8 + c);
                    button3.BackColor = Color.MediumSeaGreen;
                    button3.Click += Button3_Click;
                    buttonlistjam3.Add(button3);
                    nambah++;
                    b += 27;
                }
                b = 0;
                c += 27;
            }

            //random seat jam 15.00
            for (int i = 0; i < 70; i++)
            {
                int acak = seat.Next(0, 100);
                buttonlistjam3[acak].BackColor = Color.Red;
                buttonlistjam3[acak].Enabled = false;
            }

            //jam 13.00
            b = 0;
            c = 0;
            ageofultron.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10; a++)
                {
                    Button button2 = new Button();
                    button2.Tag = "(" + a.ToString() + "," + i.ToString() + ") ";
                    button2.Size = new Size(27, 27);
                    button2.Location = new Point(4 + b, 8 + c);
                    button2.BackColor = Color.MediumSeaGreen;
                    button2.Click += Button2_Click;
                    buttonlistjam2.Add(button2);
                    nambah++;
                    b += 27;
                }
                b = 0;
                c += 27;
            }

            //random seat jam 13.00
            for (int i = 0; i < 70; i++)
            {
                int acak = seat.Next(0, 100);
                buttonlistjam2[acak].BackColor = Color.Red;
                buttonlistjam2[acak].Enabled = false;
            }

            //jam 11.00
            b = 0;
            c = 0;
            ageofultron.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                for (int a = 0; a < 10; a++)
                {
                    Button button1 = new Button();
                    button1.Tag = "(" + a.ToString() + "," + i.ToString() + ") ";
                    button1.Size = new Size(27, 27);
                    button1.Location = new Point(4 + b, 8 + c);
                    button1.BackColor = Color.MediumSeaGreen;
                    button1.Click += Button1_Click;
                    buttonlistjam1.Add(button1);
                    nambah++;
                    b += 27;
                }
                b = 0;
                c += 27;
            }

            //random seat jam 11.00
            for (int i = 0; i < 70; i++)
            {
                int acak = seat.Next(0, 100);
                buttonlistjam1[acak].BackColor = Color.Red;
                buttonlistjam1[acak].Enabled = false;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ageofultron.Controls.Clear();

            foreach (Button seat in buttonlistjam1)
            {
                ageofultron.Controls.Add(seat);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.MediumSeaGreen)
            {
                button.BackColor = Color.YellowGreen;
                gatau.Text += button.Tag.ToString();
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ageofultron.Controls.Clear();

            foreach (Button seat in buttonlistjam2)
            {
                ageofultron.Controls.Add(seat);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.MediumSeaGreen)
            {
                button.BackColor = Color.YellowGreen;
                gatau.Text += button.Tag.ToString();
            }
        }

        public void Button3_Click(object sender, EventArgs e)
        {
            ageofultron.Controls.Clear();

            foreach (Button seat in buttonlistjam3)
            {
                ageofultron.Controls.Add(seat);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.MediumSeaGreen)
            {
                button.BackColor = Color.YellowGreen;
                gatau.Text += button.Tag.ToString();
            }
        }

        private void Oke_Click(object sender, EventArgs e)
        {
            if (nyoba == 1)
            {
                foreach (Button button in buttonlistjam1)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.MediumSeaGreen;

                    }
                    if (button.BackColor == Color.Red)
                    {

                        button.BackColor = Color.MediumSeaGreen;
                        button.Enabled = true;
                        gatau.Text = "Seat Choose : ";
                    }
                }
            }

            if (nyoba == 2)
            {
                foreach (Button button in buttonlistjam2)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.MediumSeaGreen;

                    }
                    if (button.BackColor == Color.Red)
                    {

                        button.BackColor = Color.MediumSeaGreen;
                        button.Enabled = true;
                        gatau.Text = "Seat Choose : ";
                    }
                }
            }

            if (nyoba == 3)
            {
                foreach (Button button in buttonlistjam3)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.MediumSeaGreen;

                    }
                    if (button.BackColor == Color.Red)
                    {

                        button.BackColor = Color.MediumSeaGreen;
                        button.Enabled = true;
                        gatau.Text = "Seat Choose : ";
                    }
                }
            }

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            if (milih == 1)
            {
                foreach (Button button in buttonlistjam1)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                    else
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.MediumSeaGreen;
                    }
                }
            }
            if (milih == 2)
            {
                foreach (Button button in buttonlistjam2)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                }
            }
            if (milih == 3)
            {
                foreach (Button button in buttonlistjam3)
                {
                    if (button.BackColor == Color.YellowGreen)
                    {
                        button.BackColor = Color.Red;
                        button.Enabled = false;
                    }
                }
            }
        }

        private void Gatau_Click(object sender, EventArgs e)
        {
           
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Jam3_Click(object sender, EventArgs e)
        {
            ageofultron.Controls.Clear();
            milih = 3;
            nyoba = 3;
            foreach (Button seat in buttonlistjam3)
            {
                ageofultron.Controls.Add(seat);
                gatau.Text = "Seat Choose : ";
            }
        }

        private void Jam2_Click(object sender, EventArgs e)
        {
            ageofultron.Controls.Clear();
            milih = 2;
            nyoba = 2;
            foreach (Button seat in buttonlistjam2)
            {
                ageofultron.Controls.Add(seat);
                gatau.Text = "Seat Choose : ";
            }
        }

        private void Jam1_Click(object sender, EventArgs e)
        {
            ageofultron.Controls.Clear();
            milih = 1;
            nyoba = 1;
            foreach (Button seat in buttonlistjam1)
            {
                ageofultron.Controls.Add(seat);
                gatau.Text = "Seat Choose : ";
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Movie1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
