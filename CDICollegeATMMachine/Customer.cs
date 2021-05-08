using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDICollegeATMMachine {
    public class Customer {

        private string name;
        private string pinNumber;
        public void setName(string name) {
            this.name = name;
        }

        public void setPinNumber(string pinNumber) {
            this.pinNumber = pinNumber;
        }
        public string getName() {
            return this.name;
        }
        public string getPinNumber() {
            return this.pinNumber;
        }
    }
}
