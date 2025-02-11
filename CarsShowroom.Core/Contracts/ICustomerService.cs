namespace CarsShowroom.Core.Contracts
{
    public interface ICustomerService
    {
        Task<bool> ExistByIdAsync(string userId);
        Task<bool> UserWithPhoneNumberExistAsync(string phoneNumber);
        Task CreateAsync(string userId, string phoneNumber, string name, string address);
        Task<int> GetCustomerIdAsync(string userId);
    }
}
