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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StephanosMichailidisProjekt
{
    public partial class Zaměstnanci : Form
    {
        private readonly string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProjektDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Zaměstnanci()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Employee (PersNum, FirstName, LastName, BirthDate, Email, PhoneNumber) VALUES (@PersNum, @FirstName, @LastName, @BirthDate, @Email, @PhoneNumber)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersNum", txtID.Text);
                    command.Parameters.AddWithValue("@FirstName", txtJmeno.Text);
                    command.Parameters.AddWithValue("@LastName", txtPrijmeni.Text);
                    command.Parameters.AddWithValue("@BirthDate", txtDateNar.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", txtTelCis.Text);
                        
                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();

                    if (result > 0)
                    {
                        MessageBox.Show("Employee added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error adding employee.");
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Employee WHERE PersNum=@PersNum";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersNum", txtID.Text);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();

                    if (result > 0)
                    {
                        MessageBox.Show("Employee removed successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error removing employee.");
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Employee SET FirstName=@FirstName, LastName=@LastName, BirthDate=@BirthDate, Email=@Email, PhoneNumber=@PhoneNumber WHERE PersNum=@PersNum";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersNum", txtID.Text);
                    command.Parameters.AddWithValue("@FirstName", txtJmeno.Text);
                    command.Parameters.AddWithValue("@LastName", txtPrijmeni.Text);
                    command.Parameters.AddWithValue("@BirthDate", txtDateNar.Text);
                    command.Parameters.AddWithValue("@Email", txtEmail.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", txtTelCis.Text);

                    connection.Open();
                    int result = command.ExecuteNonQuery();
                    connection.Close();

                    if (result > 0)
                    {
                        MessageBox.Show("Employee updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error updating employee.");
                    }
                }
            }
        }

        private void btnFiltr_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Employee WHERE PersNum=@PersNum";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersNum", txtID.Text);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count > 0)
                    {
                        txtJmeno.Text = table.Rows[0]["FirstName"].ToString();
                        txtPrijmeni.Text = table.Rows[0]["LastName"].ToString();
                        txtDateNar.Text = table.Rows[0]["BirthDate"].ToString();
                        txtEmail.Text = table.Rows[0]["Email"].ToString();
                        txtTelCis.Text = table.Rows[0]["PhoneNumber"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Employee not found");
                    }
                }
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Employee";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dataGridView1.DataSource = table;
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
