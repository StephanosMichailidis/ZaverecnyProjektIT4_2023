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

namespace StephanosMichailidisProjekt
{
    public partial class zakazky : Form
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProjektDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public zakazky()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string zakaznik = txtZakaznik.Text;
            int cas;
            if (!int.TryParse(txtCas.Text, out cas))
            {
                MessageBox.Show("Zadejte spravne cas");
                return;
            }
            string Id = txtID.Text;
            string jmeno = txtZamestanec.Text;
            string typPrace = txtPrace.Text;
            int ID;
            try
            {
                ID = Convert.ToInt32(Id);
            }
            catch (FormatException)
            {
                MessageBox.Show("Spatna Hodnota ID");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("Insert INTO Records(ID, Customer, Hours, WorkType, Username, DateAdded) VALUES (@ID, @Customer, @Hours, @WorkType, @Username, @DateAdded )", connection);
                command.Parameters.AddWithValue("@ID", Id);
                command.Parameters.AddWithValue("@Customer", zakaznik);
                command.Parameters.AddWithValue("@Hours", cas);
                command.Parameters.AddWithValue("@WorkType", typPrace);
                command.Parameters.AddWithValue("@Username", jmeno);
                command.Parameters.AddWithValue("DateAdded", DateTime.Now.Date);
                int rowsAffected = command.ExecuteNonQuery();

            }
        }

        private void zakazky_Load(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Records WHERE ID=@ID", connection))
                {
                    command.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = int.Parse(txtID.Text);
                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string zakaznik = txtZakaznik.Text;
            int cas;
            if (!int.TryParse(txtCas.Text, out cas))
            {
                MessageBox.Show("Zadej spravne cas");
                return;
            }
            string Id = txtID.Text;
            string jmeno = txtZamestanec.Text;
            string typPrace = txtPrace.Text;
            int ID;
            try
            {
                ID = Convert.ToInt32(Id);
            }
            catch (FormatException)
            {
                MessageBox.Show("Spatna hodnota ID");
                return;
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("UPDATE Records set Customer = @Customer, Hours =@Hours, WorkType=@WorkType, Username=@Username WHERE ID=@ID", connection);
                command.Parameters.AddWithValue("@ID", Id);
                command.Parameters.AddWithValue("@Customer", zakaznik);
                command.Parameters.AddWithValue("@Hours", cas);
                command.Parameters.AddWithValue("@WorkType", typPrace);
                command.Parameters.AddWithValue("@Username", jmeno);
                command.Parameters.AddWithValue("DateAdded", DateTime.Now.Date);
                int rowsAffected = command.ExecuteNonQuery();
            }
        }

        private void btnFiltr_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("Select * From Records WHERE ID=@ID", connection))
                {
                    command.Parameters.AddWithValue("@ID", SqlDbType.Int).Value = int.Parse(txtID.Text);
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dtable = new DataTable();
                    da.Fill(dtable);
                    dataGridView1.DataSource = dtable;
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("Select * From Records", connection))
                {
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dtable = new DataTable();
                    da.Fill(dtable);
                    dataGridView1.DataSource = dtable;
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.FormClosed += (s, args) => this.Close();
            adminMenu.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }
    }
}
