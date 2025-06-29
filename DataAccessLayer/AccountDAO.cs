using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.DataAccessLayer;

namespace DataAccessLayer
{
    public class AccountDAO
    {
        public static AccountMember GetAccountById(string accountID)
        {
            try
            {
                using var db = new MyStoreContext();
                return db.AccountMembers.FirstOrDefault(c => c.MemberId.Equals(accountID));
            }
            catch (Exception e)
            {
                throw new Exception("Error retrieving account by ID: " + e.Message);
            }
        }
    }
}
