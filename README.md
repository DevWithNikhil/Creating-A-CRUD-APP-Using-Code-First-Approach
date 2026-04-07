## 📌 Student CRUD App (ASP.NET Core + EF Core)

This is a simple CRUD (Create, Read, Update, Delete) application built using **ASP.NET Core MVC** and **Entity Framework Core (Code First approach)**.

The purpose of this project is to understand how basic database operations work in a real application.

---

## 🚀 Features

* Add new student
* View student list
* Edit student details
* Delete student
* Clean UI using Bootstrap
* Form validation

---

## 🛠️ Tech Stack

* ASP.NET Core MVC
* Entity Framework Core (Code First)
* SQL Server
* Razor Views
* Bootstrap

---

## 📂 Project Structure (Simple Overview)

* **Models** → Student class (Entity)
* **DbContext** → Database configuration
* **Controllers** → Handles CRUD operations
* **Views** → UI pages (Create, Edit, Details, Delete, Index)

---

## ⚙️ How It Works

1. Model class (`Student`) defines table structure
2. DbContext connects app to SQL Server
3. Migrations create database from code
4. Controller handles user requests
5. Views display data and forms

---

## ▶️ How to Run

1. Clone the repository
2. Open in Visual Studio
3. Update connection string in `appsettings.json`
4. Run migrations:

   ```
   Add-Migration Init
   Update-Database
   ```
5. Run the project

---

## 🎯 Goal of This Project

* Learn **Code First approach**
* Understand **CRUD operations**
* Practice **ASP.NET Core MVC + EF Core**

---

## 📌 Note

This is a beginner-friendly project focused on learning basics, not production-level architecture.
