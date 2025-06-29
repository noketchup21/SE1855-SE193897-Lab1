
using DataAccessLayer;
using DataAccessLayer.DataAccessLayer;

namespace Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public AccountMember GetAccountById(string accountID) => AccountDAO.GetAccountById(accountID);
    }
}
