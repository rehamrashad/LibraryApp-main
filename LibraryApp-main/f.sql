SELECT  DISTINCT buy.username,Reader.fname,Reader.lname,Reader.phone,Reader.UserType, (SELECT COUNT(BoughtNum) FROM
buy WHERE buy.username=Reader.username)
from Reader,buy
where buy.username=Reader.username