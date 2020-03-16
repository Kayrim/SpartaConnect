use master 

go

drop database if exists SpartaDB

go

create database SpartaDB

go

use SpartaDB

go

CREATE TABLE Category (
    CategoryID int not null primary key identity,
    CategoryName varchar (100)
);

go

CREATE TABLE Trainer (
    TrainerID int not null primary key identity,
    LastName varchar(30),
    FirstName varchar(30),
    Photo varchar(255),
    Bio varchar (255)
);

go

CREATE TABLE Course (
    CourseID int not null primary key identity,
    CourseName varchar(30),
    CatgeoryID int foreign key references Category(CategoryID),
    LengthOfCourse varchar (100),
    CourseDescription varchar (255)
);

go

CREATE TABLE Consultant (
    ConsultantID int not null primary key identity,
    LastName varchar(30),
    FirstName varchar(30),
    CourseID int foreign key references Course(CourseID),
    Photo varchar(255),
    Bio varchar (255),
    University varchar (100),
    CvLink  varchar (255),
    VideoLink varchar (255)
);

go 



CREATE TABLE Project (
    ProjectID int not null primary key identity,
    ProjectName varchar(50),
    ConsultantID int foreign key references Consultant(ConsultantID),
    ProjectDescription varchar (255)
);

go

CREATE TABLE TrainerCourses (
  
    TrainerID int foreign key references Trainer(TrainerID) NOT NULL,
    CourseID int foreign key references Course(CourseID) NOT NULL,
	Primary Key (CourseID, TrainerID)

);

go

INSERT INTO Category Values
('Developer'),
('Business');

go

INSERT INTO Trainer (FirstName,LastName,Bio) Values
('Phil', 'Anderson' ,'I love Ketchup'),
('Markson', 'Jackson', 'okay'),
('Jim', 'Bob', 'Huh?');

go

INSERT INTO Course (CourseName,CatgeoryID,LengthOfCourse,CourseDescription) Values
('C# Dev',1, '10 Weeks', 'C# Development courses for learning programming full stack'),
('Java Dev',1, '10 Weeks', 'Java Development courses for learning programming full stack'),
('Business Analyst',2, '5 Weeks', 'Agile and some SQL');

go

INSERT INTO Consultant (FirstName, LastName, CourseID, Bio,University, CvLink) Values 
('Karim','Bakkali',1, 'I like food', 'Kings College','https://testingcircle-my.sharepoint.com/:w:/g/personal/kbakkali_spartaglobal_com/ESygUVXtrkJDp_ASoEt8-5sB-LcE9vxRs4R2t7qabrgi1g?e=ciSzl5'),
('Stephen','Callum',1,  'I want waves', 'Swansea University', 'https://testingcircle-my.sharepoint.com/:w:/g/personal/scallum_spartaglobal_com/Ebb2HBX3SVFPoqiek-NLFn8BCRxWWjCKwMxTx4clwFVMEg?e=A5RK35'),
('Jamie','Benjamin',1,  'I play games with my hands', 'Anglia Ruskin University', 'https://testingcircle-my.sharepoint.com/:w:/g/personal/jbenjamin_spartaglobal_com/EdjvHkjZPYZNlsDWaS-B7VsBuHixUolHMQ9Iy9Bum_Njow?e=Zw27W8'),
('Hassan','Abdullahi',1, 'I pray 5 times a day', 'Queen Mary', 'https://testingcircle-my.sharepoint.com/:w:/g/personal/habdullahi_spartaglobal_com/EV03xyraEEJEqZSjR8i7tvsB4mTf6b4tHpeQSW-AtBnFSA?e=0oDfRD'),
('James','Kavanagh',1,  'I like Jamie', 'University of Kent', 'https://testingcircle-my.sharepoint.com/:w:/g/personal/jkavanagh_spartaglobal_com/Ed86jNVYWjNAksXCVxg-DS4B7NgvGS0BMO0b7E869t4_bw?e=FOXl8T'),
('Timothy','Wong',1,  'Ooooo I like that', 'Brunel University', 'https://testingcircle-my.sharepoint.com/:w:/g/personal/twong_spartaglobal_com/EU4rd5GeALRHjfjvD9Gms8UBJPjRtoZSQqCQ8RWm5U4zDA?e=cbwxYC'),
('Jordan','Benbelaid',1, 'I left it on my home computer', 'Brunel University', 'https://testingcircle-my.sharepoint.com/:w:/g/personal/jbenbelaid_spartaglobal_com/EUkyclpdmxhBnY5yLkqFWwgBO_mhj_nWJdve1OFC7j9beA?e=WQAND3');

go



INSERT INTO Project (ConsultantID,ProjectName,ProjectDescription) Values
(1, 'Unity Game Project', 'Made a first person Shooter'),
(2, 'Unity Game Project', 'Made a third person platformer'),
(3, 'Unity Game Project', 'Made a flight simulator in space');

go

INSERT INTO TrainerCourses  Values
(1,1),
(1,2),
(2,2),
(2,3),
(3,1),
(3,3);