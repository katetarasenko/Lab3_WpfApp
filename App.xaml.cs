using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Lab3_WpfApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public UserDatabase mydb { get; set; }
        public UserData currentUser { get; set; }

        // Constructor
        public App()
        {
            mydb = new Lab3_WpfApp.UserDatabase();
            UserData useradmin = new UserData("admin", "a", "admin");
            UserData usertest = new UserData("test", "t", "student");
            mydb.AddUserRecord(useradmin);
            mydb.AddUserRecord(usertest);
        }
        
    }
}
