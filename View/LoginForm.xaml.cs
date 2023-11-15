using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lab3_WpfApp
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        public LoginForm()
        {
            InitializeComponent();
        }

 
        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            string name = this.tbname.Text;
            string passw = this.tbpassw.Text;
            UserDatabase db = ((App)Application.Current).mydb;
            bool resultat = false;

            foreach (var user in db.userRecords)
            {
                if (user.Name == name & user.Password == passw)
                {
                    resultat = true;
                    ((App)Application.Current).currentUser = user;
                    switch (user.Role)
                    {
                        case "admin":
                            new Lab3_WpfApp.FormAdmin().Show();
                            break;
                        case "student":
                            new Lab3_WpfApp.View.FormStudent().Show();
                            break;
                        case "teacher":
                            new Lab3_WpfApp.View.FormTeacher().Show();
                            break;
                    }
                    this.Close();
                }

            }

            if (!resultat)
            {
                new Lab3_WpfApp.Msg_fail().Show();
            }

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
