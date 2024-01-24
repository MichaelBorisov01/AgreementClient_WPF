using AgreementClient.Model;

namespace AgreementClient.Helper
{
    internal class FindPerson(int id)
    {
        readonly int id = id;

        public bool PersonPredicate(Person person)
        {
            return person.Id == id;
        }

    }
}
