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
using System.Xml.Linq;

namespace StephanosMichailidisProjekt
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // připojení k databázi
            string connectionString = ("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProjektDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // ověření uživatelského jména a hesla
            string username = txtNames.Text;
            string password = txtPassword.Text;
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Name = @Name AND password = @Password", connection);
            command.Parameters.AddWithValue("@Name", username);
            command.Parameters.AddWithValue("@Password", password);
            int count = (int)command.ExecuteScalar();

            // získání role uživatele
            string role = "";
            if (count > 0)
            {
                command = new SqlCommand("SELECT role FROM users WHERE Name = @Name", connection);
                command.Parameters.AddWithValue("@Name", username);
                role = (string)command.ExecuteScalar();
            }

            // odkázání na další formulář podle role uživatele
            if (role.Equals("Admin"))
            {
                this.Hide();
                AdminMenu AdminMenu = new AdminMenu();
                AdminMenu.FormClosed += (s, args) => this.Close();
                AdminMenu.Show();
            }
            else if (role.Equals("User"))
            {
                this.Hide();
                ZamestnanecTab ZamestnanecTab = new ZamestnanecTab(username);
                ZamestnanecTab.FormClosed += (s, args) => this.Close();
                ZamestnanecTab.Owner = this;
                ZamestnanecTab.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
