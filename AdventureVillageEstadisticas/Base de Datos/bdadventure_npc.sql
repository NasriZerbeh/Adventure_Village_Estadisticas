-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: bdadventure
-- ------------------------------------------------------
-- Server version	8.0.36

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
-- Table structure for table `npc`
--

DROP TABLE IF EXISTS `npc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `npc` (
  `idNPC` varchar(20) NOT NULL,
  `idZona` varchar(20) NOT NULL,
  `idEstadisticas_Base` varchar(20) NOT NULL,
  `idRelacion` varchar(20) NOT NULL,
  `Activo` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`idNPC`,`idZona`,`idEstadisticas_Base`,`idRelacion`),
  KEY `fk_NPC_Mundo1_idx` (`idZona`),
  KEY `fk_NPC_Relacion_NPC1_idx` (`idRelacion`),
  KEY `fk_NPC_Estadisticas_Base1_idx` (`idEstadisticas_Base`),
  CONSTRAINT `fk_NPC_Estadisticas_Base1` FOREIGN KEY (`idEstadisticas_Base`) REFERENCES `estadisticas_base` (`idEstadisticas_Base`),
  CONSTRAINT `fk_NPC_Mundo1` FOREIGN KEY (`idZona`) REFERENCES `zona` (`idZona`),
  CONSTRAINT `fk_NPC_Relacion_NPC1` FOREIGN KEY (`idRelacion`) REFERENCES `relacion_npc` (`idRelacion`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `npc`
--

LOCK TABLES `npc` WRITE;
/*!40000 ALTER TABLE `npc` DISABLE KEYS */;
/*!40000 ALTER TABLE `npc` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-04-04  6:56:53
