using AgreementClient.Helper;
using AgreementClient.Model;
using AgreementClient.ViewModel;
using System.Collections.ObjectModel;
using System.Data;
using System.Windows;

namespace AgreementClient.View
{
    /// <summary>
    /// Interaction logic for WindowsAgreement.xaml
    /// </summary>
    public partial class WindowsAgreement : Window
    {

        private readonly AgreementViewModel vmAgreement;

        private readonly PersonViewModel vmPerson;
        private readonly TypeAgreementViewModel vmTypeAgreement;
        private readonly StatusAgreementViewModel vmStatusAgreement;

        private readonly ObservableCollection<AgreementDPO> agreementDPO;

        private readonly List<Person> persons;
        private readonly List<TypeAgreement> typeAgreements;
        private readonly List<StatusAgreement> statusAgreements;

        public WindowsAgreement()
        {
            InitializeComponent();

            vmAgreement = new AgreementViewModel();

            vmPerson = new PersonViewModel();
            persons = [.. vmPerson.Persons];

            vmStatusAgreement = new StatusAgreementViewModel();
            statusAgreements = [.. vmStatusAgreement.StatusAgreements];

            vmTypeAgreement = new TypeAgreementViewModel();
            typeAgreements = [.. vmTypeAgreement.TypeAgreements];

            agreementDPO = [];

            foreach (var agreement in vmAgreement.Agreements)
            {
                AgreementDPO ag = new();
                ag = ag.CopyFromAgreement(agreement);
                agreementDPO.Add(ag);
            }

            lvAgreement.ItemsSource = agreementDPO;
        }


        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewAgreement wnAgreement = new()
            {
                Title = "Новый договор",
                Owner = this
            };

            int maxIdAgreement = vmAgreement.MaxId() + 1;
            AgreementDPO agr = new()
            {
                Id = maxIdAgreement,
            };
            wnAgreement.DataContext = agr;

            //wnAgreement.TbPerson = persons;
            wnAgreement.CbType.ItemsSource = typeAgreements;
            wnAgreement.CbStatus.ItemsSource = statusAgreements;

            if (wnAgreement.ShowDialog() == true)
            {
                TypeAgreement ta = (TypeAgreement)wnAgreement.CbType.SelectedValue;
                agr.Type = ta.Type;
                agreementDPO.Add(agr);

                StatusAgreement sa = (StatusAgreement)wnAgreement.CbStatus.SelectedValue;
                agr.Status = sa.Status;
                agreementDPO.Add(agr);

                Agreement ag = new();
                ag = ag.CopyFromAgreementDPO(agr);
                vmAgreement.Agreements.Add(ag);
            }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowNewAgreement wnAgreement = new()
            {
                Title = "Редактирование данных",
                Owner = this
            };
            AgreementDPO agrDPO = (AgreementDPO)lvAgreement.SelectedValue;
            AgreementDPO tempAgrDPO; // временный класс для редактирования
            if (agrDPO != null)
            {
                tempAgrDPO = agrDPO.ShallowCopy();
                wnAgreement.DataContext = tempAgrDPO;

                wnAgreement.CbType.ItemsSource = typeAgreements;
                wnAgreement.CbType.Text = tempAgrDPO.Type;

                wnAgreement.CbStatus.ItemsSource = typeAgreements;
                wnAgreement.CbStatus.Text = tempAgrDPO.Status;

                if (wnAgreement.ShowDialog() == true)
                {
                    // перенос данных из временного класса в класс отображения данных
                    TypeAgreement ta = (TypeAgreement)wnAgreement.CbType.SelectedValue;
                    StatusAgreement sa = (StatusAgreement)wnAgreement.CbStatus.SelectedValue;

                    agrDPO.Id = tempAgrDPO.Id;
                    agrDPO.Person = tempAgrDPO.Person;
                    agrDPO.Type = ta.Type;
                    agrDPO.Status = sa.Status;
                    agrDPO.Number = tempAgrDPO.Number;
                    agrDPO.DataOpen = tempAgrDPO.DataOpen;
                    agrDPO.DataClose = tempAgrDPO.DataClose;

                    lvAgreement.ItemsSource = null;
                    lvAgreement.ItemsSource = agreementDPO;

                    FindAgreement finder = new(agrDPO.Id);
                    List<Agreement> Agreements = [.. vmAgreement.Agreements];
                    Agreement ag = Agreements.Find(new Predicate<Agreement>(finder.AgreementPredicate));
                    ag = ag.CopyFromAgreementDPO(agrDPO);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать договор для редактированния",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            AgreementDPO agreement = (AgreementDPO)lvAgreement.SelectedItem;
            if (agreement != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные по договору:" +
                    agreement.Number + " " + agreement.Type,

                "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    // удаление данных в списке отображения данных
                    agreementDPO.Remove(agreement);

                    Agreement agr = new();
                    agr = agr.CopyFromAgreementDPO(agreement);
                    vmAgreement.Agreements.Remove(agr);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать данные по договору для удаления",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }



    }



}
