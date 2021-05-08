using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDICollegeATMMachine
{
    public class SavingAccounts {

        private List<Savings> allSavingAccounts = new List<Savings>();

        public void addSavings(Savings aSavingAccount) {
            allSavingAccounts.Add(aSavingAccount);
        }

        public Savings getSavings(int index) {
            return allSavingAccounts.ElementAt(index);
        }

        public List<Savings> getAllSavingAccounts() {
            return allSavingAccounts;
        }
    }
}
