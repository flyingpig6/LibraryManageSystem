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
-- Table structure for table `overdue_fine_info`
--

DROP TABLE IF EXISTS `overdue_fine_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `overdue_fine_info` (
  `OverdueID` varchar(20) NOT NULL,
  `BorID` varchar(20) NOT NULL,
  `MID` varchar(10) NOT NULL,
  `Fine` float DEFAULT NULL,
  `IfPay` tinyint(1) DEFAULT NULL,
  `PayDate` datetime DEFAULT NULL,
  `Remark` text,
  PRIMARY KEY (`OverdueID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `overdue_fine_info`
--

LOCK TABLES `overdue_fine_info` WRITE;
/*!40000 ALTER TABLE `overdue_fine_info` DISABLE KEYS */;
INSERT INTO `overdue_fine_info` VALUES ('OVD001','BOR001','M001',3.6,1,'2023-01-15 14:30:00','已支付'),('OVD002','BOR002','M002',5.4,0,'2023-02-20 09:45:00','未支付'),('OVD003','BOR003','M003',2.8,1,'2023-03-10 16:15:00','已支付'),('OVD004','BOR004','M004',4.3,0,'2023-04-05 11:20:00','未支付'),('OVD005','BOR005','M005',3.12,1,'2023-05-18 13:55:00','已支付'),('OVD006','LB008','M001',182.5,0,NULL,NULL),('OVD007','LB008','M001',182.5,0,NULL,NULL);
/*!40000 ALTER TABLE `overdue_fine_info` ENABLE KEYS */;
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
