USE [EmpresaDB];
GO
//Departamentos
INSERT INTO dbo.Departamentos(Nombre,Presupuesto,Estado,Fecha_Creacion,Fecha_Modificacion, Usuario_Creacion_Id, Usuario_Modificacion_Id)
VALUES ('Produccion',13500300,1,GETDATE(),GETDATE(),1,1),
('Logistica',5905400,1,GETDATE(),GETDATE(),1,1),
('Bodega',25566500,1,GETDATE(),GETDATE(),1,1),
('Inteligencia',65000,1,GETDATE(),GETDATE(),1,1),
('Investigación',157000,1,GETDATE(),GETDATE(),1,1);

//Empleados
INSERT INTO dbo.Empleados
(Nombres, Apellidos, CUI, Fecha_Ingreso, Salario_Actual,
 Fecha_Ultimo_Aumento, Fecha_baja, Puesto, Jerarquia, Estado,
 Departamento_Id, DepartamentoId, Fecha_Creacion, Fecha_Modificacion,
 Usuario_Creacion_Id, Usuario_Modificacion_Id)
VALUES
('AARON ISAAC', 'PAR GUITZ', '1696745898754', '2022-01-15', 4500.00, GETDATE(), NULL, 'Operario', 'Junior', 1, 7, 7, GETDATE(), GETDATE(), 1, 1),
('ADELFA VERONICA', 'PEREZ LOPEZ', '1525145111111', '2021-06-10', 4700.00, GETDATE(), NULL, 'Asistente', 'Junior', 1, 9, 9, GETDATE(), GETDATE(), 1, 1),
('ADELIO', 'PEREZ Y PEREZ', '1362145545000', '2020-05-20', 5200.00, GETDATE(), NULL, 'Supervisor', 'Mid', 1, 10, 10, GETDATE(), GETDATE(), 1, 1),
('ADELSO', 'ZUÑIGA REGALADO', '1234567891250', '2019-09-12', 4800.00, GETDATE(), NULL, 'Operario', 'Junior', 1, 8, 8, GETDATE(), GETDATE(), 1, 1),
('ADELY NATYNELLY', 'MARGOTTIUL CU', '1822812548952', '2023-03-18', 4600.00, GETDATE(), NULL, 'Asistente', 'Junior', 1, 17, 17, GETDATE(), GETDATE(), 1, 1),
('BECERA SUZZETH', 'OVALLE ROLDAN', '2575745879568', '2021-07-25', 4900.00, GETDATE(), NULL, 'Auxiliar', 'Junior', 1, 9, 9, GETDATE(), GETDATE(), 1, 1),
('BEIMER DANILO', 'PEREZ BAUTISTA', '2201145879512', '2022-11-05', 5000.00, GETDATE(), NULL, 'Operario', 'Junior', 1, 10, 10, GETDATE(), GETDATE(), 1, 1),
('BELBETH YESENIA', 'HERNANDEZ GONZALEZ', '1338285456489', '2020-10-10', 5400.00, GETDATE(), NULL, 'Analista', 'Mid', 1, 3, 3, GETDATE(), GETDATE(), 1, 1),
('BELGICA ANABELLA', 'DERAS ROMAN', '1056945879750', '2023-02-10', 4550.00, GETDATE(), NULL, 'Operaria', 'Junior', 1, 8, 8, GETDATE(), GETDATE(), 1, 1),
('BELICA ANABELA', 'MIRANDA MONZON', '1860055658790', '2021-09-09', 5100.00, GETDATE(), NULL, 'Contadora', 'Mid', 1, 3, 3, GETDATE(), GETDATE(), 1, 1),
('BELLANIRA DANALY', 'MEDRANO MORALES', '2116345879600', '2022-05-14', 5300.00, GETDATE(), NULL, 'Asistente RRHH', 'Junior', 1, 8, 8, GETDATE(), GETDATE(), 1, 1),
('BELMIN', 'PINEDA GONZALEZ', '1383745897622', '2019-11-15', 4800.00, GETDATE(), NULL, 'Técnico', 'Junior', 1, 9, 9, GETDATE(), GETDATE(), 1, 1),
('BELSY KORINA', 'ALVARADO HERNANDEZ', '2436745893225', '2023-07-10', 4600.00, GETDATE(), NULL, 'Operaria', 'Junior', 1, 9, 9, GETDATE(), GETDATE(), 1, 1),
('BELSY LORENA', 'DE LEON GODINEZ', '2056112358924', '2020-08-18', 5500.00, GETDATE(), NULL, 'Supervisora', 'Mid', 1, 16, 16, GETDATE(), GETDATE(), 1, 1),
('BELSY YUCELA', 'SOLANO CRUZ', '1744945896512', '2021-10-30', 4700.00, GETDATE(), NULL, 'Asistente', 'Junior', 1, 9, 9, GETDATE(), GETDATE(), 1, 1),
('CARMEN LUCIA', 'ACU RECINOS', '1910745126550', '2020-01-25', 5200.00, GETDATE(), NULL, 'Secretaria', 'Junior', 1, 2, 2, GETDATE(), GETDATE(), 1, 1),
('CARMEN LUCIA', 'NAJARRO RUANO', '2094058954596', '2019-03-10', 5100.00, GETDATE(), NULL, 'Analista', 'Mid', 1, 3, 3, GETDATE(), GETDATE(), 1, 1);

