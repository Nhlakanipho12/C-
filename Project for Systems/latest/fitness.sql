-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Oct 15, 2016 at 01:26 PM
-- Server version: 10.1.13-MariaDB
-- PHP Version: 7.0.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `fitness`
--
CREATE DATABASE IF NOT EXISTS `fitness` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `fitness`;

DELIMITER $$
--
-- Procedures
--
DROP PROCEDURE IF EXISTS `GetAge`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetAge` (IN `strUser` VARCHAR(15))  BEGIN

SELECT age FROM fitness.athlete
WHERE idathlete = strUser;

END$$

DROP PROCEDURE IF EXISTS `InsertBMI`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertBMI` (IN `result` DOUBLE, IN `uname` VARCHAR(15))  BEGIN
UPDATE fitness.record
SET
bmi = result
WHERE username = uname;

END$$

DROP PROCEDURE IF EXISTS `InsertHrate`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertHrate` (IN `hrate` DOUBLE, IN `uname` VARCHAR(15))  BEGIN

UPDATE fitness.record
SET
heartrate = hrate
WHERE
 username = uname;
END$$

DROP PROCEDURE IF EXISTS `Insertspeed`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `Insertspeed` (IN `uspeed` DOUBLE, IN `udistance` DOUBLE, IN `upacetime` TIME, IN `strUser` VARCHAR(15))  BEGIN

UPDATE fitness.record
SET
speed = uspeed,
pacetime = upacetime,
distance = udistance
WHERE username = strUser;

END$$

DROP PROCEDURE IF EXISTS `InsertVOmax`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `InsertVOmax` (IN `results` DOUBLE, IN `strUser` VARCHAR(15))  BEGIN
UPDATE fitness.record
SET
vomax = results
WHERE username = strUser;
END$$

DROP PROCEDURE IF EXISTS `RegisterAthlete`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegisterAthlete` (IN `idnum` VARCHAR(15), IN `Uname` VARCHAR(15), IN `nname` VARCHAR(15), IN `Sname` VARCHAR(20), IN `digits` VARCHAR(12), IN `mail` VARCHAR(45), IN `addres` VARCHAR(45), IN `pass` VARCHAR(45), IN `btype` VARCHAR(4), IN `heIght` DOUBLE, IN `weIght` DOUBLE, IN `old` INT(2), IN `utype` VARCHAR(15))  BEGIN

INSERT INTO fitness.user
(`iduser`,
`username`,
`name`,
`surname`,
`contact`,
`email`,
`address`,
`password`,
`usertype`)
VALUES
(idnum,
Uname,
nname,
Sname,
digits,
mail,
addres,
pass,
utype);

INSERT INTO fitness.athlete
(
`bloodtype`,
`height`,
`weight`,
`age`)
VALUES
(
btype,
heIght,
weIght,
old);


END$$

DROP PROCEDURE IF EXISTS `selectBmi`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `selectBmi` (IN `strUser` VARCHAR(15))  BEGIN

SELECT idathlete, height, weight FROM athlete WHERE idathlete = strUser;

END$$

