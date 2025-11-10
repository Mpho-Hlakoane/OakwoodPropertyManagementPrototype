using OakwoodPropertyManagementPrototype.Components.Pages;

namespace OakwoodPropertyManagementPrototype.Models
{
    public class Tenant
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public List<Lease> Leases { get; set; } = new();
        public List<Payment> Payments { get; set; } = new();
        public List<MaintenanceRequest> Requests { get; set; } = new();
    }
}
