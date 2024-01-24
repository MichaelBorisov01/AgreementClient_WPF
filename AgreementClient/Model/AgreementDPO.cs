namespace AgreementClient.Model
{
    internal class AgreementDPO
    {
        public int Id { get; set; }
        public string Person { get; set; }
        public AgreementType Type { get; set; }
        public StatusAgreementType Status { get; set; }
        public int Number { get; set; }
        public DateTime DataOpen { get; set; }
        public DateTime DataClose { get; set; }
        public AgreementDPO() { }
        public AgreementDPO(int id, string person, AgreementType type,
            StatusAgreementType status, int number, DateTime dataOpen, DateTime dataClose)
        {
            Id = id;
            Person = person;
            Type = type;
            Status = status;
            Number = number;
            DataOpen = dataOpen;
            DataClose = dataClose;
        }
    }
}
