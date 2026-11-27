
using System;
using System.Windows.Forms;
using DataLogicLayer.Models;

namespace Form_PersonalMovieTracker
{
    public partial class DashboardForm : Form
    {
        private Account loggedInAccount;

        public DashboardForm(Account account)
        {
            InitializeComponent();

            loggedInAccount = account;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
