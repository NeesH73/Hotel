-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Apr 03, 2024 at 02:04 PM
-- Server version: 5.7.24
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotel`
--

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `id` int(10) UNSIGNED NOT NULL,
  `fio` varchar(100) NOT NULL,
  `status` varchar(32) NOT NULL,
  `datazaezda` date NOT NULL,
  `dataviezda` date NOT NULL,
  `koldnei` int(15) NOT NULL,
  `jivotnie` varchar(3) NOT NULL,
  `datarojdenia` date NOT NULL,
  `oplata` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id`, `fio`, `status`, `datazaezda`, `dataviezda`, `koldnei`, `jivotnie`, `datarojdenia`, `oplata`) VALUES
(1, 'Петров Иван Иванович', 'Свободный', '2024-03-01', '2024-03-05', 5, 'Да', '2000-03-03', 'Картой'),
(2, 'Иванов Евгений Алексеевич', 'Выписывается', '2024-03-27', '2024-04-01', 6, 'Нет', '2002-05-07', 'Картой'),
(3, 'Сметанин Игнат Алексеевич', 'Занятый', '2024-03-31', '2024-04-04', 5, 'Да', '1999-01-07', 'Наличкой'),
(4, 'Пупкин Василий Евгеньевич', 'Зарезервирован', '2024-04-03', '2024-04-09', 7, 'Нет', '2000-05-05', 'Картой');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD UNIQUE KEY `id` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
