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
-- Table structure for table `planta`
--

DROP TABLE IF EXISTS `planta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `planta` (
  `idPlanta` varchar(20) NOT NULL,
  `idUsuario` varchar(30) NOT NULL,
  `idTipo_Planta` varchar(20) NOT NULL,
  `idFruto_Planta` varchar(20) NOT NULL,
  `Tiempo_Para_Crecer` int DEFAULT NULL,
  `Tiempo_por_Cosecha` int DEFAULT NULL,
  `Cosecha_Actual` int DEFAULT NULL,
  `Maximo_Cosecha` int DEFAULT NULL,
  PRIMARY KEY (`idPlanta`,`idUsuario`,`idTipo_Planta`,`idFruto_Planta`),
  KEY `fk_Planta_Tipo_Planta1_idx` (`idTipo_Planta`),
  KEY `fk_Planta_Fruto_Planta1_idx` (`idFruto_Planta`),
  KEY `fk_Planta_Cuenta_Usuario1_idx` (`idUsuario`),
  CONSTRAINT `fk_Planta_Cuenta_Usuario1` FOREIGN KEY (`idUsuario`) REFERENCES `cuenta_usuario` (`idUsuario`),
  CONSTRAINT `fk_Planta_Fruto_Planta1` FOREIGN KEY (`idFruto_Planta`) REFERENCES `fruto_planta` (`idFruto_Planta`),
  CONSTRAINT `fk_Planta_Tipo_Planta1` FOREIGN KEY (`idTipo_Planta`) REFERENCES `tipo_planta` (`idTipo_Planta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `planta`
--

LOCK TABLES `planta` WRITE;
/*!40000 ALTER TABLE `planta` DISABLE KEYS */;
/*!40000 ALTER TABLE `planta` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-04-04  6:56:49
