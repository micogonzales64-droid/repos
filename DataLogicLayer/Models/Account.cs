using System.Collections.Generic;

namespace DataLogicLayer.Models
{
    public class Account
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
        public int Balance { get; set; } = 500;
        public List<string> Movies { get; set; } = new List<string>();
    }
}