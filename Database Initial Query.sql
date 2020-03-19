use master 

go

drop database if exists SpartaDB

go

create database SpartaDB

go

use SpartaDB

go

CREATE TABLE Consultant (
    ConsultantID int not null primary key identity,
    LastName varchar(30),
    FirstName varchar(30),
    Bio text,
    University varchar (100),
    Degree varchar(100),
    Grade varchar(100),
    Stream varchar(100),
    CvLink  varchar (255),
    VideoLink varchar (255),
    PhotoLink varchar(255)
);


INSERT INTO Consultant (FirstName, LastName,VideoLink, Degree,Grade ,Stream, Bio,University, CvLink, PhotoLink) Values  
('Karim','Bakkali','https://www.youtube.com/watch?v=9ps2_2Bq1Ao','BSc Computer Science','2.1','C# Developer','Karim is enthusiastic and an attentive software developer, with a huge interest in Technology and everything it involves. His fascination of coding originated from video games and how they worked, as a result he began teaching himself a wide array of coding languages. He loves solving problems and constantly challenges himself with new practices and tasks online. His interest in game development has also created a keen interest in graphics design and 3D modelling. Studying with Sparta Global, Karim has been able to blend his self-taught skills with professional guidance to better apply himself as a software developer. He finds working in a group has helped him identify problems and learned with others to correct them. ', 'Kings College','https://testingcircle-my.sharepoint.com/:w:/g/personal/kbakkali_spartaglobal_com/Eb8Pp-S-ErhOld1i2uVYxTYB4E2e9_8JrvWAYGa74j2OQw?e=XU7Uop','/Pics/Karim_Bakkali.jpg'), 
('Stephen','Callum','https://www.youtube.com/watch?v=zmg7bcC-kJk','MSc Computer Science ', 'Merit' ,'Java Developer' , 'Stephen is a committed and motivated computer science master’s graduate with a keen interest for programming and all types of technology. With a strong self-driven personality, he can learn new skills and pick up new technologies with ease. Through this he has taught himself an array of skills including web development and game development. Using his knowledge practically is his main way of strengthening and solidifying his knowledge. He finds taking on difficult tasks an effective way of challenging himself and seeks these opportunities eagerly. These challenges include making video games from scratch with the aim of publishing them on public platforms for sale. ', 'Swansea University', 'https://testingcircle-my.sharepoint.com/:w:/g/personal/scallum_spartaglobal_com/Ebb2HBX3SVFPoqiek-NLFn8BCRxWWjCKwMxTx4clwFVMEg?e=x3BmnW','/Pics/Stephen_Callum.jpg'), 
('Jamie','Benjamin','https://www.youtube.com/watch?v=9ps2_2Bq1Ao', 'BSc Computer Games Development','2.1','BA', 'Jamie is a passionate programming developer who has a keen eye for problem solving and learning new skills. He has learnt many new skills during his time at university ranging from programming languages such as C# and C++ to 3D model making in Maya and creating 2D animations in Adobe Photoshop. Combining these skills allowed him to produce video games within Unity Engine using unique and emerging technologies to showcase all that he has learnt whilst simultaneously showcasing his creative talents. As game development was his priority in university Jamie joined Sparta Global to broaden his knowledge within the program development industry advancing his current C# skills as well as learning new tools such as HTML, WPF and CSS. He still is keen on video game development and creates small vertical slices in his spare time to learn new skills and improve the ones he currently has.  ', 'Anglia Ruskin University', 'https://testingcircle-my.sharepoint.com/:w:/g/personal/jbenjamin_spartaglobal_com/EdjvHkjZPYZNlsDWaS-B7VsBuHixUolHMQ9Iy9Bum_Njow?e=Zw27W8','/Pics/Jamie_Benjamin.jpg'), 
('Hassan','Abdullahi','https://www.youtube.com/watch?v=zmg7bcC-kJk','BSc (Hons) Mathematics','2.1', 'DevOps', 'Hassan is a determined and analytical graduate who has developed an interest in creating C# applications. Having studied mathematics including modules such as statistical theory and probability models, he is an individual who can tackle a complex problem with confidence even when the solution is not obvious. He has a flexible and positive approach to everything he does and can work effectively on his own or as part of a team. ', 'Queen Mary University', 'https://testingcircle-my.sharepoint.com/:w:/g/personal/habdullahi_spartaglobal_com/EV03xyraEEJEqZSjR8i7tvsB4mTf6b4tHpeQSW-AtBnFSA?e=0oDfRD','/Pics/Hassan_Abdullahi.jpg'), 
('James','Kavanagh','https://www.youtube.com/watch?v=9ps2_2Bq1Ao', 'BSc (Hons) Chemistry', '2.1', 'C# Developer','James is a dynamic, versatile and personable graduate looking to apply his skills acquired at university to a career as a developer. A well-versed individual in technology and a science-driven mind, with a passion to develop a strong understanding and solve challenging problems. The taste for programming was gained in a first-year module at university, using the Fortran syntax – igniting a passion for a career path which aligns with personal interests. James is a well-rounded individual having played rugby for most of his life, developing strong team-work and social attributes. ', 'University of Kent', 'https://testingcircle-my.sharepoint.com/:w:/g/personal/jkavanagh_spartaglobal_com/Ed86jNVYWjNAksXCVxg-DS4B7NgvGS0BMO0b7E869t4_bw?e=FOXl8T','/Pics/James_Kavanagh.jpg'), 
('Timothy','Wong','https://www.youtube.com/watch?v=zmg7bcC-kJk','BSc (Hons) Computer Science','2.1', 'Java Developer', 'Tim is a highly motivated and experienced software developer, currently looking to resume his professional career after dedicating over a year in developing mobile apps. He has over 5 years IT industry experience, including software development, technical support and graphics designing. With great enthusiasm to further develop his skills, he has great communication skills and has proven experience working in different teams and environments. In Sparta he gained new skills in SQL and web development such as JavaScript, CSS, HTML and now has become skilful in C#. Tim is currently seeking new opportunities and challenges to further progress in his career. ', 'Brunel University', 'https://testingcircle-my.sharepoint.com/:w:/g/personal/twong_spartaglobal_com/EU4rd5GeALRHjfjvD9Gms8UBJPjRtoZSQqCQ8RWm5U4zDA?e=cbwxYC','/Pics/Timothy_Wong.jpg'), 
('Jordan','Benbelaid','https://www.youtube.com/watch?v=9ps2_2Bq1Ao', 'BSc Computer Science', '2.1','BA' ,'Jordan is a motivated and well-rounded software engineer, with the drive to develop his current skills as well as improve himself by learning new skills. Technology is his passion, and he enjoys creating something from scratch to feel a real achievement in his work. He is a methodical thinker, working with the same principle in mind. Jordan is a keen developer, learning skills in different languages and retaining information he touches upon. As well as Jordan being a fast learner, he picks up on soft skills with ease. He has great interpersonal skills, which allows him to communicate well with anyone he encounters, maintaining a professional demeanour. ', 'Brunel University', 'https://testingcircle-my.sharepoint.com/:w:/g/personal/jbenbelaid_spartaglobal_com/EUkyclpdmxhBnY5yLkqFWwgBO_mhj_nWJdve1OFC7j9beA?e=WQAND3','/Pics/Jordan_Benbelaid.jpg');  

go
