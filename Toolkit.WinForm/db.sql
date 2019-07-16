# ************************************************************
# Sequel Pro SQL dump
# Version 5446
#
# https://www.sequelpro.com/
# https://github.com/sequelpro/sequelpro
#
# Host: 127.0.0.1 (MySQL 5.7.26)
# Database: toolkit
# Generation Time: 2019-07-16 09:08:40 +0000
# ************************************************************


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
SET NAMES utf8mb4;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


# Dump of table tk_interface
# ------------------------------------------------------------

DROP TABLE IF EXISTS `tk_interface`;

CREATE TABLE `tk_interface` (
  `SID` varchar(32) NOT NULL DEFAULT '',
  `ProjectSID` varchar(255) DEFAULT NULL,
  `ApiName` varchar(255) DEFAULT NULL,
  `ApiCode` varchar(50) DEFAULT NULL,
  `ApiDesc` varchar(255) DEFAULT NULL,
  `ActionMethod` varchar(10) DEFAULT NULL,
  `ActionName` varchar(50) DEFAULT NULL,
  `ActionRoute` varchar(255) DEFAULT NULL,
  `LastDateTime` date DEFAULT NULL,
  `IsResultPaging` tinyint(4) DEFAULT NULL,
  `IsResultBool` tinyint(4) DEFAULT NULL,
  `IsResultInt` tinyint(4) DEFAULT NULL,
  `IsList` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`SID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;



# Dump of table tk_project
# ------------------------------------------------------------

DROP TABLE IF EXISTS `tk_project`;

CREATE TABLE `tk_project` (
  `SID` varchar(32) NOT NULL DEFAULT '',
  `ProjectName` varchar(255) DEFAULT NULL,
  `Namespace` varchar(255) DEFAULT NULL,
  `Version` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`SID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;



# Dump of table tk_request
# ------------------------------------------------------------

DROP TABLE IF EXISTS `tk_request`;

CREATE TABLE `tk_request` (
  `SID` varchar(32) NOT NULL DEFAULT '',
  `RelationSID` varchar(32) DEFAULT NULL,
  `FieldName` varchar(255) DEFAULT NULL,
  `FieldCode` varchar(255) DEFAULT NULL,
  `DataType` varchar(30) DEFAULT NULL,
  `DataLength` int(11) DEFAULT NULL,
  `IsAllowEmpty` tinyint(4) DEFAULT NULL,
  `IsVaild` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`SID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;



# Dump of table tk_response
# ------------------------------------------------------------

DROP TABLE IF EXISTS `tk_response`;

CREATE TABLE `tk_response` (
  `SID` varchar(32) NOT NULL DEFAULT '',
  `RelationSID` varchar(32) DEFAULT NULL,
  `FieldName` varchar(255) DEFAULT NULL,
  `FieldCode` varchar(255) DEFAULT NULL,
  `DataType` varchar(30) DEFAULT NULL,
  `DataLength` int(11) DEFAULT NULL,
  PRIMARY KEY (`SID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;




/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
