# 🅿️ Parking Management System – .NET Windows Forms Application  
### Semester 5 – Application Development Using .NET Framework

This project was created as part of my **Semester 5 subject: Application Development using .NET Framework**.  
It is a **Windows Forms application** developed in **C# (.NET Framework)** with a **SQL Server MDF/LDF database**.  
The system helps a parking space owner track entries, exits, available slots, and maintain daily parking operations.

---

## 📘 Project Overview

The application includes:

### ✔ Admin Login
- Secure login screen  
- Only authenticated users can access the Dashboard  

### ✔ Vehicle Entry Management
- Enter vehicle number  
- Record entry time  
- Assign a parking slot  
- Store data inside SQL Server local database  

### ✔ Vehicle Exit
- Mark vehicles as exited  
- Free the parking slot  
- Calculate parking duration and charges

### ✔ Parking Slot Visualization
- Total slots  
- Occupied slots  
- Available slots  
- Realtime updates

### ✔ Database Integration
- SQL Server (.mdf/.ldf) local database  
- Tables may include:
  - `Vehicles`
  - `Parking_history`

### ✔ Multi-Form UI
The app uses multiple WinForms:
- Login Form  
- Dashboard  
- Vehicle Entry/Exit Form  
- Slot Management Form  
- End User / Visitor Form  
- Feedback / Report Form (if implemented)

---

## 🛠️ Technologies Used

- **C# (.NET Framework)**  
- **Windows Forms (WinForms)**  
- **SQL Server LocalDB (MDF / LDF)**  
- **App.config for DB Connection**  
- **Event-driven programming**  

---

## 📂 Project Structure

```
dotnet-parking-management-system/
│
├── ParkingSystem.sln
├── ParkingSystem/
│   ├── ParkingSystem.csproj
│   ├── Program.cs
│   ├── App.config
│   ├── dashboard.cs
│   ├── dashboard.Designer.cs
│   ├── dashboard.resx
│   ├── database.cs
│   ├── enduser.cs
│   ├── enduser.Designer.cs
│   ├── login.cs
│   ├── login.Designer.cs
│   ├── register.cs
│   ├── register.Designer.cs
│   ├── location.cs
│   ├── location.Designer.cs
│   ├── feedback.cs
│   └── Other forms...
│
├── Database/
│   ├── CusotmerDetails.mdf
│   └── CusotmerDetails_log.ldf
│
└── README.md
```

---

## ▶️ How to Open/Run (For Visual Studio Users)

1. Install **Visual Studio** with  
   - .NET Desktop Development  
   - SQL Server Data Tools  
2. Open the `.sln` file  
3. Make sure the `.mdf` database attaches correctly  
4. Press **Start (F5)** to run the app  

---

## 🎓 Academic Context

- **Course:** Application Development using .NET Framework  
- **Semester:** 5  
- **Focus Areas:**
  - WinForms UI development  
  - Working with SQL Server LocalDB  
  - CRUD operations  
  - Multi-form navigation  
  - Login authentication  
  - Real-world case study (Parking System)

---

## 📄 License

This project is provided for academic and learning purposes.
