using System;
 

namespace AgreementClient.Model
{
    
    internal class Person
    {
        public int Id { get; set; }
        public string Inn { get; set; }
        public String Type { get; set; }
        public string Shifer { get; set; }
        public DateTime Data { get; set; }

        public Person() { }

        public Person(int id, string inn, String type, string shifer, 
            DateTime data)
        {
            Id = id;
            Inn = inn;
            Type = type;
            Shifer = shifer;
            Data = data;
        }
    }
}


