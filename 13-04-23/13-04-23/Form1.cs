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

namespace _13_04_23
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string connectionString;
        string sqlQuery;

        DataTable dtPemain = new DataTable();
        DataTable dtNationality = new DataTable();
        DataTable dtTim = new DataTable();
        DataTable dtNamaPemain = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connectionString = "server=localhost;uid=root;pwd=;database=premier_league";
            sqlConnect = new MySqlConnection(connectionString);
            sqlConnect.Open(); // hanya digunakan ketika kalian dml

            sqlQuery = "SELECT player_id as 'Player ID', player_name as 'Player Name',height as 'Player Height', team_name as 'Team Name' FROM player  INNER JOIN team ON player.team_id = team.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPemain);
            DGVPemain.DataSource = dtPemain;
            

            sqlQuery = "SELECT abv as 'Abrevation', nation as 'Nation' FROM nationality";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNationality);
            cmbNation.DataSource = dtNationality;
            cmbNation.ValueMember = "Abrevation";
            cmbNation.DisplayMember = "Nation";

            sqlQuery = "SELECT team_name as 'Team Name', team_id as 'Team ID' FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTim);
            cmbTeam.DataSource = dtTim;
            cmbTeam.ValueMember = "Team ID";
            cmbTeam.DisplayMember = "Team Name";

        }

        private void cmbNation_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = cmbNation.SelectedValue.ToString();
        }

        private void cmbTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtNamaPemain.Clear();
            DGVPemain.DataSource = null;
            sqlQuery = $"SELECT player_id as 'Player ID', player_name as 'Player Name',height as 'Player Height', team_name as 'Team Name' FROM player INNER JOIN team ON player.team_id = team.team_id WHERE player.team_id = '{cmbTeam.SelectedValue.ToString()}'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNamaPemain);
            DGVPemain.DataSource = dtNamaPemain;

        }
    }
}
