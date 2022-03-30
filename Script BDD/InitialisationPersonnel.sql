-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : lun. 28 mars 2022 à 11:05
-- Version du serveur : 5.7.36
-- Version de PHP : 8.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `personnel`
--
CREATE DATABASE IF NOT EXISTS `personnel` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci;
DROP USER IF EXISTS'personnel'@'%';
CREATE USER 'personnel'@'%' IDENTIFIED BY 'motdepasse';
GRANT USAGE ON *.* TO 'personnel'@'%';
GRANT ALL PRIVILEGES ON `personnel`.* TO 'personnel'@'%';
USE `personnel`;

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `IDPERSONNEL` int(2) NOT NULL,
  `DATEDEBUT` datetime NOT NULL,
  `IDMOTIF` int(2) NOT NULL,
  `DATEFIN` datetime DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`,`DATEDEBUT`),
  KEY `I_FK_ABSENCE_MOTIF` (`IDMOTIF`),
  KEY `I_FK_ABSENCE_PERSONNEL` (`IDPERSONNEL`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`IDPERSONNEL`, `DATEDEBUT`, `IDMOTIF`, `DATEFIN`) VALUES
(2, '2021-09-29 00:00:00', 2, '2021-12-11 14:08:15'),
(2, '2021-10-22 00:00:00', 3, '2021-06-08 23:03:44'),
(2, '2021-11-07 00:00:00', 2, '2022-06-17 09:16:01'),
(2, '2022-06-22 00:00:00', 2, '2021-12-29 16:27:56'),
(2, '2023-01-29 00:00:00', 2, '2021-09-23 09:28:30'),
(2, '2023-03-14 00:00:00', 1, '2022-06-10 07:36:47'),
(3, '2021-04-26 00:00:00', 3, '2021-07-22 11:31:18'),
(3, '2022-01-23 00:00:00', 2, '2022-04-17 06:54:49'),
(3, '2022-04-06 00:00:00', 2, '2023-01-21 02:58:52'),
(3, '2022-06-17 00:00:00', 3, '2021-04-20 02:51:19'),
(3, '2023-01-31 00:00:00', 2, '2021-11-17 20:17:23'),
(3, '2023-02-18 00:00:00', 1, '2022-02-27 15:57:06'),
(4, '2021-05-19 00:00:00', 3, '2021-07-13 06:04:49'),
(4, '2021-08-30 00:00:00', 2, '2023-02-09 02:25:59'),
(4, '2022-03-22 00:00:00', 4, '2022-03-23 00:00:00'),
(4, '2023-01-22 00:00:00', 2, '2022-12-17 14:56:07'),
(5, '2021-05-05 00:00:00', 2, '2022-07-10 21:58:54'),
(5, '2021-08-01 00:00:00', 3, '2022-05-01 16:30:06'),
(5, '2021-12-05 00:00:00', 4, '2022-03-19 00:02:27'),
(5, '2021-12-17 00:00:00', 4, '2021-06-06 02:23:04'),
(5, '2022-03-16 00:00:00', 2, '2022-02-09 09:30:17'),
(5, '2022-04-12 00:00:00', 3, '2022-10-29 03:43:48'),
(5, '2022-07-20 00:00:00', 1, '2022-08-15 14:53:01'),
(5, '2022-12-29 00:00:00', 1, '2021-06-17 21:43:35'),
(6, '2021-12-25 00:00:00', 4, '2021-12-22 09:44:00'),
(6, '2022-06-08 00:00:00', 2, '2022-01-09 23:29:50'),
(6, '2022-07-11 00:00:00', 1, '2022-08-01 22:09:41'),
(6, '2022-12-06 00:00:00', 2, '2022-02-07 05:00:09'),
(6, '2022-12-10 00:00:00', 1, '2021-08-20 23:29:24'),
(6, '2022-12-21 00:00:00', 2, '2022-02-18 20:22:38');

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `IDMOTIF` int(2) NOT NULL AUTO_INCREMENT,
  `LIBELLE` varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IDMOTIF`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`IDMOTIF`, `LIBELLE`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `IDPERSONNEL` int(2) NOT NULL AUTO_INCREMENT,
  `IDSERVICE` int(2) NOT NULL,
  `NOM` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `PRENOM` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `TEL` varchar(15) COLLATE utf8_unicode_ci DEFAULT NULL,
  `MAIL` varchar(128) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`),
  KEY `I_FK_PERSONNEL_SERVICE` (`IDSERVICE`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`IDPERSONNEL`, `IDSERVICE`, `NOM`, `PRENOM`, `TEL`, `MAIL`) VALUES
(2, 3, 'Dark', 'Vador', '0631666666', 'jesuis.tonpere@luke.non'),
(3, 2, 'Holmes', 'Sherlock', '0660066006', 'elementary@watson.uk'),
(4, 1, 'Bond', 'James', '0655007007', 'bond.james@bond.mi5'),
(5, 3, 'Courrejou', 'Matthieu', '0631511046', 'mattcourrejou@hotmail.fr'),
(6, 3, 'McPicsou', 'Balthazar', '0660123456', 'canard.leplusriche@argent.dv'),
(27, 2, 'Nouveau', 'Personnel', '0606060606', 'personnel.nouveau@hotmail.fr');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) COLLATE utf8_unicode_ci NOT NULL,
  `pwd` varchar(64) COLLATE utf8_unicode_ci NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('responsable', '967520ae23e8ee14888bae72809031b98398ae4a636773e18fff917d77679334');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `IDSERVICE` int(2) NOT NULL AUTO_INCREMENT,
  `NOM` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`IDSERVICE`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`IDSERVICE`, `NOM`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt');

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `absence`
--
ALTER TABLE `absence`
  ADD CONSTRAINT `absence_ibfk_1` FOREIGN KEY (`IDMOTIF`) REFERENCES `motif` (`IDMOTIF`),
  ADD CONSTRAINT `absence_ibfk_2` FOREIGN KEY (`IDPERSONNEL`) REFERENCES `personnel` (`IDPERSONNEL`);

--
-- Contraintes pour la table `personnel`
--
ALTER TABLE `personnel`
  ADD CONSTRAINT `personnel_ibfk_1` FOREIGN KEY (`IDSERVICE`) REFERENCES `service` (`IDSERVICE`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
