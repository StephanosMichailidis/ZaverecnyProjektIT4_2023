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
    public partial class editUzivatel : Form
    {
        private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProjektDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection connection;
        public editUzivatel()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
        }
        private void ExecuteNonQuery(SqlCommand command)
        {
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }

        }
        private DataTable ExecuteQuery(SqlCommand command)
        {
            DataTable dataTable = new DataTable();
            try
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { connection.Close(); }
            return dataTable;

        }


        private void chkAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.FormClosed += (s, args) => this.Close();
            adminMenu.Show();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Users", connection);
            dataGridView1.DataSource = ExecuteQuery(command);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Users SET Name=@Name, Password=@Password, Role=@Role WHERE ID=@ID", connection))
                {
                    command.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
                    command.Parameters.AddWithValue("@Name", txtJmeno.Text);
                    command.Parameters.AddWithValue("@Password", txtHeslo.Text);
                    command.Parameters.AddWithValue("@Role", chkAdmin.Checked ? "Admin" : "User");
                    ExecuteNonQuery(command);

                }
            }
        }

        private void btnFiltr_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE ID=@ID", connection))
                {
                    command.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
                    dataGridView1.DataSource = ExecuteQuery(command);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("DELETE FROM Users WHERE ID=@ID", connection))
                {
                    command.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
                    ExecuteNonQuery(command);

                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Users(ID, Name, Password, Role) VALUES (@ID, @Name, @Password, @Role)", connection))
                {
                    command.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
                    command.Parameters.AddWithValue("@Name", txtJmeno.Text);
                    command.Parameters.AddWithValue("@Password", txtHeslo.Text);
                    command.Parameters.AddWithValue("@Role", chkAdmin.Checked ? "Admin" : "User");
                    ExecuteNonQuery(command);

                }
            }
            connection.Close();
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
