/*
SQLyog Community Edition- MySQL GUI v6.03
Host - 5.5.16-log : Database - idb
*********************************************************************
Server version : 5.5.16-log
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

create database if not exists `idb`;

USE `idb`;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

/*Table structure for table `lane` */

DROP TABLE IF EXISTS `lane`;

CREATE TABLE `lane` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `lane_name` varchar(45) DEFAULT NULL,
  `ip` varchar(45) DEFAULT NULL,
  `port` varchar(45) DEFAULT '4370',
  `machine_number` varchar(45) DEFAULT NULL,
  `status` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Data for the table `lane` */

insert  into `lane`(`id`,`lane_name`,`ip`,`port`,`machine_number`,`status`) values (1,'ENTRY-1','10.11.12.246','4370','1','1'),(2,'EXIT-1','10.11.12.63','4370','1','1');

/*Table structure for table `logs` */

DROP TABLE IF EXISTS `logs`;

CREATE TABLE `logs` (
  `id` bigint(255) NOT NULL AUTO_INCREMENT,
  `dt` datetime DEFAULT NULL,
  `cardcode` varchar(255) DEFAULT NULL,
  `personnel_name` varchar(255) DEFAULT NULL,
  `personnel_type` varchar(255) DEFAULT NULL,
  `lane` varchar(255) DEFAULT NULL,
  `tapstatus` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=52 DEFAULT CHARSET=latin1;

/*Data for the table `logs` */

insert  into `logs`(`id`,`dt`,`cardcode`,`personnel_name`,`personnel_type`,`lane`,`tapstatus`) values (1,'2022-07-21 10:33:36','383591065','MARK ALDRIN T. HERNANDEZ','Officer','ENTRY-1','Access Authorized'),(2,'2022-07-21 10:33:37','383591065','MARK ALDRIN T. HERNANDEZ','Officer','EXIT-1','Access Authorized'),(3,'2022-07-21 10:33:47','384215897','','','ENTRY-1','Access Denied'),(4,'2022-07-21 10:33:48','384215897','','','EXIT-1','Access Denied'),(5,'2022-07-21 10:34:32','383591065','MARK ALDRIN T. HERNANDEZ','Officer','ENTRY-1','Access Authorized'),(6,'2022-07-21 10:34:35','384215897','','','EXIT-1','Access Denied'),(7,'2022-07-21 10:34:38','383591065','MARK ALDRIN T. HERNANDEZ','Officer','ENTRY-1','Access Authorized'),(8,'2022-07-21 10:34:39','383591065','MARK ALDRIN T. HERNANDEZ','Officer','EXIT-1','Access Authorized'),(9,'2022-07-21 10:37:51','384215897','','','ENTRY-1','Access Denied'),(10,'2022-07-21 10:37:55','384215897','','','EXIT-1','Access Denied'),(11,'2022-07-21 10:38:14','383591065','MARK ALDRIN T. HERNANDEZ','Officer','ENTRY-1','Access Authorized'),(12,'2022-07-21 10:38:18','383591065','MARK ALDRIN T. HERNANDEZ','Officer','EXIT-1','Access Authorized'),(13,'2022-07-21 10:38:23','384215897','','','ENTRY-1','Access Denied'),(14,'2022-07-21 10:38:28','383591065','MARK ALDRIN T. HERNANDEZ','Officer','EXIT-1','Access Authorized'),(15,'2022-07-21 10:38:31','384215897','','','EXIT-1','Access Denied'),(16,'2022-07-21 10:39:20','383591065','MARK ALDRIN T. HERNANDEZ','Officer','ENTRY-1','Access Authorized'),(17,'2022-07-21 10:39:25','383591065','MARK ALDRIN T. HERNANDEZ','Officer','ENTRY-1','Access Authorized'),(18,'2022-07-21 10:39:28','384215897','','','EXIT-1','Access Denied'),(19,'2022-07-21 10:40:12','383591065','MARK ALDRIN T. HERNANDEZ','Officer','ENTRY-1','Access Authorized'),(20,'2022-07-21 10:40:19','383591065','MARK ALDRIN T. HERNANDEZ','Officer','EXIT-1','Access Authorized'),(21,'2022-07-21 10:40:23','384215897','','','ENTRY-1','Access Denied'),(22,'2022-07-21 10:40:27','384215897','','','EXIT-1','Access Denied'),(23,'2022-07-21 11:32:51','383591065','MARK ALDRIN T. HERNANDEZ','Officer','ENTRY-1','Access Authorized'),(24,'2022-07-21 11:32:53','383591065','MARK ALDRIN T. HERNANDEZ','Officer','EXIT-1','Access Authorized'),(25,'2022-07-21 11:32:57','384215897','','','ENTRY-1','Access Denied'),(26,'2022-07-21 11:32:58','384215897','','','EXIT-1','Access Denied'),(27,'2022-07-21 11:33:01','383591065','MARK ALDRIN T. HERNANDEZ','Officer','ENTRY-1','Access Authorized'),(28,'2022-07-21 11:33:03','383591065','MARK ALDRIN T. HERNANDEZ','Officer','EXIT-1','Access Authorized'),(29,'2022-07-21 11:33:06','384215897','','','ENTRY-1','Access Denied'),(30,'2022-07-21 11:33:07','384215897','','','EXIT-1','Access Denied'),(31,'2022-07-21 11:33:12','384215897','','','ENTRY-1','Access Denied'),(32,'2022-07-21 11:33:16','383591065','MARK ALDRIN T. HERNANDEZ','Officer','ENTRY-1','Access Authorized'),(33,'2022-07-21 11:33:22','383591065','MARK ALDRIN T. HERNANDEZ','Officer','EXIT-1','Access Authorized'),(34,'2022-07-21 11:33:24','383591065','MARK ALDRIN T. HERNANDEZ','Officer','ENTRY-1','Access Authorized'),(35,'2022-07-21 11:33:29','384215897','','','ENTRY-1','Access Denied'),(36,'2022-07-21 11:33:37','383591065','MARK ALDRIN T. HERNANDEZ','Officer','ENTRY-1','Access Authorized'),(37,'2022-07-21 11:33:45','383591065','MARK ALDRIN T. HERNANDEZ','Officer','ENTRY-1','Access Authorized'),(38,'2022-07-26 14:59:30','2788463884','','','ENTRY-1','Access Denied'),(39,'2022-07-26 15:00:22','2788463884','ARDI S DABO','Officer','ENTRY-1','Access Authorized'),(40,'2022-07-26 15:00:36','2788463884','ARDI S DABO','Officer','ENTRY-1','Access Authorized'),(41,'2022-07-26 15:00:44','2788463884','ARDI S DABO','Officer','ENTRY-1','Access Authorized'),(42,'2022-07-26 15:00:57','2788463884','ARDI S DABO','Officer','ENTRY-1','Access Expired'),(43,'2022-07-26 15:01:01','2788463884','ARDI S DABO','Officer','ENTRY-1','Access Expired'),(44,'2022-07-26 15:01:50','2788463884','ARDI S DABO','Officer','ENTRY-1','Access Expired'),(45,'2022-07-26 15:01:53','2788463884','ARDI S DABO','Officer','ENTRY-1','Access Expired'),(46,'2022-07-26 15:02:49','2788463884','ARDI S DABO','Officer','ENTRY-1','Access Expired'),(47,'2022-07-26 15:03:42','2788463884','ARDI S DABO','Officer','ENTRY-1','Access Expired'),(48,'2022-07-26 15:03:44','2788463884','ARDI S DABO','Officer','ENTRY-1','Access Expired'),(49,'2022-07-26 15:03:48','2788463884','ARDI S DABO','Officer','ENTRY-1','Access Expired'),(50,'2022-07-26 15:03:57','2788463884','ARDI S DABO','Officer','ENTRY-1','Access Authorized'),(51,'2022-07-26 15:04:02','2788463884','ARDI S DABO','Officer','ENTRY-1','Access Authorized');

/*Table structure for table `office` */

DROP TABLE IF EXISTS `office`;

CREATE TABLE `office` (
  `id` bigint(255) NOT NULL AUTO_INCREMENT,
  `office` varchar(255) DEFAULT NULL,
  `dt` datetime DEFAULT NULL,
  `admin` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `office` */

insert  into `office`(`id`,`office`,`dt`,`admin`) values (1,'PRESIDENT\'S OFFICE',NULL,NULL),(2,'VP DEPT',NULL,NULL),(3,'IT DEPT',NULL,NULL);

/*Table structure for table `personnel` */

DROP TABLE IF EXISTS `personnel`;

CREATE TABLE `personnel` (
  `id` bigint(255) NOT NULL AUTO_INCREMENT,
  `ateillaid` varchar(255) DEFAULT NULL,
  `personneltype` varchar(255) DEFAULT NULL,
  `lastname` varchar(255) DEFAULT NULL,
  `firstname` varchar(255) DEFAULT NULL,
  `middleinitial` varchar(255) DEFAULT NULL,
  `rank` varchar(255) DEFAULT NULL,
  `brofsvc` varchar(255) DEFAULT NULL,
  `unit` varchar(255) DEFAULT NULL,
  `position` varchar(255) DEFAULT NULL,
  `category` varchar(255) DEFAULT NULL,
  `tagaccessno` varchar(255) DEFAULT NULL,
  `smartcardno` varchar(255) DEFAULT NULL,
  `dateissued` datetime DEFAULT NULL,
  `expiration` datetime DEFAULT NULL,
  `remarks1` text,
  `remarks2` text,
  `release` tinyint(1) DEFAULT NULL,
  `photo` varchar(255) DEFAULT NULL,
  `AP` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

/*Data for the table `personnel` */

insert  into `personnel`(`id`,`ateillaid`,`personneltype`,`lastname`,`firstname`,`middleinitial`,`rank`,`brofsvc`,`unit`,`position`,`category`,`tagaccessno`,`smartcardno`,`dateissued`,`expiration`,`remarks1`,`remarks2`,`release`,`photo`,`AP`) values (1,'2345','Officer','DABO','ARDI','S','EPIC 1','WEWRE','REWREWR','ERRTER','RERE','123232','2788463884','2022-07-26 00:00:00','2022-11-19 00:00:00','wewew','ewewew',1,'a.png',0),(2,'3435','Officer','WERRWEQ','DERWEWREW','WEQERWRWE','EWREREREW','','','','','34343','2322','2022-07-26 00:00:00','2022-11-19 00:00:00','','',1,'TechContactless.png',0),(3,'3455','Civilian Employee','A','B','B','B','B','B','B','B','12121','121213232','2022-07-26 00:00:00','2022-11-26 00:00:00','ewew','rerer',1,'contactless-payment.png',0),(4,'3455','Civilian Employee','QWEEW','RERERE','E','R','EWQEWE','EWEW','WEWE','EWEW','23232','2323322','2022-07-26 00:00:00','2022-12-26 00:00:00','rewr','rer',0,'notification-network-wireless-disconnected-icon.png',0);

/*Table structure for table `purpose` */

DROP TABLE IF EXISTS `purpose`;

CREATE TABLE `purpose` (
  `id` bigint(255) NOT NULL AUTO_INCREMENT,
  `purpose` varchar(255) DEFAULT NULL,
  `dt` datetime DEFAULT NULL,
  `admin` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

/*Data for the table `purpose` */

insert  into `purpose`(`id`,`purpose`,`dt`,`admin`) values (1,'OFFICIAL BUSINESS',NULL,NULL),(2,'VISITING',NULL,NULL),(3,'MEETING',NULL,NULL),(4,'PICkUP',NULL,NULL);

/*Table structure for table `terminal` */

DROP TABLE IF EXISTS `terminal`;

CREATE TABLE `terminal` (
  `id` bigint(255) NOT NULL AUTO_INCREMENT,
  `driver` varchar(255) DEFAULT NULL,
  `ip` varchar(255) DEFAULT NULL,
  `port` varchar(255) DEFAULT NULL,
  `uid` varchar(255) DEFAULT NULL,
  `pwd` varchar(255) DEFAULT NULL,
  `db` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Data for the table `terminal` */

insert  into `terminal`(`id`,`driver`,`ip`,`port`,`uid`,`pwd`,`db`) values (1,'{mySQL ODBC 5.1 Driver}','10.11.12.215','3306','isa','1saIT2k18','idb'),(2,'{mySQL ODBC 5.1 Driver}','192.168.1.193','3306','root','sa','idb');

/*Table structure for table `user` */

DROP TABLE IF EXISTS `user`;

CREATE TABLE `user` (
  `id` bigint(255) NOT NULL AUTO_INCREMENT,
  `fullname` varchar(255) DEFAULT NULL,
  `username` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `usercontrol` varchar(255) DEFAULT NULL,
  `status` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `user` */

/*Table structure for table `vcard` */

DROP TABLE IF EXISTS `vcard`;

CREATE TABLE `vcard` (
  `id` bigint(255) NOT NULL AUTO_INCREMENT,
  `tagno` varchar(255) DEFAULT NULL,
  `cardcode` varchar(255) DEFAULT NULL,
  `dt` datetime DEFAULT NULL,
  `admin` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Data for the table `vcard` */

insert  into `vcard`(`id`,`tagno`,`cardcode`,`dt`,`admin`) values (1,'1234','232323232','2022-07-25 20:36:43',''),(2,'9876','2788463884','2022-07-26 08:09:36','');

/*Table structure for table `visitor` */

DROP TABLE IF EXISTS `visitor`;

CREATE TABLE `visitor` (
  `id` bigint(255) NOT NULL AUTO_INCREMENT,
  `dt` datetime DEFAULT NULL,
  `tagid` varchar(255) DEFAULT NULL,
  `cardcode` varchar(255) DEFAULT NULL,
  `visitorname` varchar(255) DEFAULT NULL,
  `contact` varchar(255) DEFAULT NULL,
  `officevisit` varchar(255) DEFAULT NULL,
  `purpose` varchar(255) DEFAULT NULL,
  `admin` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

/*Data for the table `visitor` */

/*Table structure for table `visitor_logs` */

DROP TABLE IF EXISTS `visitor_logs`;

CREATE TABLE `visitor_logs` (
  `id` bigint(255) NOT NULL AUTO_INCREMENT,
  `tagid` varchar(255) DEFAULT NULL,
  `cardcode` varchar(255) DEFAULT NULL,
  `visitorname` varchar(255) DEFAULT NULL,
  `contact` varchar(255) DEFAULT NULL,
  `officevisit` varchar(255) DEFAULT NULL,
  `purpose` varchar(255) DEFAULT NULL,
  `admin` varchar(255) DEFAULT NULL,
  `dt_in` datetime DEFAULT NULL,
  `dt_out` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Data for the table `visitor_logs` */

insert  into `visitor_logs`(`id`,`tagid`,`cardcode`,`visitorname`,`contact`,`officevisit`,`purpose`,`admin`,`dt_in`,`dt_out`) values (1,'1234','232323232','ARIANA GRANDE','LADY GAGA','RAIN','ON ME','','2022-07-25 22:41:20',NULL),(2,'1234','232323232','SAM SMITH','DEMI LOVATO','BELIVER','LONELY','','2022-07-25 23:05:17','2022-07-25 23:05:25');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
