
select fname
from Auther
where Auther.username not in (select book.username from book )
