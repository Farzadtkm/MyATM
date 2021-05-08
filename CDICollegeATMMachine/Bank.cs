using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDICollegeATMMachine {
    public class Bank : Account {
        private double maximumTopUp = 20000;
        private double refillAmount = 5000;
        ATMManager atmManager = new ATMManager();

        public void refillATM(double amount) {
            if (amount + this.getAccountBalance() < maximumTopUp)
                this.setAccountBalance(amount + this.getAccountBalance());
        }
    }
}
