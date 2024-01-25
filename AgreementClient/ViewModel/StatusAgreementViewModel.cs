using AgreementClient.Model;
using System.Collections.ObjectModel;
 

namespace AgreementClient.ViewModel
{
    internal class StatusAgreementViewModel
    {
        public ObservableCollection<StatusAgreement> StatusAgreements { get; set; } = [];
        public StatusAgreementViewModel()
        {
            StatusAgreements.Add(
            new StatusAgreement
            {
                Id = 1,
                Status = "Enable"

            });
            StatusAgreements.Add(
            new StatusAgreement
            {
                Id = 2,
                Status = "Enable"
            });
            StatusAgreements.Add(
            new StatusAgreement
            {
                Id = 3,
                Status = "Disable"
            });
            StatusAgreements.Add(
            new StatusAgreement
            {
                Id = 4,
                Status = "Enable"
            });
        }
    }
}
