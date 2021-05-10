using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDICollegeATMMachine {
    public class Customer {

        private string name;
        private string pinNumber;
        private String email;
        private String phoneNumber;

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
        public void setEmail(String accountEmail)
        {
            this.email = accountEmail;
        }

        public String getEmail()
        {
            return this.email;
        }

        public void setPhoneNumber(String accountPhoneNumber)
        {
            this.phoneNumber = accountPhoneNumber;
        }

        public String getPhoneNumber()
        {
            return this.phoneNumber;
        }
    }
}
