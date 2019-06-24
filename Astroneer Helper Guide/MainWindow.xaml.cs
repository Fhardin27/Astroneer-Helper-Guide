﻿using System;
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

namespace Astroneer_Helper_Guide
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //MainWindow: Initializes everything
        public MainWindow()
        {
            InitializeComponent();
        }

        //View_Planets_Click: Changes to the planets viewing screen
        private void View_Planets_Click(object sender, RoutedEventArgs e)
        {
            Home_Screen.Visibility = Visibility.Collapsed;
            Planets_Screen.Visibility = Visibility.Visible;
        }
         //
        private void Return_To_Home_Click(object sender, RoutedEventArgs e)
        {
            Planets_Screen.Visibility = Visibility.Collapsed;
            Astroneer_Screen.Visibility = Visibility.Collapsed;
            Backpack_Screen.Visibility = Visibility.Collapsed;
            Home_Screen.Visibility = Visibility.Visible;
        }

        private void View_Astroneer_Click(object sender, RoutedEventArgs e)
        {
            Home_Screen.Visibility = Visibility.Collapsed;
            Astroneer_Screen.Visibility = Visibility.Visible;
        }

        private void View_BackPack_Click(object sender, RoutedEventArgs e)
        {
            Home_Screen.Visibility = Visibility.Collapsed;
            Backpack_Screen.Visibility = Visibility.Visible;
        }
    }
}
