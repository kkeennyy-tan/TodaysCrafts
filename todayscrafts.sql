-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 15, 2019 at 11:31 AM
-- Server version: 10.1.36-MariaDB
-- PHP Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `todayscrafts`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer_info`
--

CREATE TABLE `customer_info` (
  `id` int(11) NOT NULL,
  `first_name` varchar(50) DEFAULT NULL,
  `last_name` varchar(50) DEFAULT NULL,
  `contact_no` varchar(50) DEFAULT NULL,
  `color` varchar(50) DEFAULT NULL,
  `size` varchar(50) DEFAULT NULL,
  `quantity` varchar(50) DEFAULT NULL,
  `company_name` varchar(50) DEFAULT NULL,
  `address` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `date` varchar(50) DEFAULT NULL,
  `remarks` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `customer_info`
--

INSERT INTO `customer_info` (`id`, `first_name`, `last_name`, `contact_no`, `color`, `size`, `quantity`, `company_name`, `address`, `email`, `date`, `remarks`) VALUES
(1, 'asd', 'asdasd', 'kjnb', 'j', 'nbkj', 'nkjnkj', 'nk', 'nkj', 'n', 'kjn', 'nkj'),
(4, 'eeeeeeeeeeeeee', 'asdasd', 'kjnb', 'j', 'nbkj', 'nkjnkj', 'nk', 'nkj', 'n', 'kjn', 'nkj');

-- --------------------------------------------------------

--
-- Table structure for table `employee`
--

CREATE TABLE `employee` (
  `id` int(11) NOT NULL,
  `first_name` varchar(50) DEFAULT NULL,
  `last_name` varchar(50) DEFAULT NULL,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `birthday` varchar(50) DEFAULT NULL,
  `address` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `contact_no` varchar(50) NOT NULL,
  `gender` varchar(50) DEFAULT NULL,
  `date_applied` varchar(50) DEFAULT NULL,
  `date_resigned` varchar(50) DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `employee`
--

INSERT INTO `employee` (`id`, `first_name`, `last_name`, `username`, `password`, `birthday`, `address`, `email`, `contact_no`, `gender`, `date_applied`, `date_resigned`, `status`) VALUES
(1, 'admin', 'admin', 'admin', 'admin', '121212', 'pureza', 'todayscrafts@gmail.com', '09264040123', 'gender', 'march', 'march', 'master'),
(5, 'asd', 'asdasd', 'qqq', 'qqq', 'Wednesday, 10 April 2019', 'asd', 'ads', '123', 'asd', 'Wednesday, 10 April 2019', 'Wednesday, 10 April 2019', 'user'),
(6, 'asdasdjh', 'gv', 'user', 'user', 'Thursday, 11 April 2019', 'vjhg', 'bvjb', '36146546515', ' v', 'Thursday, 11 April 2019', 'Thursday, 11 April 2019', 'user'),
(7, 'asdasdjh', 'gv', 'bert', 'bert', 'Thursday, 11 April 2019', 'vjhg', 'bvjb', '36146546515', ' v', 'Thursday, 11 April 2019', 'Thursday, 11 April 2019', 'user');

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `id` int(11) NOT NULL,
  `brand` varchar(50) DEFAULT NULL,
  `serial_number` varchar(50) DEFAULT NULL,
  `product_code` varchar(50) DEFAULT NULL,
  `description` varchar(50) DEFAULT NULL,
  `category` varchar(50) DEFAULT NULL,
  `on_stock` varchar(50) DEFAULT NULL,
  `out_of_stock` varchar(50) DEFAULT NULL,
  `unit_price` varchar(50) DEFAULT NULL,
  `wholesale_price` varchar(50) DEFAULT NULL,
  `minimum_order` varchar(50) DEFAULT NULL,
  `manufacturer` varchar(50) DEFAULT NULL,
  `supplier_address` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `contact_no` varchar(50) DEFAULT NULL,
  `date_of_purchase` varchar(50) DEFAULT NULL,
  `remarks` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `inventory`
--

INSERT INTO `inventory` (`id`, `brand`, `serial_number`, `product_code`, `description`, `category`, `on_stock`, `out_of_stock`, `unit_price`, `wholesale_price`, `minimum_order`, `manufacturer`, `supplier_address`, `email`, `contact_no`, `date_of_purchase`, `remarks`) VALUES
(1, 'qqqqqq', 'kjh', 'bkjh', 'b', 'jhb', 'jhb', 'jhb', 'jhb', 'bjh', 'bjh', 'bjh', 'bsdfsdf', 'bjh', 'bjh', 'bh', 'jhbjh'),
(2, 'eeeeeeeeeeeeeee', 'kjh', 'asasasasasas', 'asasasasas', 'jhb', 'jhb', 'jhb', 'jhb', 'bjh', 'bjh', 'bjh', 'bsdfsdf', 'bjh', 'bjh', 'bh', 'jhbjh'),
(4, 'ppppppppppppppppp', 'kjh', 'asasasasasas', 'asasasasas', 'jhb', 'jhb', 'jhb', 'jhb', 'bjh', 'bjh', 'bjh', 'bsdfsdf', 'bjh', 'bjh', 'bh', 'jhbjh');

-- --------------------------------------------------------

--
-- Table structure for table `inventory_fan`
--

CREATE TABLE `inventory_fan` (
  `id` int(50) NOT NULL,
  `stock_number` varchar(50) DEFAULT NULL,
  `brand` varchar(50) DEFAULT NULL,
  `type` varchar(50) DEFAULT NULL,
  `color` varchar(50) DEFAULT NULL,
  `8.5` varchar(50) DEFAULT NULL,
  `total_stocks` varchar(50) DEFAULT NULL,
  `out_stocks` varchar(50) DEFAULT NULL,
  `unit_price` varchar(50) DEFAULT NULL,
  `wholesale_price` varchar(50) DEFAULT NULL,
  `manufacturer` varchar(50) DEFAULT NULL,
  `contact_number` varchar(50) DEFAULT NULL,
  `date_delivered` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `inventory_lanyard`
--

CREATE TABLE `inventory_lanyard` (
  `id` int(50) NOT NULL,
  `stock_number` varchar(50) DEFAULT NULL,
  `brand` varchar(50) DEFAULT NULL,
  `color` varchar(50) DEFAULT NULL,
  `totol_stocks` varchar(50) DEFAULT NULL,
  `out_stocks` varchar(50) DEFAULT NULL,
  `3/4` varchar(50) DEFAULT NULL,
  `1` varchar(50) DEFAULT NULL,
  `2` varchar(50) DEFAULT NULL,
  `unit_price` varchar(50) DEFAULT NULL,
  `wholesale_price` varchar(50) DEFAULT NULL,
  `manufacturer` varchar(50) DEFAULT NULL,
  `contact_number` varchar(50) DEFAULT NULL,
  `date_delivered` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `inventory_mug`
--

CREATE TABLE `inventory_mug` (
  `id` int(50) NOT NULL,
  `stock_number` varchar(50) DEFAULT NULL,
  `brand` varchar(50) DEFAULT NULL,
  `color` varchar(50) DEFAULT NULL,
  `total_stock` varchar(50) DEFAULT NULL,
  `out_stock` varchar(50) DEFAULT NULL,
  `8oz` varchar(50) DEFAULT NULL,
  `12oz` varchar(50) DEFAULT NULL,
  `16oz` varchar(50) DEFAULT NULL,
  `unit_price` varchar(50) DEFAULT NULL,
  `wholesale_price` varchar(50) DEFAULT NULL,
  `manufacturer` varchar(50) DEFAULT NULL,
  `contact_number` varchar(50) DEFAULT NULL,
  `date_delivered` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `inventory_pen`
--

CREATE TABLE `inventory_pen` (
  `id` int(20) NOT NULL,
  `stock_number` varchar(50) DEFAULT NULL,
  `brand` varchar(50) DEFAULT NULL,
  `type` varchar(50) DEFAULT NULL,
  `color` varchar(50) NOT NULL,
  `total_stock` varchar(50) DEFAULT NULL,
  `out_stock` varchar(50) DEFAULT NULL,
  `unit_price` varchar(50) DEFAULT NULL,
  `wholesale_price` varchar(50) DEFAULT NULL,
  `manufacturer` varchar(50) DEFAULT NULL,
  `contact_number` varchar(50) DEFAULT NULL,
  `date_delivered` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `inventory_plate`
--

CREATE TABLE `inventory_plate` (
  `id` int(20) NOT NULL,
  `stock_number` varchar(50) DEFAULT NULL,
  `brand` varchar(50) DEFAULT NULL,
  `type` varchar(50) DEFAULT NULL,
  `color` varchar(50) DEFAULT NULL,
  `total_stocks` varchar(50) DEFAULT NULL,
  `out_stocks` varchar(50) DEFAULT NULL,
  `8.5` varchar(50) DEFAULT NULL,
  `10` varchar(50) DEFAULT NULL,
  `11` varchar(50) DEFAULT NULL,
  `12` varchar(50) DEFAULT NULL,
  `unit_price` varchar(50) DEFAULT NULL,
  `wholesale_price` varchar(50) DEFAULT NULL,
  `manufacturer` varchar(50) DEFAULT NULL,
  `contact_number` varchar(50) DEFAULT NULL,
  `date_delivered` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `inventory_shirt`
--

CREATE TABLE `inventory_shirt` (
  `id` int(20) NOT NULL,
  `stock_number` varchar(50) DEFAULT NULL,
  `brand` varchar(50) DEFAULT NULL,
  `type` varchar(50) DEFAULT NULL,
  `color` varchar(50) DEFAULT NULL,
  `total_stocks` varchar(50) DEFAULT NULL,
  `out_stocks` varchar(50) DEFAULT NULL,
  `small` varchar(50) DEFAULT NULL,
  `medium` varchar(50) DEFAULT NULL,
  `large` varchar(50) DEFAULT NULL,
  `xl` varchar(50) DEFAULT NULL,
  `xxl` varchar(50) DEFAULT NULL,
  `unit_price` varchar(50) DEFAULT NULL,
  `wholesale_price` varchar(50) DEFAULT NULL,
  `manufacturer` varchar(50) DEFAULT NULL,
  `contact_number` varchar(50) DEFAULT NULL,
  `date_delivered` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `purchase_order`
--

CREATE TABLE `purchase_order` (
  `id` int(11) NOT NULL,
  `job_order` varchar(50) DEFAULT NULL,
  `first_name` varchar(50) DEFAULT NULL,
  `last_name` varchar(50) DEFAULT NULL,
  `company_name` varchar(50) DEFAULT NULL,
  `address` varchar(50) DEFAULT NULL,
  `email` varchar(50) DEFAULT NULL,
  `date_of_transaction` varchar(50) DEFAULT NULL,
  `product_code` varchar(50) DEFAULT NULL,
  `description` varchar(50) DEFAULT NULL,
  `quantity` varchar(50) DEFAULT NULL,
  `color` varchar(50) DEFAULT NULL,
  `size` varchar(50) DEFAULT NULL,
  `category` varchar(50) DEFAULT NULL,
  `unit_price` varchar(50) DEFAULT NULL,
  `grand_total` varchar(50) DEFAULT NULL,
  `discount` varchar(50) DEFAULT NULL,
  `remarks` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer_info`
