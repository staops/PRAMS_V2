USE [desarrolloPRAMS]
GO



SELECT 
	Category.CategoriaID, 
	Category.Categoria, 
	Parameter.TX_Filtro1 AS TX_Filtro, 
	Category.Descripcion AS CatDescripcion
FROM dbo.Adm_ParametroCategoria Category
	CROSS APPLY (
		SELECT * FROM dbo.Adm_ParametrosSeleccion 
		WHERE CategoriaID = Category.CategoriaID
	) Parameter
GROUP BY 
	Category.CategoriaID, 
	Category.Categoria, 
	Parameter.TX_Filtro1,
	Category.Descripcion
Order by Category.CategoriaID


SELECT * 
FROM [Adm_ParametrosSeleccion] 
WHERE 1 = 1
	AND CategoriaID = 16
ORDER BY CategoriaID

SELECT * FROM [Adm_ParametroCategoria] WHERE CategoriaID = 16