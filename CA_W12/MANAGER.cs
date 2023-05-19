using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;
using Org.BouncyCastle.Utilities.Collections;
using Microsoft.SqlServer.Server;
using System.Xml;

namespace CA_W12
{
    public partial class MANAGER : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter SQLAdapter;
        MySqlDataReader DataReader;

        DataTable manager1 = new DataTable();
        DataTable manager2 = new DataTable();
        DataTable team = new DataTable();
        string sqlQuery;

        public MANAGER()
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=premier_league;";
            sqlConnect = new MySqlConnection(connectionString);
            InitializeComponent();
            dgv_manager1.DataSource = manager1;
            dgv_manager2.DataSource = manager2;
        }

        private void MANAGER_Load(object sender, EventArgs e)
        {
            sqlQuery = "select team_name 'Team Name', team_id from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(team);
            cb_ManagerTeam.DataSource = team;
            cb_ManagerTeam.DisplayMember = "Team Name";
            cb_ManagerTeam.ValueMember = "team_id";
        }

        private void cb_ManagerTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            team = new DataTable();
            UpdateManager();
        }

        private void UpdateManager()
        {
            manager1 = new DataTable();
            sqlQuery = $"select m.manager_id, m.manager_name, n.nation, m.birthdate from manager m, team t, nationality n where m.manager_id = t.manager_id  and m.nationality_id = n.nationality_id and t.team_id = '{cb_ManagerTeam.SelectedValue}';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(manager1);
            dgv_manager1.DataSource = manager1;

            manager2 = new DataTable();
            sqlQuery = $"select m.manager_id, m.manager_name, n.nation, m.birthdate from manager m, nationality n where m.nationality_id = n.nationality_id and m.working = 0;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(manager2);
            dgv_manager2.DataSource = manager2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv_manager1.CurrentCell != null)
            {
                string manager2 = dgv_manager2.CurrentRow.Cells[0].Value.ToString();
                string Comdd = $"update team set manager_id = '" + manager2 + "' where team_id = '" + cb_ManagerTeam.SelectedValue + "';";
                try
                {
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(Comdd, sqlConnect);
                    DataReader = sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnect.Close();
                }

                string manager1 = dgv_manager1.CurrentRow.Cells[0].Value.ToString();
                string Comd = $"update manager set working = 0 where manager_id = '" + manager1 + "';";
                try
                {
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(Comd, sqlConnect);
                    DataReader = sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnect.Close();
                }



                string Comddd = $"update manager set working = 1 where manager_id =  '" + manager2 + "'; ";
                try
                {
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(Comddd, sqlConnect);
                    DataReader = sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlConnect.Close();
                    UpdateManager();
                }
            }
            else
            {
                MessageBox.Show("Please select Manager!");
            }

        }
    }
}

