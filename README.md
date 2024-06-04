Bu proje, üniversite öğrencileri ve öğretim üyeleri arasında bilgi akışını kolaylaştırmak amacıyla geliştirilen bir akademik bilgi yönetim sistemidir.
 Projenin hedefi, kullanıcı dostu bir arayüz ve iyileştirilmiş veri entegrasyon süreçleri ile eğitimde dijital dönüşümü teşvik etmektir. Bu proje hala geliştirilmektedir ve en temel versiyon budur. basit bir frontend tasarımı ve backend tarafında kayıt açma giriş yapma yönlendirmeler ve sql işlemleri mevcuttur.

Projenin MySQL tablo kodları.


USE university;

CREATE TABLE `announcements` (

  `announmentid` int NOT NULL AUTO_INCREMENT,

  `lessonname` varchar(45) DEFAULT NULL,

  `userid` int DEFAULT NULL,

  `teachername` varchar(45) DEFAULT NULL,

  `announce` varchar(45) DEFAULT NULL,

  PRIMARY KEY (`announmentid`)

) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


CREATE TABLE `assignments` (

  `indeks` int NOT NULL AUTO_INCREMENT,

  `userid` int DEFAULT NULL,

  `username` varchar(45) DEFAULT NULL,

  `deptid` int DEFAULT NULL,

  `lessonid` int DEFAULT NULL,

  `title` varchar(45) DEFAULT NULL,

  `text` varchar(800) DEFAULT NULL,

  PRIMARY KEY (`indeks`)

) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `examresult` (

  `examresultno` int NOT NULL AUTO_INCREMENT,

  `midtermresult` int DEFAULT NULL,

  `finalresult` int DEFAULT NULL,

  `userid` int DEFAULT NULL,

  `teacherid` int DEFAULT NULL,

  `dersid` int DEFAULT NULL,

  PRIMARY KEY (`examresultno`)

) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `faculty` (

  `deptid` int NOT NULL,

  `facultyname` varchar(45) DEFAULT NULL,

  `departmentname` varchar(45) DEFAULT NULL,

  PRIMARY KEY (`deptid`)

) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


CREATE TABLE `lesson` (

  `lessonid` int NOT NULL,

  `lessonname` varchar(45) DEFAULT NULL,

  `deptid` int DEFAULT NULL,

  `userid` int DEFAULT NULL,

  PRIMARY KEY (`lessonid`)

) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `studentabsence` (

  `index` int NOT NULL AUTO_INCREMENT,

  `dersid` int DEFAULT NULL,

  `userid` int DEFAULT NULL,

  `week1` int DEFAULT NULL,

  `week2` int DEFAULT NULL,

  `week3` int DEFAULT NULL,

  `week4` int DEFAULT NULL,

  `week5` int DEFAULT NULL,

  `week6` int DEFAULT NULL,

  `week7` int DEFAULT NULL,

  `week8` int DEFAULT NULL,

  `week9` int DEFAULT NULL,

  `week10` int DEFAULT NULL,

  `week11` int DEFAULT NULL,

  `week12` int DEFAULT NULL,

  `week13` int DEFAULT NULL,

  `week14` int DEFAULT NULL,

  PRIMARY KEY (`index`)

) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `syllabus` (

  `lessonid` int NOT NULL,

  `deptid` int DEFAULT NULL,

  `day` varchar(45) DEFAULT NULL,

  `time` varchar(45) DEFAULT NULL,

  PRIMARY KEY (`lessonid`)

) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `usertable` (

  `userid` int NOT NULL,

  `userName` varchar(45) DEFAULT NULL,

  `userPassword` varchar(45) DEFAULT NULL,

  `accessLevel` varchar(45) DEFAULT NULL,

  `name_surname` varchar(45) DEFAULT NULL,

  `deptid` int DEFAULT NULL,

  PRIMARY KEY (`userid`)

) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
