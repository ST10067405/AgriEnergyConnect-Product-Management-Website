# AgriEnergyConnect Product Management Website

**Version:** 1.1

## Hardware Specifications
- **Minimum Requirements:**
  - Processor: Dual-core processor (Intel Core i3 or equivalent)
  - RAM: 4 GB
  - Storage: 100 MB free disk space
- **Recommended:**
  - Processor: Quad-core processor (Intel Core i5 or equivalent)
  - RAM: 8 GB
  - Storage: 500 MB free disk space

## Installation Instructions
1. Clone the repository to your local machine.
2. Open the solution in Visual Studio.
3. Restore NuGet packages if prompted.
4. Set up a local SQL Server database. Modify the connection string in `appsettings.json` to point to your database.
5. Build the solution and run the application.
**NB:** It will auto create database when you run the solution.

## NEW!!
**Applied Lecturer Feedback**
1. Farmer's Name now hyperlinked to filter by their name.
2. Added/Updated Search to seperate the product name and type, and added a type dropdown menu.
3. Fixed when adding a product, it will give a list of food type instead of asking the user for one, causing mismatch lists of categories.
4. Generated a separate SQL database script with more test data.

## How to Use
1. **User Registration/Login:**
   - Users can register or log in using their email and password.
2. **User Roles:**
   - Users can have different roles such as Administrator, Employee, or Farmer.
3. **Product Management:**
   - Users with appropriate roles can create, view, edit, and delete products.
4. **User Management:**
   - Administrators and Employees can manage users, including assigning roles.
5. **Delete Account:**
   - Users can delete their accounts if needed.
6. **Filter Products:**
   - Users with Farmer role can filter products by other farmers.

## Functionality
- **Product Management:**
  - Create Product:
    - Users can add new products by providing product details such as name, category, and production date.
  - View Products:
    - Users can view a list of all products in the database.
  - Edit Product:
    - Users can modify existing product details.
  - Delete Product:
    - Users can remove products from the system.
- **User Management:**
  - Make/Remove Farmer:
    - Administrators and Employees can assign or remove the Farmer role from users.
  - Make/Remove Employee:
    - Administrators can assign or remove the Employee role from users.
  - Make/Remove Administrator:
    - Administrators can assign or remove the Administrator role from users.
- **Delete Account:**
  - Users can delete their accounts, which will remove their data from the system.

## FAQs
- **Q: Can I recover deleted products?**
  - A: No, once a product is deleted, it cannot be recovered. Make sure to confirm before deleting.
- **Q: How can I reset my password if I forget it?**
  - A: Use the "Forgot Password" feature on the login page to reset your password via email.

## Code Attributions
- The codebase uses ASP.NET Core MVC for the backend.
- Entity Framework Core is used for database operations.
- Identity framework is used for user authentication and authorization.

## Developer Information
- **Developed By:** Jaime Marc Futter
- **Contact:** [ST10067405@vcconnect.edu.za]
- **GitHub:** [Link to GitHub Repository](https://github.com/VCWVL/prog7311---programming-3a---poe-ST10067405)

## Frameworks and Plugins Used
- ASP.NET Core 8 MVC 
- Entity Framework Core
- Identity Framework
- Bootstrap (for front-end styling)
- jQuery (for client-side scripting)
