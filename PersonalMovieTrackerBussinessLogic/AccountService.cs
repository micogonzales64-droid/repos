

using DataLogicLayer.Models;
using PersonalMovieTracker.DataAccess;
using System.Collections.Generic;

namespace PersonalMovieTracker.BusinessLogic
{
    public class AccountService
    {
        private readonly AccountRepository accountRepository;

        public AccountService()
        {
            accountRepository = new AccountRepository();
        }
        public bool CreateAccount(List<Account> accounts, string username, string password)
        {
           
            for (int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].Username == username)
                {
                    return false;
                }
            }

            Account newAccount = new Account();

            newAccount.Username = username;
            newAccount.Password = password;

            accounts.Add(newAccount);

            return true;
        }
     public int LoginUser(List<Account> accounts, string username, string password)
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                if (username == accounts[i].Username &&
                    password == accounts[i].Password)
                {
                    return i;
                }
            }

            return -1;
        }
     public List<Account> LoadAccounts()
        {
           return accountRepository.LoadAccounts();
        }

        public void SaveAccounts(List<Account> accounts)
        {
            accountRepository.SaveAccounts(accounts);
        }
    }
}