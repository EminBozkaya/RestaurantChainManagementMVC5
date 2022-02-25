using Core.Model;

namespace RCM.Model.Domain
{
    public class AdressOfCustomer : BaseDomain
    {
        
        public int Id { get; set; }
        public int CId { get; set; }
        public string AdressName { get; set; }
        public string Adress { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
