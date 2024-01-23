using System;


namespace AgreementClient.Model
{
    enum AgreementType
    {
        Dealer,
        Brokerage,
        Management
    }

    internal class TypeAgreement
    {
        public int Id { get; set; }
        public AgreementType Type { get; set; }
         
        public TypeAgreement() { }
        public TypeAgreement(int id, AgreementType type)
        {
            Id = id;
            Type = type;
        }
    }
}