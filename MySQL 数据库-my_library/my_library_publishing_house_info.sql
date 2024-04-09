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
-- Table structure for table `publishing_house_info`
--

DROP TABLE IF EXISTS `publishing_house_info`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `publishing_house_info` (
  `PID` varchar(10) NOT NULL,
  `PName` varchar(20) NOT NULL,
  `ConPerson` varchar(20) DEFAULT NULL,
  `ConPhone` varchar(11) DEFAULT NULL,
  `Fax` varchar(20) DEFAULT NULL,
  `Province` varchar(10) DEFAULT NULL,
  `City` varchar(10) DEFAULT NULL,
  `District` varchar(10) DEFAULT NULL,
  `Street` varchar(10) DEFAULT NULL,
  `HouseNum` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`PID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `publishing_house_info`
--

LOCK TABLES `publishing_house_info` WRITE;
/*!40000 ALTER TABLE `publishing_house_info` DISABLE KEYS */;
INSERT INTO `publishing_house_info` VALUES ('P001','人民出版社','张经理','13812345678','010-1234567','北京','北京','朝阳区','建国路','123号'),('P002','清华大学出版社','王总编','13998765432','010-9876543','北京','北京','海淀区','中关村','456号'),('P003','上海文艺出版社','李出版','13678901234','021-5678901','上海','上海','黄浦区','南京东路','789号'),('P004','湖南文艺出版社','陈总','18765432109','0731-3456789','湖南','长沙','岳麓区','桐梓坡路','345号'),('P005','四川人民出版社','刘总编','18345678901','028-8901234','四川','成都','武侯区','锦里西路','567号');
/*!40000 ALTER TABLE `publishing_house_info` ENABLE KEYS */;
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
