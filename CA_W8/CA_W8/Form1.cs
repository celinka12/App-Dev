using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CA_W8
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand; // menerima perintah query // select*form itu
        MySqlDataAdapter SQLAdapter; // menerima hasil dari querynya // hasil dari selectform 
        string connectionString;
        string sqlQuery; // cm buat nulis querynya
        DataTable dtPemain = new DataTable();
        DataTable dtNationality = new DataTable();
        DataTable dtCountry = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "server=localhost;uid=root;pwd=;database=premier_league;"; // pwd di isi pwd sndiri
            sqlConnect = new MySqlConnection(connectionString);
            sqlConnect.Open();  //hanya digunakan ketika kalian DML , insert,update,delete . jk tidak maka gausah karna program bisa jadi berat  . Pastikan sudh g crash pas sql open di pct

            //sqlQuery = "SELECT player_id as 'Player ID',\r\nPlayer_name as 'Player Name',\r\nheight  as 'Player Height'\r\nfrom player;";
            //sqlCommand = new MySqlCommand (sqlQuery, sqlConnect);
            //SQLAdapter = new MySqlDataAdapter(sqlCommand);
            //SQLAdapter.Fill(dtPemain);
            //dgv_Pemain.DataSource = dtPemain;
          

            //sqlQuery = "select abv as `Abrevation`, nation as `Nation` from nationality;";
            //sqlCommand = new MySqlCommand (sqlQuery, sqlConnect);
            //SQLAdapter = new MySqlDataAdapter( sqlCommand); 
            //SQLAdapter.Fill(dtNationality);
            //combo_NAtionality.DataSource = dtNationality;
            //combo_NAtionality.ValueMember = "Abrevation"; 
            //combo_NAtionality.DisplayMember = "Nation";

            sqlQuery = "SELECT team_name, team_id from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(dtPemain);
            combo_Country.DataSource = dtPemain;
            combo_Country.ValueMember = "Team_name";
            combo_Country.DisplayMember = "Team_name";
         

        }

        private void combo_NAtionality_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelValue.Text = combo_NAtionality.SelectedValue.ToString();
        }

        private void combo_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtCountry = new DataTable();
            dtCountry.Clear();
          //  string save = combo_Country.SelectedValue.ToString();
           // sqlQuery = $"select player_id, player_name, height, team_name from player inner join team on player.team_id = team.team_id where team_name ='{save}';";
            sqlQuery = "select player_id, player_name, height, team_name from player inner join team on player.team_id = team.team_id where team_name ='" + combo_Country.SelectedValue.ToString()+"';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(dtCountry);
          
            dgv_Pemain.DataSource = dtCountry;

        }
    }
}
