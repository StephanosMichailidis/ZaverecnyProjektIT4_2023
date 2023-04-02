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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StephanosMichailidisProjekt
{
    public partial class ZamestnanecTab : Form
    {
        private string username;
        private string connectionString;
        public ZamestnanecTab(string username)
        {
            InitializeComponent();
            this.username = username;
            label5.Text = this.username;
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProjektDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string customer = txtCust.Text;
            int hours;
            if (!int.TryParse(txtTime.Text, out hours))
            {
                MessageBox.Show("Invalid value for Hours.");
                return;
            }
            string workType = txtJobtype.Text;
            string IDText = txtID.Text;
            int ID;
            try
            {
                ID = Convert.ToInt32(IDText);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid value for ID.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Records (ID, Customer, Hours, WorkType, Username, DateAdded) VALUES (@ID, @Customer, @Hours, @WorkType, @Username, @DateAdded)", connection);
                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Customer", customer);
                command.Parameters.AddWithValue("@Hours", hours);
                command.Parameters.AddWithValue("@WorkType", workType);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@DateAdded", DateTime.Now.Date);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record added successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to add record.");
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // Remove record
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            int recordId;
            if (!int.TryParse(dataGridView1.Rows[rowIndex].Cells[0].Value.ToString(), out recordId))
            {
                MessageBox.Show("Invalid value for Record ID.");
                return;
            }
            DateTime dateAdded;
            if (!DateTime.TryParse(dataGridView1.Rows[rowIndex].Cells[5].Value.ToString(), out dateAdded))
            {
                MessageBox.Show("Invalid value for Date Added.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Records WHERE Id = @Id AND Username = @Username AND DateAdded = @DateAdded", connection);
                command.Parameters.AddWithValue("@Id", recordId);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@DateAdded", dateAdded);

                int count = (int)command.ExecuteScalar();
                if (count == 0)
                {
                    MessageBox.Show("You can only delete your own records and only on the day they were added.");
                    return;
                }

                command = new SqlCommand("DELETE FROM Records WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", recordId);

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record removed successfully.");
                    ListRecords();
                }
                else
                {
                    MessageBox.Show("Failed to remove record.");
                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            ListRecords();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }
        private void ListRecords()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Records WHERE Username = @Username", connection);
                command.Parameters.AddWithValue("@Username", username);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.Refresh();
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}
