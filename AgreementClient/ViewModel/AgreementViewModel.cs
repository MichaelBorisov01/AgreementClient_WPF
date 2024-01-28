using System;
using System.Collections.ObjectModel;
using AgreementClient.Model;

namespace AgreementClient.ViewModel
{
    public class AgreementViewModel
    {
        public ObservableCollection<Agreement> Agreements { get; set; } =
            [];
        public AgreementViewModel()
        {
            Agreements.Add(
            new Agreement
            {
                Id = 1,
                PersonID = 1,
                TypeID = 1,
                StatusID = 1,
                Number = 1,
                DataOpen = new DateTime(1981, 03, 20),
                DataClose = new DateTime(1983, 03, 20)
            });
            Agreements.Add(
            new Agreement
            {
                Id = 2,
                PersonID = 2,
                TypeID = 2,
                StatusID = 2,
                Number = 2,
                DataOpen = new DateTime(1983, 03, 20),
                DataClose = new DateTime(1984, 03, 20)
            });
            Agreements.Add(
            new Agreement
            {
                Id = 3,
                PersonID = 3,
                TypeID = 3,
                StatusID = 3,
                Number = 3,
                DataOpen = new DateTime(1984, 03, 20),
                DataClose = new DateTime(1985, 03, 20)
            });
            Agreements.Add(
            new Agreement
            {
                Id = 4,
                PersonID = 4,
                TypeID = 4,
                StatusID = 4,
                Number = 4,
                DataOpen = new DateTime(1985, 03, 20),
                DataClose = new DateTime(1986, 03, 20)
            });
        }

        public int MaxId()
        {
            int max = 0;
            foreach (var ag in this.Agreements)
            {
                if (max < ag.Id)
                {
                    max = ag.Id;
                };
            }
            return max;
        }
    }
}
