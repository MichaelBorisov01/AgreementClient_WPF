using AgreementClient.Model;
using System.Collections.ObjectModel;
 


namespace AgreementClient.ViewModel
{
    internal class PersonViewModel
    {
        public ObservableCollection<Person> Persons { get; set; } = [];
        public PersonViewModel()
        {
            Persons.Add(
            new Person
            {
                Id = 1,
                Inn = "123456789789",
                Type = "Individual",
                Shifer = "sdfg4845-sdf4-sdfsd8",
                Data = new DateTime(2001, 03, 20)

            });
            Persons.Add(
            new Person
            {
                Id = 2,
                Inn = "321654987852",
                Type = "Individual",
                Shifer = "sdfg4845-sdf4-sdfsd8",
                Data = new DateTime(2002, 03, 20)
            });
            Persons.Add(
            new Person
            {
                Id = 3,
                Inn = "456987123357",
                Type = "LegalEntity",
                Shifer = "sdfg4845-sdf4-sdfsd8",
                Data = new DateTime(2003, 03, 20)
            });
            Persons.Add(
            new Person
            {
                Id = 4,
                Inn = "456951789528",
                Type = "Individual",
                Shifer = "sdfg4845-sdf4-sdfsd8",
                Data = new DateTime(2004, 03, 20)
            });
        }
    }
}
