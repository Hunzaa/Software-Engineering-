--LibrarySys.sql

--T00203592
--Hinza Noor Amin Mughal
--Software Development

PROMPT Dropping All Tables
PROMPT

DROP TABLE Book;
DROP TABLE Category;
DROP TABLE Member;

PROMPT
PROMPT Creating tables
PROMPT

--------------------------------------------------------------------------------
--1 Category--
CREATE TABLE Category(
  Cat_Code char (3) ,
  Description char (15) NOT NULL,
  
  CONSTRAINT pk_Category PRIMARY KEY (Cat_Code)
);
--------------------------------------------------------------------------------
--2 Book--
CREATE TABLE Book(
  BookId numeric (5) ,
  Isbn char(13) NOT NULL,
  Title char (30) NOT NULL,
  Author char (20) ,
  Cat_Code char (3) NOT NULL,
  Status char(1) CHECK (Status IN ('A','U','R')),  
  
  CONSTRAINT pk_Book PRIMARY KEY (BookId),
  CONSTRAINT fk_Category FOREIGN KEY (Cat_Code) REFERENCES Category
);
--------------------------------------------------------------------------------
--3 Member--
CREATE TABLE Member(
  MemId numeric (5),
  Surname char(15) NOT NULL,
  Forename char(15) NOT NULL,
  Address char(40) NOT NULL,
  Dob Date NOT NULL,
  Phone varchar(15) UNIQUE,
  Status char(20) DEFAULT 'A' CHECK (Status IN ('A','H')) ,                      --A Active    H OnHold
  Fine decimal(5,2) DEFAULT NULL,
  
  CONSTRAINT pk_Member PRIMARY KEY (MemId)
);








--------------------------------------------------------------------------------
--------------------------------------------------------------------------------
-----                      Inserting Data

PROMPT 

PROMPT Populating Category
INSERT INTO Category
VALUES('SCI','Science');
INSERT INTO Category
VALUES('COM','Computer');
INSERT INTO Category
VALUES('BUS','Business');
INSERT INTO Category
VALUES('NOV','Novel');
INSERT INTO Category
VALUES('POL','Politics');
INSERT INTO Category
VALUES('POE','Poetry');

PROMPT
COMMIT;
