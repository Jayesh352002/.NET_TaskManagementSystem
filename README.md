# Task Management Web API

This project is a simple **Task Management System** built using **ASP.NET Core Web API**. It allows users to perform CRUD operations on tasks and includes a Swagger UI for easy testing and exploration of the API.

---

## 🚀 Features

- Create, view, update, and delete tasks
- Mark tasks as complete
- JSON-based RESTful API
- Swagger UI available for testing endpoints

---

## 📦 Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- (Optional) Any modern web browser to open the Swagger UI
- (Optional) Visual Studio or Visual Studio Code

---

## 🔧 How to Build and Run the Application

1. **Clone the repository:**

   ```bash
   git clone https://github.com/your-username/task-management-api.git
   cd task-management-api

2. **Restore Package (Optional):**

   dotnet restore

3. **Build the Project:**

   dotnet build
   
4. **Run the Application:**

   dotnet run

5. **The API will start and open in your browser at:**

   https://localhost:7052/swagger
   This is the Swagger UI, where you can test all API endpoints directly.

## API Endpoints

1. **GET - /api/Task**
2. **POST - /api/Task**
3. **GET - /api/Task/{id}**
4. **PUT - /api/Task/{id}**
5. **DELETE - /api/Task/{id}**