//Productos
INSERT INTO dbo.Productos(Descripcion, Existencia, Precio, Costo, Fecha_Creacion, Fecha_Modificacion, Usuario_Creacion_Id, Usuario_Modificacion_Id,Estado)
VALUES
('Shampoo de Romero 250ml', 50, 45.00, 25.00, GETDATE(), GETDATE(), 1, 1, 1),
('Acondicionador de Keratina 250ml', 40, 48.00, 28.00, GETDATE(), GETDATE(), 1, 1, 1),
('Aceite de Almendras 120ml', 60, 35.00, 20.00, GETDATE(), GETDATE(), 1, 1, 1),
('Mascarilla Capilar Ceramidas 200ml', 30, 55.00, 32.00, GETDATE(), GETDATE(), 1, 1, 1),
('Shampoo de Coco 250ml', 45, 42.00, 22.00, GETDATE(), GETDATE(), 1, 1, 1),
('Acondicionador de Argán 250ml', 50, 47.00, 27.00, GETDATE(), GETDATE(), 1, 1, 1),
('Tratamiento Capilar de Romero 100ml', 35, 60.00, 38.00, GETDATE(), GETDATE(), 1, 1, 1),
('Aceite para Peinar Almendra y Romero 150ml', 70, 30.00, 18.00, GETDATE(), GETDATE(), 1, 1, 1),
('Shampoo Anticaída 250ml', 55, 50.00, 29.00, GETDATE(), GETDATE(), 1, 1, 1),
('Acondicionador Hidratante de Miel 250ml', 40, 46.00, 26.00, GETDATE(), GETDATE(), 1, 1, 1),
('Shampoo de Aloe Vera 250ml', 45, 43.00, 24.00, GETDATE(), GETDATE(), 1, 1, 1),
('Acondicionador de Coco 250ml', 50, 46.00, 26.00, GETDATE(), GETDATE(), 1, 1, 1),
('Mascarilla Capilar de Miel 200ml', 35, 52.00, 31.00, GETDATE(), GETDATE(), 1, 1, 1),
('Aceite Esencial de Romero 50ml', 60, 38.00, 20.00, GETDATE(), GETDATE(), 1, 1, 1),
('Shampoo de Manzanilla 250ml', 55, 40.00, 22.00, GETDATE(), GETDATE(), 1, 1, 1),
('Acondicionador de Colágeno 250ml', 50, 49.00, 27.00, GETDATE(), GETDATE(), 1, 1, 1),
('Tratamiento Capilar de Argán 100ml', 30, 58.00, 36.00, GETDATE(), GETDATE(), 1, 1, 1),
('Aceite Nutritivo de Coco 100ml', 65, 34.00, 19.00, GETDATE(), GETDATE(), 1, 1, 1),
('Shampoo de Ortiga Anticaspa 250ml', 40, 48.00, 28.00, GETDATE(), GETDATE(), 1, 1, 1),
('Acondicionador de Sábila 250ml', 45, 44.00, 24.00, GETDATE(), GETDATE(), 1, 1, 1),
('Shampoo Hidratante de Menta 250ml', 55, 47.00, 26.00, GETDATE(), GETDATE(), 1, 1, 1),
('Acondicionador Reparador de Aguacate 250ml', 35, 50.00, 30.00, GETDATE(), GETDATE(), 1, 1, 1),
('Mascarilla Suavizante de Karité 200ml', 30, 53.00, 32.00, GETDATE(), GETDATE(), 1, 1, 1),
('Aceite Capilar con Vitamina E 120ml', 70, 36.00, 20.00, GETDATE(), GETDATE(), 1, 1, 1),
('Shampoo Fortalecedor de Biotina 250ml', 60, 49.00, 29.00, GETDATE(), GETDATE(), 1, 1, 1),
('Acondicionador con Extracto de Té Verde 250ml', 50, 45.00, 25.00, GETDATE(), GETDATE(), 1, 1, 1),
('Tratamiento Capilar Regenerador 100ml', 40, 61.00, 39.00, GETDATE(), GETDATE(), 1, 1, 1),
('Shampoo Natural de Lavanda 250ml', 55, 42.00, 23.00, GETDATE(), GETDATE(), 1, 1, 1),
('Acondicionador Antifrizz de Argán 250ml', 50, 48.00, 27.00, GETDATE(), GETDATE(), 1, 1, 1),
('Aceite para Peinar con Miel y Almendra 150ml', 75, 33.00, 18.00, GETDATE(), GETDATE(), 1, 1, 1),
('Detergente Líquido Multiusos 1L', 80, 28.00, 15.00, GETDATE(), GETDATE(), 1, 1, 1),
('Suavizante de Telas Lavanda 900ml', 60, 26.00, 14.00, GETDATE(), GETDATE(), 1, 1, 1),
('Limpiador de Vidrios 500ml', 75, 22.00, 12.00, GETDATE(), GETDATE(), 1, 1, 1),
('Desinfectante de Pino 1L', 70, 25.00, 13.00, GETDATE(), GETDATE(), 1, 1, 1),
('Jabón Líquido para Platos 750ml', 85, 20.00, 11.00, GETDATE(), GETDATE(), 1, 1, 1),
('Cloro Concentrado 1L', 90, 18.00, 9.00, GETDATE(), GETDATE(), 1, 1, 1),
('Limpiador de Piso Floral 1L', 65, 24.00, 13.00, GETDATE(), GETDATE(), 1, 1, 1),
('Esponjas para Cocina (pack x3)', 100, 15.00, 8.00, GETDATE(), GETDATE(), 1, 1, 1),
('Toalla de Microfibra (pack x2)', 50, 30.00, 18.00, GETDATE(), GETDATE(), 1, 1, 1),
('Trapeador Absorbente Profesional', 45, 40.00, 25.00, GETDATE(), GETDATE(), 1, 1, 1),
('Guantes de Limpieza Resistentes', 60, 22.00, 12.00, GETDATE(), GETDATE(), 1, 1, 1),
('Ambientador de Cítricos 250ml', 75, 27.00, 15.00, GETDATE(), GETDATE(), 1, 1, 1),
('Cera Líquida para Pisos 500ml', 40, 33.00, 20.00, GETDATE(), GETDATE(), 1, 1, 1),
('Paños Desechables Multiusos (pack x5)', 90, 18.00, 10.00, GETDATE(), GETDATE(), 1, 1, 1),
('Desengrasante de Cocina 500ml', 70, 29.00, 17.00, GETDATE(), GETDATE(), 1, 1, 1),
('Bolsa para Basura Negra (rollo 20u)', 100, 25.00, 13.00, GETDATE(), GETDATE(), 1, 1, 1),
('Escoba de Cerdas Suaves', 55, 35.00, 22.00, GETDATE(), GETDATE(), 1, 1, 1),
('Recogedor Metálico con Mango', 50, 32.00, 20.00, GETDATE(), GETDATE(), 1, 1, 1),
('Desodorante Ambiental de Vainilla 250ml', 65, 26.00, 14.00, GETDATE(), GETDATE(), 1, 1, 1),
('Limpiador Antigrasa Limón 1L', 70, 31.00, 17.00, GETDATE(), GETDATE(), 1, 1, 1);

