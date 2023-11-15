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
    /// Interaction logic for FormAdmin.xaml
    /// </summary>
    public partial class FormAdmin : Window
    {
        public FormAdmin()
        {
            InitializeComponent();
        }
        private void Form_Loaded(object sender, RoutedEventArgs e)
        {
            this.Current_username.Content = ((App)Application.Current).currentUser.Name;
        }
    }
}
