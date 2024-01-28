using AgreementClient.Model;

namespace AgreementClient.Helper
{
    internal class FindAgreement(int id)
    {
        readonly int id = id;

        public bool AgreementPredicate(Agreement agreement)
        {
            return agreement.Id == id;
        }
    }
}
