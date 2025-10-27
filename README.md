# EmpresaSistema

Prueba Técnica Dearrollodor Junior

La solución se enfocó en la implementación del backend utilizando ASP.NET Core 8.0 con Entity Framework Core bajo el enfoque Code First.
El proyecto cuenta con endpoints CRUD funcionales para las principales entidades solicitadas.

***Arquitectura y tecnologías utilizadas**

Lenguaje = C# (.NET 8.0)
Framework = ASP.NET Core Web API
ORM = Entity Framework Core
Patrón de desarrollo = Code First con migraciones
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
2.Entidades diseñadas con relaciones mediante llaves foraneas
3.Validaciones básicas

----COMERCIAL----
1.CRUD completos para Producto, Cliente, DetalleVenta y Venta.
2.Entidades diseñadas con relaciones mediante llaves foraneas
3.Validaciones básicas

----BASE DE DATOS----
1.Creación median Code First.
2.Generación automatica con migraciones
3.Carga de datos ejemplos (menos de los solicitados)

----AUTENTICACIÓN Y AUTORIZACION----
1.No se implemento autenticacion ni manejo de roles
2.Se realizo unicamente CRUD de usuarios y rol, tambien los controladores para intregralo posteriormente

----FRONTEND----
1.No se desarrollo interfaz web debido a limitaciones de tiempo

***Versionamiento***
El proyecto se versionó en GitHub con commits descriptivos que reflejan las etapas del desarrollo, desde la configuración inicial hasta la implementación de los CRUD.

***Desiciones Técnicas***
1.Se eligió Entity Framework Core por su integración natural con .NET, soporte para migraciones y sintaxis LINQ intuitiva.
2.Se usó Code First para permitir flexibilidad en la evolución del modelo sin depender de un esquema inicial.
3.No se implementó autenticación debido a limitaciones de tiempo, pero se planea agregar JWT o Identity como siguiente paso.

---Scripts de Bd y Poblado---

Se añadira una carpeta llamada Scripts y ahi podra encontrar los recursos utilizados para la base de datos y las consultas solicitadas


Gracias por la oportunidad. Este proyecto fue un reto, pero también una buena forma de aprender y superarme.
Atte.
Lisbeth Yanira Hernandez Garcia
