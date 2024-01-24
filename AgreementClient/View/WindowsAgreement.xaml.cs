using AgreementClient.Helper;
using AgreementClient.Model;
using AgreementClient.ViewModel;
using System.Collections.ObjectModel;
using System.Windows;

namespace AgreementClient.View
{
    /// <summary>
    /// Interaction logic for WindowsAgreement.xaml
    /// </summary>
    public partial class WindowsAgreement : Window
    {
        public WindowsAgreement()
        {
            InitializeComponent();
            AgreementViewModel vmAgreement = new();

            PersonViewModel vmPerson = new();
            StatusAgreementViewModel vmStatusAgreement = new();
            TypeAgreementViewModel vmTypeAgreement = new();

            List<Person> persons = [];
            List<StatusAgreement> statusAgreements = [];
            List<TypeAgreement> typeAgreements = [];

            foreach (Person p in vmPerson.Persons)
            {
                persons.Add(p);
            }

            foreach (StatusAgreement sa in vmStatusAgreement.StatusAgreements)
            {
                statusAgreements.Add(sa);
            }

            foreach (TypeAgreement ta in vmTypeAgreement.TypeAgreements)
            {
                typeAgreements.Add(ta);
            }

            ObservableCollection<AgreementDPO> agreements = [];

            FindPerson finderP;
            FindStatusAgreement finderSA;
            FindTypeAgreement finderTA;

            foreach (var a in vmAgreement.Agreements)
            {
                finderP = new FindPerson(a.PersonID);
                finderSA = new FindStatusAgreement(a.TypeID);
                finderTA = new FindTypeAgreement(a.StatusID);

                Person per = persons.Find(new Predicate<Person>(finderP.PersonPredicate));
                StatusAgreement sa = statusAgreements.Find(new Predicate<StatusAgreement>(finderSA.StatusAgreementPredicate));
                TypeAgreement ta = typeAgreements.Find(new Predicate<TypeAgreement>(finderTA.TypeAgreementPredicate));

                agreements.Add(new AgreementDPO
                {

                    Id = a.Id,
                    Person = per.Inn,
                    Type = ta.Type,
                    Status = sa.Status,
                    Number = a.Number,
                    DataOpen = a.DataOpen,
                    DataClose = a.DataClose
                });
            }

            lvAgreement.ItemsSource = agreements;
        }
    }
}
