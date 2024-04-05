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
-- Table structure for table `registro_actividad`
--

DROP TABLE IF EXISTS `registro_actividad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `registro_actividad` (
  `idRegistro` varchar(12) NOT NULL,
  `idUsuario` varchar(20) DEFAULT NULL,
  `Descripcion` varchar(320) DEFAULT NULL,
  `Fecha_Actividad` datetime DEFAULT NULL,
  PRIMARY KEY (`idRegistro`),
  KEY `idUsuario` (`idUsuario`),
  CONSTRAINT `registro_actividad_ibfk_1` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `registro_actividad`
--

LOCK TABLES `registro_actividad` WRITE;
/*!40000 ALTER TABLE `registro_actividad` DISABLE KEYS */;
INSERT INTO `registro_actividad` VALUES ('1','AswagerKgzK','Probando Funcionalidad','2024-03-30 23:01:00'),('10','AswagerKgzK','Ha Exportado el reporte de Registros','2024-03-31 21:58:19'),('11','AswagerKgzK','Ha iniciado sesión.','2024-03-31 22:03:34'),('12','AswagerKgzK','Ha Exportado el reporte de Registros','2024-03-31 22:04:54'),('13','AswagerKgzK','Ha iniciado sesión.','2024-03-31 23:07:40'),('14','AswagerKgzK','Ha iniciado sesión.','2024-04-02 02:16:55'),('15','AswagerKgzK','Ha iniciado sesión.','2024-04-02 02:19:46'),('16','AswagerKgzK','Ha iniciado sesión.','2024-04-02 02:51:45'),('17','AswagerKgzK','Ha iniciado sesión.','2024-04-02 02:55:01'),('18','AswagerKgzK','Ha iniciado sesión.','2024-04-02 03:03:14'),('19','MikeSlovak','Ha iniciado sesión.','2024-04-02 09:48:56'),('2','AswagerKgzK','Ha iniciado sesión.','2024-03-31 19:53:17'),('20','MikeSlovak','Ha iniciado sesión.','2024-04-02 09:51:44'),('21','AswagerKgzK','Ha iniciado sesión.','2024-04-02 10:06:59'),('22','AswagerKgzK','Ha Exportado el registro de Usuarios','2024-04-02 10:08:11'),('23','AswagerKgzK','Ha iniciado sesión.','2024-04-02 14:10:17'),('24','MikeSlovak','Ha iniciado sesión.','2024-04-03 13:36:19'),('25','AswagerKgzK','Ha iniciado sesión.','2024-04-04 02:55:44'),('26','AswagerKgzK','Ha iniciado sesión.','2024-04-04 02:59:58'),('3','AswagerKgzK','Ha iniciado sesión.','2024-03-31 21:26:21'),('4','AswagerKgzK','Ha iniciado sesión.','2024-03-31 21:36:33'),('5','AswagerKgzK','Ha iniciado sesión.','2024-03-31 21:38:44'),('6','AswagerKgzK','Ha iniciado sesión.','2024-03-31 21:40:18'),('7','AswagerKgzK','Ha iniciado sesión.','2024-03-31 21:42:02'),('8','AswagerKgzK','Ha iniciado sesión.','2024-03-31 21:56:11'),('9','AswagerKgzK','Ha iniciado sesión.','2024-03-31 21:57:42');
/*!40000 ALTER TABLE `registro_actividad` ENABLE KEYS */;
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
