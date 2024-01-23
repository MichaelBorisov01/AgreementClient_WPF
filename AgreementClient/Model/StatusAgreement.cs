using System;

namespace AgreementClient.Model
{
    enum StatusAgreementType
    {
        Enable, 
        Disable
    }

    internal class StatusAgreement
    {
        public int Id { get; set; }
        public StatusAgreementType Status { get; set; }
        
        public StatusAgreement() { }
        public StatusAgreement(int id, StatusAgreementType status)
        {
            Id = id;
            Status = status;
            
        }
    }
}
