using AgreementClient.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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
                Type = "Dealer"

            });
            TypeAgreements.Add(
            new TypeAgreement
            {
                Id = 2,
                Type =  "Brokerage"
            });
            TypeAgreements.Add(
            new TypeAgreement
            {
                Id = 3,
                Type = "Brokerage"
            });
            TypeAgreements.Add(
            new TypeAgreement
            {
                Id = 4,
                Type = "Management"
            });
        }

        public int MaxId()
        {
            int max = 0;
            foreach (var ta in this.TypeAgreements)
            {
                if (max < ta.Id)
                {
                    max = ta.Id;
                };
            }
            return max;
        }
    }
}
