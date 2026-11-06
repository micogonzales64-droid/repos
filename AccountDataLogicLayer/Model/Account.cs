using System;
using System.Collections.Generic;
using System.Text;
// Account.cs
namespace PersonalMovieTracker.BusinessLogic
{
    public class Account
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public int Balance { get; set; } = 500;
        public List<string> Movies { get; set; } = new List<string>();
    }
}