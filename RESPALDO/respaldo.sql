-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: proyecto
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
-- Table structure for table `altas`
--

DROP TABLE IF EXISTS `altas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `altas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `idproducto` int NOT NULL,
  `nombreproducto` varchar(45) NOT NULL,
  `cantidad` int NOT NULL,
  `fecha` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `total` double DEFAULT '0',
  PRIMARY KEY (`id`),
  KEY `idproducto_idx` (`idproducto`),
  CONSTRAINT `fk_idproducto` FOREIGN KEY (`idproducto`) REFERENCES `producto` (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `altas`
--

LOCK TABLES `altas` WRITE;
/*!40000 ALTER TABLE `altas` DISABLE KEYS */;
INSERT INTO `altas` VALUES (5,1,'Papitas',5,'2022-05-27 21:49:22',50),(8,1,'Papitas',1,'2022-05-27 21:55:10',10),(12,1,'Papitas',2,'2022-05-27 22:02:14',20),(13,1,'Papitas',2,'2022-05-27 22:03:13',20),(14,1,'Papitas',5,'2022-05-27 22:06:05',50),(15,1,'Papitas',2,'2022-05-27 22:09:15',20),(16,1,'Papitas',2,'2022-05-27 22:12:48',20);
/*!40000 ALTER TABLE `altas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `codigo` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `apellidos` varchar(45) NOT NULL,
  `numero_telefono` bigint NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (2,'Jose','Perez',3318630423),(5,'Fernando','Castillo',3318202203);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producto` (
  `codigo` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(45) NOT NULL,
  `descripcion` varchar(45) NOT NULL,
  `precio` int NOT NULL,
  `existencia` int NOT NULL,
  `coste` varchar(45) NOT NULL DEFAULT 'precio*1.5',
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,'Papitas','Papas fritas',10,10,'5'),(2,'Tortillas','Tortilla de maiz de 1kg',38,9,'19'),(3,'Coca cola','Refresco de cola de 1lt',20,1,'10'),(4,'Pepsi','Refresco de cola de 1lt',20,3,'12'),(5,'Carlos V','Barra de chocolate chica.',7,4,'5');
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `actualizarventa` BEFORE UPDATE ON `producto` FOR EACH ROW BEGIN 
IF NEW.existencia < old.existencia
	THEN 
	INSERT INTO venta (producto,nombre_producto,cantidad, total) Values (new.codigo,new.nombre,(old.existencia - new.existencia),(old.existencia - new.existencia)*(new.precio));
END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `actualizaALtas` AFTER UPDATE ON `producto` FOR EACH ROW BEGIN
IF NEW.existencia > old.existencia
	THEN 
	INSERT INTO altas (idproducto,nombreproducto,cantidad, total) Values (new.codigo,new.nombre,(new.existencia - old.existencia),(new.existencia - old.existencia)*(new.precio));
END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `proveedor` (
  `codigo` int NOT NULL AUTO_INCREMENT,
  `marca` varchar(45) NOT NULL,
  `cod_producto` int NOT NULL,
  `numero_telefono` int NOT NULL,
  PRIMARY KEY (`codigo`),
  UNIQUE KEY `marca` (`marca`),
  KEY `proveedor_ibfk_1` (`cod_producto`),
  CONSTRAINT `proveedor_ibfk_1` FOREIGN KEY (`cod_producto`) REFERENCES `producto` (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES (1,'Sabritas',1,33167),(2,'Tortillas del campo',2,3343034),(3,'COCA COLA',3,432332),(4,'´Pepsico',4,343325),(5,'Nestle',5,33435345);
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `venta`
--

DROP TABLE IF EXISTS `venta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `venta` (
  `n_compra` int NOT NULL AUTO_INCREMENT,
  `producto` int NOT NULL,
  `nombre_producto` varchar(45) NOT NULL,
  `cantidad` int NOT NULL,
  `fecha` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `total` double NOT NULL,
  PRIMARY KEY (`n_compra`),
  KEY `compra_ibfk_1_idx` (`producto`),
  CONSTRAINT `venta_ibfk_1` FOREIGN KEY (`producto`) REFERENCES `producto` (`codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `venta`
--

LOCK TABLES `venta` WRITE;
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
INSERT INTO `venta` VALUES (1,2,'Tortillas',2,'2022-05-14 20:29:23',0),(3,3,'Coca cola',-2,'2022-05-27 18:50:29',-40),(4,3,'Coca cola',1,'2022-05-27 18:51:59',20),(5,3,'Coca cola',2,'2022-05-27 18:52:04',40),(6,1,'Papitas',5,'2022-05-27 21:00:13',50),(7,1,'Papitas',1,'2022-05-27 21:40:34',10),(8,1,'Papitas',18,'2022-05-27 22:02:35',180),(9,1,'Papitas',5,'2022-05-27 22:14:23',50);
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'proyecto'
--

--
-- Dumping routines for database 'proyecto'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-05-27 22:54:47
