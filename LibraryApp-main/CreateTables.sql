CREATE TABLE Admin
(
  phone VARCHAR(11) NOT NULL,
  fname VARCHAR(30) NOT NULL,
  lname VARCHAR(30) NOT NULL,
  UserPassword VARCHAR(40) NOT NULL,
  username VARCHAR(40) NOT NULL,
  UserType VARCHAR(30) NOT NULL,
  PRIMARY KEY (username)
);

CREATE TABLE Reader
(
  phone VARCHAR(11) NOT NULL,
  fname VARCHAR(30) NOT NULL,
  lname VARCHAR(30) NOT NULL,
  UserPassword VARCHAR(40) NOT NULL,
  username VARCHAR(40) NOT NULL,
  UserType VARCHAR(30) NOT NULL,
  PRIMARY KEY (username)
);

CREATE TABLE Auther
(
  phone VARCHAR(11) NOT NULL,
  fname VARCHAR(30) NOT NULL,
  UserPassword VARCHAR(40) NOT NULL,
  lname VARCHAR(30) NOT NULL,
  username VARCHAR(40) NOT NULL,
  UserType VARCHAR(30) NOT NULL,
  PRIMARY KEY (username)
);

CREATE TABLE book
(
  price INT NOT NULL,
  BookType VARCHAR(30) NOT NULL,
  title VARCHAR(50) NOT NULL,
  available INT NOT NULL,
  sold INT NOT NULL,
  lastsolddate DATE,
  publishdate DATE NOT NULL,
  bookid INT NOT NULL,
  username VARCHAR(40) NOT NULL,
  PRIMARY KEY (bookid),
  FOREIGN KEY (username) REFERENCES Auther(username)
);

CREATE TABLE report
(
  ReportName VARCHAR(30) NOT NULL,
  Report VARCHAR(250) NOT NULL,
  ReportID INT NOT NULL,
  bookid INT NOT NULL,
  username VARCHAR(40) NOT NULL,
  PRIMARY KEY (ReportID),
  FOREIGN KEY (bookid) REFERENCES book(bookid),
  FOREIGN KEY (username) REFERENCES Admin(username),
  UNIQUE (bookid)
);

CREATE TABLE offer
(
  offer FLOAT NOT NULL,
  offerID INT NOT NULL,
  bookid INT NOT NULL,
  username VARCHAR(40) NOT NULL,
  PRIMARY KEY (offerID),
  FOREIGN KEY (bookid) REFERENCES book(bookid),
  FOREIGN KEY (username) REFERENCES Admin(username),
  UNIQUE (bookid)
);

CREATE TABLE buy
(
  BoughtNum INT NOT NULL,
  bookid INT NOT NULL,
  username VARCHAR(40) NOT NULL,
  PRIMARY KEY (bookid),
  FOREIGN KEY (bookid) REFERENCES book(bookid),
  FOREIGN KEY (username) REFERENCES Reader(username)
);

CREATE TABLE search
(
  bookid INT NOT NULL,
  username VARCHAR(40) NOT NULL,
  PRIMARY KEY (bookid),
  FOREIGN KEY (bookid) REFERENCES book(bookid),
  FOREIGN KEY (username) REFERENCES Reader(username)
);

CREATE TABLE comment
(
  comment VARCHAR(250) NOT NULL,
  commmentID INT NOT NULL,
  bookid INT NOT NULL,
  username VARCHAR(40) NOT NULL,
  PRIMARY KEY (commmentID),
  FOREIGN KEY (bookid) REFERENCES book(bookid),
  FOREIGN KEY (username) REFERENCES Reader(username),
  UNIQUE (bookid)
);