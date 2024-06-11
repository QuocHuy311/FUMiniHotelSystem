using BusinessObjects.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CustomerService(CustomerRepository customerRepo)
    {
        private readonly CustomerRepository _customerRepo = customerRepo;

        public IEnumerable<Customer> GetAllCustomers()
        {
            IEnumerable<Customer> customers = _customerRepo.GetAllCustomers();
            return customers;
        }

        public void AddCustomer(Customer customer)
        {
            _customerRepo.AddCustomer(customer);
        }

        public Customer GetCustomerByID(int id)
        {
            return _customerRepo.GetCustomerById(id);
        }

        public void DeleteCustomerByID(int id)
        {
            _customerRepo.DeleteCustomer(id);
        }

        public void UpdateCustomerByID(Customer customer)
        {
            _customerRepo.UpdateCustomer(customer);
        }
    }
}
