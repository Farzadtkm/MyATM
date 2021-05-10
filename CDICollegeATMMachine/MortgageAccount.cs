using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDICollegeATMMachine
{
    public class MortgageAccount 
    {
        private List<Mortgage> allMortgageAccounts = new List<Mortgage>();

        public void addMortgage(Mortgage aMortgageAccount)
        {
            allMortgageAccounts.Add(aMortgageAccount);
        }

        public Mortgage getMortgage(int index)
        {
            return allMortgageAccounts.ElementAt(index);
        }

        public List<Mortgage> getAllMortgageAccounts()
        {
            return allMortgageAccounts;
        }
    }
}
