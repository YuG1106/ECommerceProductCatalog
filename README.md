🛒 ECommerce Product Catalog

A simple **ASP.NET Core MVC** web application that demonstrates basic **CRUD (Create, Read, Update, Delete)** operations for managing products in an e-commerce catalog.

This project is built as part of a **Web Technologies with .NET** college assignment and uses **Entity Framework Core** with **SQL Server** for data storage.

---

## 📘 Project Description

The **ECommerce Product Catalog** allows users to:
- Add, edit, view, and delete products.
- Upload product images.
- Search products by name or category.
- Store product details (name, category, price, description, image) in a SQL Server database.

This project is a beginner-friendly demonstration of a real-world web application using the **.NET MVC pattern**, **Entity Framework Core**, and **Bootstrap** for styling.

---

## ⚙️ Technologies Used

- **ASP.NET Core MVC (v8.0)**  
- **Entity Framework Core (Code-First)**  
- **SQL Server (LocalDB)**  
- **Bootstrap 5** (for responsive UI)  
- **C#**

---

## 🧩 Folder Structure

```

ECommerceProductCatalog/
│
├── Controllers/
│   └── ProductsController.cs
│
├── Models/
│   └── Product.cs
│
├── Data/
│   └── ApplicationDbContext.cs
│
├── Views/
│   └── Products/
│       ├── Index.cshtml
│       ├── Create.cshtml
│       ├── Edit.cshtml
│       ├── Details.cshtml
│       └── Delete.cshtml
│
├── wwwroot/
│   └── images/
│
├── appsettings.json
├── Program.cs
├── ECommerceProductCatalog.csproj
└── README.md

````

---

## 🧰 Installation Steps

Follow these steps to set up and run the project locally:

### 1️⃣ Clone this repository
```bash
git clone https://github.com/YuG1106/ECommerceProductCatalog.git
cd ECommerceProductCatalog
````

### 2️⃣ Open in Visual Studio

* Open the solution file: **`ECommerceProductCatalog.sln`**
* Ensure **.NET SDK 8.0 or later** is installed

### 3️⃣ Set up the Database

Open **Package Manager Console** in Visual Studio:

```
Tools → NuGet Package Manager → Package Manager Console
```

Then run:

```powershell
Add-Migration InitialCreate
Update-Database
```

✅ This creates a **SQL Server LocalDB** database named `ECommerceDB` automatically.

---

## 🖥️ How to Run the Project

1. Press **Ctrl + F5** or click the **Run ▶️** button in Visual Studio.

2. Your browser should open at:

   ```
   https://localhost:<port>/Products
   ```

3. You will see the **Product Catalog** home page.

4. From here, you can:

   * ➕ Add new products
   * ✏ Edit existing products
   * 🗑 Delete products
   * 🔍 Search by name or category


## 🗃️ Default Connection String

The default database connection string (in `appsettings.json`) is:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ECommerceDB;Trusted_Connection=True;"
}
```

If you’re using another SQL Server, replace the `Server` and `Database` values as needed.

---
🖼️ UI Screenshots

Homepage
<img width="1366" height="768" alt="Screenshot 2025-10-30 185955" src="https://github.com/user-attachments/assets/ff273eaf-15a3-4376-8cae-14329528107d" />

Create Product
<img width="1366" height="768" alt="Create" src="https://github.com/user-attachments/assets/507011e4-ef4d-47f4-a925-d03654c43bf0" />

Produts Added
<img width="1366" height="768" alt="Screenshot 2025-10-30 190238" src="https://github.com/user-attachments/assets/60e3bbef-de3d-4efc-bcfd-884866ecd6cb" />

Edit Product
<img width="1366" height="768" alt="Edit Product" src="https://github.com/user-attachments/assets/6295c0e9-a171-444b-a162-f7e64c150eb4" />

Edit Successfully
<img width="1366" height="768" alt="Screenshot 2025-10-30 190434" src="https://github.com/user-attachments/assets/473b703c-c112-46b6-9b9f-4c9bcf2f68a2" />

Search Product
<img width="1366" height="768" alt="Search" src="https://github.com/user-attachments/assets/f4dd607f-fb23-4c92-b690-7b4f8a9c5b9d" />

Delete Product
<img width="1366" height="768" alt="delete" src="https://github.com/user-attachments/assets/db4d432b-bf08-4623-928c-9d40bd059038" />

Deleted Successfully
<img width="1366" height="768" alt="Screenshot 2025-10-30 190526" src="https://github.com/user-attachments/assets/a912f9e5-c713-44a9-b30f-2caead6b6ee6" />

---

## 🚀 Features Overview

| Feature        | Description                                    |
| -------------- | ---------------------------------------------- |
| Add Product    | Create a new product with image upload         |
| Edit Product   | Modify existing product details                |
| Delete Product | Remove products from catalog                   |
| View Details   | See full product details                       |
| Search         | Search by name or category                     |
| Image Upload   | Save product images in `wwwroot/images` folder |

---

## 🧠 Learning Outcomes

Through this project, you’ll learn:

* How MVC architecture works in .NET Core.
* How to use **Entity Framework Core (Code-First)**.
* How to perform **CRUD operations** in ASP.NET Core.
* How to handle image uploads.


---

## 👨‍💻 Author

Developed by: Yug Bhagat

Enrollment No: 202403103520099

GitHub: @YuG1106

Contributions:
  
   Project Architecture
  
  Database Design
  
  Core Functionality
  
  Documentation


Contact

For any queries or suggestions, feel free to reach out:


📧 Email: bhagatyug90@gmail.com

---

## 📜 License

This project is open-source and available for educational purposes.



