using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_W4_CELINKA_E
{
    public partial class Form1 : Form
    {
        List<Team> teamm = new List<Team>();
        int count = 0;
        string pilihplayer = "";
        public Form1()
        {

            InitializeComponent();
            MU();
            Chealsea();
            Spanyol();
            updateCountry();

        }
        private void MU()
        {
            string[] playername = { "David de Gea", "Victor Lindelöf", "Phil Jones", "Harry Maguire", "Lisandro Martínez", " Bruno Fernandes", "Anthony Martial", "Marcus Rashford", " Mason Greenwood", " Diogo Dalot", "Raphaël Varane" };
            string[] playernumber = { "1", "2", "4", "5", "6", "8", "9", "10", "11", "20", "19" };
            string[] playerposition = { "GK", "DF", "DF", "DF", "DF", "MF", "FW", "FW", "FW", "DF", "DF" };
            Team mu2 = new Team();
            mu2.teamcountry = "England";
            mu2.teamcity = "Manchester";
            mu2.teamname = "Manchester United";
            mu2.playerlist = new List<Player>();
            for (int a = 0; a < playername.Count(); a++)
            {
                Player pemain = new Player();
                pemain.playername = playername[a];
                pemain.playernumber = playernumber[a];
                pemain.playerposition = playerposition[a];
                mu2.playerlist.Add(pemain);
            }
            teamm.Add(mu2);
        }

        private void Chealsea()
        {
            string[] playername = { "Kepa Arrizabalaga", "Benoît Badiashile", "Enzo Fernández", "Thiago Silva", "N'Golo Kanté", " Mateo Kovačić", "P. Aubameyang", "Christian Pulisic", "João Félix ", "Ruben Loftus-Cheek", "Marcus Bettinelli" };
            string[] playernumber = { "1", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13" };
            string[] playerposition = { "GK", "DF", "MF", "DF", "DF", "MF", "FW", "MF", "FW", "MF", "GK" };
            Team mu2 = new Team();
            mu2.teamcountry = "England";
            mu2.teamcity = "Chealsea";
            mu2.teamname = "Chealsea";
            mu2.playerlist = new List<Player>();
            for (int a = 0; a < playername.Count(); a++)
            {
                Player pemain = new Player();
                pemain.playername = playername[a];
                pemain.playernumber = playernumber[a];
                pemain.playerposition = playerposition[a];
                mu2.playerlist.Add(pemain);
            }
            teamm.Add(mu2);

        }

        private void Spanyol()
        {
            string[] playername = { "Thibaut Courtois", "Dani Carvajal", "Éder Militão", "David Alaba", "Jesús Vallejo", "Nacho", " Eden Hazard", "Toni Kroos", "Karim Benzema", "Luka Modrić", "Marco Asensio" };
            string[] playernumber = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11" };
            string[] playerposition = { "GK", "DF", "MF", "DF", "DF", "MF", "FW", "MF", "FW", "DF", "FW" };
            Team mu2 = new Team();
            mu2.teamcountry = "Spanyol";
            mu2.teamcity = "Madrid";
            mu2.teamname = "Real Madrid";
            mu2.playerlist = new List<Player>();
            for (int a = 0; a < playername.Count(); a++)
            {
                Player pemain = new Player();
                pemain.playername = playername[a];
                pemain.playernumber = playernumber[a];
                pemain.playerposition = playerposition[a];
                mu2.playerlist.Add(pemain);
            }
            teamm.Add(mu2);

        }

        class Team
        {
            public List<Player> playerlist = new List<Player>();
            private string teamName;
            private string teamCountry;
            private string teamCity;

            public string teamname
            {
                get { return teamName; }
                set { teamName = value; }
            }
            public string teamcountry
            {
                get { return teamCountry; }
                set { teamCountry = value; }
            }
            public string teamcity
            {
                get { return teamCity; }
                set { teamCity = value; }
            }
            public void AddPlayer(Player a)
            {
                playerlist.Add(a);
            }
        }


        class Player
        {
            private string playerName;
            private string playerNumber;
            private string playerPosition;

            public string playername
            {
                get { return playerName; }
                set
                {
                    playerName = value;
                }
            }
            public string playernumber
            {
                get { return playerNumber; }
                set
                {
                    playerNumber = value;
                }
            }

            public string playerposition
            {
                get { return playerPosition; }
                set { playerPosition = value; }
            }
        }

        public void updateCountry()
        {
            comboBox_Country.Items.Clear();
            foreach (Team a in teamm)
            {
                count = 0;
                foreach (string b in comboBox_Country.Items)
                {
                    if (a.teamcountry == b)
                    {
                        count = 1;
                    }
                }
                if (count == 0)
                {
                    comboBox_Country.Items.Add(a.teamcountry);
                }
            }
        }

        public void updateTeam()
        {
            comboBox_Team.Items.Clear();
            foreach (Team team in teamm)
            {
                if (team.teamcountry == comboBox_Country.SelectedItem.ToString())
                {
                    comboBox_Team.Items.Add(team.teamname);
                }
            }
            listBox_isi.Sorted = true;
        }

        public void UpdatePlayer()
        {
            listBox_isi.Items.Clear();
            foreach (Team update in teamm)
            {
                if (update.teamname == comboBox_Team.SelectedItem.ToString())
                {
                    foreach (Player player in update.playerlist)
                    {
                        listBox_isi.Items.Add($"({player.playernumber}){player.playername},{player.playerposition}");
                    }
                }
            }
            listBox_isi.Sorted = true;
        }
        private void btn_Add_Team_Click(object sender, EventArgs e)
        {
            bool menyerah = false;
            foreach (Team tolong in teamm)
            {
                if (tolong.teamname == textBox_TName.Text)
                {
                    MessageBox.Show("Team already added");
                    menyerah = true;

                }
                if (textBox_TCity.Text == "" && textBox_TName.Text == "" && textBox_TCountry.Text == "")
                {
                    MessageBox.Show("All fields need to be field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    menyerah = true;
                }
            }
            if (menyerah == false)

            {
                comboBox_Team.Items.Clear();
                Team sedih = new Team();
                sedih.teamcountry = textBox_TCountry.Text;
                sedih.teamname = textBox_TName.Text;
                sedih.teamcity = textBox_TCity.Text;
                sedih.playerlist = new List<Player>();
                teamm.Add(sedih);
                updateCountry();
            }
            textBox_TName.Focus();
            textBox_TCity.Clear();
            textBox_TName.Clear();
            textBox_TCountry.Clear();
            textBox_TCity.Focus();
            textBox_TCountry.Focus();
            listBox_isi.Items.Clear();
        }


        private void btn_Add_Player_Click(object sender, EventArgs e)
        {
            count = 0;
            if (textBox_PName.Text == "" && textBox_PNumber.Text == "" && comboBox_Position.SelectedIndex == -1)
            {
                MessageBox.Show("All fields need to be field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox_Team.SelectedIndex == -1)
                {
                    MessageBox.Show("Choose Team");
                }
                else
                {
                    foreach (string nangis in listBox_isi.Items)
                    {
                        if (nangis == $"({textBox_PNumber.Text}) {textBox_PName.Text}, {comboBox_Position.SelectedItem.ToString()}")
                        {
                            count = 1;
                        }
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("Player already added");
                    }
                    else
                    {
                        foreach (Team team in teamm)
                        {
                            if (team.teamname == comboBox_Team.SelectedItem.ToString())
                            {

                                Player player = new Player();
                                player.playername = textBox_PName.Text;
                                player.playernumber = textBox_PNumber.Text;
                                player.playerposition = comboBox_Position.SelectedItem.ToString();
                                team.AddPlayer(player);
                            }
                        }
                    }
                    textBox_PName.Clear();
                    textBox_PNumber.Clear();
                    comboBox_Position.Text = null;
                    UpdatePlayer();
                }
            }
        }


        private void comboBox_Team_SelectedIndexChanged(object sender, EventArgs e)
        {

            UpdatePlayer();

        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
         
            if (listBox_isi.Items.Count < 11)
            {
                MessageBox.Show("Player is less than 11, can't be remove", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (Team teamm in teamm)
                {
                    if (teamm.teamname == comboBox_Team.Text)
                    {
                        foreach (Player play in teamm.playerlist)
                        {
                            if (listBox_isi.SelectedItem.ToString().Contains(play.playername))
                            {
                                teamm.playerlist.Remove(play);
                                UpdatePlayer();
                                break;

                            }
                        }
                    }
                }
            }
        }
                        
        private void comboBox_Country_SelectedIndexChanged(object sender, EventArgs e)
        {

            updateTeam();
            listBox_isi.Items.Clear();
        }
    }
}

