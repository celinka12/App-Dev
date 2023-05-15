using Microsoft.SqlServer.Server;
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

namespace THA_W8_CELINKA_E
{
    public partial class Form3 : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter SQLAdapter;
        MySqlDataReader sqlDataReader;
        DataTable dt = new DataTable();
        public Form3()
        {
            try
            {
                string connection = "server=localhost;uid=root;pwd=;database=premier_league;";
                sqlConnect = new MySqlConnection(connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            InitializeComponent();
            dataGridView1.DataSource = dt;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
        }

        private void updateDGV1()
        {
            dt.Clear();
            try
            {
                string command = "select*from nationality";
                sqlCommand = new MySqlCommand(command, sqlConnect);
                SQLAdapter = new MySqlDataAdapter(sqlCommand);
                SQLAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExecuteSQL(string command)
        {
            try
            {
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(command, sqlConnect);
                sqlDataReader = sqlCommand.ExecuteReader();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlConnect.Close();
                updateDGV1();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string nation = textBox2.Text;
            string abv = textBox3.Text;
            string command = $"insert into nationality values ('{id}' ,'{abv}', '{nation}', 0";
          ExecuteSQL(command);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            updateDGV1();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox4.Text = id;
            textBox5.Text = id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("ID Textbox must not be empty");
            }
            else
            {
                string id = textBox4.Text;
                string command = $"delete from nationality where nationality_id = '{id}'";
                ExecuteSQL(command);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = textBox5.Text;
            string nation = textBox6.Text;
            string abv = textBox7.Text;
            string command = $"update nationality set `abv` = '{abv}', `nation` = '{nation}' where` nationality_id` = '{id}'";
            ExecuteSQL(command);
        }
    }
}
