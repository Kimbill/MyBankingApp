using BankingApp.Model;
using MyBankingApp.Model;
using MyBankingApp.Repo;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MyBankingApp
{
    public partial class AccountMenu : Form
    {
        private static AccountRepository _accountRepository;
        private static TransactionRepository _transactionRepository;
        public AccountMenu()
        {
            InitializeComponent();
            _accountRepository = new AccountRepository();
            _transactionRepository = new TransactionRepository();
            labelUser.Text += " " +_loggedInUser.FullName;
            accountname.Text = _loggedInUser.FullName;
        }

        private User _loggedInUser = LoginForm.loggedUser;

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void close_click(object sender, EventArgs e)
        {
            MessageBox.Show("Close is clicked");
        }

        private void AccountMenu_Load(object sender, EventArgs e)
        {

        }

        private void close_Form(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            string acctType = radio_current.Checked ? radio_current.Text : radio_savings.Text;

            try
            {
                decimal amount = decimal.Parse(openBal.Text);

                Account account = new Account();
                _accountRepository.AddAccountToDB(account);

                // add transaction to account
                account.TransactionsHistory.Add(new Transactions(account.AccountNumber, amount, "Initial deposit", account.AccType));
                _transactionRepository.AddTransactionToDB(new Transactions(account.AccountNumber, amount, "Initial deposit", account.AccType));
                MessageBox.Show($"Hurray!!... Account {account.AccountNumber} created for {account.AccountOwnerId} \n" +
                    $"amount deposited: {amount}");

                // add account to user
                // _loggedInUser.Accounts.Add(account);
                accountname.Text = "";
                openBal.Text = "";

            }
            catch (FormatException)
            {

                MessageBox.Show("Account not created, check input");
            }
        }


        private void tabCreateAccount_Click(object sender, EventArgs e)
        {
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //MakeDeposite(string accountNum, decimal amount, string type, string note)
            string acctType = btn_radio_current.Checked ? btn_radio_current.Text : btn_radio_savings.Text;
            try
            {
                decimal amount = decimal.Parse(depositAmount.Text);


                // add transaction to account
                _accountRepository.MakeDeposite(accountNumberField.Text, amount, acctType, depositNote.Text);
                MessageBox.Show($"Hurray!!... Money was deposited into {accountNumberField.Text} \n" +
                    $"amount deposited: {amount}");

                accountNumberField.Text = "";
                depositNote.Text = "";
                depositAmount.Text = "";

            }
            catch (FormatException)
            {

                MessageBox.Show("Transaction not successful");
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {
                string acctType = btn_radio_current.Checked ? btn_radio_current.Text : btn_radio_savings.Text;
                decimal amount = decimal.Parse(withDrawalAmt.Text);


                // add transaction to account
                _accountRepository.MakeWithdrawal(withdrawAcctNum.Text, amount, withdrawalNote.Text, acctType);
                MessageBox.Show($"Hurray!!... Money was withdrawn from {accountNumberField.Text} \n" +
                    $"amount deposited: {amount}");

                withdrawAcctNum.Text = "";
                withdrawalNote.Text = "";
                withDrawalAmt.Text = "";

            }
            catch (FormatException)
            {

                MessageBox.Show("Transaction not successful");
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            // MakeTransfer(string senderNumber, string receiverNumber, decimal amt, string note, string type)
            string recieverAcct = recieverAccountNum.Text;
            string senderAcct = senderAcctNum.Text;
            string acctType = radio_trf_current.Checked ? radio_trf_current.Text : radio_trf_savings.Text;
            string trfAmount = transferAmount.Text;
            string trfNote = transferNote.Text;
            try
            {
                decimal amount = decimal.Parse(trfAmount);

                // add transaction to account
                _accountRepository.MakeTransfer(senderAcct, recieverAcct, amount, trfNote, acctType);
                MessageBox.Show($"Hurray!!... Money was transfered from {senderAcct} \n" +
                    $"amount deposited: {trfAmount}");

                recieverAccountNum.Text = "";
                senderAcctNum.Text = "";
                transferAmount.Text = "";
                transferNote.Text = "";

            }
            catch (FormatException)
            {

                MessageBox.Show("Transaction not successful");
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }


        private List<Transactions> GetTransactions(string acctNum)
        {
            accountBal.Text = "";
            statementList.Items.Clear();
            try
            {
                var statements = _transactionRepository.GetAllTransactions(acctNum);
                return statements;
            }
            catch (FormatException)
            {

                MessageBox.Show("Request for Statement not successful");
                return null;
            }
        }
        private void btnStatement_Click(object sender, EventArgs e)
        {

            string acctNum = acctNumStatement.Text;
            decimal accountBalance = 0;
            foreach (var trans in GetTransactions(acctNum))
            {
                decimal amt = trans.Amount < 0 ? trans.Amount * -1 : trans.Amount;
                statementList.Items.Add(new ListViewItem(new string[]
                {
                    trans.AccountNumber, trans.AccType, amt.ToString(), trans.DateOfTransaction.ToString()
                }));

                accountBalance += trans.Amount;
            }

            accountBal.Text += "NGN" + accountBalance.ToString();

        }

        private void btnWithdraw2_Click(object sender, EventArgs e)
        {
            try
            {
                string acctType = radio_current_withdraw.Checked ? radio_current_withdraw.Text : radio_savings_withdraw.Text;
                decimal amount = decimal.Parse(withdrawAmmount.Text);


                // add transaction to account
                _accountRepository.MakeWithdrawal(withdrawAccNum.Text, amount, withdrawNote.Text, acctType);
                MessageBox.Show($"{amount} Withdrawn ");

                withdrawAccNum.Text = "";
                withdrawNote.Text = "";
                withdrawAmmount.Text = "";

            }
            catch (FormatException)
            {

                MessageBox.Show("Transaction not successful");
            }
        }
    }
}
