What I have created is an ASP.NET Web API with EntityFramwork (neither is .NET Core). It has one model, one repository 
and one CRUD controller for the model. It also has some base classes as well as the support of unit of work, although it is not really 
useful in this case.

The set up is the standard one for code first migration.
The automigration is already enabled. The Data is in separate class library, but I had to install EntityFramework to both projects,
since it was the only way to solve an error.
Once the application is running I used Postman for sending HTTP requests and had no problems using CRUD operations from there.