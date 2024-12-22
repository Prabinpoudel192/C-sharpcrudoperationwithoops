-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Dec 22, 2024 at 08:05 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `chatgpt`
--

-- --------------------------------------------------------

--
-- Table structure for table `s_degree`
--

CREATE TABLE `s_degree` (
  `StudentID` int(11) NOT NULL,
  `Degree` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `s_degree`
--

INSERT INTO `s_degree` (`StudentID`, `Degree`) VALUES
(10050, 'Major Nepali'),
(1002, 'SLC Pass'),
(1235, 'Not Yet Graduated'),
(1003, 'Not Yet Graduated');

-- --------------------------------------------------------

--
-- Table structure for table `s_details`
--

CREATE TABLE `s_details` (
  `StudentID` int(11) NOT NULL,
  `Name` varchar(50) DEFAULT NULL,
  `Age` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `s_details`
--

INSERT INTO `s_details` (`StudentID`, `Name`, `Age`) VALUES
(1002, 'Badki Chaudhary', 33),
(1003, 'Kushal Bhurtel', 24),
(1235, 'Maya Dc Ghimire', 30),
(10050, 'Suman Magic Mushroom wala', 30);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `s_degree`
--
ALTER TABLE `s_degree`
  ADD KEY `StudentID` (`StudentID`);

--
-- Indexes for table `s_details`
--
ALTER TABLE `s_details`
  ADD PRIMARY KEY (`StudentID`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `s_degree`
--
ALTER TABLE `s_degree`
  ADD CONSTRAINT `s_degree_ibfk_1` FOREIGN KEY (`StudentID`) REFERENCES `s_details` (`StudentID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
