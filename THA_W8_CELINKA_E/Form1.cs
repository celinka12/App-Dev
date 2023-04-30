using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;

namespace THA_W8_CELINKA_E
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter SQLAdapter;
        string connectionString;
        string sqlQuery;

        DataTable dataPlayer = new DataTable();
        DataTable dataMatch = new DataTable();
        DataTable dataCountry = new DataTable();
        DataTable dataKartu = new DataTable();


      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "server=localhost;uid=root;pwd=;database=premier_league;";
            sqlConnect = new MySqlConnection(connectionString);
            sqlConnect.Open();
            panel1.Visible = false;
        }

        private void Kartu()
        {
            int yellow = 0;
            int red = 0;
            int goal = 0;
            int penalti = 0;
            //int goalpenalti = 0;
            //int goalown = 0;
            dataKartu = new DataTable();
            string save = cb_chooseplayer.GetItemText(cb_chooseplayer.SelectedItem).ToString();
            sqlQuery = $"select `type` as 'Cards' from dmatch d, player p where d.player_id = p.player_id and p.player_name = '{save}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(dataKartu);
            for (int i = 0; i < dataKartu.Rows.Count; i++)
            {
                if (dataKartu.Rows[i][0].ToString() == "CY")
                {
                    yellow++;
                }
                if (dataKartu.Rows[i][0].ToString() == "CR")
                {
                    red++;
                }
                if (dataKartu.Rows[i][0].ToString() == "GO")
                {
                    goal++;
                }
                //if (dataKartu.Rows[i][0].ToString() == "GW")
                //{
                //    goalown++;
                //}
                if (dataKartu.Rows[i][0].ToString() == "PM")
                {
                    penalti++;
                }
                //if (dataKartu.Rows[i][0].ToString() == "GP")
                //{
                //    goalpenalti++;
                //}
            }
            label_Yellow.Text = yellow.ToString();
            label_Red.Text = red.ToString();
            label_Goal.Text = goal.ToString();
            label_Penalty.Text = penalti.ToString();
            //label_Gw.Text = goalown.ToString();
            //label_gp.Text = goalpenalti.ToString();
        }

        private void cb_pilihteam_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataMatch = new DataTable();
            sqlQuery = $"select player_name as 'nama player' from player p where p.team_id = '{cb_chooseteam.SelectedValue.ToString()}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(dataMatch);
            cb_chooseplayer.DataSource = dataMatch;
            cb_chooseplayer.DisplayMember = "nama player";
        }


        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlQuery = "select team_name as 'nama team',team_id as 'id team' from team ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(dataPlayer);
            cb_chooseteam.DataSource = dataPlayer;
            cb_chooseteam.DisplayMember = "nama team";
            cb_chooseteam.ValueMember = "id team";
            panel1.Visible = true;
            panel2.Visible = false;
        }

        private void cb_chooseplayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataCountry = new DataTable();
            string save = cb_chooseplayer.GetItemText(cb_chooseplayer.SelectedItem).ToString();
            string saveteam = cb_chooseteam.GetItemText(cb_chooseteam.SelectedItem).ToString();
            sqlQuery = $"select player_name as 'nama player', team_name as 'nama team', nation as 'nationality',playing_pos as 'playing pos',team_number as 'squad number' from player p,nationality n,dmatch d,team t where player_name = '{save}' and team_name = '{saveteam}' and p.nationality_id = n.nationality_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(dataCountry);
            label_Name.Text = dataCountry.Rows[0][0].ToString();
            label_Team.Text = dataCountry.Rows[0][1].ToString();
            label_Position.Text = dataCountry.Rows[0][2].ToString();
            label_nation.Text = dataCountry.Rows[0][3].ToString();
            label_PlayingPos.Text = dataCountry.Rows[0][4].ToString();
            Kartu();
        }
        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void showMatchDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            Form2 form2 = new Form2();
            form2.TopLevel = false;
            panel2.Controls.Add(form2);
            form2.Show();
        }
    }
}


