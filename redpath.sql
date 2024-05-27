-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: May 23, 2024 at 10:56 PM
-- Server version: 5.7.36
-- PHP Version: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `redpath`
--

-- --------------------------------------------------------

--
-- Table structure for table `karyawan`
--

DROP TABLE IF EXISTS `karyawan`;
CREATE TABLE IF NOT EXISTS `karyawan` (
  `fi_no` int(11) NOT NULL AUTO_INCREMENT,
  `ri_no` varchar(20) NOT NULL,
  `employee_name` varchar(25) NOT NULL,
  `education` varchar(10) NOT NULL,
  `emp_status1` varchar(10) NOT NULL,
  `emp_status2` varchar(15) NOT NULL,
  `ethnic` varchar(20) NOT NULL,
  `tribes` varchar(40) NOT NULL,
  `gender` varchar(15) NOT NULL,
  `place_of_birth` varchar(20) NOT NULL,
  `dob` date NOT NULL,
  `ages` int(10) NOT NULL,
  `religion` varchar(10) NOT NULL,
  `marital_status` varchar(10) NOT NULL,
  `dependant` int(5) NOT NULL,
  `poh` varchar(15) NOT NULL,
  `poo` varchar(15) NOT NULL,
  `pot` varchar(15) NOT NULL,
  `doh` date NOT NULL,
  `contract_exp` date NOT NULL,
  `actual_classification` varchar(25) NOT NULL,
  `actual_worklocation` varchar(30) NOT NULL,
  PRIMARY KEY (`fi_no`)
) ENGINE=InnoDB AUTO_INCREMENT=80009604 DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `karyawan`
--

INSERT INTO `karyawan` (`fi_no`, `ri_no`, `employee_name`, `education`, `emp_status1`, `emp_status2`, `ethnic`, `tribes`, `gender`, `place_of_birth`, `dob`, `ages`, `religion`, `marital_status`, `dependant`, `poh`, `poo`, `pot`, `doh`, `contract_exp`, `actual_classification`, `actual_worklocation`) VALUES
(7878, '6767', 'jj', 'SMP', 'm', ' knk', 'non papua', 'knn', 'MALE', 'nnk', '2024-05-17', 98, 'ijj', 'M+1', 0, 'knk', 'knk', 'knk', '2024-05-17', '2024-05-30', 'knk', 'knk'),
(8989, '65', 'Ryan', 'SMA / SMK', 'nk', 'knk', '7 tribes', 'kn', 'MALE', 'mnknk', '2024-05-17', 88, 'kkk', 'M+1', 0, 'knk', 'knnk', 'knk', '2024-05-17', '2024-05-30', 'jbjb', 'jbj'),
(80009603, 'SSS-NS-0124', 'Agustinus Yosef Kota Niro', 'SMK', 'NS', 'Non-Staff', 'papua', 'Non Papuan - NTT', 'MALE', 'Flores', '1985-01-09', 39, 'Christian', 'M+1', 2, 'Timika', 'Bali', 'Bali', '2015-11-15', '2025-02-05', 'Raisebore Drillerr', 'Raisebore - GBC');

-- --------------------------------------------------------

--
-- Table structure for table `table_login`
--

DROP TABLE IF EXISTS `table_login`;
CREATE TABLE IF NOT EXISTS `table_login` (
  `id_login` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `passwd` varchar(10) NOT NULL,
  `Fi-No` int(11) NOT NULL,
  `status` varchar(9) NOT NULL DEFAULT 'Staff',
  PRIMARY KEY (`id_login`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `table_login`
--

INSERT INTO `table_login` (`id_login`, `username`, `passwd`, `Fi-No`, `status`) VALUES
(1, 'yosef', '1234', 80009603, 'admin'),
(2, 'ryan', '1111', 8989, 'staff');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
