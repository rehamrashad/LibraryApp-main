SELECT a.BookType
FROM (SELECT COUNT(bookType)  AS c,BookType
from book 
GROUP BY BookType) AS a
WHERE a.c = (SELECT MIN(a.c) FROM  (SELECT COUNT(bookType)  AS c,BookType
from book 
GROUP BY BookType) AS a)