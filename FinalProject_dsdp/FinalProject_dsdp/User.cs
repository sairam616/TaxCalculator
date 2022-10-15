using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject_dsdp
{
    internal class User
    {
        private string name;
        private string email;
        private long phone;

        public User(string name, string email, long phone)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public long Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
}