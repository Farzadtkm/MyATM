using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDICollegeATMMachine {
    public class Account {

        private string pinNumber;
        private string accountNumber;
        private double accountBalance;
        private int maximumWithDrawal = 10000;
        private int maximumTransferAmount;
        private String email;
        private String phoneNumber;

        public double withdarw(double amount) {
            return 0;
        }

        public double deposit(double deposit) {
            return 0;
        }

        public double transferOut(double deposit) {
            return 0;
        }

        public double transferIn(double deposit) {
            return 0;
        }

        public string getPinNumber() {
            return this.pinNumber;
        }
        public void setPinNumber(string pinNumber) {
            this.pinNumber = pinNumber;
        }

        public void setAccountNumber(string accountNumber) {
            this.accountNumber = accountNumber;
        }
        public string getAccountNumber() {
            return this.accountNumber;
        }

        public void setAccountBalance(double accountBalance) {
            this.accountBalance = accountBalance;
        }

        public double getAccountBalance() {
            return this.accountBalance;
        }

    }
}
