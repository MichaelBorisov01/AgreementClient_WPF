using AgreementClient.Model;

namespace AgreementClient.Helper
{
    internal class FindStatusAgreement(int id)
    {
        readonly int id = id;

        public bool StatusAgreementPredicate(StatusAgreement statusAgreement)
        {
            return statusAgreement.Id == id;
        }

    }
}
