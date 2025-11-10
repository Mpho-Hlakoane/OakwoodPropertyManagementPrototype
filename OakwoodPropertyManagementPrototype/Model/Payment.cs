namespace OakwoodPropertyManagementPrototype.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int TenantId { get; set; } 
        public decimal Amount { get; set; }
        public DateTime DatePaid { get; set; } = DateTime.Now;
        public string Method { get; set; } = ""; 
    }
}
