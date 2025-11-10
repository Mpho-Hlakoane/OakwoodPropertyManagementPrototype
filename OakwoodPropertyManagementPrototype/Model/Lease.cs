namespace OakwoodPropertyManagementPrototype.Models
{
    public class Lease
    {
        public int Id { get; set; }
        public string Unit { get; set; } = ""; 
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now.AddYears(1);
        public decimal RentAmount { get; set; } = 1200; 
        public int TenantId { get; set; } 
    }
}
