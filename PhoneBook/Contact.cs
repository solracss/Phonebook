﻿namespace PhoneBook
{
    internal class Contact
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public Contact(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
}
