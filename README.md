# DVLD (Driving License Management System)

A **C# .NET WinForms application** for managing driving licenses and related services.  
This project was developed between **May – July 2025** as part of a learning journey to practice **database integration, and layered architecture (3-tier design)**.  

The system simulates the operations of a **Driving & Vehicle License Department (DVLD)**, ensuring proper management of licenses, applicants, and services.

---

## 🚀 Features

### License Services
- **New License Issuance** (first-time license requests by category).
- **Re-Examination Service** (retaking failed vision, theory, or practical tests).
- **License Renewal** (including validation of expired licenses).
- **Replacement Services**:
  - Lost License  
  - Damaged License
- **License Unlocking** (release of detained/blocked licenses).
- **International License Issuance** (for holders of valid category 3 licenses).

### License Categories
The system supports multiple license categories with age requirements, fees, and validity periods:
1. Motorcycles (small)  
2. Motorcycles (heavy)  
3. Regular car license  
4. Commercial (taxi/limousine)  
5. Agricultural vehicles  
6. Small/medium buses  
7. Trucks & heavy vehicles  

### Applicant Management
- Unique applicant records (no duplication by national ID).  
- Stores full personal details (name, DOB, nationality, contact info, photo).  
- Ability to add, update, search, or delete applicants.  

### Request Management
- Tracks service requests (applications).  
- Prevents duplicate or incomplete applications for the same service.  
- Supports filtering and searching by request ID or applicant national ID.  

### Examination Management
- **Vision Test** (mandatory first step).  
- **Theory Test** (traffic laws, paper-based with system results entry).  
- **Practical Driving Test** (on-road).  
- Tracks results, fees, scheduling, and retakes.  

### System Administration
- User management (basic: add, update, delete, freeze).  
- Audit trail of operations (records who performed each action and when).  

---

## 🏗️ Architecture

This project follows a **3-Tier Architecture**:

- **Presentation Layer (WinForms GUI)** – User interface built with C#.  
- **Business Logic Layer (BLL)** – Handles business rules, validations, and workflows.  
- **Data Access Layer (DAL)** – Responsible for database communication via ADO.NET.  

---

## 📂 Project Structure
- **│__ DVLD** : Presentation Layer (WinForms Forms, UI)
- **│__ DVLD_BLL** : Business Logic Layer
- **│__ DVLD_DAL** : Data Access Layer

---

## ⚙️ Technologies Used

- **C# .NET (WinForms)** – Desktop application development  
- **SQL Server** – Database backend  
- **ADO.NET** – Data access and queries  

---

## 📸 Screenshots (Optional)

![Screenshot 1](Screenshots/Screenshot%202025-09-27%20154249.png)
![Screenshot 2](Screenshots/Screenshot%202025-09-27%20154327.png)
![Screenshot 3](Screenshots/Screenshot%202025-09-27%20154454.png)
![Screenshot 4](Screenshots/Screenshot%202025-09-27%20154519.png)
![Screenshot 5](Screenshots/Screenshot%202025-09-27%20154554.png)
![Screenshot 6](Screenshots/Screenshot%202025-09-27%20154621.png)
![Screenshot 7](Screenshots/Screenshot%202025-09-27%20154703.png)

---

## 📜 License

This project is for **educational purposes** and is based on the requirements from **ProgrammingAdvices.com DVLD Project**.  
