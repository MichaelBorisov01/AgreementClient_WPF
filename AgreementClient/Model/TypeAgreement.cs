namespace AgreementClient.Model
{

    internal class TypeAgreement
    {
        public int Id { get; set; }
        public String Type { get; set; }
         
        public TypeAgreement() { }
        public TypeAgreement(int id, String type)
        {
            Id = id;
            Type = type;
        }

        public TypeAgreement ShallowCopy()
        {
            return (TypeAgreement)this.MemberwiseClone();
        }


    }
}