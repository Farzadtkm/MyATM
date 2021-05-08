using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDICollegeATMMachine
{
    public class CheckingAccounts {

        private List<Checking> allCheckingAccounts = new List<Checking>();
        
        public void addChecking(Checking aCheckingAccount) {
            allCheckingAccounts.Add(aCheckingAccount);
        }

        public Checking getChecking(int index) {
            return allCheckingAccounts.ElementAt(index);
        }

        public List<Checking> getAllCheckingAccounts() {
            return allCheckingAccounts;
        }

    }
}
