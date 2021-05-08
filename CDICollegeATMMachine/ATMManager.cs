using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CDICollegeATMMachine {
    public class ATMManager {

        private Bank bank;
        private Customers customers = new Customers();
        private SavingAccounts savingAccounts = new SavingAccounts();
        private CheckingAccounts checkingAccounts = new CheckingAccounts();

        private Boolean outofService = false;

        private double currentBalance;


        
        public Boolean validateUser(string name, string pin) {
            
            for(int i = 0; i < 5; i++) {
                if (customers.getCustomer(i).getName().Equals(name) && customers.getCustomer(i).getPinNumber().Equals(pin.Trim())) {
                    return true;
                }
            }

            return false;
        }
        public Boolean withdrawChecking(string pin, double amount) {
            foreach (Checking each in checkingAccounts.getAllCheckingAccounts()) {
                if (each.getPinNumber() == pin) {
                    each.setAccountBalance(each.getAccountBalance() - amount);

                    return true;
                }
            }

            return false;
        }
        public Boolean withdrawSavings(string pin, double amount) {
            foreach (Savings each in savingAccounts.getAllSavingAccounts()) {
                if (each.getPinNumber() == pin) {
                    each.setAccountBalance(each.getAccountBalance() - amount);

                    return true;
                }
            }

            return false;
        }
        public Boolean depositChecking(string pin, double amount) {
            foreach(Checking each in checkingAccounts.getAllCheckingAccounts()) {
                if(each.getPinNumber() == pin) {
                    each.setAccountBalance(amount + each.getAccountBalance());

                    return true;
                }
            }

            return false;
        }
        public Boolean depositSavings(string pin, double amount) {
            foreach (Savings each in savingAccounts.getAllSavingAccounts()) {
                if (each.getPinNumber() == pin) {
                    each.setAccountBalance(amount + each.getAccountBalance());

                    return true;
                }
            }

            return false;
        }
        public Boolean payBill(string pin, double amount) {
            foreach (Checking each in checkingAccounts.getAllCheckingAccounts()) {
                if (each.getPinNumber() == pin) {
                    each.setAccountBalance(each.getAccountBalance() - amount - 1.25);

                    return true;
                }
            }

            return false;
        }
        public void transferFunds(string pin, double amount, string accountType) {
            if(accountType == "C") {
                foreach (Checking each in checkingAccounts.getAllCheckingAccounts()) {
                    if (each.getPinNumber() == pin) {

                        each.setAccountBalance(each.getAccountBalance() - amount);
                    }
                }

                foreach (Savings each in savingAccounts.getAllSavingAccounts()) {
                    if (each.getPinNumber() == pin) {

                        each.setAccountBalance(each.getAccountBalance() + amount);
                    }
                }
            }

            if(accountType == "S") {
                foreach (Savings each in savingAccounts.getAllSavingAccounts()) {
                    if (each.getPinNumber() == pin) {

                        each.setAccountBalance(each.getAccountBalance() - amount);
                    }
                }

                foreach (Checking each in checkingAccounts.getAllCheckingAccounts()) {
                    if (each.getPinNumber() == pin) {

                        each.setAccountBalance(each.getAccountBalance() + amount);
                    }
                }
            }
        }
        public void displayAccountBalance() {
            Console.WriteLine("Your current balance is: " + currentBalance);
        }
        public Boolean readCustomers() {


            try {
                String[] lines = File.ReadAllLines("C:\\Users\\Farzad Torkaman\\Desktop\\MyATM\\Customers.txt");

                for (int i = 0; i < 5; i++) {
                    Customer AddCustomer = new Customer();
                    String[] each = lines[i].Split(',');
                    AddCustomer.setName(each[0]);
                    AddCustomer.setPinNumber(each[1]);
                    customers.addCustomer(AddCustomer);
                }

            } catch (IOException e) {
                Console.Write("There was an error when loading the file");
            }

            return true;
        }
        public Boolean readAccounts() {

            //int accountsCounter = checkingAccounts.getAllCheckingAccounts().Count + savingAccounts.getAllSavingAccounts().Count + 1;

            try {
                String[] lines = File.ReadAllLines("C:\\Users\\Farzad Torkaman\\Desktop\\MyATM\\AccountsCopy.txt");

                for (int i = 0; i < 11; i++) {
                    String[] each = lines[i].Split(',');

                    if (each[0] == "B") {
                        bank = new Bank();

                        bank.setPinNumber(each[1]);
                        bank.setAccountNumber(each[2]);
                        bank.setAccountBalance(Convert.ToDouble(each[3]));
                    } else if (each[0] == "C") {
                        Checking aCheckingAccount = new Checking();

                        aCheckingAccount.setPinNumber(each[1]);
                        aCheckingAccount.setAccountNumber(each[2]);
                        aCheckingAccount.setAccountBalance(Convert.ToDouble(each[3]));

                        checkingAccounts.addChecking(aCheckingAccount);

                    } else if (each[0] == "S") {

                        Savings aSavingAccount = new Savings();

                        aSavingAccount.setPinNumber(each[1]);
                        aSavingAccount.setAccountNumber(each[2]);
                        aSavingAccount.setAccountBalance(Convert.ToDouble(each[3]));

                        savingAccounts.addSavings(aSavingAccount);
                    }
                }
            } catch (IOException e) {
                Console.Write("There was an error when loading the file");
            }

            return true;
        }
        public Boolean WriteAccounts() {

            

            using (StreamWriter file = new StreamWriter("C:\\Users\\Farzad\\source\\repos\\CDICollegeATMMachine\\AccountsCopy.txt")) {
                file.Flush();

                file.WriteLine("B," + bank.getPinNumber() + "," + bank.getAccountNumber() + "," + bank.getAccountBalance());

                foreach (Checking each in checkingAccounts.getAllCheckingAccounts()) {
                    file.WriteLine("C," + each.getPinNumber() + "," + each.getAccountNumber() + "," + each.getAccountBalance());
                }

                foreach (Savings each in savingAccounts.getAllSavingAccounts()) {
                    file.WriteLine("S," + each.getPinNumber() + "," + each.getAccountNumber() + "," + each.getAccountBalance());
                }
            }

            return true;
        }
        public CheckingAccounts getCheckingAccount() {
            return checkingAccounts;
        }
        public SavingAccounts getSavingAccounts() {
            return savingAccounts;
        }
        public Bank getBank() {
            return this.bank;
        }
        public Boolean getOutOfService() {
            return this.outofService;
        }
        public void setOutOfService(Boolean outofService) {
            this.outofService = outofService;
        }
    }

}
