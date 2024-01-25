using System;

namespace AgreementClient.Model
{
    
    internal class StatusAgreement
    {
        public int Id { get; set; }
        public String Status { get; set; }
        
        public StatusAgreement() { }
        public StatusAgreement(int id, String status)
        {
            Id = id;
            Status = status;
            
        }
    }
}
