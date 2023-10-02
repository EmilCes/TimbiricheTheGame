using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
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
using TimbiricheTheGame.Servidor;

namespace TimbiricheTheGame
{
    /// <summary>
    /// Lógica de interacción para UserForm.xaml
    /// </summary>
    public partial class UserForm : Window
    {
        public UserForm(String language)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
            InitializeComponent();

        }

        private void btnCreateAccount_Click(object sender, RoutedEventArgs e)
        {
            DateTime birthdate;
            DateTime.TryParse(tbxBirthdate.Text, out birthdate);
            Account newAccount = new Account()
            {
                Name = tbxName.Text,
                LastName = tbxLastName.Text,
                Surname = tbxSurname.Text,
                Birthdate = birthdate
            };

            Player newPlayer = new Player()
            {
                Username = tbxUsername.Text,
                Email = tbxEmail.Text,
                Password = pwBxPassword.Password.ToString(),
                AccountFK = newAccount

            };

            Servidor.UserManagerClient cliente = new Servidor.UserManagerClient();
            _ = cliente.AddUser(newAccount, newPlayer);
        
        }
    }
}
