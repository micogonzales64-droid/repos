using DataLogicLayer.Models;
using PersonalMovieTracker.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Windows.Forms;

namespace Form_PersonalMovieTracker
{
    public partial class LoginForm : Form
    {
        private AccountService accountService = new AccountService();
        private List<Account> accounts;

        public LoginForm()
        {
            InitializeComponent();

            accounts = accountService.LoadAccounts();
          

        }
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            int accountIndex = accountService.LoginUser(accounts, username, password);

            if (accountIndex != -1)
            {
                Account loggedInAccount = accounts[accountIndex];

                MessageBox.Show("Login Successful! Welcome, " + username);

                DashboardForm dashboard = new DashboardForm(loggedInAccount);

                this.Hide();
                dashboard.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
