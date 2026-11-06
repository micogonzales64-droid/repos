using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using DataLogicLayer.Models;

namespace PersonalMovieTracker.DataAccess
{

    public class AccountRepository
    {
        private readonly string filePath = "accounts.json";
        
        public void SaveAccounts(List<Account> accounts)

        {
            string json = JsonSerializer.Serialize(accounts, new JsonSerializerOptions { WriteIndented = true});
            

            File.WriteAllText(filePath, json);
        }

        public List<Account> LoadAccounts()
        {
            if (!File.Exists(filePath))
            {
                return new List<Account>();
            }

            string json = File.ReadAllText(filePath);

            List<Account> accounts =
                JsonSerializer.Deserialize<List<Account>>(json);

            return accounts ?? new List<Account>();
        }
    }
}