//clientes
INSERT INTO dbo.Clientes(Nit,Nombre,Fecha_Creacion,Fecha_Modificacion,Usuario_Creacion_Id,Usuario_Modificacion_Id,Estado)
VALUES 
('1234567-1', 'Pedro Martinez', GETDATE(), GETDATE(), 1, 1, 1),
('2345678-2', 'Juana Perez', GETDATE(), GETDATE(), 1, 1, 1),
('3456789-3', 'Flor Juarez', GETDATE(), GETDATE(), 1, 1, 1),
('4567890-4', 'Panadería El Trigal', GETDATE(), GETDATE(), 1, 1, 1),
('5678901-5', 'Librería San José', GETDATE(), GETDATE(), 1, 1, 1),
('6789012-6', 'Rosa Perez', GETDATE(), GETDATE(), 1, 1, 1),
('7890123-7', 'Mario Sosa', GETDATE(), GETDATE(), 1, 1, 1),
('8901234-8', 'Dorian Velasquez', GETDATE(), GETDATE(), 1, 1, 1),
('9012345-9', 'Distribuidora Los Olivos', GETDATE(), GETDATE(), 1, 1, 1),
('0123456-0', 'Papelería Mundial', GETDATE(), GETDATE(), 1, 1, 1),
('1122334-5', 'Supermercado San Juan', GETDATE(), GETDATE(), 1, 1, 1),
('2233445-6', 'Juan Mendez', GETDATE(), GETDATE(), 1, 1, 1),
('3344556-7', 'Ferretería El Constructor', GETDATE(), GETDATE(), 1, 1, 1),
('4455667-8', 'Estefany Marcos', GETDATE(), GETDATE(), 1, 1, 1),
('5566778-9', 'Panadería Delicias', GETDATE(), GETDATE(), 1, 1, 1),
('6677889-0', 'Carnicería San Pedro', GETDATE(), GETDATE(), 1, 1, 1),
('7788990-1', 'Restaurante El Mirador', GETDATE(), GETDATE(), 1, 1, 1),
('8899001-2', 'Tienda El Sol', GETDATE(), GETDATE(), 1, 1, 1),
('9900112-3', 'Ferretería Moderna', GETDATE(), GETDATE(), 1, 1, 1),
('1011121-4', 'Boutique La Elegancia', GETDATE(), GETDATE(), 1, 1, 1);


