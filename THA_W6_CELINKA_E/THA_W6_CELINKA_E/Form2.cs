using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W6_CELINKA_E
{
    public partial class Form2 : Form
    {
        Form1 form = new Form1();
        List<Button> buttonlist = new List<Button>();
        List<Button> buttonlist2 = new List<Button>();
        List<string> huruf = new List<string>() { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M" };
        string[] list = File.ReadAllText("Wordle Word List.txt").Split(',');
        List<string> kata = new List<string>();
        string isi = "";
        List<char> katadobel = new List<char>();
        string jawaban;
        int b = 0;
        int c = 0;
        int nambah = 0;
        int plus = 10;
        int baru = 0;
        int yaa = 4;
        int capek = 4;
        int yaya = 0;
        int cek = 0;
        int neww = 0;
        int baruu = 5;
        int lain = 0;
        string word = "";
        int count = 0;
        int dahla = 0;
        bool Isvalid = false;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Form1.input; i++)
            {
                for (int a = 0; a < 5; a++)
                {
                    Button button = new Button();
                    button.Tag = "tombol" + nambah;
                    button.Size = new Size(50, 50);
                    button.Location = new Point(20 + b, 40 + c);
                    buttonlist.Add(button);
                    nambah++;
                    b += 50;
                }
                b = 0;
                c += 60;
            }
            foreach (Button button in buttonlist)
            {
                this.Controls.Add(button);
            }

            nambah = 0;
            b = 0;
            c = 0;
            for (int i = 0; i < 3; i++)
            {
                if (i == 2)
                {
                    plus -= 1;
                    b += 40;
                }
                for (int a = 0; a < plus; a++)
                {
                    Button angka = new Button();
                    angka.Tag = huruf[nambah];
                    angka.Text = huruf[nambah];
                    angka.Size = new Size(45, 45);
                    angka.Location = new Point(300 + b, 100 + c);
                    buttonlist2.Add(angka);
                    nambah++;
                    b += 45;
                }
                b = 0;
                b += 25;
                c += 45;
                plus--;
            }
            foreach (Button angka in buttonlist2)
            {
                this.Controls.Add(angka);
                angka.Click += Angka_Click;
            }

            string tebak = list[new Random().Next(0, list.Length)].ToUpper();
            MessageBox.Show(tebak);
            isi = tebak;
        }

        private void Angka_Click(object sender, EventArgs e)
        {
            if (buttonlist[yaa].Text == "")
            {
                Button huruf = sender as Button;
                foreach (Button angka in buttonlist2)
                {
                    if (huruf.Tag == angka.Tag)
                    {
                        buttonlist[baru].Text = angka.Text;
                    }
                }
                baru++;
            }
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            yaa += 5;
            for (int z = 0; z < list.Length; z++)
            {
                if (word == list[z].ToUpper())
                {
                    count = 1;
                }
            }
            for (int q = dahla; q < dahla + 5; q++)
            {
                Button nyoba = buttonlist[q];
                if (nyoba.Text == "" || nyoba.Text == " ")
                {
                    lain = 1;
                }
                else
                {
                    word += nyoba.Text;
                }
            }

            if (lain == 1)
            {
                MessageBox.Show("Please enter 5 letter word!");
                word = "";
                lain = 0;
            }
            else if (count == 0)
            {
                MessageBox.Show(word + " is not found");
                word = "";
            }
            else
            {
                foreach (var w in isi)
                {
                    int charCount = 0;
                    foreach (var chars in isi)
                    {
                        if (w == chars)
                        {
                            charCount++;
                        }
                        if (charCount > 1 && !katadobel.Contains(w))
                        {
                            katadobel.Add(w);
                        }
                    }
                }

                for (int a = 0; a < 5; a++)
                {
                    kata.Add(isi[a].ToString().ToUpper());
                }
                yaya = 0;
                for (int z = lain; z <= capek; z++)
                {
                    if (buttonlist[z].Text == isi[yaya].ToString().ToUpper())
                    {
                        buttonlist[z].BackColor = Color.LightGreen;
                        kata[yaya] = "";
                        cek++;
                    }
                    yaya++;

                }

                for (int y = neww; y < baruu; y++)
                {
                    foreach (string kataa in kata)
                    {
                        if (buttonlist[y].Text == kataa)
                        {
                            buttonlist[y].BackColor = Color.Yellow;
                        }
                    }
                }
                neww += 5;
                baruu += 5;
                if (word == isi)
                {
                    MessageBox.Show("Horee!");
                    this.Close();
                }
                else if (dahla == 5* Form1.input-5 )
                {
                    MessageBox.Show("Sadd!, Answer is" + isi);
                    this.Close();
                }
                //if (word != "")
                //{
                //    dahla += 5;
                    
                //}              
            }

            //for (int q = count; q < 5; q++)
            //{

            //    ab += buttonlist[q].Text;
            //    count++;
            //}
            //count += 5;

            //foreach (string angka in list)
            //{
            //    if (angka == ab)
            //    {
            //        if (buttonlist[dahla].Text ==angka)
            //        {
            //            MessageBox.Show("Fill !!");
            //        }

            //        Isvalid = true;
            //    }
            //    Isvalid = true;
            //}

            //if (Isvalid == true)
            //{
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (buttonlist[0].Text != "")
            {
                buttonlist[baru - 1].Text = "";
                baru--;
            }
        }
    }
}
    
