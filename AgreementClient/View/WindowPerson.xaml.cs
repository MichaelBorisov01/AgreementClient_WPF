using System.Windows;
using AgreementClient.ViewModel;

namespace AgreementClient.View
{
    /// <summary>
    /// Interaction logic for WindowPerson.xaml
    /// </summary>
    public partial class WindowPerson : Window
    {
        public WindowPerson()
        {
            InitializeComponent();

            PersonViewModel vmPerson = new();
            lvPerson.ItemsSource = vmPerson.Persons;
        }
    }
}
