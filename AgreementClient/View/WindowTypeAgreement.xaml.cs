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
        private readonly TypeAgreementViewModel vmTypeAgreement = new();
        public WindowTypeAgreement()
        {
            InitializeComponent();
           
            lvTypeAgreement.ItemsSource = vmTypeAgreement.TypeAgreements;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewTypeAgreement wnTypeAgreement = new()
            {
                Title = "Новый тип",
                Owner = this
            };

            
            int maxIdTypeAgreement = vmTypeAgreement.MaxId() + 1;
            TypeAgreement typeAgreement = new()
            {
                Id = maxIdTypeAgreement
            };
            wnTypeAgreement.DataContext = typeAgreement;
            if (wnTypeAgreement.ShowDialog() == true)
            {
                vmTypeAgreement.TypeAgreements.Add(typeAgreement);
            }

        }

        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            
            WindowNewTypeAgreement wnTypeAgreement = new()
            {
                Title = "Редактирование типа договора",
                Owner = this
            };
            if (lvTypeAgreement.SelectedItem is TypeAgreement typeAgreement)

            {
                TypeAgreement tempTypeAgreement = typeAgreement.ShallowCopy();
                wnTypeAgreement.DataContext = tempTypeAgreement;

                if (wnTypeAgreement.ShowDialog() == true)
                {
                    // сохранение данных
                    typeAgreement.Type = tempTypeAgreement.Type;
                    lvTypeAgreement.ItemsSource = null;
                    lvTypeAgreement.ItemsSource = vmTypeAgreement.TypeAgreements;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать тип для редактированния",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            
            TypeAgreement typeAgreement = (TypeAgreement)lvTypeAgreement.SelectedItem;
            if (typeAgreement != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные по типу договора: " +
                typeAgreement.Type, "Предупреждение", MessageBoxButton.OKCancel,
                MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    vmTypeAgreement.TypeAgreements.Remove(typeAgreement);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать тип для удаления",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


    }
}
