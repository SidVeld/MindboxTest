SELECT Products.name, Categories.name
FROM Products LEFT JOIN  Categories ON Products.id=Categories.Id 
ORDER BY Products.name;
