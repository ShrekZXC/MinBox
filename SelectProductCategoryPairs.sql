SELECT 
    p.ProductName, 
    pc.CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategoryMap pcm ON p.ProductID = pcm.ProductID
LEFT JOIN 
    ProductCategories pc ON pcm.CategoryID = pc.CategoryID
ORDER BY 
    p.ProductName, pc.CategoryName;
