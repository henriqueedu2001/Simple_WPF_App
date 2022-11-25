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
using WPF_TEST_APP.Models;

namespace WPF_TEST_APP
{
    /// <summary>
    /// Lógica interna para UserSpace.xaml
    /// </summary>
    public partial class UserSpace : Window
    {
        public UserSpace()
        {
            InitializeComponent();
            string welcome_text = $"Welcome, {CurrentUser.Name}!";
            WelcomeLabel.Content = welcome_text;
        }
    }
}
