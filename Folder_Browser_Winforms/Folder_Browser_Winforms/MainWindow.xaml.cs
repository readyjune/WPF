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
using System.Windows;
using WinForms = System.Windows.Forms;

namespace Folder_Browser_Winforms
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
            WinForms.FolderBrowserDialog dialog = new WinForms.FolderBrowserDialog();
            dialog.InitialDirectory = "C:\\Users\\kimjinwoo\\source\\repos\\Folder_Browser_Winforms\\Folder_Browser_Winforms";
            WinForms.DialogResult result = dialog.ShowDialog();

            if(result == WinForms.DialogResult.OK)
            {
                string folder = dialog.SelectedPath;
            }
           
        }
    }
}
