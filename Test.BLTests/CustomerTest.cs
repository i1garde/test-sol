using System;
using test_lib;
using Xunit;

namespace Test.BLTests
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            Customer customer = new Customer()
            {
                FirstName = "Fedor",
                SecondName = "Truntcev"
            };
            
            string expected = "Truntcev, Fedor";

            string actual = customer.FullName;
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void FullNameEmptyFirstNameValid()
        {
            Customer customer = new Customer()
            {
                SecondName = "Truntcev"
            };
            
            string expected = "Truntcev";

            string actual = customer.FullName;
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void FullNameEmptySecondNameValid()
        {
            Customer customer = new Customer()
            {
                FirstName = "Fedor"
            };
            
            string expected = "Fedor";

            string actual = customer.FullName;
            
            Assert.Equal(expected, actual);
        }
    }
}