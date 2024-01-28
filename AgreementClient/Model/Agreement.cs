using AgreementClient.ViewModel;
using System;


namespace AgreementClient.Model
{
    public class Agreement
    {
        public int Id { get; set; }
        public int PersonID { get; set; }
        public int TypeID { get; set; }
        public int StatusID { get; set; }
        public int Number { get; set; }
        public DateTime DataOpen { get; set; }
        public DateTime DataClose { get; set; }
        public Agreement() { }
        public Agreement(int id, int personId, int typeId,
            int statusId, int number, DateTime dataOpen, DateTime dataClose)
        {
            Id = id;
            PersonID = personId;
            TypeID = typeId;
            StatusID = statusId;
            Number = number;
            DataOpen = dataOpen;
            DataClose = dataClose;
        }

        public Agreement CopyFromAgreementDPO(AgreementDPO ag)
        {
            PersonViewModel vmPerson = new();
            TypeAgreementViewModel vmTypeAgreement = new();
            StatusAgreementViewModel vmStatusAgreement = new();

            int personId = 0;
            int typeAgreementId = 0;
            int statusAgreementId = 0;

            foreach (var p in vmPerson.Persons)
            {
                if (p.Inn == ag.Person)
                {
                    personId = p.Id;
                    break;
                }
            }

            foreach (var ta in vmTypeAgreement.TypeAgreements)
            {
                if (ta.Type == ag.Type)
                {
                    typeAgreementId = ta.Id;
                    break;
                }
            }

            foreach (var sa in vmStatusAgreement.StatusAgreements)
            {
                if (sa.Status == ag.Status)
                {
                    statusAgreementId = sa.Id;
                    break;
                }
            }
            if ((personId != 0) && (typeAgreementId != 0) && (statusAgreementId != 0))
            {
                Id = ag.Id;
                PersonID = personId;
                TypeID = typeAgreementId;
                StatusID = statusAgreementId;
                Number = ag.Number;
                DataOpen = ag.DataOpen;
                DataClose = ag.DataClose;
            }
            return this;
        }
    }



}
