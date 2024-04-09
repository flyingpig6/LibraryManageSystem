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
-- Table structure for table `reader_info`
--

DROP TABLE IF EXISTS `reader_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reader_info` (
  `RID` varchar(10) NOT NULL,
  `RPWD` varchar(10) NOT NULL,
  `RTID` int NOT NULL,
  `RName` varchar(30) NOT NULL,
  `RSex` int DEFAULT NULL,
  `RPhone` varchar(11) DEFAULT NULL,
  `RegDate` datetime DEFAULT NULL,
  `ValDate` datetime DEFAULT NULL,
  `BorBookNum` int DEFAULT NULL,
  `TolBorBookNum` int DEFAULT NULL,
  `IfLost` tinyint(1) DEFAULT NULL,
  `ViolationNum` int DEFAULT NULL,
  `Remark` text,
  PRIMARY KEY (`RID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reader_info`
--

LOCK TABLES `reader_info` WRITE;
/*!40000 ALTER TABLE `reader_info` DISABLE KEYS */;
INSERT INTO `reader_info` VALUES ('R001','aaa',1,'安妮',1,'13672471681','2014-12-05 00:00:00','2015-02-16 00:00:00',2,5,0,0,''),('R002','bbb',2,'贝贝',2,'13672471682','2012-12-05 00:00:00','2013-02-16 00:00:00',2,5,0,0,''),('R003','ccc',3,'可儿',1,'13672471683','2014-12-05 00:00:00','2015-02-16 00:00:00',2,5,0,0,''),('R004','ddd',3,'东东',2,'13672471684','2014-12-05 00:00:00','2015-02-16 00:00:00',2,5,0,0,''),('R005','eee',3,'依依',1,'13672471685','2014-12-05 00:00:00','2015-02-16 00:00:00',2,5,0,0,''),('R006','aaa',1,'芳芳',1,'13672471686','2016-12-05 00:00:00','2017-02-16 00:00:00',2,5,0,0,''),('R007','bbb',3,'刚刚',2,'13672471687','2016-12-06 00:00:00','2017-02-17 00:00:00',2,5,0,0,''),('R008','ccc',3,'华华',1,'13672471688','2016-12-07 00:00:00','2017-02-18 00:00:00',2,5,0,0,''),('R009','ddd',3,'杰杰',2,'13672471689','2016-12-08 00:00:00','2017-02-19 00:00:00',2,5,0,0,''),('R010','eee',3,'坤坤',1,'13672471690','2016-12-09 00:00:00','2017-02-20 00:00:00',2,5,0,0,''),('R011','fff',1,'莉莉',2,'13672471691','2016-12-10 00:00:00','2017-02-21 00:00:00',2,5,0,0,''),('R012','ggg',3,'妙妙',1,'13672471692','2016-12-11 00:00:00','2017-02-22 00:00:00',2,5,0,0,''),('R013','hhh',2,'楠楠',2,'13672471693','2016-12-12 00:00:00','2017-02-23 00:00:00',2,5,0,0,''),('R014','iii',3,'欧欧',1,'13672471694','2016-12-13 00:00:00','2017-02-24 00:00:00',2,5,0,0,''),('R015','jjj',3,'普普',2,'13672471695','2016-12-14 00:00:00','2017-02-25 00:00:00',2,7,0,2,'');
/*!40000 ALTER TABLE `reader_info` ENABLE KEYS */;
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
