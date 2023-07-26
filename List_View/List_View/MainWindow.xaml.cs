using System;
using System.Collections;
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

namespace List_View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lvEntries.Items.Add("a");
            lvEntries.Items.Add("b");
            lvEntries.Items.Add("c");
     
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Add(txtEntry.Text);
            txtEntry.Clear();

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //int index = lvEntries.SelectedIndex;
            // object item = lvEntries.SelectedItem;
            var items = lvEntries.SelectedItems;

            var result = MessageBox.Show($"Are you sure you want to delete: {items.Count}?", "Sure?", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {

                var itemsList = new ArrayList(items);

                foreach(var item in itemsList)
                {
                    lvEntries.Items.Remove(item);
                }
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            lvEntries.Items.Clear();
        }
    }
}
