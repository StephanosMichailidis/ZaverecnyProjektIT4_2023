using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StephanosMichailidisProjekt
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void btnUzi_Click(object sender, EventArgs e)
        {
            this.Hide();
            editUzivatel editUzivatel = new editUzivatel();
            editUzivatel.FormClosed += (s, args) => this.Close();
            editUzivatel.Show();
        
        }

        private void btnZam_Click(object sender, EventArgs e)
        {
            this.Hide();
            Zaměstnanci Zaměstnanci = new Zaměstnanci();
            Zaměstnanci.FormClosed += (s, args) => this.Close();
            Zaměstnanci.Show();
        }

        private void btnZakaz_Click(object sender, EventArgs e)
        {
            this.Hide();
            zakazky zakazky = new zakazky();
            zakazky.FormClosed += (s, args) => this.Close();
            zakazky.Show();
        }
    }
}
