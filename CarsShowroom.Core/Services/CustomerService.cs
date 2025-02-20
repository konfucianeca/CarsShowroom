using CarsShowroom.Core.Contracts;
using CarsShowroom.Infrastructure.Data.Common;
using CarsShowroom.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CarsShowroom.Core.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository repository;
        public CustomerService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task CreateAsync(string userId, string name, string phoneNumber, string address)
        {
            await repository.AddAsync(new Customer()
            {
                Name = name,
                PhoneNumber = phoneNumber,
                Address = address,
                UserId = userId
            });

            await repository.SaveChangesAsync();
        }
        public async Task<bool> ExistByIdAsync(string userId)
        {
            return await repository.AllReadOnlyAsync<Customer>()
                .AnyAsync(c => c.UserId == userId);
        }

        public async Task<int> GetCustomerIdAsync(string userId)
        {
            return (await repository.AllReadOnlyAsync<Customer>()
                .FirstOrDefaultAsync(c => c.UserId == userId))
                .Id;
        }
        public async Task<bool> UserWithPhoneNumberExistAsync(string phoneNumber)
        {
            return await repository.AllReadOnlyAsync<Customer>()
                .AnyAsync(c => c.PhoneNumber == phoneNumber);
        }
    }
}
