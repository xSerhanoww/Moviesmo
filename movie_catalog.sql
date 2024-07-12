-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 12, 2024 at 11:18 AM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `movie_catalog`
--

-- --------------------------------------------------------

--
-- Table structure for table `actors`
--

CREATE TABLE `actors` (
  `ActorId` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `actors`
--

INSERT INTO `actors` (`ActorId`, `Name`) VALUES
(1, 'Leonardo DiCaprio'),
(2, 'Tom Hanks'),
(3, 'Morgan Freeman'),
(4, 'Robert De Niro'),
(5, 'Meryl Streep'),
(6, 'Brad Pitt'),
(7, 'Johnny Depp'),
(8, 'Natalie Portman'),
(9, 'Christian Bale'),
(10, 'Scarlett Johansson'),
(11, 'Denzel Washington'),
(12, 'Matt Damon'),
(13, 'Angelina Jolie'),
(14, 'Jennifer Lawrence'),
(15, 'Will Smith'),
(16, 'Emma Stone'),
(17, 'Samuel L. Jackson'),
(18, 'Anne Hathaway'),
(19, 'Ryan Gosling'),
(20, 'Julia Roberts'),
(21, 'Chris Hemsworth');

-- --------------------------------------------------------

--
-- Table structure for table `countries`
--

CREATE TABLE `countries` (
  `CountryId` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `countries`
--

INSERT INTO `countries` (`CountryId`, `Name`) VALUES
(1, 'United States'),
(2, 'United Kingdom'),
(3, 'Canada'),
(4, 'France'),
(5, 'Australia');

-- --------------------------------------------------------

--
-- Table structure for table `directors`
--

CREATE TABLE `directors` (
  `DirectorId` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `directors`
--

INSERT INTO `directors` (`DirectorId`, `Name`) VALUES
(1, 'Steven Spielberg'),
(2, 'Martin Scorsese'),
(3, 'Christopher Nolan'),
(4, 'Quentin Tarantino'),
(5, 'James Cameron');

-- --------------------------------------------------------

--
-- Table structure for table `genres`
--

CREATE TABLE `genres` (
  `GenreId` int(11) NOT NULL,
  `Name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `genres`
--

INSERT INTO `genres` (`GenreId`, `Name`) VALUES
(1, 'Action'),
(2, 'Drama'),
(3, 'Comedy'),
(4, 'Thriller'),
(5, 'Science Fiction');

-- --------------------------------------------------------

--
-- Table structure for table `movieactors`
--

CREATE TABLE `movieactors` (
  `MovieId` int(11) NOT NULL,
  `ActorId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `movieactors`
--

INSERT INTO `movieactors` (`MovieId`, `ActorId`) VALUES
(1, 1),
(2, 1),
(3, 9),
(4, 7),
(5, 1),
(6, 10),
(7, 3),
(8, 1),
(9, 9),
(10, 11),
(11, 2),
(12, 2),
(13, 4),
(14, 1),
(15, 9),
(16, 6),
(17, 4),
(18, 2),
(19, 2),
(20, 19),
(21, 8);

-- --------------------------------------------------------

--
-- Table structure for table `movies`
--

CREATE TABLE `movies` (
  `MovieId` int(11) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Description` text NOT NULL,
  `DirectorId` int(11) DEFAULT NULL,
  `CountryId` int(11) DEFAULT NULL,
  `GenreId` int(11) DEFAULT NULL,
  `Length` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `movies`
--

INSERT INTO `movies` (`MovieId`, `Title`, `Description`, `DirectorId`, `CountryId`, `GenreId`, `Length`) VALUES
(1, 'Inception', 'A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a CEO.', 3, 1, 5, 148),
(2, 'Titanic', 'A young aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.', 5, 1, 2, 195),
(3, 'The Dark Knight', 'When the menace known as the Joker emerges from his mysterious past, he causes chaos and destruction in Gotham. The Dark Knight faces a great test to fight injustice.', 3, 1, 1, 152),
(4, 'Pulp Fiction', 'The lives of various people intertwine in four stories of crime and redemption.', 4, 1, 4, 154),
(5, 'The Wolf of Wall Street', 'The true story of Jordan Belfort, from his rise to a wealthy stockbroker to his involvement in crime and the federal government.', 2, 1, 3, 180),
(6, 'Avatar', 'A Marine dispatched to the moon Pandora becomes torn between following his orders and protecting the world he feels is his home.', 5, 1, 5, 162),
(7, 'The Shawshank Redemption', 'Two imprisoned men bond over many years, finding solace and redemption through acts of kindness.', 2, 1, 2, 142),
(8, 'The Departed', 'An undercover cop and a mole in the police try to identify each other while infiltrating an Irish gang in South Boston.', 2, 1, 4, 151),
(9, 'Gladiator', 'A former Roman General sets out to get justice against the corrupt emperor who harmed his family and sent him into slavery.', 3, 2, 1, 155),
(10, 'The Matrix', 'When a beautiful stranger leads a computer hacker to a forbidding underworld, he discovers the shocking truth about reality.', 5, 1, 5, 136),
(11, 'Jurassic Park', 'During a preview tour, a theme park suffers a major power breakdown that allows its cloned dinosaur exhibits to run amok.', 1, 1, 1, 127),
(12, 'Forrest Gump', 'The presidencies of Kennedy and Johnson, the events of Vietnam, Watergate, and other history unfold through the perspective of an Alabama man with an IQ of 75.', 1, 1, 3, 142),
(13, 'The Godfather', 'The aging patriarch of an organized crime dynasty transfers control of his empire to his reluctant son.', 2, 1, 1, 175),
(14, 'Schindler\'s List', 'In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.', 1, 1, 2, 195),
(15, 'Interstellar', 'A team of explorers travel through a wormhole in space in an attempt to ensure humanity\'s survival.', 3, 1, 5, 169),
(16, 'Fight Club', 'An insomniac office worker and a soap maker form an underground club with rules that they break and chaos they unleash.', 5, 1, 1, 139),
(17, 'Goodfellas', 'The story of Henry Hill and his life in the mob, covering his relationship with his wife and his partners in crime.', 2, 1, 3, 146),
(18, 'The Silence of the Lambs', 'A young F.B.I. cadet must confide in an incarcerated and manipulative killer to receive his help on catching another serial killer.', 4, 1, 4, 118),
(19, 'Saving Private Ryan', 'Following the Normandy Landings, a group of U.S. soldiers go behind enemy lines to retrieve a paratrooper whose brothers have been killed in action.', 1, 1, 2, 169),
(20, 'American Beauty', 'A sexually frustrated suburban father has a mid-life crisis after becoming infatuated with his daughter\'s best friend.', 4, 1, 2, 122),
(21, 'Black Swan', 'A committed dancer struggles to maintain her sanity after winning the lead role in a production of Tchaikovsky\'s Swan Lake.', 2, 1, 2, 108);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `actors`
--
ALTER TABLE `actors`
  ADD PRIMARY KEY (`ActorId`);

--
-- Indexes for table `countries`
--
ALTER TABLE `countries`
  ADD PRIMARY KEY (`CountryId`);

--
-- Indexes for table `directors`
--
ALTER TABLE `directors`
  ADD PRIMARY KEY (`DirectorId`);

--
-- Indexes for table `genres`
--
ALTER TABLE `genres`
  ADD PRIMARY KEY (`GenreId`);

--
-- Indexes for table `movieactors`
--
ALTER TABLE `movieactors`
  ADD PRIMARY KEY (`MovieId`,`ActorId`),
  ADD KEY `ActorId` (`ActorId`);

--
-- Indexes for table `movies`
--
ALTER TABLE `movies`
  ADD PRIMARY KEY (`MovieId`),
  ADD KEY `DirectorId` (`DirectorId`),
  ADD KEY `CountryId` (`CountryId`),
  ADD KEY `GenreId` (`GenreId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `actors`
--
ALTER TABLE `actors`
  MODIFY `ActorId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `countries`
--
ALTER TABLE `countries`
  MODIFY `CountryId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `directors`
--
ALTER TABLE `directors`
  MODIFY `DirectorId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `genres`
--
ALTER TABLE `genres`
  MODIFY `GenreId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `movies`
--
ALTER TABLE `movies`
  MODIFY `MovieId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `movieactors`
--
ALTER TABLE `movieactors`
  ADD CONSTRAINT `movieactors_ibfk_1` FOREIGN KEY (`MovieId`) REFERENCES `movies` (`MovieId`),
  ADD CONSTRAINT `movieactors_ibfk_2` FOREIGN KEY (`ActorId`) REFERENCES `actors` (`ActorId`);

--
-- Constraints for table `movies`
--
ALTER TABLE `movies`
  ADD CONSTRAINT `movies_ibfk_1` FOREIGN KEY (`DirectorId`) REFERENCES `directors` (`DirectorId`),
  ADD CONSTRAINT `movies_ibfk_2` FOREIGN KEY (`CountryId`) REFERENCES `countries` (`CountryId`),
  ADD CONSTRAINT `movies_ibfk_3` FOREIGN KEY (`GenreId`) REFERENCES `genres` (`GenreId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
