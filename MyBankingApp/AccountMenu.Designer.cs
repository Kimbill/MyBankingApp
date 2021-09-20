
namespace MyBankingApp
{
    partial class AccountMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.homeTab = new System.Windows.Forms.TabControl();
            this.tabCreateAccount = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.radio_current = new System.Windows.Forms.RadioButton();
            this.radio_savings = new System.Windows.Forms.RadioButton();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openBal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.accountname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDeposit = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_radio_current = new System.Windows.Forms.RadioButton();
            this.btn_radio_savings = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.depositNote = new System.Windows.Forms.TextBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.depositAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.accountNumberField = new System.Windows.Forms.TextBox();
            this.labelDeposit = new System.Windows.Forms.Label();
            this.tabWithdraw2 = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.radio_current_withdraw = new System.Windows.Forms.RadioButton();
            this.radio_savings_withdraw = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.withdrawNote = new System.Windows.Forms.TextBox();
            this.btnWithdraw2 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.withdrawAmmount = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.withdrawAccNum = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.tabTransfer = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.radio_trf_current = new System.Windows.Forms.RadioButton();
            this.radio_trf_savings = new System.Windows.Forms.RadioButton();
            this.label20 = new System.Windows.Forms.Label();
            this.senderAcctNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.transferNote = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.transferAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.recieverAccountNum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabStatement = new System.Windows.Forms.TabPage();
            this.accountBal = new System.Windows.Forms.Label();
            this.panel_statement = new System.Windows.Forms.Panel();
            this.statementList = new System.Windows.Forms.ListView();
            this.accountNumber = new System.Windows.Forms.ColumnHeader();
            this.accttype = new System.Windows.Forms.ColumnHeader();
            this.tranAmt = new System.Windows.Forms.ColumnHeader();
            this.transDate = new System.Windows.Forms.ColumnHeader();
            this.btnStatement = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.acctNumStatement = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tabWithdraw = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.withdrawalNote = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.withDrawalAmt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.withdrawAcctNum = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.homeTab.SuspendLayout();
            this.tabCreateAccount.SuspendLayout();
            this.tabDeposit.SuspendLayout();
            this.tabWithdraw2.SuspendLayout();
            this.tabTransfer.SuspendLayout();
            this.tabStatement.SuspendLayout();
            this.panel_statement.SuspendLayout();
            this.tabWithdraw.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.tabCreateAccount);
            this.homeTab.Controls.Add(this.tabDeposit);
            this.homeTab.Controls.Add(this.tabWithdraw2);
            this.homeTab.Controls.Add(this.tabTransfer);
            this.homeTab.Controls.Add(this.tabStatement);
            this.homeTab.Location = new System.Drawing.Point(40, 39);
            this.homeTab.Margin = new System.Windows.Forms.Padding(5);
            this.homeTab.MinimumSize = new System.Drawing.Size(15, 10);
            this.homeTab.Name = "homeTab";
            this.homeTab.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.homeTab.SelectedIndex = 0;
            this.homeTab.ShowToolTips = true;
            this.homeTab.Size = new System.Drawing.Size(866, 649);
            this.homeTab.TabIndex = 6;
            // 
            // tabCreateAccount
            // 
            this.tabCreateAccount.Controls.Add(this.label4);
            this.tabCreateAccount.Controls.Add(this.radio_current);
            this.tabCreateAccount.Controls.Add(this.radio_savings);
            this.tabCreateAccount.Controls.Add(this.btnOpenAccount);
            this.tabCreateAccount.Controls.Add(this.label3);
            this.tabCreateAccount.Controls.Add(this.openBal);
            this.tabCreateAccount.Controls.Add(this.label2);
            this.tabCreateAccount.Controls.Add(this.accountname);
            this.tabCreateAccount.Controls.Add(this.label1);
            this.tabCreateAccount.Location = new System.Drawing.Point(4, 34);
            this.tabCreateAccount.Name = "tabCreateAccount";
            this.tabCreateAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreateAccount.Size = new System.Drawing.Size(858, 611);
            this.tabCreateAccount.TabIndex = 0;
            this.tabCreateAccount.Text = " Create New Bank Account";
            this.tabCreateAccount.UseVisualStyleBackColor = true;
            this.tabCreateAccount.Click += new System.EventHandler(this.tabCreateAccount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select Account Type";
            // 
            // radio_current
            // 
            this.radio_current.AutoSize = true;
            this.radio_current.Location = new System.Drawing.Point(297, 284);
            this.radio_current.Name = "radio_current";
            this.radio_current.Size = new System.Drawing.Size(92, 29);
            this.radio_current.TabIndex = 7;
            this.radio_current.TabStop = true;
            this.radio_current.Text = "current";
            this.radio_current.UseVisualStyleBackColor = true;
            // 
            // radio_savings
            // 
            this.radio_savings.AutoSize = true;
            this.radio_savings.Location = new System.Drawing.Point(46, 284);
            this.radio_savings.Name = "radio_savings";
            this.radio_savings.Size = new System.Drawing.Size(96, 29);
            this.radio_savings.TabIndex = 6;
            this.radio_savings.TabStop = true;
            this.radio_savings.Text = "savings";
            this.radio_savings.UseVisualStyleBackColor = true;
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Location = new System.Drawing.Point(18, 548);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(502, 34);
            this.btnOpenAccount.TabIndex = 5;
            this.btnOpenAccount.Text = "Open Account Now";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            this.btnOpenAccount.Click += new System.EventHandler(this.btnOpenAccount_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Opening Amount";
            // 
            // openBal
            // 
            this.openBal.Location = new System.Drawing.Point(18, 414);
            this.openBal.Name = "openBal";
            this.openBal.PlaceholderText = "Amount";
            this.openBal.Size = new System.Drawing.Size(502, 31);
            this.openBal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account Name";
            // 
            // accountname
            // 
            this.accountname.Location = new System.Drawing.Point(18, 150);
            this.accountname.Name = "accountname";
            this.accountname.PlaceholderText = "Account Name";
            this.accountname.Size = new System.Drawing.Size(502, 31);
            this.accountname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open a new Bank Account";
            // 
            // tabDeposit
            // 
            this.tabDeposit.Controls.Add(this.label19);
            this.tabDeposit.Controls.Add(this.btn_radio_current);
            this.tabDeposit.Controls.Add(this.btn_radio_savings);
            this.tabDeposit.Controls.Add(this.label8);
            this.tabDeposit.Controls.Add(this.depositNote);
            this.tabDeposit.Controls.Add(this.btnDeposit);
            this.tabDeposit.Controls.Add(this.label5);
            this.tabDeposit.Controls.Add(this.depositAmount);
            this.tabDeposit.Controls.Add(this.label6);
            this.tabDeposit.Controls.Add(this.accountNumberField);
            this.tabDeposit.Controls.Add(this.labelDeposit);
            this.tabDeposit.Location = new System.Drawing.Point(4, 34);
            this.tabDeposit.Name = "tabDeposit";
            this.tabDeposit.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeposit.Size = new System.Drawing.Size(858, 611);
            this.tabDeposit.TabIndex = 1;
            this.tabDeposit.Text = "Deposit";
            this.tabDeposit.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(61, 192);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(170, 25);
            this.label19.TabIndex = 16;
            this.label19.Text = "Select Account Type";
            // 
            // btn_radio_current
            // 
            this.btn_radio_current.AutoSize = true;
            this.btn_radio_current.Location = new System.Drawing.Point(340, 249);
            this.btn_radio_current.Name = "btn_radio_current";
            this.btn_radio_current.Size = new System.Drawing.Size(92, 29);
            this.btn_radio_current.TabIndex = 15;
            this.btn_radio_current.TabStop = true;
            this.btn_radio_current.Text = "current";
            this.btn_radio_current.UseVisualStyleBackColor = true;
            // 
            // btn_radio_savings
            // 
            this.btn_radio_savings.AutoSize = true;
            this.btn_radio_savings.Location = new System.Drawing.Point(89, 249);
            this.btn_radio_savings.Name = "btn_radio_savings";
            this.btn_radio_savings.Size = new System.Drawing.Size(96, 29);
            this.btn_radio_savings.TabIndex = 14;
            this.btn_radio_savings.TabStop = true;
            this.btn_radio_savings.Text = "savings";
            this.btn_radio_savings.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Note";
            // 
            // depositNote
            // 
            this.depositNote.Location = new System.Drawing.Point(61, 467);
            this.depositNote.Name = "depositNote";
            this.depositNote.PlaceholderText = "Add Note";
            this.depositNote.Size = new System.Drawing.Size(502, 31);
            this.depositNote.TabIndex = 12;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(61, 553);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(502, 34);
            this.btnDeposit.TabIndex = 11;
            this.btnDeposit.Text = "Deposit Now";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Amount";
            // 
            // depositAmount
            // 
            this.depositAmount.Location = new System.Drawing.Point(61, 379);
            this.depositAmount.Name = "depositAmount";
            this.depositAmount.PlaceholderText = "Amount";
            this.depositAmount.Size = new System.Drawing.Size(502, 31);
            this.depositAmount.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Account Number";
            // 
            // accountNumberField
            // 
            this.accountNumberField.AcceptsReturn = true;
            this.accountNumberField.Location = new System.Drawing.Point(61, 125);
            this.accountNumberField.Name = "accountNumberField";
            this.accountNumberField.PlaceholderText = "Account Number";
            this.accountNumberField.Size = new System.Drawing.Size(502, 31);
            this.accountNumberField.TabIndex = 7;
            // 
            // labelDeposit
            // 
            this.labelDeposit.AutoSize = true;
            this.labelDeposit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDeposit.Location = new System.Drawing.Point(61, 37);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(186, 28);
            this.labelDeposit.TabIndex = 6;
            this.labelDeposit.Text = "Deposit Money";
            // 
            // tabWithdraw2
            // 
            this.tabWithdraw2.Controls.Add(this.label22);
            this.tabWithdraw2.Controls.Add(this.radio_current_withdraw);
            this.tabWithdraw2.Controls.Add(this.radio_savings_withdraw);
            this.tabWithdraw2.Controls.Add(this.label23);
            this.tabWithdraw2.Controls.Add(this.withdrawNote);
            this.tabWithdraw2.Controls.Add(this.btnWithdraw2);
            this.tabWithdraw2.Controls.Add(this.label24);
            this.tabWithdraw2.Controls.Add(this.withdrawAmmount);
            this.tabWithdraw2.Controls.Add(this.label25);
            this.tabWithdraw2.Controls.Add(this.withdrawAccNum);
            this.tabWithdraw2.Controls.Add(this.label26);
            this.tabWithdraw2.Location = new System.Drawing.Point(4, 34);
            this.tabWithdraw2.Name = "tabWithdraw2";
            this.tabWithdraw2.Size = new System.Drawing.Size(858, 611);
            this.tabWithdraw2.TabIndex = 5;
            this.tabWithdraw2.Text = "Withdraw Money";
            this.tabWithdraw2.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(56, 194);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(170, 25);
            this.label22.TabIndex = 27;
            this.label22.Text = "Select Account Type";
            // 
            // radio_current_withdraw
            // 
            this.radio_current_withdraw.AutoSize = true;
            this.radio_current_withdraw.Location = new System.Drawing.Point(228, 242);
            this.radio_current_withdraw.Name = "radio_current_withdraw";
            this.radio_current_withdraw.Size = new System.Drawing.Size(92, 29);
            this.radio_current_withdraw.TabIndex = 26;
            this.radio_current_withdraw.TabStop = true;
            this.radio_current_withdraw.Text = "current";
            this.radio_current_withdraw.UseVisualStyleBackColor = true;
            // 
            // radio_savings_withdraw
            // 
            this.radio_savings_withdraw.AutoSize = true;
            this.radio_savings_withdraw.Location = new System.Drawing.Point(56, 242);
            this.radio_savings_withdraw.Name = "radio_savings_withdraw";
            this.radio_savings_withdraw.Size = new System.Drawing.Size(96, 29);
            this.radio_savings_withdraw.TabIndex = 25;
            this.radio_savings_withdraw.TabStop = true;
            this.radio_savings_withdraw.Text = "savings";
            this.radio_savings_withdraw.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(56, 421);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 25);
            this.label23.TabIndex = 24;
            this.label23.Text = "Note";
            // 
            // withdrawNote
            // 
            this.withdrawNote.Location = new System.Drawing.Point(56, 466);
            this.withdrawNote.Name = "withdrawNote";
            this.withdrawNote.PlaceholderText = "Add Note";
            this.withdrawNote.Size = new System.Drawing.Size(502, 31);
            this.withdrawNote.TabIndex = 23;
            // 
            // btnWithdraw2
            // 
            this.btnWithdraw2.Location = new System.Drawing.Point(56, 538);
            this.btnWithdraw2.Name = "btnWithdraw2";
            this.btnWithdraw2.Size = new System.Drawing.Size(502, 34);
            this.btnWithdraw2.TabIndex = 22;
            this.btnWithdraw2.Text = "Withdraw Now";
            this.btnWithdraw2.UseVisualStyleBackColor = true;
            this.btnWithdraw2.Click += new System.EventHandler(this.btnWithdraw2_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(56, 321);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 25);
            this.label24.TabIndex = 21;
            this.label24.Text = "Amount";
            // 
            // withdrawAmmount
            // 
            this.withdrawAmmount.Location = new System.Drawing.Point(56, 375);
            this.withdrawAmmount.Name = "withdrawAmmount";
            this.withdrawAmmount.PlaceholderText = "Amount";
            this.withdrawAmmount.Size = new System.Drawing.Size(502, 31);
            this.withdrawAmmount.TabIndex = 20;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(56, 90);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(147, 25);
            this.label25.TabIndex = 19;
            this.label25.Text = "Account Number";
            // 
            // withdrawAccNum
            // 
            this.withdrawAccNum.AcceptsReturn = true;
            this.withdrawAccNum.Location = new System.Drawing.Point(56, 127);
            this.withdrawAccNum.Name = "withdrawAccNum";
            this.withdrawAccNum.PlaceholderText = "Account Number";
            this.withdrawAccNum.Size = new System.Drawing.Size(502, 31);
            this.withdrawAccNum.TabIndex = 18;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(56, 31);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(207, 28);
            this.label26.TabIndex = 17;
            this.label26.Text = "Withdraw Money";
            // 
            // tabTransfer
            // 
            this.tabTransfer.Controls.Add(this.label21);
            this.tabTransfer.Controls.Add(this.radio_trf_current);
            this.tabTransfer.Controls.Add(this.radio_trf_savings);
            this.tabTransfer.Controls.Add(this.label20);
            this.tabTransfer.Controls.Add(this.senderAcctNum);
            this.tabTransfer.Controls.Add(this.label9);
            this.tabTransfer.Controls.Add(this.transferNote);
            this.tabTransfer.Controls.Add(this.btnTransfer);
            this.tabTransfer.Controls.Add(this.label10);
            this.tabTransfer.Controls.Add(this.transferAmount);
            this.tabTransfer.Controls.Add(this.label11);
            this.tabTransfer.Controls.Add(this.recieverAccountNum);
            this.tabTransfer.Controls.Add(this.label12);
            this.tabTransfer.Location = new System.Drawing.Point(4, 34);
            this.tabTransfer.Name = "tabTransfer";
            this.tabTransfer.Size = new System.Drawing.Size(858, 611);
            this.tabTransfer.TabIndex = 2;
            this.tabTransfer.Text = "Transfer";
            this.tabTransfer.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(60, 294);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(230, 25);
            this.label21.TabIndex = 26;
            this.label21.Text = "Select Sender Account Type";
            // 
            // radio_trf_current
            // 
            this.radio_trf_current.AutoSize = true;
            this.radio_trf_current.Location = new System.Drawing.Point(184, 333);
            this.radio_trf_current.Name = "radio_trf_current";
            this.radio_trf_current.Size = new System.Drawing.Size(92, 29);
            this.radio_trf_current.TabIndex = 25;
            this.radio_trf_current.TabStop = true;
            this.radio_trf_current.Text = "current";
            this.radio_trf_current.UseVisualStyleBackColor = true;
            // 
            // radio_trf_savings
            // 
            this.radio_trf_savings.AutoSize = true;
            this.radio_trf_savings.Location = new System.Drawing.Point(60, 333);
            this.radio_trf_savings.Name = "radio_trf_savings";
            this.radio_trf_savings.Size = new System.Drawing.Size(96, 29);
            this.radio_trf_savings.TabIndex = 24;
            this.radio_trf_savings.TabStop = true;
            this.radio_trf_savings.Text = "savings";
            this.radio_trf_savings.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(60, 205);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(286, 25);
            this.label20.TabIndex = 23;
            this.label20.Text = "Sender Account Number (To debit)";
            // 
            // senderAcctNum
            // 
            this.senderAcctNum.Location = new System.Drawing.Point(60, 246);
            this.senderAcctNum.Name = "senderAcctNum";
            this.senderAcctNum.PlaceholderText = "Account Number";
            this.senderAcctNum.Size = new System.Drawing.Size(502, 31);
            this.senderAcctNum.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 460);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Note";
            // 
            // transferNote
            // 
            this.transferNote.Location = new System.Drawing.Point(60, 502);
            this.transferNote.Name = "transferNote";
            this.transferNote.PlaceholderText = "Add Note";
            this.transferNote.Size = new System.Drawing.Size(502, 31);
            this.transferNote.TabIndex = 20;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(60, 570);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(502, 34);
            this.btnTransfer.TabIndex = 19;
            this.btnTransfer.Text = "Transfer Now";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 375);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Amount";
            // 
            // transferAmount
            // 
            this.transferAmount.Location = new System.Drawing.Point(60, 414);
            this.transferAmount.Name = "transferAmount";
            this.transferAmount.PlaceholderText = "Amount";
            this.transferAmount.Size = new System.Drawing.Size(502, 31);
            this.transferAmount.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Location = new System.Drawing.Point(60, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 25);
            this.label11.TabIndex = 16;
            this.label11.Text = "Reciever Account Number";
            // 
            // recieverAccountNum
            // 
            this.recieverAccountNum.Location = new System.Drawing.Point(60, 147);
            this.recieverAccountNum.Name = "recieverAccountNum";
            this.recieverAccountNum.PlaceholderText = "Account Number";
            this.recieverAccountNum.Size = new System.Drawing.Size(502, 31);
            this.recieverAccountNum.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(60, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(156, 28);
            this.label12.TabIndex = 14;
            this.label12.Text = "Send Money";
            // 
            // tabStatement
            // 
            this.tabStatement.Controls.Add(this.accountBal);
            this.tabStatement.Controls.Add(this.panel_statement);
            this.tabStatement.Controls.Add(this.btnStatement);
            this.tabStatement.Controls.Add(this.label17);
            this.tabStatement.Controls.Add(this.acctNumStatement);
            this.tabStatement.Controls.Add(this.label18);
            this.tabStatement.Location = new System.Drawing.Point(4, 34);
            this.tabStatement.Name = "tabStatement";
            this.tabStatement.Size = new System.Drawing.Size(858, 611);
            this.tabStatement.TabIndex = 4;
            this.tabStatement.Text = "Get Statement";
            this.tabStatement.UseVisualStyleBackColor = true;
            // 
            // accountBal
            // 
            this.accountBal.AutoSize = true;
            this.accountBal.Font = new System.Drawing.Font("MS Reference Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accountBal.Location = new System.Drawing.Point(51, 418);
            this.accountBal.Name = "accountBal";
            this.accountBal.Size = new System.Drawing.Size(115, 28);
            this.accountBal.TabIndex = 14;
            this.accountBal.Text = "Balance: ";
            // 
            // panel_statement
            // 
            this.panel_statement.Controls.Add(this.statementList);
            this.panel_statement.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_statement.Location = new System.Drawing.Point(337, 0);
            this.panel_statement.Name = "panel_statement";
            this.panel_statement.Size = new System.Drawing.Size(521, 611);
            this.panel_statement.TabIndex = 13;
            // 
            // statementList
            // 
            this.statementList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.accountNumber,
            this.accttype,
            this.tranAmt,
            this.transDate});
            this.statementList.GridLines = true;
            this.statementList.HideSelection = false;
            this.statementList.Location = new System.Drawing.Point(0, 3);
            this.statementList.Name = "statementList";
            this.statementList.Size = new System.Drawing.Size(514, 455);
            this.statementList.TabIndex = 0;
            this.statementList.UseCompatibleStateImageBehavior = false;
            this.statementList.View = System.Windows.Forms.View.Details;
            // 
            // accountNumber
            // 
            this.accountNumber.Text = "Account Number";
            this.accountNumber.Width = 150;
            // 
            // accttype
            // 
            this.accttype.Text = "Account Type";
            this.accttype.Width = 100;
            // 
            // tranAmt
            // 
            this.tranAmt.Text = "Transaction Amount";
            this.tranAmt.Width = 120;
            // 
            // transDate
            // 
            this.transDate.Text = "Transaction Date";
            this.transDate.Width = 200;
            // 
            // btnStatement
            // 
            this.btnStatement.Location = new System.Drawing.Point(74, 303);
            this.btnStatement.Name = "btnStatement";
            this.btnStatement.Size = new System.Drawing.Size(273, 34);
            this.btnStatement.TabIndex = 12;
            this.btnStatement.Text = "Generate Statement";
            this.btnStatement.UseVisualStyleBackColor = true;
            this.btnStatement.Click += new System.EventHandler(this.btnStatement_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(74, 130);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 25);
            this.label17.TabIndex = 11;
            this.label17.Text = "Account Number";
            // 
            // acctNumStatement
            // 
            this.acctNumStatement.Location = new System.Drawing.Point(74, 171);
            this.acctNumStatement.Name = "acctNumStatement";
            this.acctNumStatement.PlaceholderText = "Account Number";
            this.acctNumStatement.Size = new System.Drawing.Size(273, 31);
            this.acctNumStatement.TabIndex = 10;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(65, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(282, 28);
            this.label18.TabIndex = 9;
            this.label18.Text = "Get Account Statement";
            // 
            // tabWithdraw
            // 
            this.tabWithdraw.Controls.Add(this.label13);
            this.tabWithdraw.Controls.Add(this.withdrawalNote);
            this.tabWithdraw.Controls.Add(this.btnWithdraw);
            this.tabWithdraw.Controls.Add(this.label14);
            this.tabWithdraw.Controls.Add(this.withDrawalAmt);
            this.tabWithdraw.Controls.Add(this.label15);
            this.tabWithdraw.Controls.Add(this.withdrawAcctNum);
            this.tabWithdraw.Controls.Add(this.label16);
            this.tabWithdraw.Location = new System.Drawing.Point(4, 34);
            this.tabWithdraw.Name = "tabWithdraw";
            this.tabWithdraw.Size = new System.Drawing.Size(898, 611);
            this.tabWithdraw.TabIndex = 3;
            this.tabWithdraw.Text = "Withdraw";
            this.tabWithdraw.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 400);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 25);
            this.label13.TabIndex = 21;
            this.label13.Text = "Note";
            // 
            // withdrawalNote
            // 
            this.withdrawalNote.Location = new System.Drawing.Point(58, 459);
            this.withdrawalNote.Name = "withdrawalNote";
            this.withdrawalNote.PlaceholderText = "Add Note";
            this.withdrawalNote.Size = new System.Drawing.Size(502, 31);
            this.withdrawalNote.TabIndex = 20;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(58, 545);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(502, 34);
            this.btnWithdraw.TabIndex = 19;
            this.btnWithdraw.Text = "Withdraw Now";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(58, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 25);
            this.label14.TabIndex = 18;
            this.label14.Text = "Amount";
            // 
            // withDrawalAmt
            // 
            this.withDrawalAmt.Location = new System.Drawing.Point(58, 311);
            this.withDrawalAmt.Name = "withDrawalAmt";
            this.withDrawalAmt.PlaceholderText = "Amount";
            this.withDrawalAmt.Size = new System.Drawing.Size(502, 31);
            this.withDrawalAmt.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(58, 106);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 25);
            this.label15.TabIndex = 16;
            this.label15.Text = "Account Number";
            // 
            // withdrawAcctNum
            // 
            this.withdrawAcctNum.Location = new System.Drawing.Point(58, 147);
            this.withdrawAcctNum.Name = "withdrawAcctNum";
            this.withdrawAcctNum.PlaceholderText = "Account Number";
            this.withdrawAcctNum.Size = new System.Drawing.Size(502, 31);
            this.withdrawAcctNum.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(58, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(207, 28);
            this.label16.TabIndex = 14;
            this.label16.Text = "Withdraw Money";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(738, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.close_Form);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.logout);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(906, 45);
            this.panel3.TabIndex = 5;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(611, 5);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(131, 34);
            this.logout.TabIndex = 5;
            this.logout.Text = "Log Out";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.homeTab);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(368, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(906, 688);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::MyBankingApp.Properties.Resources.Bank11;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 689);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUser.Location = new System.Drawing.Point(26, 625);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(105, 30);
            this.labelUser.TabIndex = 11;
            this.labelUser.Text = "Welcome";
            this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(0, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(388, 47);
            this.label7.TabIndex = 12;
            this.label7.Text = "Providus Bank Plc.";
            // 
            // AccountMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 689);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "AccountMenu";
            this.Text = "Account Menu";
            this.Load += new System.EventHandler(this.AccountMenu_Load);
            this.homeTab.ResumeLayout(false);
            this.tabCreateAccount.ResumeLayout(false);
            this.tabCreateAccount.PerformLayout();
            this.tabDeposit.ResumeLayout(false);
            this.tabDeposit.PerformLayout();
            this.tabWithdraw2.ResumeLayout(false);
            this.tabWithdraw2.PerformLayout();
            this.tabTransfer.ResumeLayout(false);
            this.tabTransfer.PerformLayout();
            this.tabStatement.ResumeLayout(false);
            this.tabStatement.PerformLayout();
            this.panel_statement.ResumeLayout(false);
            this.tabWithdraw.ResumeLayout(false);
            this.tabWithdraw.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl homeTab;
        private System.Windows.Forms.TabPage tabCreateAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox openBal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox accountname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabDeposit;
        private System.Windows.Forms.TabPage tabTransfer;
        private System.Windows.Forms.TabPage tabWithdraw;
        private System.Windows.Forms.TabPage tabStatement;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radio_current;
        private System.Windows.Forms.RadioButton radio_savings;
        private System.Windows.Forms.Button btnOpenAccount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox depositNote;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox depositAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox accountNumberField;
        private System.Windows.Forms.Label labelDeposit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox transferNote;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox transferAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox recieverAccountNum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox withdrawalNote;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox withDrawalAmt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox withdrawAcctNum;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnStatement;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox acctNumStatement;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton btn_radio_current;
        private System.Windows.Forms.RadioButton btn_radio_savings;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox senderAcctNum;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.RadioButton radio_trf_current;
        private System.Windows.Forms.RadioButton radio_trf_savings;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Panel panel_statement;
        private System.Windows.Forms.ListView statementList;
        private System.Windows.Forms.ColumnHeader accountNumber;
        private System.Windows.Forms.ColumnHeader accttype;
        private System.Windows.Forms.ColumnHeader tranAmt;
        private System.Windows.Forms.ColumnHeader transDate;
        private System.Windows.Forms.Label accountBal;
        private System.Windows.Forms.TabPage tabWithdraw2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.RadioButton radio_current_withdraw;
        private System.Windows.Forms.RadioButton radio_savings_withdraw;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox withdrawNote;
        private System.Windows.Forms.Button btnWithdraw2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox withdrawAmmount;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox withdrawAccNum;
        private System.Windows.Forms.Label label26;
    }
}