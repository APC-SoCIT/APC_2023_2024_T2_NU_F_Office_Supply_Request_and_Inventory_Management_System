-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 03, 2024 at 11:22 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `nufvdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `accountcredentials`
--

CREATE TABLE `accountcredentials` (
  `accountid` int(11) NOT NULL,
  `usertype` varchar(255) NOT NULL,
  `username` varchar(255) NOT NULL,
  `passwd` varchar(255) NOT NULL,
  `firstname` varchar(255) NOT NULL,
  `lastname` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `accountcredentials`
--

INSERT INTO `accountcredentials` (`accountid`, `usertype`, `username`, `passwd`, `firstname`, `lastname`) VALUES
(1, 'LRC', 'employee1', 'employee1', 'Erick', 'Valenzuela'),
(2, 'Admission', 'employee2', 'employee2', 'Carl', 'Taganna'),
(3, 'Accounting', 'employee3', 'employee3', 'Shaina', 'Manalo'),
(4, 'Admin', 'employee4', 'employee4', 'Michael', 'Linezo'),
(5, 'ITSO', 'employee5', 'employee5', 'James', 'Custudio'),
(6, 'SuperAdmin', 'employee6', 'employee6', 'Mesina', 'Friday'),
(7, 'Faculty', 'employee9', 'employee9', 'Lorence', 'Espiritu'),
(8, 'Approver_LRC', 'employeelrc', 'employeelrc', 'Sandra', 'Rosales'),
(9, 'Approver_ITSO', 'employeeITSO', 'employeeITSO', 'Peter', 'Magcaling'),
(10, 'Approver_Accounting', 'employeeAccounting', 'employeeAccounting', 'Maribeth', 'Ramos'),
(11, 'Approver_Admission', 'employeeAdmission', 'employeeAdmission', 'Patricia', 'Zamora'),
(12, 'Approver_Faculty', 'employeeFaculty', 'employeeFaculty', 'Sarah', 'Limbron'),
(13, 'HeadApproval1', 'employeeHeadApproval1', 'employeeHeadApproval1', 'Jed', 'Catimbuhan');

-- --------------------------------------------------------

--
-- Table structure for table `budget`
--

CREATE TABLE `budget` (
  `budgetid` int(11) NOT NULL,
  `department` varchar(255) NOT NULL,
  `budgetamount` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `budget`
--

INSERT INTO `budget` (`budgetid`, `department`, `budgetamount`) VALUES
(1, 'lrc', 21583.99),
(2, 'admission', 83721.55),
(3, 'itso', 45381.15),
(4, 'Faculty', 12512.21),
(5, 'accounting', 50590.78);

-- --------------------------------------------------------

--
-- Table structure for table `table_osrequest`
--

CREATE TABLE `table_osrequest` (
  `requestID` int(11) NOT NULL,
  `requestorname` varchar(255) NOT NULL,
  `department` varchar(255) NOT NULL,
  `branch` varchar(255) NOT NULL,
  `purpose` varchar(255) NOT NULL,
  `total` double NOT NULL,
  `date` date NOT NULL,
  `item1` varchar(255) NOT NULL,
  `quantity1` int(11) NOT NULL,
  `unitprice1` double NOT NULL,
  `amount1` double NOT NULL,
  `item2` varchar(255) NOT NULL,
  `quantity2` int(11) NOT NULL,
  `unitprice2` double NOT NULL,
  `amount2` double NOT NULL,
  `item3` varchar(255) NOT NULL,
  `quantity3` int(11) NOT NULL,
  `unitprice3` double NOT NULL,
  `amount3` decimal(10,0) NOT NULL,
  `item4` varchar(255) NOT NULL,
  `quantity4` int(11) NOT NULL,
  `unitprice4` double NOT NULL,
  `amount4` double NOT NULL,
  `item5` varchar(255) NOT NULL,
  `quantity5` int(11) NOT NULL,
  `unitprice5` double NOT NULL,
  `amount5` double NOT NULL,
  `item6` varchar(255) NOT NULL,
  `quantity6` int(11) NOT NULL,
  `unitprice6` double NOT NULL,
  `amount6` double NOT NULL,
  `item7` varchar(255) NOT NULL,
  `quantity7` int(11) NOT NULL,
  `unitprice7` double NOT NULL,
  `amount7` double NOT NULL,
  `item8` varchar(255) NOT NULL,
  `quantity8` int(11) NOT NULL,
  `unitprice8` double NOT NULL,
  `amount8` double NOT NULL,
  `item9` varchar(255) NOT NULL,
  `quantity9` int(11) NOT NULL,
  `unitprice9` double NOT NULL,
  `amount9` double NOT NULL,
  `item10` varchar(255) NOT NULL,
  `quantity10` int(11) NOT NULL,
  `unitprice10` double NOT NULL,
  `amount10` double NOT NULL,
  `approved_date_1` date DEFAULT NULL,
  `rejected_date_1` date DEFAULT NULL,
  `approved_date_2` date DEFAULT NULL,
  `rejected_date_2` date DEFAULT NULL,
  `approved_date_3` date DEFAULT NULL,
  `rejected_date_3` date DEFAULT NULL,
  `status1` varchar(50) NOT NULL DEFAULT 'Pending',
  `status2` varchar(50) NOT NULL DEFAULT 'Pending',
  `status3` varchar(50) NOT NULL DEFAULT 'Pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `table_osrequest`
--

INSERT INTO `table_osrequest` (`requestID`, `requestorname`, `department`, `branch`, `purpose`, `total`, `date`, `item1`, `quantity1`, `unitprice1`, `amount1`, `item2`, `quantity2`, `unitprice2`, `amount2`, `item3`, `quantity3`, `unitprice3`, `amount3`, `item4`, `quantity4`, `unitprice4`, `amount4`, `item5`, `quantity5`, `unitprice5`, `amount5`, `item6`, `quantity6`, `unitprice6`, `amount6`, `item7`, `quantity7`, `unitprice7`, `amount7`, `item8`, `quantity8`, `unitprice8`, `amount8`, `item9`, `quantity9`, `unitprice9`, `amount9`, `item10`, `quantity10`, `unitprice10`, `amount10`, `approved_date_1`, `rejected_date_1`, `approved_date_2`, `rejected_date_2`, `approved_date_3`, `rejected_date_3`, `status1`, `status2`, `status3`) VALUES
(9, 'Carl Taganna', 'Admission', 'National University Fairview', '', 5451, '2024-02-22', 'Colored Paper', 23, 237, 5451, '', 0, 0, 0, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, NULL, NULL, NULL, NULL, NULL, NULL, 'Pending', 'Pending', 'Pending'),
(12, 'Shaina Manalo', 'Accounting', 'National University Fairview', '', 2079.98, '2024-03-01', 'Paper Envelope', 1, 160, 160, 'Red Ballpen', 1, 90, 90, 'Colored Paper', 1, 237, '237', 'Bond Paper', 1, 200, 200, 'Bond Paper', 1, 200, 200, 'Green Ballpen', 1, 110, 110, 'Calculator', 1, 345.98, 345.98, 'Green Ink', 1, 341, 341, 'Green Ink', 1, 341, 341, 'Scissor', 1, 55, 55, NULL, NULL, NULL, NULL, NULL, NULL, 'Pending', 'Pending', 'Pending'),
(13, 'Lorence Espiritu', 'Faculty', 'National University Fairview', '', 4862.84, '2024-03-01', 'Bond Paper', 1, 200, 200, 'Colored Paper', 2, 237, 474, 'Red Ballpen', 3, 90, '270', 'Green Ballpen', 4, 110, 440, 'Highlighters', 5, 289, 1445, 'Paper Shredder', 6, 3, 18, 'Pencil Sharpener', 7, 90, 630, 'Binder Clip', 8, 64.52, 516.16, 'Binder Clip', 9, 64.52, 580.68, 'Highlighters', 1, 289, 289, NULL, NULL, NULL, NULL, NULL, NULL, 'Pending', 'Pending', 'Pending'),
(17, 'Carl Taganna', 'Admission', 'National University Fairview', 'dasdad', 874, '2024-03-01', 'Colored Paper', 2, 237, 474, 'Notebook', 3, 20, 60, 'Red Ink', 1, 340, '340', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, NULL, NULL, NULL, NULL, NULL, NULL, 'Pending', 'Pending', 'Pending'),
(19, 'Shaina Manalo', 'Accounting', 'National University Fairview', 'nasd', 2070, '2024-03-01', 'Pencil Sharpener', 23, 90, 2070, '', 0, 0, 0, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, NULL, NULL, NULL, NULL, NULL, NULL, 'Pending', 'Pending', 'Pending'),
(23, 'Carl Taganna', 'Admission', 'National University Fairview', 'Enrollment', 6959.76, '2024-03-02', 'Staples', 12, 559.98, 6719.76, 'Notebook', 12, 20, 240, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, NULL, NULL, NULL, NULL, NULL, NULL, 'Pending', 'Pending', 'Pending'),
(29, 'Shaina Manalo', 'Accounting', 'National University Fairview', 'Sample Request Only', 2490, '2024-03-02', 'Green Ballpen', 1, 110, 110, 'Red Ink', 7, 340, 2380, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, NULL, NULL, NULL, NULL, NULL, NULL, 'Pending', 'Pending', 'Pending'),
(31, 'Shaina Manalo', 'Accounting', 'National University Fairview', 'sample', 1481.88, '2024-03-02', 'Black Marker', 12, 115.99, 1391.88, 'Red Ballpen', 1, 90, 90, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, NULL, NULL, NULL, NULL, NULL, NULL, 'Pending', 'Pending', 'Pending'),
(33, 'Shaina Manalo', 'Accounting', 'National University Fairview', 'sample', 160, '2024-03-02', 'Black Ballpen', 1, 80, 80, 'Colored Paper', 1, 237, 80, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, NULL, NULL, NULL, NULL, NULL, NULL, 'Pending', 'Pending', 'Pending'),
(34, 'Shaina Manalo', 'Accounting', 'National University Fairview', 'Sample', 205.99, '2024-03-02', 'Black Marker', 1, 115.99, 115.99, 'Red Ballpen', 1, 90, 90, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, NULL, NULL, NULL, NULL, NULL, NULL, 'Pending', 'Pending', 'Pending'),
(35, 'Shaina Manalo', 'Accounting', 'National University Fairview', 'sample', 237, '2024-03-02', 'Colored Paper', 1, 237, 237, '', 0, 0, 0, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, NULL, NULL, NULL, NULL, NULL, NULL, 'Pending', 'Pending', 'Pending'),
(36, 'Shaina Manalo', 'Accounting', 'National University Fairview', 'Exam', 2265.89, '2024-03-02', 'Black Marker', 11, 115.99, 1275.89, 'Red Ballpen', 11, 90, 990, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, NULL, NULL, NULL, NULL, NULL, NULL, 'Pending', 'Pending', 'Pending');

-- --------------------------------------------------------

--
-- Table structure for table `table_requesthistory`
--

CREATE TABLE `table_requesthistory` (
  `requestID` int(11) NOT NULL,
  `requestorname` varchar(255) NOT NULL,
  `department` varchar(255) NOT NULL,
  `branch` varchar(255) NOT NULL,
  `purpose` varchar(255) NOT NULL,
  `total` double NOT NULL,
  `date` date NOT NULL,
  `item1` varchar(255) NOT NULL,
  `quantity1` int(11) NOT NULL,
  `unitprice1` double NOT NULL,
  `amount1` double NOT NULL,
  `item2` varchar(255) NOT NULL,
  `quantity2` int(11) NOT NULL,
  `unitprice2` double NOT NULL,
  `amount2` double NOT NULL,
  `item3` varchar(255) NOT NULL,
  `quantity3` int(11) NOT NULL,
  `unitprice3` double NOT NULL,
  `amount3` decimal(10,0) NOT NULL,
  `item4` varchar(255) NOT NULL,
  `quantity4` int(11) NOT NULL,
  `unitprice4` double NOT NULL,
  `amount4` double NOT NULL,
  `item5` varchar(255) NOT NULL,
  `quantity5` int(11) NOT NULL,
  `unitprice5` double NOT NULL,
  `amount5` double NOT NULL,
  `item6` varchar(255) NOT NULL,
  `quantity6` int(11) NOT NULL,
  `unitprice6` double NOT NULL,
  `amount6` double NOT NULL,
  `item7` varchar(255) NOT NULL,
  `quantity7` int(11) NOT NULL,
  `unitprice7` double NOT NULL,
  `amount7` double NOT NULL,
  `item8` varchar(255) NOT NULL,
  `quantity8` int(11) NOT NULL,
  `unitprice8` double NOT NULL,
  `amount8` double NOT NULL,
  `item9` varchar(255) NOT NULL,
  `quantity9` int(11) NOT NULL,
  `unitprice9` double NOT NULL,
  `amount9` double NOT NULL,
  `item10` varchar(255) NOT NULL,
  `quantity10` int(11) NOT NULL,
  `unitprice10` double NOT NULL,
  `amount10` double NOT NULL,
  `approved_date_1` date DEFAULT NULL,
  `rejected_date_1` date DEFAULT NULL,
  `approved_date_2` date DEFAULT NULL,
  `rejected_date_2` date DEFAULT NULL,
  `approved_date_3` date DEFAULT NULL,
  `rejected_date_3` date DEFAULT NULL,
  `status1` varchar(50) NOT NULL DEFAULT 'Pending',
  `status2` varchar(50) NOT NULL DEFAULT 'Pending',
  `status3` varchar(50) NOT NULL DEFAULT 'Pending'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `table_requesthistory`
--

INSERT INTO `table_requesthistory` (`requestID`, `requestorname`, `department`, `branch`, `purpose`, `total`, `date`, `item1`, `quantity1`, `unitprice1`, `amount1`, `item2`, `quantity2`, `unitprice2`, `amount2`, `item3`, `quantity3`, `unitprice3`, `amount3`, `item4`, `quantity4`, `unitprice4`, `amount4`, `item5`, `quantity5`, `unitprice5`, `amount5`, `item6`, `quantity6`, `unitprice6`, `amount6`, `item7`, `quantity7`, `unitprice7`, `amount7`, `item8`, `quantity8`, `unitprice8`, `amount8`, `item9`, `quantity9`, `unitprice9`, `amount9`, `item10`, `quantity10`, `unitprice10`, `amount10`, `approved_date_1`, `rejected_date_1`, `approved_date_2`, `rejected_date_2`, `approved_date_3`, `rejected_date_3`, `status1`, `status2`, `status3`) VALUES
(3, 'James Custudio', 'ITSO', 'National University Fairview', '', 8611.82, '2024-02-18', 'Black Ballpen', 1, 80, 80, 'Staples', 2, 559.98, 1119.96, 'Plastic Envelope', 3, 150, '450', 'Green Ballpen', 4, 110, 440, 'Pencil Sharpener', 5, 90, 450, 'Red Ballpen', 6, 90, 540, 'Calculator', 7, 345.98, 2421.86, 'Blue Ink', 8, 340, 2720, 'Paper Clips', 9, 40, 360, 'Paper Shredder', 10, 3, 30, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(5, 'Lorence Espiritu', 'LRC', 'National University Fairview', '', 8179, '2024-02-18', 'Highlighters', 24, 289, 6936, 'Paper Clips', 1, 40, 40, 'Red Ballpen', 2, 90, '180', 'Green Ink', 3, 341, 1023, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(6, 'Lorence Espiritu', 'LRC', 'National University Fairview', '', 2511, '2024-02-18', 'Green Ballpen', 1, 110, 110, 'Highlighters', 2, 289, 578, 'Green Ink', 3, 341, '1023', 'Scissor', 4, 55, 220, 'Black Ballpen', 5, 80, 400, 'Pink Folder', 6, 30, 180, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(8, 'Carl Taganna', 'Admission', 'National University Fairview', '', 7860.99, '2024-02-18', 'Black Marker', 1, 115.99, 115.99, 'Black Ink', 23, 325, 7475, 'Pencil Sharpener', 3, 90, '270', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(10, 'Erick Valenzuela', 'LRC', 'National University Fairview', 'aaaa', 9076.94, '2024-02-29', 'Highlighters', 23, 289, 6647, 'Staples', 3, 559.98, 1679.94, 'Plastic Envelope', 5, 150, '750', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(11, 'Erick Valenzuela', 'LRC', 'National University Fairview', 'because i want it', 3476.95, '2024-03-01', 'Bond Paper', 2, 200, 400, 'Colored Paper', 1, 237, 237, 'Black Marker', 5, 115.99, '580', 'Red Ballpen', 7, 90, 630, 'Black Ballpen', 8, 80, 640, 'Green Ballpen', 9, 110, 990, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(14, 'James Custudio', 'ITSO', 'National University Fairview', '', 2924.9, '2024-03-01', 'Black Ballpen', 2, 80, 160, 'Green Ink', 3, 341, 1023, 'Paper Shredder', 4, 3, '12', 'Calculator', 5, 345.98, 1729.9, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(15, 'James Custudio', 'ITSO', 'National University Fairview', '', 3090.96, '2024-03-01', 'Red Ballpen', 1, 90, 90, 'Staples', 2, 559.98, 1119.96, 'Plastic Envelope', 2, 150, '300', 'Green Ink', 3, 341, 1023, 'Red Ballpen', 6, 90, 540, 'Paper Shredder', 6, 3, 18, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(16, 'Erick Valenzuela', 'LRC', 'National University Fairview', 'waaaa', 2419.92, '2024-03-01', 'Red Ballpen', 2, 90, 180, 'Staples', 4, 559.98, 2239.92, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(18, 'James Custudio', 'ITSO', 'National University Fairview', 'baaaa', 1955, '2024-03-01', 'Green Ballpen', 3, 110, 330, 'Black Ink', 5, 325, 1625, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(20, 'James Custudio', 'ITSO', 'National University Fairview', 'asdagadg', 480, '2024-03-01', 'Notebook', 24, 20, 480, '', 0, 0, 0, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(21, 'James Custudio', 'ITSO', 'National University Fairview', 'agdsagg', 8290.9, '2024-03-01', 'Colored Paper', 23, 237, 5451, 'Notebook', 2, 20, 40, 'Staples', 5, 559.98, '2800', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(22, 'James Custudio', 'ITSO', 'National University Fairview', 'afgfsagasgsgd', 15547.31, '2024-03-01', 'Black Marker', 23, 115.99, 2667.77, 'Staples', 23, 559.98, 12879.54, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(24, 'Erick Valenzuela', 'LRC', 'National University Fairview', 'sample', 3480, '2024-03-02', 'Bond Paper', 12, 200, 2400, 'Red Ballpen', 12, 90, 1080, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(25, 'Carl Taganna', 'Admission', 'National University Fairview', 'Enrollment', 315.99, '2024-03-02', 'Bond Paper', 1, 200, 200, 'Black Marker', 1, 115.99, 115.99, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(26, 'Carl Taganna', 'Admission', 'National University Fairview', 'sample request only', 352.99, '2024-03-02', 'Colored Paper', 1, 237, 237, 'Black Marker', 1, 115.99, 115.99, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(27, 'Erick Valenzuela', 'LRC', 'National University Fairview', 'sample request', 1430, '2024-03-02', 'Bond Paper', 1, 200, 200, 'Green Ballpen', 11, 110, 1210, 'Notebook', 1, 20, '20', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(28, 'Erick Valenzuela', 'LRC', 'National University Fairview', 'Sample Request only ', 205.99, '2024-03-02', 'Red Ballpen', 1, 90, 90, 'Black Marker', 1, 115.99, 115.99, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(30, 'Erick Valenzuela', 'LRC', 'National University Fairview', 'sample', 490, '2024-03-02', 'Red Ballpen', 1, 90, 90, 'Bond Paper', 2, 200, 400, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(32, 'Erick Valenzuela', 'LRC', 'National University Fairview', 'sample', 352.99, '2024-03-02', 'Colored Paper', 1, 237, 237, 'Black Marker', 1, 115.99, 115.99, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-02', NULL, NULL, '2024-03-03', NULL, NULL, 'Rejected', 'Rejected', 'Rejected'),
(37, 'James Custudio', 'ITSO', 'National University Fairview', 'sample', 315.99, '2024-03-02', 'Black Marker', 1, 115.99, 115.99, 'Bond Paper', 1, 200, 200, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(38, 'James Custudio', 'ITSO', 'National University Fairview', 'sdasda', 460, '2024-03-02', 'Bond Paper', 1, 200, 200, 'Red Ballpen', 1, 90, 200, 'Notebook', 3, 20, '60', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(39, 'James Custudio', 'ITSO', 'National University Fairview', 'sample', 315.99, '2024-03-02', 'Black Marker', 1, 115.99, 115.99, 'Bond Paper', 1, 200, 200, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(40, 'James Custudio', 'ITSO', 'National University Fairview', 'sample', 437, '2024-03-02', 'Colored Paper', 1, 237, 237, 'Bond Paper', 1, 200, 200, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-02', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(42, 'Erick Valenzuela', 'LRC', 'National University Fairview', 'dasdada', 200, '2024-03-03', 'Red Ballpen', 1, 90, 90, 'Green Ballpen', 1, 110, 110, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(43, 'Erick Valenzuela', 'LRC', 'National University Fairview', '12312313', 1290, '2024-03-03', 'Green Ballpen', 11, 110, 1210, 'Black Ballpen', 1, 80, 80, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(45, 'Erick Valenzuela', 'LRC', 'National University Fairview', '123131313131', 404.99, '2024-03-03', 'Black Marker', 1, 115.99, 115.99, 'Highlighters', 1, 289, 289, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(46, 'Erick Valenzuela', 'LRC', 'National University Fairview', 'q123131313123', 265.99, '2024-03-03', 'Plastic Envelope', 1, 150, 150, 'Black Marker', 1, 115.99, 115.99, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(47, 'Erick Valenzuela', 'LRC', 'National University Fairview', '123', 200, '2024-03-03', 'Paper Envelope', 1, 160, 160, 'Paper Clips', 1, 40, 40, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(48, 'James Custudio', 'ITSO', 'National University Fairview', '1231231231', 280, '2024-03-03', 'Black Ballpen', 1, 80, 80, 'Bond Paper', 1, 200, 200, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(49, 'Erick Valenzuela', 'LRC', 'National University Fairview', '123123', 507, '2024-03-03', 'Colored Paper', 1, 237, 237, 'Green Ballpen', 1, 110, 110, 'Paper Envelope', 1, 160, '160', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(50, 'Erick Valenzuela', 'LRC', 'National University Fairview', '123', 360, '2024-03-03', 'Notebook', 1, 20, 20, 'Red Ink', 1, 340, 340, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(51, 'Erick Valenzuela', 'LRC', 'National University Fairview', '123', 80, '2024-03-03', 'Black Ballpen', 1, 80, 80, '', 0, 0, 0, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(52, 'Erick Valenzuela', 'LRC', 'National University Fairview', 'sample', 250, '2024-03-03', 'Red Ballpen', 1, 90, 90, 'Paper Envelope', 1, 160, 160, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(53, 'Erick Valenzuela', 'LRC', 'National University Fairview', 'sample', 490, '2024-03-03', 'Red Ballpen', 1, 90, 90, 'Paper Clips', 10, 40, 400, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(54, 'Erick Valenzuela', 'LRC', 'National University Fairview', '123131', 317, '2024-03-03', 'Black Ballpen', 1, 80, 80, 'Colored Paper', 1, 237, 237, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(55, 'Erick Valenzuela', 'LRC', 'National University Fairview', '123131313', 240, '2024-03-03', 'Red Ballpen', 1, 90, 90, 'Plastic Envelope', 1, 150, 150, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(56, 'Erick Valenzuela', 'LRC', 'National University Fairview', '', 330, '2024-03-03', 'Green Ballpen', 1, 110, 110, 'Notebook', 1, 20, 20, 'Bond Paper', 1, 200, '200', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending'),
(57, 'Erick Valenzuela', 'LRC', 'National University Fairview', '', 405, '2024-03-03', 'Black Ballpen', 1, 80, 80, 'Black Ink', 1, 325, 325, '', 0, 0, '0', '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '', 0, 0, 0, '2024-03-03', NULL, '2024-03-03', NULL, NULL, NULL, 'Approved', 'Approved', 'Pending');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_category`
--

