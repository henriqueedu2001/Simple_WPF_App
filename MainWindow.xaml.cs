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
using WPF_TEST_APP.Models;

namespace WPF_TEST_APP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            User cleito = new User(new Guid(), "Cleito", "cleito2001", "123", "admin");
            Autentication.AddUser(cleito);
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            UserSpace userSpace;

            string name = UsernameInput.Text;
            string password = PasswordInput.Text;

            if(Autentication.AutenticateUser(name, password))
            {
                CurrentUser.Name = name;
                userSpace = new UserSpace();
                this.Close();
                userSpace.Show();
            } else
            {
                MessageBox.Show("Incorrect username or password");
            }
            
        }
    }
}
