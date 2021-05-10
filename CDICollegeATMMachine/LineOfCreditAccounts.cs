using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDICollegeATMMachine
{
    public class LineOfCreditAccounts
    {
        private List<LineOfCredit> allLineofCreditAccounts = new List<LineOfCredit>();

        public void addLineOfCredit(LineOfCredit aLineOfCreditAccount)
        {
            allLineofCreditAccounts.Add(aLineOfCreditAccount);
        }

        public LineOfCredit getLineOfCredit(int index)
        {
            return allLineofCreditAccounts.ElementAt(index);
        }

        public List<LineOfCredit> getAllLineOfCreditAccounts()
        {
            return allLineofCreditAccounts;
        }
    }
}
