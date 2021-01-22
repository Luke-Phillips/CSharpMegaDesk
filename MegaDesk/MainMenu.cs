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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void openForm(Form form)
        {
            form.Tag = this;
            this.Hide();
            form.Show();
            form.Location = this.Location;
        }

        private void btnAddNewQuote_Click(object sender, EventArgs e)
        {
            var addQuoteForm = new AddQuote();
            openForm(addQuoteForm);   
        }

        private void btnViewQuotes_Click(object sender, EventArgs e)
        {
            var addViewQuotesForm = new ViewQuotes();
            openForm(addViewQuotesForm);
        }

        private void btnSearchQuotes_Click(object sender, EventArgs e)
        {
            var addSearchQuotesForm = new SearchQuotes();
            openForm(addSearchQuotesForm);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show($"{e.KeyValue} key pressed");
            switch (e.KeyValue)
            {
                case 'a':
                    //openAddNewQuoteForm();
                    break;
                case 'v':
                    //openViewQuotesForm();
                    break;
                case 's':
                    //openSearchQuotesForm();
                    break;
                case 'e':
                case 'q':
                case 'x':
                    Application.Exit();
                    break;
            }
        }
    }
}
