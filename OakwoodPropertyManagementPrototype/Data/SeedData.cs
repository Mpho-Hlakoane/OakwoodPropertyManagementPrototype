using OakwoodPropertyManagementPrototype.Components.Pages;
using OakwoodPropertyManagementPrototype.Models;
using System;
using System.Collections.Generic;

namespace OakwoodPropertyManagementPrototype.Data
{
    public static class SeedData
    {
        public static List<Tenant> Tenants = new List<Tenant>
        {
            new Tenant { Id = 1, Name = "Jane Doe" },
            new Tenant { Id = 2, Name = "Mpho Hlakoane" },
            new Tenant { Id = 3, Name = "Forever Yena" }
        };

        public static List<Lease> Leases = new List<Lease>
        {
            new Lease { Id = 101, Unit = "Apartment 12B", StartDate = new DateTime(2025,1,1), EndDate = new DateTime(2025,12,31), RentAmount = 1200, TenantId = 1 },
            new Lease { Id = 102, Unit = "Apartment 15A", StartDate = new DateTime(2025,3,1), EndDate = new DateTime(2026,2,28), RentAmount = 1500, TenantId = 2 },
            new Lease { Id = 103, Unit = "Apartment 9C", StartDate = new DateTime(2025,6,15), EndDate = new DateTime(2026,6,14), RentAmount = 1300, TenantId = 3 }
        };

        public static List<Payment> Payments = new List<Payment>
        {
            new Payment { Id = 1, TenantId = 1, Amount = 1200, DatePaid = new DateTime(2025,11,10), Method = "Credit Card" },
            new Payment { Id = 2, TenantId = 2, Amount = 1500, DatePaid = new DateTime(2025,11,5), Method = "Bank Transfer" }
        };

        public static List<MaintenanceRequest> MaintenanceRequests = new List<MaintenanceRequest>
        {
            new MaintenanceRequest { Id = 1, Title = "Leaking faucet", Description = "Leaking faucet in kitchen", Priority = "Medium", Status = "In Progress", DateSubmitted = new DateTime(2025,11,8), TenantId = 1 },
            new MaintenanceRequest { Id = 2, Title = "Broken window", Description = "Broken window in living room", Priority = "High", Status = "Completed", DateSubmitted = new DateTime(2025,11,2), TenantId = 1 },
            new MaintenanceRequest { Id = 3, Title = "AC not working", Description = "Air conditioner not working", Priority = "High", Status = "In Progress", DateSubmitted = new DateTime(2025,11,7), TenantId = 2 }
        };

        public static List<VacantUnit> VacantUnits = new List<VacantUnit>
        {
            new VacantUnit { UnitId = "12C", PropertyName = "Oakwood Heights", Size = "2 Bedroom", Status = "Vacant" },
            new VacantUnit { UnitId = "7A", PropertyName = "Maple Residences", Size = "1 Bedroom", Status = "Application Pending" },
            new VacantUnit { UnitId = "5D", PropertyName = "Oakwood Heights", Size = "3 Bedroom", Status = "Vacant" }
        };
    }
}
