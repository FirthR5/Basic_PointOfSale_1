/* ================================= */
/* View tables*/
/* ================================= */


/*				Brand				*/
CREATE PROCEDURE Sp_ViewBrands
AS
SELECT * FROM _BRAND
order by Id_Br ASC
GO

/*				Category			*/
CREATE PROCEDURE Sp_ViewCategory
AS
SELECT * FROM _CATEGORY
GO

/*				PRODUCTS			*/
CREATE PROCEDURE Sp_ViewProducts
AS
SELECT Product_Id, Cat_Name, Brand_Name, Product_Name, Quantity, Price
FROM PRODUCT 
INNER JOIN _CATEGORY
ON PRODUCT.Category_Id = _CATEGORY.Id_Cat
INNER JOIN _BRAND
ON PRODUCT.Brand_Id = _BRAND.Id_Br
GO



/* ================================= */
/*				Register			 */
/* ================================= */

/*			Category				*/
CREATE PROCEDURE Sp_Register_Category(
@Cat_Name varchar(20)
)
AS
INSERT INTO _CATEGORY VALUES(
@Cat_Name
)
GO

/*				Brand				*/
CREATE PROCEDURE Sp_Register_Brand(
@Brand_Name VARCHAR(20)
)
AS
INSERT INTO _BRAND VALUES(
@Brand_Name
)
GO

/*				PRODUCTS			*/
ALTER PROCEDURE Sp_RegisterProduct(
@Category_Id INT,
@Brand_Id INT,
@Product_Name VARCHAR(20),
@Quantity INT,
@Price DECIMAL(20,2)
)
AS
INSERT INTO PRODUCT VALUES(
@Category_Id,
@Brand_Id,
@Product_Name,
@Quantity,
@Price
)
GO

EXECUTE[dbo].[Sp_RegisterProduct]
@Category_Id =5,
@Brand_Id =3,
@Product_Name='pep',
@Quantity=9,
@Price=9.02
GO
EXECUTE Sp_ViewProducts
GO

/* ====================================================== */
/* PROCEDURE FOR SEARCH ID OF BRANDS AND CATEGORY BY NAME */
/* ====================================================== */
CREATE PROCEDURE Sp_SearchBrand_ID_By_Name(
@Brand_Name VARCHAR(20)
)
AS 
SELECT Id_Br FROM _BRAND
WHERE Brand_Name = @Brand_Name
GO


CREATE PROCEDURE Sp_SearchCategoryID_V_By_Name(
@Cat_Name VARCHAR(20)
)
AS
SELECT Id_Cat FROM _CATEGORY
WHERE Cat_Name = @Cat_Name
GO

/* ====================================================== */
/*					PROCEDURE FOR REMOVE				  */
/* ====================================================== */

/*				Brand				*/

CREATE PROC Sp_Delete_Brand
@Id_Br INT
AS
DELETE FROM _BRAND
WHERE
Id_Br=@Id_Br
GO

/*			Category				*/
CREATE PROC Sp_Delete_Category
@Id_Cat INT
AS
DELETE FROM _CATEGORY
WHERE
Id_Cat = @Id_Cat
GO

/*				PRODUCTS			*/



/* ====================================================== */
/*					PROCEDURE SALES				  */
/* ====================================================== */

/*
CREATE PROCEDURE Sp_Sales_Stock
Products
ID, NAME,
BRAND, PRICE,
CATEGORY
*/

/*				STOCK				*/
/*
NAME OF THE PRODUCT
ID (NEL)
STOCK
*/


/* ================================= */
SELECT * FROM _BRAND
SELECT * FROM _CATEGORY
SELECT * FROM PRODUCT
GO
EXECUTE Sp_ViewProducts