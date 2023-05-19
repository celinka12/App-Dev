using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace CA_W12
{
    public partial class player : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter SQLAdapter;
        MySqlDataReader DataReader;
        DataTable player1 = new DataTable();
        string sqlQuery;

        public player()
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=premier_league;Convert Zero Datetime=True;";
            sqlConnect = new MySqlConnection(connectionString);
            InitializeComponent();
            dgv_tampil.DataSource = player1;
        }

        private void player_Load(object sender, EventArgs e)
        {
            sqlQuery = "select team_name 'Team Name', team_id from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(player1);
            cb_Team.DataSource = player1;
            cb_Team.DisplayMember = "Team Name";
            cb_Team.ValueMember = "team_id";
        }

        private void DeletePlayer()
        {
            player1 = new DataTable();
            sqlQuery = "select p.player_id, p.team_number, p.player_name, n.nation, p.playing_pos, p.height, p.weight, p.birthdate, t.team_name FROM player p, nationality n, team t where p.nationality_id = n.nationality_id and t.team_id = p.team_id and p.team_id = '" + cb_Team.SelectedValue + "' and p.status = 1; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(player1);
            dgv_tampil.DataSource = player1;
        }

        private void cb_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            player1 = new DataTable();
            DeletePlayer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv_tampil.Rows.Count >= 12)
            {
                string player = dgv_tampil.CurrentRow.Cells[0].Value.ToString();
                string hore = $"update player set status = 0 where player_id = '{player}'";
                try
                {
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(hore, sqlConnect);
                    SQLAdapter = new MySqlDataAdapter(sqlCommand);
                    DataReader = sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnect.Close();
                    DeletePlayer();
                }
            }
            else
            {
                MessageBox.Show("Player harus > 11");
            }
        }
    }
}
