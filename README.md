# EmpresaSistema

Prueba T�cnica Dearrollodor Junior

La soluci�n se enfoc� en la implementaci�n del backend utilizando ASP.NET Core 8.0 con Entity Framework Core bajo el enfoque Code First.
El proyecto cuenta con endpoints CRUD funcionales para las principales entidades solicitadas.

***Arquitectura y tecnolog�as utilizadas**

Lenguaje = C# (.NET 8.0)
Framework = ASP.NET Core Web API
ORM = Entity Framework Core
Patr�n de desarrollo = Code First con migraciones
Base de datos = SQL Server (localdb)
IDE = Visual Studio 2022
Control de versiones = Git + GitHub

***Estructura General del Proyecto ***
Empresa Sistema
--->Controllers
--->Data
--->DTOs
--->Helpers
--->Migrations
--->Models
--->Properties
--->Repositories
--->Servicies


***Modulos Empleados**

----RRHH----
1.CRUD completos para Empleados, Departamento e HistorialSalarial.
2.Entidades dise�adas con relaciones mediante llaves foraneas
3.Validaciones b�sicas

----COMERCIAL----
1.CRUD completos para Producto, Cliente, DetalleVenta y Venta.
2.Entidades dise�adas con relaciones mediante llaves foraneas
3.Validaciones b�sicas

----BASE DE DATOS----
1.Creaci�n median Code First.
2.Generaci�n automatica con migraciones
3.Carga de datos ejemplos (menos de los solicitados)

----AUTENTICACI�N Y AUTORIZACION----
1.No se implemento autenticacion ni manejo de roles
2.Se realizo unicamente CRUD de usuarios y rol, tambien los controladores para intregralo posteriormente

----FRONTEND----
1.No se desarrollo interfaz web debido a limitaciones de tiempo

***Versionamiento***
El proyecto se version� en GitHub con commits descriptivos que reflejan las etapas del desarrollo, desde la configuraci�n inicial hasta la implementaci�n de los CRUD.

***Desiciones T�cnicas***
1.Se eligi� Entity Framework Core por su integraci�n natural con .NET, soporte para migraciones y sintaxis LINQ intuitiva.
2.Se us� Code First para permitir flexibilidad en la evoluci�n del modelo sin depender de un esquema inicial.
3.No se implement� autenticaci�n debido a limitaciones de tiempo, pero se planea agregar JWT o Identity como siguiente paso.

---Scripts de Bd y Poblado---

Se a�adira una carpeta llamada Scripts y ahi podra encontrar los recursos utilizados para la base de datos y las consultas solicitadas


Gracias por la oportunidad. Este proyecto fue un reto, pero tambi�n una buena forma de aprender y superarme.
Atte.
Lisbeth Yanira Hernandez Garcia
