using AgreementClient.ViewModel;
using System;

namespace AgreementClient.Model
{
    public class AgreementDPO
    {
        public int Id { get; set; }
        public string Person { get; set; }
        public String Type { get; set; }
        public String Status { get; set; }
        public int Number { get; set; }
        public DateTime DataOpen { get; set; }
        public DateTime DataClose { get; set; }
        public AgreementDPO() { }
        public AgreementDPO(int id, string person, String type,
            String status, int number, DateTime dataOpen, DateTime dataClose)
        {
            Id = id;
            Person = person;
            Type = type;
            Status = status;
            Number = number;
            DataOpen = dataOpen;
            DataClose = dataClose;
        }

        public AgreementDPO CopyFromAgreement(Agreement agreement)
        {
            AgreementDPO agDPO = new();

            PersonViewModel vmPerson = new();
            TypeAgreementViewModel vmTypeAgreement = new();
            StatusAgreementViewModel vmStatusAgreement = new();

            string inn = string.Empty;
            string typeAgreement = string.Empty;
            string statusAgreement = string.Empty;

            foreach (var p in vmPerson.Persons)
            {
                if (p.Id == agreement.PersonID)
                {
                    inn = p.Inn;
                    break;
                }
            }

            foreach (var ta in vmTypeAgreement.TypeAgreements)
            {
                if (ta.Id == agreement.TypeID)
                {
                    typeAgreement = ta.Type;
                    break;
                }
            }

            foreach (var sa in vmStatusAgreement.StatusAgreements)
            {
                if (sa.Id == agreement.StatusID)
                {
                    statusAgreement = sa.Status;
                    break;
                }
            }
            if ((inn != string.Empty) &&
                (typeAgreement != string.Empty) &&
                (statusAgreement != string.Empty))
            {
                agDPO.Id = agreement.Id;
                agDPO.Person = inn;
                agDPO.Type = typeAgreement;
                agDPO.Status = statusAgreement;
                agDPO.Number = agreement.Number;
                agDPO.DataOpen = agreement.DataOpen;
                agDPO.DataClose = agreement.DataClose;
            }
            return agDPO;
        }

        public AgreementDPO ShallowCopy()
        {
            return (AgreementDPO)this.MemberwiseClone();
        }
    }
}