DROP PROCEDURE IF EXISTS `SelectlogIn`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SelectlogIn` (IN `Uname` VARCHAR(15))  BEGIN

SELECT name , password FROM user WHERE username = Uname;

END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `athlete`
--
-- Creation: Sep 14, 2016 at 08:19 PM
--

DROP TABLE IF EXISTS `athlete`;
CREATE TABLE IF NOT EXISTS `athlete` (
  `idathlete` varchar(15) NOT NULL,
  `bloodtype` varchar(4) NOT NULL,
  `height` double NOT NULL,
  `weight` double NOT NULL,
  `age` int(2) NOT NULL,
  `team` int(3) DEFAULT NULL,
  `record` int(4) NOT NULL,
  PRIMARY KEY (`idathlete`),
  KEY `team_idx` (`team`),
  KEY `record_idx` (`record`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- RELATIONS FOR TABLE `athlete`:
--

--
-- Dumping data for table `athlete`
--

INSERT INTO `athlete` (`idathlete`, `bloodtype`, `height`, `weight`, `age`, `team`, `record`) VALUES
('UADI5313', 'O', 1.2, 43.5, 20, 111, 123);

-- --------------------------------------------------------

--
-- Table structure for table `coach`
--
-- Creation: Sep 14, 2016 at 08:19 PM
--

DROP TABLE IF EXISTS `coach`;
CREATE TABLE IF NOT EXISTS `coach` (
  `idcoach` varchar(15) NOT NULL,
  `officelocation` text NOT NULL,
  `team` int(3) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`idcoach`),
  KEY `team_idx` (`team`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

--
-- RELATIONS FOR TABLE `coach`:
--

--
-- Dumping data for table `coach`
--

INSERT INTO `coach` (`idcoach`, `officelocation`, `team`) VALUES
('UCCC5413', 'nwu', 1);

-- --------------------------------------------------------

--
-- Table structure for table `record`
--
-- Creation: Oct 14, 2016 at 04:51 AM
--

DROP TABLE IF EXISTS `record`;
CREATE TABLE IF NOT EXISTS `record` (
  `idrecord` int(4) NOT NULL,
  `bmi` double DEFAULT NULL,
  `speed` double DEFAULT NULL,
  `heartrate` double DEFAULT NULL,
  `distance` double DEFAULT NULL,
  `pacetime` time DEFAULT NULL,
  `vomax` double DEFAULT NULL,
  `bodyfat` double DEFAULT NULL,
  `username` varchar(15) NOT NULL,
  `team` int(3) NOT NULL,
  PRIMARY KEY (`idrecord`),
  KEY `username_idx` (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- RELATIONS FOR TABLE `record`:
--   `username`
--       `athlete` -> `idathlete`
--

--
-- Dumping data for table `record`
--

INSERT INTO `record` (`idrecord`, `bmi`, `speed`, `heartrate`, `distance`, `pacetime`, `vomax`, `bodyfat`, `username`, `team`) VALUES
(123, 325, NULL, 150, NULL, NULL, 104, NULL, 'UADI5313', 0);

-- --------------------------------------------------------

--
-- Table structure for table `team`
--
-- Creation: Sep 14, 2016 at 08:19 PM
--

DROP TABLE IF EXISTS `team`;
CREATE TABLE IF NOT EXISTS `team` (
  `idteam` int(3) NOT NULL,
  `name` varchar(30) NOT NULL,
  `typeofsport` varchar(20) NOT NULL,
  PRIMARY KEY (`idteam`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- RELATIONS FOR TABLE `team`:
--

--
-- Dumping data for table `team`
--

INSERT INTO `team` (`idteam`, `name`, `typeofsport`) VALUES
(111, 'M6', 'Coding');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--
-- Creation: Sep 14, 2016 at 08:19 PM
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE IF NOT EXISTS `user` (
  `iduser` varchar(15) NOT NULL,
  `username` varchar(15) NOT NULL,
  `name` varchar(15) NOT NULL,
  `surname` varchar(20) NOT NULL,
  `contact` varchar(12) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `address` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `usertype` varchar(15) NOT NULL,
  PRIMARY KEY (`iduser`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- RELATIONS FOR TABLE `user`:
--

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`iduser`, `username`, `name`, `surname`, `contact`, `email`, `address`, `password`, `usertype`) VALUES
('9511045313084', 'UADI5313', 'Dante', 'Stopper', '0789125412', 'me@mail.com', 'heso', 'pass', ''),
('9609255413081', 'UCCC5413', 'Cats', 'Crazy', '0712345678', 'version2@mail.com', 'vaal', 'password', '');

--
-- Triggers `user`
--
DROP TRIGGER IF EXISTS `user_AINS`;
DELIMITER $$
CREATE TRIGGER `user_AINS` AFTER INSERT ON `user` FOR EACH ROW BEGIN
if user.usertype = 'athlete'
then
INSERT INTO fitness.athlete
(idathlete)
VALUES
(user.iduser);
else
if user.usertype = 'coach'
then
INSERT INTO fitness.coach
(idcoach)
VALUES
(user.iduser);
end if;
end if;

END
$$
DELIMITER ;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `record`
--
ALTER TABLE `record`
  ADD CONSTRAINT `username` FOREIGN KEY (`username`) REFERENCES `athlete` (`idathlete`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
