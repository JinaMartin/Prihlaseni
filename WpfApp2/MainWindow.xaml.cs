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

namespace WpfApp2
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool cislice = false;
            for (int i = 0; i < Heslo1.Text.Length; i++)
            {
                if (Char.IsDigit(Heslo1.Text[i]))
                    cislice = true;
            }
            if (((Heslo1.Text.Length >= 6) && (Heslo1.Text == Heslo2.Text) && (cislice == true)))
            {
                MessageBox.Show("Úspěšně jste zadal jméno a heslo. Pro ukončení aplikace stiskněte Ok", "Přihlášení");
                this.Close();
            }
            else
            {
                MessageBox.Show("Zadané heslo nesplňuje požadavky.", "Chyba");
                Heslo1.Text = "";
                Heslo2.Text = "";
            }
        }
    }
}
