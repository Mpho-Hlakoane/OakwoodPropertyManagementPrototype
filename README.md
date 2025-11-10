Oakwood Property Management Prototype
Project Overview

The Oakwood Property Management Prototype is a Blazor WebAssembly application designed to streamline operations for Oakwood Property Management, a family-owned rental property business. The system addresses key challenges identified in the business case, including:

⦁	Tenant and lease management
⦁	Digital rent collection
⦁	Maintenance request tracking
⦁	Vacancy and rental application management

This prototype demonstrates a fully functional, interactive front-end using seed data, providing a realistic simulation of core system operations without requiring a back-end database.


Key Features

1.	Tenant Dashboard

⦁	Displays tenant details, leased unit, lease duration, and outstanding rent.
⦁	Shows a list of maintenance requests submitted by the tenant.
⦁	Provides navigation to payment and maintenance pages.

1.	Make Payment Page

⦁	Allows tenants to pay rent digitally in South African Rand (R).
⦁	Supports multiple payment methods (Credit Card, Bank Transfer, PayPal).
⦁	Generates a payment receipt with amount, date, and receipt number.

1.	Maintenance Request Page

⦁	Enables tenants to submit maintenance requests with priority selection.
⦁	Displays all submitted requests and their current status.

1.	Vacant Units Page

⦁	Lists all available rental units with details (unit ID, property name, status).
⦁	Allows prospective tenants to submit rental applications.

1.	Admin Dashboard 

⦁	Summarizes total rent collected, occupancy rate, and pending maintenance requests.
⦁	Provides a management overview of all tenant and maintenance data.


Technology Used
⦁	Framework: .NET 8 / Blazor WebAssembly
⦁	Language: C#
⦁	Frontend: Razor Components, Bootstrap 5
⦁	Data Simulation: SeedData class for models (Tenant, Lease, Payment, MaintenanceRequest, VacantUnit)
⦁	IDE: Visual Studio 2022


Installation & Set Up
1.	Clone or download the repository.
2.	Open the solution file OakwoodPropertyManagementPrototype.sln in Visual Studio 2022.
3.	Restore NuGet packages if prompted.
4.	Build the solution to ensure all dependencies are resolved.
5.	Set the project as the startup project.
6.	Run the application using Ctrl + F5 (Run without debugging).
