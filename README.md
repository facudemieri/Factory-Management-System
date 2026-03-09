# Factory Management System

Desktop application developed in **C# (.NET WinForms)** with **SQL Server** for managing the main operations of a manufacturing company.

The system allows managing **clients, suppliers, purchases, sales, orders and production**, integrating business logic with a relational database using stored procedures.

The project follows a **layered architecture**, separating the user interface, business logic and data access to improve maintainability and organization.

---

## System Modules

The system includes the following management modules:

### Clients

* Register and manage client information
* Used for sales and order management

### Suppliers

* Register suppliers
* Manage supplier-related purchases

### Purchases

* Register purchases from suppliers
* List purchases by supplier
* Mark purchases as paid
* Prevent duplicate payments

### Sales

* Register sales to clients
* Manage sales transactions and records

### Orders

* Manage customer orders
* Track order information and status

### Production

* Manage production processes
* Associate production with orders

---

## Technologies

* **C#**
* **.NET WinForms**
* **SQL Server**
* **ADO.NET**
* **Stored Procedures**
* **Git**

---

## Project Architecture

The project is organized using a layered architecture:

BE (Business Entities)
Contains the domain classes used throughout the system.

BLL (Business Logic Layer)
Implements business rules and coordinates system operations.

DAL (Data Access Layer)
Handles database communication and execution of SQL queries and stored procedures.

GUI (Graphical User Interface)
Windows Forms interface used by the user to interact with the system.

---


## Database

The SQL script used to create the database structure is included in:

```
database/FabricaZapatos.sql
```

The script contains:

* Table creation
* Relationships between entities
* Stored procedures

---

## Example Stored Procedure

```sql
ALTER PROCEDURE ListarComprasPorProveedor
    @idProveedor INT
AS
BEGIN
    SELECT 
        idCompra,
        Fecha,
        Total,
        Pagado,
        Comprobante
    FROM TB_Compra
    WHERE idProveedor = @idProveedor
END
```
---

## How to Run

1. Clone the repository
2. Open the solution in **Visual Studio**
3. Execute the SQL script `FabricaZapatos.sql` in **SQL Server**
4. Configure the database connection string if necessary
5. Build and run the project

---

## Author

Facundo De Mieri
Engineering in Information Systems
