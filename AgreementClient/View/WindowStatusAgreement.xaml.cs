using AgreementClient.ViewModel;
using System.Windows;

namespace AgreementClient.View
{
    /// <summary>
    /// Interaction logic for WindowStatusAgreement.xaml
    /// </summary>
    public partial class WindowStatusAgreement : Window
    {
        public WindowStatusAgreement()
        {
            InitializeComponent();
            StatusAgreementViewModel vmStatusAgreement = new();
            lvStatusAgreement.ItemsSource = vmStatusAgreement.StatusAgreements;
        }
    }
}
