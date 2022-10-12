
select distinct book.title
from book 
where book.sold =(
select max(book.sold)
from book
)
