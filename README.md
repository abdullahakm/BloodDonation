# 🩸 Blood Donation API

This is a backend API for a Blood Donation Management System developed using **ASP.NET Core Web API** and following the principles of **Clean Architecture**. The purpose of this system is to streamline the process of blood donation, blood requests, and hospital API integrations in a secure, modular, and scalable way.

---

## 📚 Table of Contents

- [🩸 Blood Donation API](#-blood-donation-api)
  - [📚 Table of Contents](#-table-of-contents)
  - [✅ Project Overview](#-project-overview)
  - [🏗️ Architecture](#️-architecture)
  - [📁 Solution Structure](#-solution-structure)
  - [🧪 Technology Stack](#-technology-stack)
  - [🧬 Entities \& Enums](#-entities--enums)
    - [Enums:](#enums)
  - [🔁 User Flow](#-user-flow)
  - [🚀 Future Scope](#-future-scope)
  - [🛠️ Getting Started](#️-getting-started)
  - [🤝 Contributing](#-contributing)
  - [📄 License](#-license)

---

## ✅ Project Overview

The Blood Donation API enables users to:
- Register via mobile or web platforms.
- Donate or request blood.
- Automatically manage user roles based on actions.
- Provide controlled API access to hospitals or organizations after registration and payment.

---

## 🏗️ Architecture

This project is structured using **Clean Architecture** which separates concerns across layers:

- **Core** – Domain entities and enums.
- **Application** – Interfaces and business logic.
- **Infrastructure** – Data access and persistence logic.
- **Presentation** – The API entry point (currently under development).

---

## 📁 Solution Structure

```
BloodDonationApi.sln
├── Core
│   ├── Entities
│   └── Enums
├── Application
│   ├── Services
│   │   ├── PersonService
│   │   ├── HospitalService
│   │   ├── BloodBankService
│   │   ├── BloodTestService
│   │   └── CityService
│   └── Persistance
│       ├── PersonRepository
│       ├── HospitalRepository
│       ├── BloodBankRepository
│       ├── BloodTestRepository
│       ├── CityRepository
│       └── Data (ApplicationDbContext)
├── Infrastructure
│   └── (To be implemented)
└── Presentation
    └── (Empty for now)
```

---

## 🧪 Technology Stack

- **.NET 9 / ASP.NET Core Web API**
- **Entity Framework Core**
- **Clean Architecture**
- **C#**
- **SQL Server** (planned)

---

## 🧬 Entities & Enums

### Enums:
- `BloodGroup` – (A+, A−, B+, B−, AB+, AB−, O+, O−)
- `Province` – (Punjab, Sindh, KhyberPakhtunkhwa, Balochistan, GilgitBaltistan)
- `Role` – (SystemAdmin, SystemUser, SimpleUser, ClientUser)
- `TestType` – (HBsAg, HIV, VDRL, AntiHCV, BloodCellCount)

> You can find these in `Core/Enums/`.

---

## 🔁 User Flow

1. **Registration**:
   - User registers via app.
   - Assigned `SimpleUser` role by default.

2. **Home Page Options**:
   - **Donate Blood**: Marks `IsDonor = true` in `BloodBank` entity.
   - **Request Blood**: Marks `IsRequestee = true`.

3. **Admin Functionalities**:
   - One primary admin manages the system.
   - Admin can:
     - Create new `SystemUser`s.
     - Approve hospital integrations.

4. **Hospital Integration**:
   - Hospital registers in the system.
   - Upon payment, a `ClientUser` is created with limited endpoint access.

---

## 🚀 Future Scope

- Full **user authentication and authorization**
- JWT token support and role-based access control
- Admin dashboard (web)
- Integration with payment gateway
- Email/SMS notification system
- Hospital analytics dashboard
- Swagger/OpenAPI documentation
- Deployment to cloud (Azure/AWS)

---

## 🛠️ Getting Started

> Prerequisites:
- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

```bash
# Clone the repo
git clone https://github.com/your-username/BloodDonationApi.git

# Navigate to the presentation layer and run the API
cd Presentation
dotnet run
```

---

## 🤝 Contributing

We welcome contributions from the community. Please follow these steps:

1. Fork the repository
2. Create a new feature branch
3. Commit and push your code
4. Create a pull request

---

## 📄 License

This project is licensed under a proprietary license. All rights reserved.

Copyright (c) 2025 Dreams Solution.

This software is proprietary and confidential. Unauthorized copying, distribution, modification, or use of this software is strictly prohibited.

For licensing inquiries or commercial integration, please contact abdullahakm43@gmail.com .

> 🔨 Built with care by a passionate development team to save lives with code.
