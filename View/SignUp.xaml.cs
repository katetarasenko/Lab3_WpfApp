using Lab3_WpfApp.ViewModel;
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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
            lbRoles.Items.Add("admin");
            lbRoles.Items.Add("student");
            lbRoles.Items.Add("teacher");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserData newuser = new UserData(this.tbName.Text, this.tbPassw.Text, this.lbRoles.SelectedItem as string);
            UserDatabase db = ((App)Application.Current).mydb;
            db.AddUserRecord(newuser);

            new Lab3_WpfApp.MainWindow().Show();
            this.Close();
        }
    }
}
