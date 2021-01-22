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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void goToMainMenu()
        {
            var frmMainMenu = (MainMenu)this.Tag;
            frmMainMenu.Location = this.Location;
            this.Hide();
            frmMainMenu.Show();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            goToMainMenu();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            goToMainMenu();
        }

        private Desk getDeskFromInput()
        {
            decimal width = numDeskWidth.Value;
            decimal depth = numDeskDepth.Value;
            int numberOfDrawers = (int)numNumberOfDrawers.Value;
            string desktopMaterialStr = listDesktopMaterial.SelectedValue.ToString();
            DesktopMaterials desktopMaterial;
            desktopMaterial = (DesktopMaterials)Enum.Parse(typeof(DesktopMaterials), desktopMaterialStr);

            return new Desk(width, depth, numberOfDrawers, desktopMaterial);
        }

        private DeskQuote getDeskQuoteFromInput()
        {
            string customerName = textCustomerName.Text;
            string rushOrderOptionStr = listRushOrderOption.SelectedItem.ToString();
            RushOrderOptions rushOrderOption;
            rushOrderOption = DeskQuote.rushOrderOptionDic[rushOrderOptionStr]; 
            Desk desk = getDeskFromInput();
            DateTime date = DateTime.Today;

            return new DeskQuote(customerName, rushOrderOption, desk, date);
        }

        private void btnAddQuote_Click(object sender, EventArgs e)
        {
            var quote = getDeskQuoteFromInput();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            listDesktopMaterial.DataSource = Enum.GetValues(typeof(DesktopMaterials));
            listDesktopMaterial.SelectedItem = DesktopMaterials.Pine;
            listRushOrderOption.SelectedItem = "14 day";
        }
    }
}