//Ventas
INSERT INTO dbo.Ventas
(Fecha_Venta, Total, Cliente_Id, ClienteId, Fecha_Creacion, Fecha_Modificacion, Usuario_Creacion_Id, Usuario_Modificacion_Id)
VALUES
(GETDATE(), 150.00, 2,2, GETDATE(), GETDATE(), 1, 1),
(GETDATE(), 225.50, 2,2, GETDATE(), GETDATE(), 1, 1),
(GETDATE(), 310.00, 3,3, GETDATE(), GETDATE(), 1, 1),
(GETDATE(), 185.75, 4,4, GETDATE(), GETDATE(), 1, 1),
(GETDATE(), 98.00, 5,5, GETDATE(), GETDATE(), 1, 1),
(GETDATE(), 410.25, 6,6, GETDATE(), GETDATE(), 1, 1),
(GETDATE(), 275.40, 7,7, GETDATE(), GETDATE(), 1, 1),
(GETDATE(), 620.00, 8,8, GETDATE(), GETDATE(), 1, 1),
(GETDATE(), 320.90, 9,9, GETDATE(), GETDATE(), 1, 1),
(GETDATE(), 500.00, 10,10, GETDATE(), GETDATE(), 1, 1),
(GETDATE(), 350.30, 11,11, GETDATE(), GETDATE(), 1, 1),
(GETDATE(), 215.00, 12,11, GETDATE(), GETDATE(), 1, 1),
(GETDATE(), 175.80, 13,13, GETDATE(), GETDATE(), 1, 1),
(GETDATE(), 420.00, 14,14, GETDATE(), GETDATE(), 1, 1),
(GETDATE(), 285.50, 15,15, GETDATE(), GETDATE(), 1, 1),
(GETDATE(), 130.75, 16,16, GETDATE(), GETDATE(), 1, 1),
(GETDATE(), 265.20, 17,17, GETDATE(), GETDATE(), 1, 1),
(GETDATE(), 195.00, 18,18, GETDATE(), GETDATE(), 1, 1),
(GETDATE(), 355.90, 19,19, GETDATE(), GETDATE(), 1, 1),
(GETDATE(), 410.10, 20,20, GETDATE(), GETDATE(), 1, 1);

