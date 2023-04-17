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
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand; // menerima perintah query // select*form itu
        MySqlDataAdapter SQLAdapter;
        string connectionString;
        string sqlQuery;
        DataTable dtPemain = new DataTable();
        DataTable dtCountry = new DataTable();
        DataTable dtmanager = new DataTable(); 
        DataTable dtmatch = new DataTable();    

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "server=localhost;uid=root;pwd=;database=premier_league;";
            sqlConnect = new MySqlConnection(connectionString);
            sqlConnect.Open();

            sqlQuery = "SELECT team_name, team_id from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(dtPemain);
            cb_data.ValueMember = "Team_name";
            cb_data.DisplayMember = "Team_id";
            cb_data.DataSource = dtPemain;
        }

        private void cb_data_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dgv_match.Visible = false;
            dtCountry.Clear();  
            string save = cb_data.SelectedValue.ToString();
            sqlQuery = $"select player_name, team_name, weight, height from player inner join team on player.team_id = team.team_id where team_name ='{save}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(dtCountry);
            dgv_data.DataSource = dtCountry;


            dtmanager.Clear();
            sqlQuery = $"select team_name, manager_name, birthdate, nation from manager inner join team on manager.manager_id = team.manager_id inner join nationality on manager.nationality_id = nationality.nationality_id where team_name = '{save}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(dtmanager);
            dgv_match.DataSource = dtmanager;
        }

        private void findMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // dgv_match.Visible = false;
            dtmatch.Clear();
            string savee = cb_data.SelectedValue.ToString();
            sqlQuery = $"select team_name, manager_name, birthdate, nation from manager inner join team on manager.manager_id = team.manager_id inner join nationality on manager.nationality_id = nationality.nationality_id where team_name = '{savee}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(dtmatch);
            dgv_match.DataSource = dtmatch;
        }

        private void teamDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
