using AgreementClient.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgreementClient.ViewModel
{
    internal class TypeAgreementViewModel
    {
        public ObservableCollection<TypeAgreement> TypeAgreements { get; set; } = [];
        public TypeAgreementViewModel()
        {
            TypeAgreements.Add(
            new TypeAgreement
            {
                Id = 1,
                Type = AgreementType.Dealer

            });
            TypeAgreements.Add(
            new TypeAgreement
            {
                Id = 2,
                Type = AgreementType.Brokerage
            });
            TypeAgreements.Add(
            new TypeAgreement
            {
                Id = 3,
                Type = AgreementType.Brokerage
            });
            TypeAgreements.Add(
            new TypeAgreement
            {
                Id = 4,
                Type = AgreementType.Management
            });
        }
    }
}
