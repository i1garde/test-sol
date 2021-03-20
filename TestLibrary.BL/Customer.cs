using System;
using System.Security.Cryptography;
using System.Threading;

namespace test_lib
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public string FullName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(SecondName))
                {
                    return FirstName;
                }
                if (string.IsNullOrWhiteSpace(FirstName))
                {
                    return SecondName;
                }
                else
                {
                    return $"{SecondName}, {FirstName}";
                }
            }
        }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }

        public void Validate()
        {
            
        }

        public void Retrieve()
        {
            
        }

        public void Save()
        {
            
        }
    }
}