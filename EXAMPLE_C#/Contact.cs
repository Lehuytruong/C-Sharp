using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace T1807M1.Properties
{
    public class Contact
    {
        public string name;
        public string phone;

        public Contact()
        {
        }

        public Contact(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Phone
        {
            get => phone;
            set => phone = value;
        }

        
    }
}