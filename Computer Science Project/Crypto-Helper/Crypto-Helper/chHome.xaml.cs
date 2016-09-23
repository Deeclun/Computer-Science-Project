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

namespace Crypto_Helper
{
    /// <summary>
    /// Interaction logic for chHome.xaml
    /// </summary>
    public partial class chHome : Window
    {
        public chHome()
        {
            InitializeComponent();
        }


        #region Close & Minimize
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Environment.Exit(1);
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        #endregion
    }
}
