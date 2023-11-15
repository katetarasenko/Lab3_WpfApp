﻿using Lab3_WpfApp.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab3_WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Lab3_WpfApp.LoginForm().Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Lab3_WpfApp.SignUp().Show();
            this.Close();

        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            MainViewModel viewModel = (MainViewModel)DataContext;
            viewModel.NumberOfObjects = ((App)Application.Current).mydb.userRecords.Count;
        }
    }
}
