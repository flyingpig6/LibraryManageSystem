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
-- Table structure for table `library_book_info`
--

DROP TABLE IF EXISTS `library_book_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `library_book_info` (
  `BID` varchar(10) NOT NULL,
  `ISBN` varchar(20) DEFAULT NULL,
  `StorageTime` datetime DEFAULT NULL,
  `BookState` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`BID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `library_book_info`
--

LOCK TABLES `library_book_info` WRITE;
/*!40000 ALTER TABLE `library_book_info` DISABLE KEYS */;
INSERT INTO `library_book_info` VALUES ('LB001','978-7-02-014746-6','2024-01-01 10:00:00','可借'),('LB002','978-7-01-000922-9','2024-01-02 10:00:00','可借'),('LB003','978-7-02-000220-7','2024-01-03 10:00:00','可借'),('LB004','978-7-5399-5479-2','2024-01-04 10:00:00','可借'),('LB005','978-7-5063-7330-2','2024-01-05 10:00:00','可借'),('LB006','978-7-5302-1334-2','2024-01-06 10:00:00','已借出'),('LB007','978-7-020-05065-0','2024-01-07 10:00:00','可借'),('LB008','978-7-80655-418-7','2024-01-08 10:00:00','可借'),('LB009','978-7-02-009459-4','2024-01-09 10:00:00','可借'),('LB010','978-7-5442-5742-0','2024-01-10 10:00:00','已借出'),('LB011','978-7-02-014746-6','2024-01-11 10:00:00','可借'),('LB012','978-7-01-000922-9','2024-01-12 10:00:00','已借出'),('LB013','978-7-02-000220-7','2024-01-13 10:00:00','损坏'),('LB014','978-7-5399-5479-2','2024-01-14 10:00:00','丢失'),('LB015','978-7-5063-7330-2','2024-01-15 10:00:00','可借'),('LB016','978-7-5302-1334-2','2024-01-16 10:00:00','已借出'),('LB017','978-7-020-05065-0','2024-01-17 10:00:00','损坏'),('LB018','978-7-80655-418-7','2024-01-18 10:00:00','可借'),('LB019','978-7-02-009459-4','2024-01-19 10:00:00','可借'),('LB020','978-7-5442-5742-0','2024-01-20 10:00:00','已借出'),('LB021','978-7-02-014746-6','2024-01-21 10:00:00','可借'),('LB022','978-7-01-000922-9','2024-01-22 10:00:00','已借出'),('LB023','978-7-02-000220-7','2024-01-23 10:00:00','损坏'),('LB024','978-7-5399-5479-2','2024-01-24 10:00:00','丢失'),('LB025','978-7-5063-7330-2','2024-01-25 10:00:00','可借'),('LB026','978-7-5302-1334-2','2024-01-26 10:00:00','已借出'),('LB027','978-7-020-05065-0','2024-01-27 10:00:00','可借'),('LB028','978-7-80655-418-7','2024-01-28 10:00:00','可借'),('LB029','978-7-02-009459-4','2024-01-29 10:00:00','可借'),('LB030','978-7-5442-5742-0','2024-01-30 10:00:00','已借出'),('LB031','978-7-02-014746-6','2024-01-31 10:00:00','可借'),('LB032','978-7-01-000922-9','2024-02-01 10:00:00','已借出'),('LB033','978-7-02-000220-7','2024-02-02 10:00:00','损坏'),('LB034','978-7-5399-5479-2','2024-02-03 10:00:00','丢失'),('LB035','978-7-5063-7330-2','2024-02-04 10:00:00','可借'),('LB036','978-7-5302-1334-2','2024-02-05 10:00:00','已借出'),('LB037','978-7-020-05065-0','2024-02-06 10:00:00','损坏'),('LB038','978-7-80655-418-7','2024-02-07 10:00:00','可借'),('LB039','978-7-02-009459-4','2024-02-08 10:00:00','可借'),('LB040','978-7-5442-5742-0','2024-02-09 10:00:00','已借出'),('LB041','978-7-02-014746-6','2024-02-10 10:00:00','可借'),('LB042','978-7-01-000922-9','2024-02-11 10:00:00','已借出'),('LB043','978-7-02-000220-7','2024-02-12 10:00:00','可借'),('LB044','978-7-5399-5479-2','2024-02-13 10:00:00','可借'),('LB045','978-7-5063-7330-2','2024-02-14 10:00:00','可借'),('LB046','978-7-5302-1334-2','2024-02-15 10:00:00','已借出'),('LB047','978-7-020-05065-0','2024-02-16 10:00:00','损坏'),('LB048','978-7-80655-418-7','2024-02-17 10:00:00','可借'),('LB049','978-7-02-009459-4','2024-02-18 10:00:00','可借'),('LB050','978-7-5442-5742-0','2024-02-19 10:00:00','已借出'),('LB051','978-7-02-000220-7','2024-01-26 09:40:08','可借');
/*!40000 ALTER TABLE `library_book_info` ENABLE KEYS */;
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
