using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class SearchQuotes : Form
    {
        private void goToMainMenu()
        {
            var frmMainMenu = (MainMenu)this.Tag;
            frmMainMenu.Location = this.Location;
            this.Hide();
            frmMainMenu.Show();
        }

        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            goToMainMenu();
        }
    }
}
