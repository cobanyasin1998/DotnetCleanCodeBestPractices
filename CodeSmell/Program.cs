using System;

namespace CodeSmell
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(new Customer
            {
                FirstName = "Yasin",
                LastName = "Çoban",
                IdentityNumber = "1516",
                CityId = 2
            });
            customerManager.Add(new Customer
            {
                FirstName = "Yasin",
                LastName = "Çoban",
                IdentityNumber = "1516"
            });
            customerManager.Add(new Customer
            {
                FirstName = "Yasin",
                LastName = "Çoban",
                IdentityNumber = "1516"
            });
            //Bad Using
            //customerManager.Add("Yasin", "Çoban", "1516");


            //First Name Min2 Karakter
            customerManager.AddByOtherBusiness(new Customer
            {
                FirstName = "S",
                LastName = "Çoban",
                IdentityNumber = "1516"
            });
        }
    }
    class CustomerManager
    {
        public void Add(Customer customer)
        {

            //Bad Using 
            //if (!String.IsNullOrEmpty(customer.FirstName) &&
            //    !String.IsNullOrEmpty(customer.LastName) &&
            //    !String.IsNullOrEmpty(customer.IdentityNumber))
            //{
            //    Console.WriteLine("Customer Added!");
            //}
            //Bad Using - Technical Debt

            //if (String.IsNullOrEmpty(customer.FirstName) ||
            //  String.IsNullOrEmpty(customer.LastName) ||
            //  String.IsNullOrEmpty(customer.IdentityNumber))
            //{
            //    throw new Exception("Validasyon Hatası Oldu");
            //}

            ValidateFirstNameIfEmpty(customer);
            ValidateLastNameIfEmpty(customer);

            ValidateIdentityNumberIfEmpty(customer);

            //    Console.WriteLine("Customer Added!");


            //if (String.IsNullOrEmpty(customer.FirstName) ||
            // String.IsNullOrEmpty(customer.LastName) ||
            // String.IsNullOrEmpty(customer.IdentityNumber))
            //{
            //    throw new Exception("Validasyon Hatası Oldu");
            //}
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
        }
        public void AddByOtherBusiness(Customer customer)
        {
            ValidateFirstNameIfEmpty(customer);
            ValidateLastNameIfEmpty(customer);

            ValidateIdentityNumberIfEmpty(customer);
            ValidateFirstNameMinLengthTwo(customer);
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
        }
        //Bad Using
        //public void Add(
        //  string firstName,
        //  string lastName,
        //  string identityNumber,
        //  int cityId)
        //{
        //    Console.WriteLine("Customer Added!");
        //}

        //Bad Using
        //private void Validate(Customer customer)
        //{
        //    if (String.IsNullOrEmpty(customer.FirstName) ||
        //   String.IsNullOrEmpty(customer.LastName) ||
        //   String.IsNullOrEmpty(customer.IdentityNumber))
        //    {
        //        throw new Exception("Validasyon Hatası Oldu");
        //    }
        //}

        private void ValidateFirstNameIfEmpty(Customer customer)
        {
            if (String.IsNullOrWhiteSpace(customer.FirstName))
            {
                throw new Exception("Validasyon Hatası Oldu");
            }
        }
        private void ValidateLastNameIfEmpty(Customer customer)
        {
            if (String.IsNullOrWhiteSpace(customer.LastName))
            {
                throw new Exception("Validasyon Hatası Oldu");
            }
        }
        private void ValidateIdentityNumberIfEmpty(Customer customer)
        {
            if (String.IsNullOrWhiteSpace(customer.IdentityNumber))
            {
                throw new Exception("Validasyon Hatası Oldu");
            }
        }
        private void ValidateFirstNameMinLengthTwo(Customer customer)
        {
            if (customer.IdentityNumber.Length > 2)
            {
                throw new Exception("Validasyon Hatası Oldu");
            }
        }

    }
    class CustomerDal
    {
        public void Add(Customer customer)
        {


            Console.WriteLine("Customer Added!");




        }
    }
    class Customer
    {




        public int Id { get; set; }
        public int CityId { get; set; }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }

    }
}
