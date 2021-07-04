CREATE DATABASE SalesPOS
GO

USE SalesPOS
GO

CREATE TABLE _CATEGORY(
	Id_Cat INT IDENTITY NOT NULL,
	Cat_Name varchar(20) NOT NULL
	CONSTRAINT PK_CAT_ID PRIMARY KEY (Id_Cat)
)
GO



CREATE TABLE _BRAND(
	Id_Br INT IDENTITY NOT NULL, 
	Brand_Name varchar(20)
	CONSTRAINT PK_ID_BR PRIMARY KEY (Id_Br)
)
GO

CREATE TABLE PRODUCT(
	Product_Id INT IDENTITY NOT NULL, 
	Category_Id INT NOT NULL,
	Brand_Id INT NOT NULL, 
	Product_Name varchar(20) NOT NULL,
	Quantity INT,
	Price DECIMAL(20,2),
	CONSTRAINT PK_PRODUCT_ID PRIMARY KEY (Product_Id),
	
	CONSTRAINT FK_BRAND_ID FOREIGN KEY (Brand_Id)
	REFERENCES _BRAND(Id_Br),

	CONSTRAINT FK_CATEGORY_ID FOREIGN KEY(Category_Id)
	REFERENCES _CATEGORY(Id_Cat)

)
GO


ALTER TABLE PRODUCT
ALTER COLUMN Price DECIMAL(20,2)


/*
Reg Cat
Nombre de cat

Reg Mar
Nombre de Marca


Reg Prod
ID
Nombre
Marca
Categoria
Cant
Precio


Reporte productos
ID 
nom prod
nom marc
cate
cantidad
precio


*/