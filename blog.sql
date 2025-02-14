-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2025. Feb 14. 13:08
-- Kiszolgáló verziója: 10.4.20-MariaDB
-- PHP verzió: 7.3.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `blog`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `blogtable`
--

CREATE TABLE `blogtable` (
  `ID` int(11) NOT NULL,
  `Title` varchar(100) NOT NULL,
  `Comment` varchar(200) NOT NULL,
  `UserId` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `usertable`
--

CREATE TABLE `usertable` (
  `ID` int(11) NOT NULL,
  `UserName` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- A tábla adatainak kiíratása `usertable`
--

INSERT INTO `usertable` (`ID`, `UserName`, `Email`, `Password`) VALUES
(1, 'asd', 'asd', 'asd'),
(2, 'ffff', 'fff', 'fff');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `blogtable`
--
ALTER TABLE `blogtable`
  ADD PRIMARY KEY (`ID`);

--
-- A tábla indexei `usertable`
--
ALTER TABLE `usertable`
  ADD PRIMARY KEY (`ID`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `usertable`
--
ALTER TABLE `usertable`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
