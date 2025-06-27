# 🧑‍💼 Role-Based Task Manager

A secure task management system with role-based access control built using **.NET 8 Web API**, **JWT Authentication**, **EF Core**, and **SQL Server**. Designed to showcase clean architecture, modular design, and readiness for real-world enterprise development.

---

## 📌 Features

- ✅ User Registration & Login (JWT Token Auth)
- ✅ Role-based task access: Admin, Manager, Employee
- ✅ CRUD operations on Tasks
- ✅ Secure APIs with policy-based authorization
- ✅ Clean architecture with separation of concerns
- ✅ Unit Testing Setup
- 🚀 (Planned) React/Razor UI, Email Notifications, Audit Logs, Azure Deployment

---

## 🧱 Tech Stack

| Layer      | Tech                        |
|------------|-----------------------------|
| Backend    | .NET 8, Web API, C#         |
| Auth       | JWT Bearer Token            |
| Database   | SQL Server, EF Core         |
| CI/CD      | GitHub Actions (Planned)    |
| Deployment | Azure App Service (Planned) |

---

## 🏗️ Architecture

```plaintext
┌────────────┐
│   Client   │
└────┬───────┘
     │
┌────▼──────┐
│  Web API  │ ← JWT Auth, Controllers
└────┬──────┘
     │
┌────▼────────┐
│ Application │ ← Interfaces, DTOs, UseCases
└────┬────────┘
     │
┌────▼──────┐
│  Domain   │ ← Entities, Enums, Core Logic
└────┬──────┘
     │
┌────▼────────────┐
│ Infrastructure  │ ← DB Context, EF Config
└─────────────────┘
