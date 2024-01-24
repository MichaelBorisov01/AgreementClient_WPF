using AgreementClient.Model;

namespace AgreementClient.Helper
{
    internal class FindTypeAgreement(int id)
    {
        readonly int id = id;

        public bool TypeAgreementPredicate(TypeAgreement typeAgreement)
        {
            return typeAgreement.Id == id;
        }

    }
}
