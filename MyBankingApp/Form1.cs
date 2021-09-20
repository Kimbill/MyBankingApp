using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingApp.Model;
using MyBankingApp.Repo;

namespace MyBankingApp
{
    public partial class LoginForm : Form
    {
        private static AuthRepository _authRepository;
        public LoginForm()
        {
            InitializeComponent();
            _authRepository = new AuthRepository();
        }

        public static User loggedUser = null;

        public User LoginUser(string email, string password)
        {
            // login using repository
            var loggedIn = _authRepository.Login(email, password);
            if (loggedIn != null)
            {
                return loggedIn;
            }
            throw new Exception("Wrong input or null value detected");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = emailField.Text;
            string password = passwordField.Text;
            try
            {
                var loggedInUser = LoginUser(email, password);
                loggedUser = loggedInUser; 
                AccountMenu myaccount = new AccountMenu();
                Hide();
                myaccount.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.ShowDialog();
        }

        private void emailField_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
