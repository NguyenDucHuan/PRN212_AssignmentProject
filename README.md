# ☕ MilkTea Management POS (MilkTea Manager Cashier)

A **Windows POS (Point-of-Sale)** application for milk tea shops, supporting daily cashier operations such as managing products, orders, invoices, and customers.  
The project is organized with a clean multi-layer architecture (**UI / BLL / DAL**) and uses **SQL Server + Entity Framework Core** for data persistence.

## Features
- Product management (CRUD)
- Order / invoice processing
- Customer management
- User/account management (depending on implemented modules)
- Basic reporting/statistics (if available)

## Tech Stack
- **.NET 6**
- **WPF** (Windows Desktop UI)
- **Entity Framework Core**
- **SQL Server**
- Layered Architecture: **UI / BLL / DAL**

## Project Structure
- `MilkTeaManagementUI/` — WPF UI (presentation layer)
- `MilkTeaManagement.BLL/` — Business logic layer
- `MilkTeaManagement.DAL/` — Data access layer (EF Core)

## Getting Started
### Prerequisites
- Visual Studio 2022 (recommended)
- .NET SDK 6.x
- SQL Server (LocalDB or SQL Server instance)

### Setup
1. Clone repository:
   ```bash
   git clone https://github.com/NguyenDucHuan/MilkTeaManagementPos.git