CREATE TABLE `tbl_category` (
  `glaccount` int(11) NOT NULL,
  `Particulars` varchar(255) NOT NULL,
  `qty` int(11) NOT NULL,
  `reference` varchar(255) NOT NULL,
  `EULIY` int(11) NOT NULL,
  `datepurchased` date NOT NULL,
  `startdate` date NOT NULL,
  `enddate` date NOT NULL,
  `costcenter` int(11) NOT NULL,
  `costcenterdescription` varchar(255) NOT NULL,
  `acquisitiontotal` decimal(12,2) NOT NULL,
  `totaldepreciation` decimal(12,2) NOT NULL,
  `destination` varchar(255) NOT NULL,
  `identitynotag` varchar(255) NOT NULL,
  `accountableperson` varchar(255) NOT NULL,
  `june` decimal(12,2) NOT NULL,
  `july` decimal(12,2) NOT NULL,
  `august` decimal(12,2) NOT NULL,
  `september` decimal(12,2) NOT NULL,
  `october` decimal(12,2) NOT NULL,
  `november` decimal(12,2) NOT NULL,
  `december` decimal(12,2) NOT NULL,
  `january` decimal(12,2) NOT NULL,
  `february` decimal(12,2) NOT NULL,
  `march` decimal(12,2) NOT NULL,
  `april` decimal(12,2) NOT NULL,
  `may` decimal(12,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_category`
--

INSERT INTO `tbl_category` (`glaccount`, `Particulars`, `qty`, `reference`, `EULIY`, `datepurchased`, `startdate`, `enddate`, `costcenter`, `costcenterdescription`, `acquisitiontotal`, `totaldepreciation`, `destination`, `identitynotag`, `accountableperson`, `june`, `july`, `august`, `september`, `october`, `november`, `december`, `january`, `february`, `march`, `april`, `may`) VALUES
(15312, 'asd', 3, 'asdad', 23, '2024-02-14', '2024-02-08', '2024-02-16', 2, 'asdsa', '1.23', '1.00', 'sadad', 'adasd', 'asdasd', '1.00', '2.00', '3.00', '4.00', '5.00', '6.00', '7.00', '8.00', '9.00', '10.00', '11.00', '12.00'),
(643266, 'sadgsg', 200, 'asdgg', 10, '2024-02-27', '2024-02-27', '2024-02-27', 0, 'asdad', '13516.54', '1.00', 'asdasd', 'sagsag', 'asdasd', '1209.35', '1209.35', '1209.35', '1209.35', '1209.35', '1209.35', '1209.35', '1209.35', '1209.35', '1209.35', '1209.35', '1209.35'),
(97697656, 'yasuoiii', 20, '315161', 10, '2024-02-27', '2024-02-27', '2024-02-27', 0, 'yes', '12513.56', '31613.67', 'dagag', 'dsfag531', 'yes', '2634.47', '2634.47', '2634.47', '2634.47', '2634.47', '2634.47', '2634.47', '2634.47', '2634.47', '2634.47', '2634.47', '2634.47');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_officesupply`
--

CREATE TABLE `tbl_officesupply` (
  `id` int(11) NOT NULL,
  `ItemNumber` int(11) NOT NULL,
  `ItemName` varchar(255) NOT NULL,
  `ItemStock` int(11) NOT NULL,
  `ItemUnit` varchar(255) NOT NULL,
  `ItemStatus` varchar(255) NOT NULL,
  `DatePurchase` date NOT NULL,
  `ItemAmount` double NOT NULL,
  `ReorderPoint` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_officesupply`
--

INSERT INTO `tbl_officesupply` (`id`, `ItemNumber`, `ItemName`, `ItemStock`, `ItemUnit`, `ItemStatus`, `DatePurchase`, `ItemAmount`, `ReorderPoint`) VALUES
(3, 1958682, 'Bond Paper', 16, 'Ream/s', 'AVAILABLE', '2024-01-14', 200, 50),
(4, 1968372, 'Colored Paper', 255, 'Ream/s', 'AVAILABLE', '2024-01-14', 237, 50),
(5, 1938586, 'Black Marker', 435, 'Box/es', 'AVAILABLE', '2024-01-14', 115.99, 50),
(6, 200223, 'Red Ballpen', 85, 'Piece/s', 'AVAILABLE', '2024-01-14', 90, 50),
(7, 205931, 'Black Ballpen', 67, 'Piece/s', 'AVAILABLE', '2024-01-14', 80, 50),
(8, 200195, 'Green Ballpen', 154, 'Box/es', 'AVAILABLE', '2024-01-14', 110, 50),
(9, 49582931, 'Notebook', 87, 'Piece/s', 'AVAILABLE', '2024-01-14', 20, 50),
(10, 485928312, 'Highlighters', 75, 'Box/es', 'AVAILABLE', '2024-01-14', 289, 50),
(11, 2050396, 'Paper Envelope', 80, 'Box/es', 'AVAILABLE', '2024-01-14', 160, 50),
(12, 2050385, 'Plastic Envelope', 59, 'Piece/s', 'NOT AVAILABLE', '2024-01-14', 150, 50),
(13, 382583, 'Staples', 200, 'Box/es', 'AVAILABLE', '2024-01-14', 559.98, 50),
(14, 668797, 'Red Ink', 405, 'Box/es', 'AVAILABLE', '2024-01-14', 340, 50),
(15, 668796, 'Black Ink', 75, 'Box/es', 'AVAILABLE', '2024-01-14', 325, 50),
(16, 668795, 'Green Ink', 200, 'Box/es', 'AVAILABLE', '2024-01-14', 341, 50),
(17, 668794, 'Blue Ink', 205, 'Box/es', 'AVAILABLE', '2024-01-14', 340, 50),
(18, 110003, 'Paper Clips', 142, 'Box/es', 'AVAILABLE', '2024-01-14', 40, 50),
(19, 110005, 'Paper Shredder', 175, 'Piece/s', 'AVAILABLE', '2024-01-14', 3, 50),
(20, 110006, 'Pencil Sharpener', 66, 'Box/es', 'AVAILABLE', '2024-01-14', 90, 50),
(21, 2900394, 'Scissor', 74, 'Piece/s', 'AVAILABLE', '2024-01-14', 55, 50),
(22, 19583923, 'Calculator', 76, 'Piece/s', 'AVAILABLE', '2024-01-14', 345.98, 50),
(23, 1104953, 'Binder Clip', 59, 'Box/es', 'AVAILABLE', '2024-01-14', 64.52, 50),
(24, 3888915, 'Pink Folder', 306, 'Piece/s', 'AVAILABLE', '2024-01-15', 30, 50);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `accountcredentials`
--
ALTER TABLE `accountcredentials`
  ADD PRIMARY KEY (`accountid`);

--
-- Indexes for table `budget`
--
ALTER TABLE `budget`
  ADD PRIMARY KEY (`budgetid`);

--
-- Indexes for table `table_osrequest`
--
ALTER TABLE `table_osrequest`
  ADD PRIMARY KEY (`requestID`);

--
-- Indexes for table `table_requesthistory`
--
ALTER TABLE `table_requesthistory`
  ADD PRIMARY KEY (`requestID`);

--
-- Indexes for table `tbl_category`
--
ALTER TABLE `tbl_category`
  ADD PRIMARY KEY (`glaccount`);

--
-- Indexes for table `tbl_officesupply`
--
ALTER TABLE `tbl_officesupply`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `accountcredentials`
--
ALTER TABLE `accountcredentials`
  MODIFY `accountid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `budget`
--
ALTER TABLE `budget`
  MODIFY `budgetid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `table_osrequest`
--
ALTER TABLE `table_osrequest`
  MODIFY `requestID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=58;

--
-- AUTO_INCREMENT for table `table_requesthistory`
--
ALTER TABLE `table_requesthistory`
  MODIFY `requestID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=58;

--
-- AUTO_INCREMENT for table `tbl_officesupply`
--
ALTER TABLE `tbl_officesupply`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
