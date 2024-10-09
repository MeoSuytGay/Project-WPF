﻿using BussinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal class AccountService:IAccountService
    {
        private readonly IAccountRepository iAccountRepository;
        public AccountService()
        {
            iAccountRepository = new AccountRepository();   
        }
        public AccountMember GetAccountById(String accountId)
        {
            return iAccountRepository.GetAccountById(accountId);
        }
    }
}
