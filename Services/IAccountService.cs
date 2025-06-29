
using DataAccessLayer.DataAccessLayer;

namespace Services
{
    public interface IAccountService
    {
        AccountMember GetAccountById(string accountID);
    }
}