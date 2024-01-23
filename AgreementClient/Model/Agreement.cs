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
    }
}
