using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;
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
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace THA_W8_CELINKA_E
{
    public partial class Form2 : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter SQLAdapter;
        string connectionString = "server=localhost;uid=root;pwd=;database=premier_league;";
        string sqlQuery;

        DataTable dataMatch = new DataTable();
        DataTable dataPlayer = new DataTable();
        DataTable Home = new DataTable();
        DataTable data = new DataTable();
        DataTable tim = new DataTable();
        DataTable help = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            sqlQuery = $"select team_id as 'ID', team_name as 'Team' from team;";
            sqlConnect = new MySqlConnection(connectionString);
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(data);
            cb_team.DataSource = data;
            cb_team.ValueMember = "ID";
            cb_team.DisplayMember = "Team";
        }

        private void cb_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            tim = new DataTable();
            sqlQuery = "select p.player_name as 'player name', t.team_name as 'Team name' from player p, team t where p.team_id = t.team_id and t.team_id = '" + cb_team.ToString() + "';";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(tim);

            dataMatch.Clear();
            dataMatch.Columns.Clear();

            dataMatch = new DataTable();
            sqlQuery = $"select match_id, t1.team_name as 'Team Home', t2.team_name as 'Team Away', t1.team_id, t2.team_id\r\nfrom `match`, team t1, team t2 where `match`.team_home = t1.team_id and `match`.team_away=t2.team_id\r\nand (t1.team_id = '{cb_team.SelectedValue.ToString()}' or t2.team_id = '{cb_team.SelectedValue.ToString()}');";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(dataMatch);

            cb_match.Items.Clear();

            for (int a = 0; a < dataMatch.Rows.Count; a++)
            {
                string capek = dataMatch.Rows[a][1].ToString();
                string away = dataMatch.Rows[a][2].ToString();
                string gabung = capek + " vs " + away;
                cb_match.Items.Add(gabung);
            }
        }

        private void cb_match_SelectedIndexChanged(object sender, EventArgs e)
        {

            Home = new DataTable();
            sqlQuery = $"select t.team_name as 'nama team', p.player_name as 'Player Name' , p.team_number as 'Player Number' from player p, team t where t.team_id = p.team_id and t.team_id = '{dataMatch.Rows[cb_match.SelectedIndex][3]}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(Home);

            dataPlayer = new DataTable();
            sqlQuery = $"select t.team_name as 'nama team', p.player_name as 'Player Name' , p.team_number as 'Player Number' from player p, team t where t.team_id = p.team_id and t.team_id = '{dataMatch.Rows[cb_match.SelectedIndex][4]}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(dataPlayer);

            dgv_team.DataSource = Home;
            dataGridView1.DataSource = dataPlayer;

            help = new DataTable();
            sqlQuery = $"select d.`minute` as 'Minute',t.team_name as 'Team Name', p.player_name as 'Player Name', if(d.`type`='go','Goal',if(d.`type`='gw','Own Goal',if(d.`type`='gp','Penalty Goal',if(d.`type`='pm','Penalty Missed',if(d.`type`='cy','Yellow Card','Red Card'))))) as 'Type' from dmatch d, player p, team t where t.team_id = d.team_id and d.player_id = p.player_id and d.match_id = '{dataMatch.Rows[cb_match.SelectedIndex][0]}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(help);

            dgv_match.DataSource = help;
          
        }
    }
}

