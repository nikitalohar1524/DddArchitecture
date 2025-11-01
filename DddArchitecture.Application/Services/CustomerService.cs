using DddArchitecture.Application.Interfaces;
using DddArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DddArchitecture.Application.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task AddCustomerAsync(string name, string email)
        {
            var customer = new Customer { Name = name, Email = email };
            if (!customer.IsEmailValid())
                throw new ArgumentException("Invalid email address");

            await _repository.AddAsync(customer);
        }
    }
}
