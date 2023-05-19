using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CA_W12
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter SQLAdapter;
        MySqlDataReader DataReader;
       
        string sqlQuery;

        DataTable player = new DataTable();
        DataTable team = new DataTable();  
        DataTable nationality = new DataTable();
        public Form1()
        {
            
            string connectionString = "server=localhost;uid=root;pwd=;database=premier_league; Convert Zero Datetime=True";
            sqlConnect = new MySqlConnection(connectionString);
            InitializeComponent();
            dgv_tampil.DataSource = player;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Update();
            sqlQuery = "select nation, nationality_id from nationality;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(nationality);
            cb_Nation.DataSource =nationality;
            cb_Nation.ValueMember = "nationality_id";
            cb_Nation.DisplayMember = "nation";

            sqlQuery = "select team_name 'Team Name', team_id from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            SQLAdapter = new MySqlDataAdapter(sqlCommand);
            SQLAdapter.Fill(team);
            cb_TeamName.DataSource = team;
            cb_TeamName.DisplayMember = "Team Name";
            cb_TeamName.ValueMember = "team_id";

        }

        private void btn_AddPlayer_Click(object sender, EventArgs e)
        {
            string id = tb_PlayerID.Text;
            string pName = tb_name.Text;
            string tNumb = tb_teamNumb.Text;
            string weight = tb_Weight.Text;
            string height = tb_Height.Text;
            string nation = cb_Nation.SelectedValue.ToString();
            string playerPos = tb_Position.Text;
            string teamName = cb_TeamName.SelectedValue.ToString();
            string Birth = dateTimePicker1.Value.Date.ToString("yyyyMMdd");
            
            string comd = $"insert into player values ('{id}','{tNumb}','{pName}','{nation}', '{playerPos}', '{height}', '{weight}', '{Birth}', '{teamName}', 1, 0);";

            try
            {
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(comd, sqlConnect);
                DataReader = sqlCommand.ExecuteReader();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                sqlConnect.Close();
                Update();
            }

            tb_PlayerID.Clear();
            tb_name.Clear();
            tb_teamNumb.Clear();
            tb_Weight.Clear();
            tb_Height.Clear();
            tb_Position.Clear();
        }

        private void Update()
        {
            player.Clear();
            try
            {
                string comb2 = "select * from player;";
                sqlCommand = new MySqlCommand(comb2, sqlConnect);
                SQLAdapter = new MySqlDataAdapter(sqlCommand);
                SQLAdapter.Fill(player);
                
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void eDITMANAGERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MANAGER manager = new MANAGER();
            manager.ShowDialog();
        }

        private void eDITPLAYERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player player = new player();
            player.ShowDialog();
        }
    }
}
