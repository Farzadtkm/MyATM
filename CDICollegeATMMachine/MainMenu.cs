using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CDICollegeATMMachine {
    public partial class MainMenu : Form {

        ATMManager atmManager;
        private string user;
        private string pinNumber;
        private int counter;
        private Checking userChecking;
        private Savings userSaving;

        public MainMenu(string user, string pass, ATMManager atmManager) {
            InitializeComponent();

            this.user = user;
            this.pinNumber = pass;
            this.atmManager = atmManager;

            FullName.Text = user;

            foreach (Checking each in atmManager.getCheckingAccount().getAllCheckingAccounts()) {
                if (pinNumber == each.getPinNumber())
                    this.userChecking = each;
            }

            foreach (Savings each in atmManager.getSavingAccounts().getAllSavingAccounts()) {
                if (pinNumber == each.getPinNumber())
                    this.userSaving = each;
            }

            Checkingtxt.Text = Convert.ToString(userChecking.getAccountBalance());
            Savingtxt.Text = Convert.ToString(userSaving.getAccountBalance());

        }

        public void readAccoounts() {

        }

        public void InputNumber(String number) {

        }
        private void CloseButton_Click(object sender, EventArgs e) {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void Button1_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "2";
        }

        private void button5_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "3";
        }

        private void button2_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "4";
        }

        private void button6_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "5";
        }

        private void button9_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "6";
        }

        private void button4_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "7";
        }

        private void button7_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "8";
        }

        private void button8_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e) {
            KeyPadTxt.Text = KeyPadTxt.Text + ".";
        }

        private void SubmitButton_Click(object sender, EventArgs e) {

            if (CheckingRadio.Checked == true && DepositRadio.Checked == true) {
                atmManager.depositChecking(pinNumber, Convert.ToDouble(KeyPadTxt.Text));
            }

            if (SavingRadio.Checked == true && DepositRadio.Checked == true) {
                atmManager.depositSavings(pinNumber, Convert.ToDouble(KeyPadTxt.Text));
            }


            //    if (CheckingRadio.Checked == true && WithdrawalRadio.Checked == true) { 
            //    if(Convert.ToDouble(KeyPadTxt.Text) > 1000)
            //        MessageBox.Show("The amount is more than a thousand dollars", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    else if(Convert.ToDouble(KeyPadTxt.Text) < 0)
            //        MessageBox.Show("The amount cannot be less than zero", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    else if(Convert.ToDouble(KeyPadTxt.Text) % 10 > 0)
            //        MessageBox.Show("The amount should be multiples of 10", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    else if(userChecking.getAccountBalance() < Convert.ToDouble(KeyPadTxt.Text))
            //        MessageBox.Show("The amount cannot be more than the amount in the account", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    else
            //        atmManager.withdrawChecking(pinNumber, Convert.ToDouble(KeyPadTxt.Text));
            //}

            if (SavingRadio.Checked == true && WithdrawalRadio.Checked == true) {
                if (Convert.ToDouble(KeyPadTxt.Text) > 1000)
                    MessageBox.Show("The amount is more than a thousand dollars", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (Convert.ToDouble(KeyPadTxt.Text) < 0)
                    MessageBox.Show("The amount cannot be less than zero", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (Convert.ToDouble(KeyPadTxt.Text) % 10 > 0)
                    MessageBox.Show("The amount should be multiples of 10", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (userSaving.getAccountBalance() < Convert.ToDouble(KeyPadTxt.Text))
                    MessageBox.Show("The amount cannot be more than the amount in the account", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    atmManager.withdrawSavings(pinNumber, Convert.ToDouble(KeyPadTxt.Text));
            }

            if (CheckingRadio.Checked == true && PayBillRadio.Checked == true) {
                if (Convert.ToDouble(KeyPadTxt.Text) > 10000)
                    MessageBox.Show("The amount is more than a ten thousand dollars", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (Convert.ToDouble(KeyPadTxt.Text) < 0)
                    MessageBox.Show("The amount cannot be less than zero", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (userChecking.getAccountBalance() < Convert.ToDouble(KeyPadTxt.Text) + 1.25)
                    MessageBox.Show("The amount cannot be more than the amount in the account with $1.25 considered.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    atmManager.payBill(pinNumber, Convert.ToDouble(KeyPadTxt.Text));
            }

            if (transferFundsCheckingRadio.Checked == true && TransferFundsRadio.Checked == true) {
                

                if (Convert.ToDouble(KeyPadTxt.Text) > 100000)
                    MessageBox.Show("The amount is more than a hundred thousand dollars", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (Convert.ToDouble(KeyPadTxt.Text) < 0)
                    MessageBox.Show("The amount cannot be less than zero", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (userChecking.getAccountBalance() < Convert.ToDouble(KeyPadTxt.Text))
                    MessageBox.Show("The amount cannot be more than the amount in the account.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    atmManager.transferFunds(pinNumber, Convert.ToDouble(KeyPadTxt.Text), "C");
            }

            if (transferFundsSavingsRadio.Checked == true && TransferFundsRadio.Checked == true) {
                

                if (Convert.ToDouble(KeyPadTxt.Text) > 100000)
                    MessageBox.Show("The amount is more than a hundred thousand dollars", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (Convert.ToDouble(KeyPadTxt.Text) < 0)
                    MessageBox.Show("The amount cannot be less than zero", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (userSaving.getAccountBalance() < Convert.ToDouble(KeyPadTxt.Text))
                    MessageBox.Show("The amount cannot be more than the amount in the account.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    atmManager.transferFunds(pinNumber, Convert.ToDouble(KeyPadTxt.Text), "S");

            }

            if (SavingRadio.Checked == true && PayBillRadio.Checked == true) {
                MessageBox.Show("Paying a bill is only available from checking", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            atmManager.WriteAccounts();
        }

        private void CheckingRadio_CheckedChanged(object sender, EventArgs e) {
            if (CheckingRadio.Checked == true) {
                Checkingtxt.Text = Convert.ToString(userChecking.getAccountBalance());
                Savingtxt.Text = Convert.ToString(userSaving.getAccountBalance());

                //foreach(Checking each in atmManager.getCheckingAccount().getAllCheckingAccounts()) {
                //    if (pinNumber == each.getPinNumber())
                //        Checkingtxt.Text = Convert.ToString(each.getAccountBalance());
                //}
            }
        }

        private void DepositRadio_CheckedChanged(object sender, EventArgs e) {
            if (DepositRadio.Checked == true) {
                SelectAccount.Enabled = true;
                transferFunds.Enabled = false;
            }
        }

        private void SavingRadio_CheckedChanged(object sender, EventArgs e) {
            if (SavingRadio.Checked == true) {
                Checkingtxt.Text = Convert.ToString(userChecking.getAccountBalance());
                Savingtxt.Text = Convert.ToString(userSaving.getAccountBalance());

                //foreach (Savings each in atmManager.getSavingAccounts().getAllSavingAccounts()) {
                //    if (pinNumber == each.getPinNumber())
                //        Savingtxt.Text = Convert.ToString(each.getAccountBalance());
                //}
            }
        }

        private void WithdrawalRadio_CheckedChanged(object sender, EventArgs e) {
            if (WithdrawalRadio.Checked == true) {
                SelectAccount.Enabled = true;
                transferFunds.Enabled = false;
            }
        }


        private void TransferFundsRadio_CheckedChanged(object sender, EventArgs e) {
            if (TransferFundsRadio.Checked == true) {
                SelectAccount.Enabled = false;
                transferFunds.Enabled = true;
            }
        }

        private void fromlbl_Click(object sender, EventArgs e) {

        }

        private void SelectTransaction_Enter(object sender, EventArgs e) {

        }

        private void transferFunds_KeyDown(object sender, EventArgs e) {

        }

        private void transferFundsSavingsRadio_CheckedChanged(object sender, EventArgs e) {
            if (transferFundsSavingsRadio.Checked == true) {
                Checkingtxt.Text = Convert.ToString(userChecking.getAccountBalance());
                Savingtxt.Text = Convert.ToString(userSaving.getAccountBalance());
                transferlbl.Text = "Checking";
            }
                
        }

        private void transferFundsCheckingRadio_CheckedChanged(object sender, EventArgs e) {
            if (transferFundsCheckingRadio.Checked == true) {
                Checkingtxt.Text = Convert.ToString(userChecking.getAccountBalance());
                Savingtxt.Text = Convert.ToString(userSaving.getAccountBalance());
                transferlbl.Text = "Savings";
            }               
        }

        private void transferFunds_Enter(object sender, EventArgs e) {

        }

        private void PayBillRadio_CheckedChanged(object sender, EventArgs e) {
            if (PayBillRadio.Checked == true) {
                SelectAccount.Enabled = true;
                transferFunds.Enabled = false;
            }
        }

        private void ExitTheATM_Click(object sender, EventArgs e) {
            this.Close();
        }

        //private void MainMenu_Load(object sender, System.EventArgs e) {
        //    if (CheckingRadio.Checked == true) {
        //        foreach (Checking each in atmManager.getCheckingAccount().getAllCheckingAccounts()) {
        //            if (pinNumber == each.getPinNumber())
        //                Checkingtxt.Text = Convert.ToString(each.getAccountBalance());
        //        }
        //    }

        //    if (SavingRadio.Checked == true) {
        //        foreach (Savings each in atmManager.getSavingAccounts().getAllSavingAccounts()) {
        //            if (pinNumber == each.getPinNumber())
        //                Savingtxt.Text = Convert.ToString(each.getAccountBalance());
        //        }
        //    }
        //}
    }
}
