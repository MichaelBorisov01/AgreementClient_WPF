using AgreementClient.Model;
using AgreementClient.ViewModel;
using System.Windows;


namespace AgreementClient.View
{
    /// <summary>
    /// Interaction logic for WindowTypeAgreement.xaml
    /// </summary>
    public partial class WindowTypeAgreement : Window
    {
        public WindowTypeAgreement()
        {
            InitializeComponent();
            TypeAgreementViewModel vmTypeAgreement = new();
            lvTypeAgreement.ItemsSource = vmTypeAgreement.TypeAgreements;
        }
    }
}
