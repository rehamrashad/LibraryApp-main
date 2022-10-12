
select Distinct title
from book 
where 
(MONTH(GETDATE()) > MONTH(book.lastsolddate) and YEAR(GETDATE()) =YEAR(book.lastsolddate))or (MONTH(GETDATE())=1 and  MONTH(book.lastsolddate)= 12 and YEAR(GETDATE())+1 =YEAR(book.lastsolddate) OR lastsolddate is NULL ) 