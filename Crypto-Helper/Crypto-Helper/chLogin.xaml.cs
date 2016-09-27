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

namespace Crypto_Helper
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

        #region Moveable Form
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }
        #endregion

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

        #region Capital Textbox
        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            string text = txtUsername.Text;
        
            
            char c = text[text.Length - 1];

            string newText = txtUsername.Text + c;
            newText = newText.Substring(0, newText.Length - 1);
            txtUsername.Text = newText.ToUpper();
        }
        #endregion


        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
               
        }
    }
}
