using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects; // Reference the BussinessObjects namespace here

namespace DataAccessLayer
{
    public class AccountDao 
    {
        public static AccountMember GetAccountById(string accountID)
        {
            AccountMember accountMember = new AccountMember();

            // Just for demonstration purposes
            if (accountID.Equals("PS0001"))
            {
                accountMember.MemberId = accountID;
                accountMember.MemberPassword = "@1";
                accountMember.MemberRole = 1;
            }

            return accountMember;
        }
    }
}
