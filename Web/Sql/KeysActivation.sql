-- phpMyAdmin SQL Dump
-- version 4.9.5
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Feb 04, 2021 at 04:11 PM
-- Server version: 10.3.16-MariaDB
-- PHP Version: 7.3.23

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `id15795707_xremote`
--

-- --------------------------------------------------------

--
-- Table structure for table `KeysActivation`
--

CREATE TABLE `KeysActivation` (
  `KeyActivation` varchar(255) NOT NULL DEFAULT '',
  `Software` varchar(255) NOT NULL DEFAULT '',
  `Date` varchar(255) NOT NULL DEFAULT '',
  `Login` varchar(255) NOT NULL DEFAULT '',
  `Password` varchar(255) NOT NULL DEFAULT '',
  `Magazine` varchar(255) NOT NULL DEFAULT '',
  `MLogin` text NOT NULL DEFAULT '-',
  `MPass` text NOT NULL DEFAULT '-',
  `MServ` text NOT NULL DEFAULT '-'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `KeysActivation`
--
ALTER TABLE `KeysActivation`
  ADD UNIQUE KEY `KeyActivation` (`KeyActivation`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
