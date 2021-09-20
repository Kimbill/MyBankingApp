using MyBankingApp.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyBankingApp
{
    public partial class CreateUser : Form
    {
        private static AuthRepository _authRepository;
        public CreateUser()
        {
            InitializeComponent();
            _authRepository = new AuthRepository();
        }

        public bool SignUpUser(string firstname, string lastname, string email, string password)
        {
            try
            {
                // login using repository
                return _authRepository.RegisterUser(firstname, lastname, email, password);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Invalid Input \n" +
                    $"{ex.Message}");
                return false;
            }
            
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            
        }

        private void backLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Close();
            string firstname = FNameField.Text;
            string lastname = LNameField.Text;
            string emailaddress = emailField.Text;
            string password = passwordField.Text;

            var createUserSuccess = SignUpUser(firstname, lastname, emailaddress, password);
            if (createUserSuccess)
            {
                MessageBox.Show("User successfully created");
                Hide();
            }
            else
            {
                MessageBox.Show("User not created");
            }
        }
    }
}
