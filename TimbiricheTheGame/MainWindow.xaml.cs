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

namespace TimbiricheTheGame
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void changeLanguage()
        {
            String language = "es";
            if (lbLanguage.Content.Equals("Español"))
            {
                language = "en";
            }

            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
            MainWindow newWindow = new MainWindow();
            if (language.Equals("en"))
            {
                newWindow.lbLanguage.Content = "English";
            }
            this.Close();
            newWindow.Show();
        }

        private void onClickChangeLanguage(object sender, MouseButtonEventArgs e)
        {
            changeLanguage();
        }

    }
}
