namespace OakwoodPropertyManagementPrototype.Models
{
    public class MaintenanceRequest
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Priority { get; set; } = "";
        public string Status { get; set; } = "Pending"; 
        public DateTime DateSubmitted { get; set; } = DateTime.Now;
        public int TenantId { get; set; }
    }
}
