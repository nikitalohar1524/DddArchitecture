using DddArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DddArchitecture.Application.Interfaces
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Domain.Entities.Customer>> GetAllAsync();
        Task<Customer?> GetByIdAsync(Guid id);
        Task AddAsync(Customer customer);
        Task UpdateAsync(Customer customer);
        Task DeleteAsync(Guid id);
    }
}