//detalleventa
INSERT INTO dbo.DetalleVentas
(Cantidad, Precio, Costo, Subtotal, Venta_Id, VentaId, Producto_Id, ProductoId, Fecha_Creacion, Fecha_Modificacion, Usuario_Creacion_Id, Usuario_Modificacion_Id)
VALUES
(2, 45.00, 25.00, 90.00, 5,5, 1,1, GETDATE(), GETDATE(), 1, 1),
(1, 60.00, 35.00, 60.00, 6,6, 2,2, GETDATE(), GETDATE(), 1, 1),
(3, 75.00, 50.00, 225.00, 7,7, 3,3, GETDATE(), GETDATE(), 1, 1),
(2, 50.25, 30.00, 100.50, 8,8, 4,4, GETDATE(), GETDATE(), 1, 1),
(1, 98.00, 65.00, 98.00, 9,9, 5,5, GETDATE(), GETDATE(), 1, 1),
(4, 20.00, 10.00, 80.00, 10,10, 6,6, GETDATE(), GETDATE(), 1, 1),
(2, 70.00, 40.00, 140.00, 11,11, 7,7, GETDATE(), GETDATE(), 1, 1),
(5, 30.00, 15.00, 150.00, 12,12, 8,8, GETDATE(), GETDATE(), 1, 1),
(3, 35.00, 20.00, 105.00, 13,13, 9,9, GETDATE(), GETDATE(), 1, 1),
(1, 500.00, 400.00, 500.00, 14,14, 10,10, GETDATE(), GETDATE(), 1, 1),
(2, 175.15, 100.00, 350.30, 15,15, 11,11, GETDATE(), GETDATE(), 1, 1),
(3, 71.66, 45.00, 215.00, 16,16, 12,12, GETDATE(), GETDATE(), 1, 1),
(2, 87.90, 55.00, 175.80, 17,17, 13,13, GETDATE(), GETDATE(), 1, 1),
(4, 105.00, 65.00, 420.00, 18,18, 14,14, GETDATE(), GETDATE(), 1, 1),
(3, 95.17, 60.00, 285.50, 19,19, 15,15, GETDATE(), GETDATE(), 1, 1),
(5, 26.15, 12.00, 130.75, 20,20, 16,16 ,GETDATE(), GETDATE(), 1, 1),
(2, 132.60, 80.00, 265.20, 21,21, 17,17, GETDATE(), GETDATE(), 1, 1),
(1, 195.00, 120.00, 195.00, 22,22, 18,18, GETDATE(), GETDATE(), 1, 1),
(3, 118.63, 70.00, 355.90, 23,23, 19,19, GETDATE(), GETDATE(), 1, 1),
(4, 102.52, 60.00, 410.10, 24,24, 20,20, GETDATE(), GETDATE(), 1, 1);


GO
