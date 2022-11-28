-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: localhost    Database: todolist
-- ------------------------------------------------------
-- Server version	8.0.18

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
-- Table structure for table `usermodel`
--

DROP TABLE IF EXISTS `usermodel`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usermodel` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Login` text,
  `Password` text,
  `RoleId` int(11) NOT NULL DEFAULT '1',
  PRIMARY KEY (`Id`),
  KEY `fk_1` (`RoleId`),
  CONSTRAINT `fk_1` FOREIGN KEY (`RoleId`) REFERENCES `userrole` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usermodel`
--

LOCK TABLES `usermodel` WRITE;
/*!40000 ALTER TABLE `usermodel` DISABLE KEYS */;
INSERT INTO `usermodel` VALUES (1,'clCxjR4B1DkpJvOddeX1zrQpHk1wKaMML0ym2k5D0SlYcw1e','clCxjR4B1DkpJvOddeX1zrQpHk1wKaMML0ym2k5D0SlYcw1d',1),(2,'clCxjR4B1DkpJvOddeX1zrQpHk1wKaMML0ym2k5D0SlYcw1q','clCxjR4B1DkpJvOddeX1zrQpHk1wKaMML0ym2k5D0SlYcw1r',1),(4,'clCxjR4B1DkpJvOddeX1zrQpHk1wKaMML0ym2k5D0SlYcw1p','tdSGeDXw601v0DbkVtLEpzuc2i8DxL9Uirz5hc5iuWAoikef',2),(5,'clCxjR4B1DkpJvOddeX1zrQpHk1wKaMML0ym2k5D0SlYcw1g','BmyVVowYGPig7IHW2E2nLXB8wY88STjXWpGrz9MmiU7ocddw',1),(6,'PyoH1rtpGr82/zwDadVWaO0ZQHWbqFT6RKnwKPMy+4gRmd0E','aEbnG8wVUIoBN5ivHtzdLJFavHae/Ybc7pucehppnSbJQTlL',1),(7,'/Or8pf2xGoVpdz+PeDG5plQSOHv+YiAQ7G9g8jMluvYGAVQX','2U9Jig2vYr5vuPCY7XnohciP+8twMwIPllH0Sy9Ms97iAb53',1),(8,'UiEtv/hNJk7qXRCu5szDj9FcAS33Zi1/dt8/r9LMb+0VFJDU','AfxfBTclGj7yjOkPrUE0DPXrOpHQNoa75CM6PRH2fPisl2c4',2),(9,'test3','iXXnHsYlGXvj5csfVr6fqAXDNqFdbEqza+NZtL6JGljj1+0P',1),(10,'admin3','PoKshdrIIBn1mLP/8WbRjb2RNBB6UmGddko/lTNA+5iveA6V',2);
/*!40000 ALTER TABLE `usermodel` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-11-29  1:29:17
