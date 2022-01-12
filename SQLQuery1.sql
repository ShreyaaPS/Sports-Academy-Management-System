

/* .personal_info  .coach   .academy_records  .login  .fees*/



use sportsacademy;
create table personal_info(firstname varchar(20) NOT NULL,lastname varchar(20),age int check(age >0),dob  date NOT NULL, gender varchar(20)  NOT NULL,address varchar(90) NOT NULL,phoneno bigint NOT NULL ,parentn varchar(50),parentphone bigint);

create table coach(coachid int NOT null PRIMARY KEY,name varchar(20),email varchar(40),mobile bigint NOT NULL,gender varchar(20),sport varchar(20),address varchar(100),awards varchar(100));

create table academy_records(academyid int PRIMARY KEY NOT NULL,name varchar(90) NOT NULL,height float,weight float,handedness varchar(15),sport varchar(90),indianrank int,worldrank int);

--create table staff(name varchar(50),staffid int NOT NULL PRIMARY KEY,job varchar(80),salary bigint);
create table login(username varchar(90) NOT NULL,password varchar(80));
create table fees(academyid int,fee bigint);
create table coach(coachid int NOT null PRIMARY KEY,name varchar(20) NOT NULL,email varchar(40),mobile bigint,gender varchar(20),sport varchar(20),address varchar(100),awards varchar(100));
select * from coach;
create table academy_records(academyid int PRIMARY KEY,name varchar(90),height float,weight float,handedness varchar(15),sport varchar(90),indianrank int,worldrank int);
select * from login;
drop table academy_records;
create table personal_info(firstname varchar(20) NOT NULL,lastname varchar(20),age int,dob varchar(50) NOT NULL, gender varchar(20)  NOT NULL,address varchar(90) NOT NULL,phoneno bigint NOT NULL ,parentn varchar(50),parentphone bigint);
create table academy_records(academyid int PRIMARY KEY,name varchar(90),height varchar(10),weight varchar(10),handedness varchar(15),sport varchar(90),indianrank int,worldrank int);
select * from personal_info;
select * from academy_records;
select * from personal_info;
create view player_rank as select academyid,name, indianrank, worldrank from academy_records;
create view pr as select name, sport, indianrank, worldrank from academy_records;
select * from academy_records;
select * from personal_info;
select * from pr;
select * from fees;
select * from coach;
select * from fees;

--use sportsacademy;





--SELECT a.name, a.handedness, p.dob, a.sport, a.indianrank, a.worldrank FROM personal_info p INNER JOIN academy_records a ON Orders.CustomerID=Customers.CustomerID;



/*
select * from coach cross join academy_records;
select s.firstname,s.dob,s.phoneno,d.academyid,d.sport from personal_info s,academy_records where s.firstname=d.name;
create view player_cricket as
select academyid,name from academy_records where sport='cricket';
create view  player_badminton as
select academyid,name from academy_records where sport='badminton';
create view   player_basketball as
select academyid,name from academy_records where sport='basketball';
create view coach_cricket as
select coachid,name from coach where sport='cricket';
create view coach_badminton as
select coachid,name from coach where sport='badminton';
create view coach_badminton as
select coachid,name from coach where sport='badminton';
*/