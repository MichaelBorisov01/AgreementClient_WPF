using AgreementClient.View;
using System.Windows;

namespace AgreementClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static int IdTypeAgreement { get; set; }
        public static int IdAgreement { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Person_OnClick(object sender, RoutedEventArgs e)
        {
            WindowPerson wPerson = new();
            wPerson.Show();
        }
        private void Agreement_OnClick(object sender, RoutedEventArgs e)
        {
            WindowsAgreement wAgreement = new();
            wAgreement.Show();
        }

        private void TypeAgreement_OnClick(object sender, RoutedEventArgs e)
        {
            WindowTypeAgreement wPersoTypeAgreement = new();
            wPersoTypeAgreement.Show();
        }

        private void StatusAgreement_OnClick(object sender, RoutedEventArgs e)
        {
            WindowStatusAgreement wStatusAgreement = new();
            wStatusAgreement.Show();
        }
    }
}