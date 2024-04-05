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
-- Table structure for table `cuenta_usuario`
--

DROP TABLE IF EXISTS `cuenta_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cuenta_usuario` (
  `idUsuario` varchar(30) NOT NULL,
  `idInventario` varchar(20) NOT NULL,
  `idEstadisticas_Base` varchar(20) NOT NULL,
  `Monedas` int DEFAULT NULL,
  `Experiencia` int DEFAULT NULL,
  `Energia` int DEFAULT NULL,
  `Tiempo_Juego_Mins` int DEFAULT NULL,
  PRIMARY KEY (`idUsuario`,`idInventario`,`idEstadisticas_Base`),
  KEY `fk_Cuenta_Usuario_Usuario1_idx` (`idUsuario`),
  KEY `fk_Cuenta_Usuario_Inventario_Usuario1_idx` (`idInventario`),
  KEY `fk_Cuenta_Usuario_Estadisticas_Base1_idx` (`idEstadisticas_Base`),
  CONSTRAINT `fk_Cuenta_Usuario_Estadisticas_Base1` FOREIGN KEY (`idEstadisticas_Base`) REFERENCES `estadisticas_base` (`idEstadisticas_Base`),
  CONSTRAINT `fk_Cuenta_Usuario_Inventario_Usuario1` FOREIGN KEY (`idInventario`) REFERENCES `inventario_usuario` (`idInventario_Usuario`),
  CONSTRAINT `fk_Cuenta_Usuario_Usuario1` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cuenta_usuario`
--

LOCK TABLES `cuenta_usuario` WRITE;
/*!40000 ALTER TABLE `cuenta_usuario` DISABLE KEYS */;
INSERT INTO `cuenta_usuario` VALUES ('AdnCrazy','INV_AdnCrazy','SB_AdnCrazy',100,0,100,0),('AñadirNuevo','INV_AñadirNuevo','SB_AñadirNuevo',100,0,100,0),('AswagerKgzK','INV_AswagerKgzK','SB_AswagerKgzK',110,10,90,2),('ckau','INV_ckau','SB_ckau',100,0,100,0),('ImKaos','INV_ImKaos','SB_ImKaos',100,0,100,0),('Magda','INV_Magda','SB_Magda',100,0,100,0),('MikeSlovak','INV_MikeSlovak','SB_MikeSlovak',100,0,100,0),('ProbandoNuevo','INV_ProbandoNuevo','SB_ProbandoNuevo',100,0,100,0),('ProbandoReg','INV_ProbandoReg','SB_ProbandoReg',100,0,100,0);
/*!40000 ALTER TABLE `cuenta_usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-04-04  6:56:54