--
ALTER TABLE `customer_info`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `employee`
--
ALTER TABLE `employee`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `inventory_fan`
--
ALTER TABLE `inventory_fan`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `inventory_lanyard`
--
ALTER TABLE `inventory_lanyard`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `inventory_mug`
--
ALTER TABLE `inventory_mug`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `inventory_pen`
--
ALTER TABLE `inventory_pen`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `inventory_plate`
--
ALTER TABLE `inventory_plate`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `inventory_shirt`
--
ALTER TABLE `inventory_shirt`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `purchase_order`
--
ALTER TABLE `purchase_order`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer_info`
--
ALTER TABLE `customer_info`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `employee`
--
ALTER TABLE `employee`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `inventory`
--
ALTER TABLE `inventory`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `inventory_fan`
--
ALTER TABLE `inventory_fan`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `inventory_lanyard`
--
ALTER TABLE `inventory_lanyard`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `inventory_mug`
--
ALTER TABLE `inventory_mug`
  MODIFY `id` int(50) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `inventory_pen`
--
ALTER TABLE `inventory_pen`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `inventory_plate`
--
ALTER TABLE `inventory_plate`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `inventory_shirt`
--
ALTER TABLE `inventory_shirt`
  MODIFY `id` int(20) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `purchase_order`
--
ALTER TABLE `purchase_order`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
