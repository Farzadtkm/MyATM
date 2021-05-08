using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDICollegeATMMachine {
    public class Savings : Account {

        private double intrestRate = 0.01;
        public void payIntrest() {
            this.setAccountBalance(this.getAccountBalance() * intrestRate / 365 / 100);
        }
    }
}
