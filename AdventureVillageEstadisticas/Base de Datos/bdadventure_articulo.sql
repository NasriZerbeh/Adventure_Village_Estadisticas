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
-- Table structure for table `articulo`
--

DROP TABLE IF EXISTS `articulo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `articulo` (
  `idArticulo` varchar(20) NOT NULL,
  `Nombre_Articulo` varchar(45) DEFAULT NULL,
  `Url_Imagen` varchar(200) DEFAULT NULL,
  `idTipo` varchar(20) NOT NULL,
  `idTipo_Stats` varchar(20) DEFAULT NULL,
  `Cantidad_Stats` int DEFAULT NULL,
  `idModo_Stats` varchar(20) DEFAULT NULL,
  `Activo` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idArticulo`,`idTipo`),
  KEY `fk_Articulo_Tipo_Articulo1_idx` (`idTipo`),
  KEY `idTipo_Stats` (`idTipo_Stats`),
  KEY `idModo_Stats` (`idModo_Stats`),
  CONSTRAINT `articulo_ibfk_1` FOREIGN KEY (`idTipo_Stats`) REFERENCES `tipo_stats` (`idTipo_Stats`),
  CONSTRAINT `articulo_ibfk_2` FOREIGN KEY (`idModo_Stats`) REFERENCES `modo_stats` (`idModo_Stats`),
  CONSTRAINT `fk_Articulo_Tipo_Articulo1` FOREIGN KEY (`idTipo`) REFERENCES `tipo_articulo` (`idTipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `articulo`
--

LOCK TABLES `articulo` WRITE;
/*!40000 ALTER TABLE `articulo` DISABLE KEYS */;
INSERT INTO `articulo` VALUES ('aa','Planta de patio','D:\\AdventureVillageEstadisticas\\AdventureVillageEstadisticas\\bin\\ImagenesOpenFile\\Articulos\\aa.png','TIPO_VESTIMENTA','TIPO_DEFENSIVO',20,'MODO_PUNTOS',0),('BOTON_VERDE','Boton de Confirmar','D:\\AdventureVillageEstadisticas\\AdventureVillageEstadisticas\\ImagenesOpenFile\\Articulos\\BOTON_VERDE.png','TIPO_BOTAS','TIPO_DEFENSIVO',10,'MODO_PORCENTAJE',1),('GATO_BERENJENA','Arturo The Mich','D:\\AdventureVillageEstadisticas\\AdventureVillageEstadisticas\\ImagenesOpenFile\\Articulos\\GATO_BERENJENA.png','TIPO_VESTIMENTA','TIPO_DEFENSIVO',90,'MODO_PORCENTAJE',1),('PLANTA_HOGAR_001','Planta de Hogar','D:\\AdventureVillageEstadisticas\\AdventureVillageEstadisticas\\ImagenesOpenFile\\Articulos\\PLANTA_HOGAR_001.png','TIPO_COMESTIBLE','TIPO_REGENERATIVO',12,'MODO_PUNTOS',1),('TABLA_DE_MADERA','Tabla de madera','D:\\AdventureVillageEstadisticas\\AdventureVillageEstadisticas\\ImagenesOpenFile\\Articulos\\TABLA_DE_MADERA.png','TIPO_ARMA','TIPO_OFENSIVO',13,'MODO_PUNTOS',1);
/*!40000 ALTER TABLE `articulo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-04-04  6:56:47
