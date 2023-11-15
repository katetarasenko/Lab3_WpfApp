using Lab3_WpfApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_WpfApp
{
    public class UserData
    {
        // Properties
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        // Constructor
        public UserData(string name, string password, string role)
        {
            Name = name;
            Password = password;
            Role = role;
        }
    }
    public class UserDatabase
    {
        public List<UserData> userRecords;

        // Constructor
        public UserDatabase()
        {
            userRecords = new List<UserData>();
        }

        public void AddUserRecord(UserData user)
        {
            userRecords.Add(user);
        }
    }
    
}
