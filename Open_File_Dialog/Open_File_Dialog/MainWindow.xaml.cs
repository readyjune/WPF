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
using Microsoft.Win32;

namespace Open_File_Dialog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFire_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "C# Source Files | *.cs"; //only show cs file.
            fileDialog.InitialDirectory = "C:\\temp";
            fileDialog.Title = "Please pick a CS Source file(s)...";
            fileDialog.Multiselect = true;

            bool? success = fileDialog.ShowDialog();
            if(success == true)
            {
                string[] path = fileDialog.FileNames;
                string[] fileName = fileDialog.SafeFileNames;

                //tbInfo.Text = fileName;
            }
            else
            {

            }
        }
    }
}
