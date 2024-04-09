-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: my_library
-- ------------------------------------------------------
-- Server version	8.0.27

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `book_info`
--

DROP TABLE IF EXISTS `book_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `book_info` (
  `ISBN` varchar(20) NOT NULL,
  `PID` varchar(10) NOT NULL,
  `BookName` varchar(30) NOT NULL,
  `Type` varchar(20) DEFAULT NULL,
  `Author` varchar(30) DEFAULT NULL,
  `Edition` int DEFAULT NULL,
  `PubDate` datetime DEFAULT NULL,
  `Price` float DEFAULT NULL,
  `Summary` text,
  `CurrentStock` int DEFAULT NULL,
  `TotalStock` int DEFAULT NULL,
  PRIMARY KEY (`ISBN`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `book_info`
--

LOCK TABLES `book_info` WRITE;
/*!40000 ALTER TABLE `book_info` DISABLE KEYS */;
INSERT INTO `book_info` VALUES ('978-7-01-000922-9','P002','西游记','小说','吴承恩',1,'2022-01-02 00:00:00',49,'描述孙悟空和唐僧取经的故事。',30,30),('978-7-02-000220-7','P001','水浒传','小说','施耐庵',1,'2022-01-03 00:00:00',45,'讲述宋江领导的108位好汉的故事。',15,15),('978-7-02-009459-4','P005','挪威的森林','小说','村上春树',1,'2022-01-09 00:00:00',33,'一段关于成长和失落的故事。',19,19),('978-7-02-014746-6','P001','红楼梦','小说','曹雪芹',1,'2022-01-01 00:00:00',59,'经典的中国古典文学作品。',20,20),('978-7-020-05065-0','P004','平凡的世界','小说','路遥',1,'2022-01-07 00:00:00',80,'描绘中国农村改革开放的巨变。',8,8),('978-7-0632-266','P002','蝴蝶梦','小说','达夫妮·杜穆里埃',1,'2024-01-26 09:37:30',36.8,'',15,15),('978-7-5063-7330-2','P003','围城','小说','钱钟书',1,'2022-01-05 00:00:00',36,'讽刺与幽默并存的现代文学作品。',18,18),('978-7-5302-1334-2','P003','活着','小说','余华',1,'2022-01-06 00:00:00',28,'普通人在苦难中求生的故事。',12,12),('978-7-5399-5479-2','P001','三国演义','小说','罗贯中',1,'2022-01-04 00:00:00',55,'三国时代的英雄豪杰故事。',25,25),('978-7-5442-5742-0','P005','解忧杂货店','小说','东野圭吾',1,'2022-01-10 00:00:00',39.5,'一个神秘杂货店的奇幻故事。',10,10),('978-7-80655-418-7','P004','白夜行','小说','东野圭吾',1,'2022-01-08 00:00:00',39.8,'一部展现人性阴暗面的推理小说。',22,22);
/*!40000 ALTER TABLE `book_info` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-26 15:35:18
