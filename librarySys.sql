--LibrarySys.sql

--T00203592
--Hinza Noor Amin Mughal
--Software Development

PROMPT Dropping All Tables
PROMPT

DROP TABLE LoanItems;
DROP TABLE Book;
DROP TABLE Category;
DROP TABLE Loans;
DROP TABLE FinePayments;
DROP TABLE Member;
DROP TABLE Genders;




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
  Isbn varchar2(13) NOT NULL,
  Title varchar2 (50) NOT NULL,
  Author varchar2 (25) ,
  Cat_Code char (3) NOT NULL,
  Status char(1) CHECK (Status IN ('A','U','R')),  
  CONSTRAINT pk_Book PRIMARY KEY (BookId),
  CONSTRAINT fk_Category FOREIGN KEY (Cat_Code) REFERENCES Category
);
--------------------------------------------------------------------------------
--3 Gender--
CREATE TABLE Genders
(Gender_Code varchar2(1),
 Description varchar2(15),
 
 CONSTRAINT pk_Genders PRIMARY KEY (Gender_Code)
 );
--------------------------------------------------------------------------------
--4 Member--
CREATE TABLE Member(
  MemId numeric (5),
  Surname varchar2(15) NOT NULL,
  Forename varchar2(15) NOT NULL,
  Street varchar2(40) NOT NULL,
  Town varchar2(20) NOT NULL,
  County varchar2(15) NOT NULL,
  Dob Date NOT NULL,
  Gender_Code varchar2(1) NOT NULL,
  Phone varchar2(15) UNIQUE,
  Status char(1) DEFAULT 'A' CHECK (Status IN ('A','H')) ,                      --A Active    H OnHold
  Fine decimal(5,2) DEFAULT 0,
  CONSTRAINT pk_Member PRIMARY KEY (MemId),
  CONSTRAINT fk_Genders FOREIGN KEY (Gender_Code) REFERENCES Genders
);
--------------------------------------------------------------------------------
--5 Loans--
CREATE TABLE Loans(
  LoanId numeric(5),
  MemId numeric(5) NOT NULL,
  LoanDate Date NOT NULL,
  DueDate Date NOT NULL,  
  CONSTRAINT pk_Loans PRIMARY KEY (LoanId),
  CONSTRAINT fk_Member FOREIGN KEY (MemId) REFERENCES Member
);
--------------------------------------------------------------------------------
--6 Loans--
CREATE TABLE LoanItems(
  LoanId numeric(5) NOT NULL,
  BookId numeric(5) NOT NULL,
  Return_Date Date DEFAULT NULL,
  CONSTRAINT pk_LoanItems PRIMARY KEY(LoanId,BookId),
  CONSTRAINT fk_Loans FOREIGN KEY (LoanId) REFERENCES Loans,
  CONSTRAINT fk_Book FOREIGN KEY (BookId) REFERENCES Book
);
--------------------------------------------------------------------------------
--7 FinePayments--
CREATE TABLE FinePayments(
  PayId numeric(5) NOT NULL,
  MId numeric(5) NOT NULL,
  PaymentDate Date DEFAULT NULL,
  AmountPaid decimal(5,2),  
  CONSTRAINT pk_FinePayments PRIMARY KEY (PayId),
  CONSTRAINT fk_MId FOREIGN KEY (MId) REFERENCES Member
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

PROMPT Populating Book
INSERT INTO Book
VALUES('00001','FJDWH746UG','Harry Potter - The Philosophers Stone','JK Rowling','NOV','U');
INSERT INTO Book
VALUES('00002','S7HGF67HHG','Black Butterfly','RM Drake','POE','A');
INSERT INTO Book
VALUES('00003','L43WH746UG','Harry Potter - The Chamber of Secrets','JK Rowling','NOV','A');
INSERT INTO Book
VALUES('00004','A8DWH746UG','On the Origin of Species','Charles Darwin','SCI','A');
INSERT INTO Book
VALUES('00005','H12WH746UG','Think and Grow Rich','Napoleon Hill','BUS','A');
INSERT INTO Book
VALUES('00006','J03WH746UG','Harry Potter - The Goblet of Fire','JK Rowling','NOV','A');
INSERT INTO Book
VALUES('00007','D33WH746UG','Fire and Fury','Michael Wolff','POL','A');
INSERT INTO Book
VALUES('00008','CTH7T746UG','Hackers: Heroes of the Computer Revolution','Steven Levy','COM','U');
INSERT INTO Book
VALUES('00009','A9G7T746UG','Black Hole Blues: And Other Songs From Outer Space','Janna Levin','SCI','A');
INSERT INTO Book
VALUES('00010','U857T746UG','Async JavaScript','Trevor Burnham','COM','A');
INSERT INTO Book
VALUES('00011','MHH7T746UG','The Intelligent Investor','Benjamin Graham','BUS','A');
INSERT INTO Book
VALUES('00012','RHA7T746UG','The Soul of an Octopus','Sy Montgomery','SCI','A');
INSERT INTO Book
VALUES('00013','E877T746UG','All the Lives We Never Lived','Anurandha Roy','NOV','A');
INSERT INTO Book
VALUES('00014','X22H7T746U','Odd John','Olaf Stapledon','NOV','A');
INSERT INTO Book
VALUES('00015','QWTH7T746G','When Breath Becomes Air','Paul Kalanithi','SCI','A');
INSERT INTO Book
VALUES('00016','ITH7T746GK','A Journey to the Center of the Earth','Jules Verne','NOV','A');
INSERT INTO Book
VALUES('00017','MTH8D746UK','Ready Player One','Ernest Cline','COM','A');
INSERT INTO Book
VALUES('00018','NTH77G46UGO','Discrete Mathematics','Richard Johnsonbaugh','COM','A');
INSERT INTO Book
VALUES('00019','W7GGA746GY','Becoming','Michelle Obama','POL','U');
INSERT INTO Book
VALUES('00020','AA56T46UGY','How to Win Friends and People','Dale Carnegie','BUS','A');

PROMPT Populate Genders
INSERT INTO Genders
VALUES('F','Female');
INSERT INTO Genders
VALUES('M','Male');
INSERT INTO Genders
VALUES('X','Other');

PROMPT Populating Member
INSERT INTO Member
VALUES('00001','Smith','Tom','76 The Meadows','Tralee','Kerry','12-JAN-1767','M','0986437271','A','9.00');
INSERT INTO Member
VALUES('00002','Sal','Damon','122 Abbey','Mullingar','Limerick','16-MAR-1967','M','0836854205','A','3.50');
INSERT INTO Member
VALUES('00003','Dobrev','Nina','900 Kildare','Kerry','Cork','28-FEB-1994','F','08328657581','A','0.00');
INSERT INTO Member
VALUES('00004','Sal','Chris','786 Oak','Virginia','Cavan','11-JUL-1998','X','0986237271','A','0.00');
INSERT INTO Member
VALUES('00005','Wells','Aria','36 Drumconrath','Navan','Meath','21-NOV-1999','M','0822437271','A','4.50');
INSERT INTO Member
VALUES('00006','Gareth','Bob','St Michaels Private Clinic Dun Laoire','Dun laoghaire','County Dublin','24-DEC-1989','M','0876333234','A','0.00');
INSERT INTO Member
VALUES('00007','Nell','R. Bowen','2364 Travis Street','Miami','FL 33128','19-SEP-1966','M','0984555312','A','0.50');
INSERT INTO Member
VALUES('00008','Brooks','Jacqueline','268 Drummond Street','Rochelle Park','New Jersey','22-FEB-1788','F','0923666171','A','0.00');
INSERT INTO Member
VALUES('00009','Hall','Adison','329  Terra Street','Seattle','Washington','08-JAN-1987','F','0883777676','A','16.00');
INSERT INTO Member
VALUES('00010','Wells','Melissa','3054  Beechwood Avenue','Bedminster','NJ','09-MAR-1997','X','0984444565','A','0.00');
PROMPT

PROMPT Populating Loans
INSERT INTO Loans
VALUES('00001','00003','23-MAR-2019','30-MAR-2019');
INSERT INTO Loans
VALUES('00002','00005','26-MAR-2019','2-APR-2019');
INSERT INTO Loans
VALUES('00003','00009','1-APR-2019','8-APR-2019');
INSERT INTO Loans
VALUES('00004','00010','16-APR-2019','16-APR-2019');

PROMPT Populating LoanItems
INSERT INTO LoanItems
VALUES('00001','00003','29-MAR-2019');
INSERT INTO LoanItems
VALUES('00002','00007','11-APR-2019');
INSERT INTO LoanItems
VALUES('00002','00002','14-APR-2019');
INSERT INTO LoanItems
VALUES('00002','00011','6-APR-2019');
INSERT INTO LoanItems
VALUES('00003','00005','10-APR-2019');
INSERT INTO LoanItems
VALUES('00004','00019','');


COMMIT;
