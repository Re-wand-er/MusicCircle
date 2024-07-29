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
using System.Windows.Shapes;

namespace MusicCircle.Settings
{
    /// <summary>
    /// Логика взаимодействия для QuintoCircleSettingsWindow.xaml
    /// </summary>
    public partial class QuintoCircleSettingsWindow : Window
    {
        //SettingsViewModel viewModel;
        public QuintoCircleSettingsWindow()
        {
            InitializeComponent();
            ListBoxOfSettings.ItemsSource = new List<string>() { "None","Ask"};
        }
    }
}
