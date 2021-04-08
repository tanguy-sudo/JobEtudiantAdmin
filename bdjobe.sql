-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3306
-- Généré le : jeu. 08 avr. 2021 à 22:12
-- Version du serveur :  8.0.21
-- Version de PHP : 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données : `bdjobe`
--
CREATE DATABASE IF NOT EXISTS `bdjobe` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `bdjobe`;

-- --------------------------------------------------------

--
-- Structure de la table `anetudiant`
--

DROP TABLE IF EXISTS `anetudiant`;
CREATE TABLE IF NOT EXISTS `anetudiant` (
  `idanetudiant` int NOT NULL AUTO_INCREMENT,
  `idAn` int NOT NULL,
  `idEtu` int NOT NULL,
  `idEta` int NOT NULL,
  PRIMARY KEY (`idanetudiant`),
  KEY `idAn` (`idAn`),
  KEY `idEtudiant` (`idEtu`),
  KEY `idCiv` (`idEta`)
) ENGINE=MyISAM AUTO_INCREMENT=84 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `anetudiant`
--

INSERT INTO `anetudiant` (`idanetudiant`, `idAn`, `idEtu`, `idEta`) VALUES
(75, 3, 1, 2),
(57, 14, 1, 1),
(62, 1, 1, 3),
(74, 2, 1, 3),
(76, 2, 3, 1),
(77, 1, 3, 2),
(78, 1, 2, 1),
(79, 3, 2, 1);

-- --------------------------------------------------------

--
-- Structure de la table `annonce`
--

DROP TABLE IF EXISTS `annonce`;
CREATE TABLE IF NOT EXISTS `annonce` (
  `idAn` int NOT NULL AUTO_INCREMENT,
  `titreAn` varchar(100) NOT NULL,
  `dateDe` date NOT NULL,
  `duree` varchar(50) NOT NULL,
  `descAn` varchar(500) NOT NULL,
  `lieu` varchar(50) NOT NULL,
  `tariHoraire` int NOT NULL,
  `idOff` int NOT NULL,
  `idCateg` int NOT NULL,
  PRIMARY KEY (`idAn`),
  KEY `idCateg` (`idOff`,`idCateg`)
) ENGINE=MyISAM AUTO_INCREMENT=33 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `annonce`
--

INSERT INTO `annonce` (`idAn`, `titreAn`, `dateDe`, `duree`, `descAn`, `lieu`, `tariHoraire`, `idOff`, `idCateg`) VALUES
(1, 'développeur informatique', '2018-11-30', 'un an', 'contrat en alternance pour développeur informatique.', 'Le Mans', 1900, 1, 16),
(2, 'travail étudiant', '2019-07-01', 'deux mois', 'travail dans le secteur VHS(viande hachée surgelée).', 'Cherré', 1400, 2, 8),
(3, 'caissier', '2019-01-05', 'un an', 'caissier chez E-leclerc pendant un an tous les weekends', 'Cherré', 400, 3, 7),
(4, 'Ramasser du raisin', '2019-08-17', 'deux jours', 'ramasser du raisin pendant 5 heures le samedi et dimanche.', 'Dollon', 100, 4, 9),
(5, 'caissier', '2019-02-22', 'six mois', 'caissier chez carrefour.', 'Le Mans', 400, 5, 7),
(15, 'babysitting', '2018-12-28', '3 heures', 'Garder ma petite fille pour une durée de trois heures pour un coût total de 50 euros.', 'connerré', 50, 11, 1);

-- --------------------------------------------------------

--
-- Structure de la table `categorie`
--

DROP TABLE IF EXISTS `categorie`;
CREATE TABLE IF NOT EXISTS `categorie` (
  `idCateg` int NOT NULL AUTO_INCREMENT,
  `libCateg` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`idCateg`)
) ENGINE=MyISAM AUTO_INCREMENT=22 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `categorie`
--

INSERT INTO `categorie` (`idCateg`, `libCateg`) VALUES
(3, 'Animation des ventes'),
(2, 'Professeur'),
(1, 'BabySitting'),
(4, 'Loisirs et Tourisme'),
(5, 'Télémarketing'),
(6, 'Secretariat'),
(7, 'Vente'),
(8, 'Manutention'),
(9, 'Cueillette'),
(10, 'Vendanges'),
(11, 'Hôtessariat'),
(12, 'Demonstrateur'),
(13, 'Restauration'),
(14, 'Hôtellerie'),
(15, 'Enqueteur'),
(16, 'Informatique'),
(17, 'Autre'),
(20, 'Services à la personne'),
(19, 'Stage');

-- --------------------------------------------------------

--
-- Structure de la table `civilite`
--

DROP TABLE IF EXISTS `civilite`;
CREATE TABLE IF NOT EXISTS `civilite` (
  `idCiv` int NOT NULL AUTO_INCREMENT,
  `libCiv` varchar(15) NOT NULL,
  PRIMARY KEY (`idCiv`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `civilite`
--

INSERT INTO `civilite` (`idCiv`, `libCiv`) VALUES
(1, 'Madame'),
(2, 'Monsieur'),
(3, 'Ent');

-- --------------------------------------------------------

--
-- Structure de la table `etat`
--

DROP TABLE IF EXISTS `etat`;
CREATE TABLE IF NOT EXISTS `etat` (
  `idEtat` int NOT NULL AUTO_INCREMENT,
  `libEtat` varchar(50) NOT NULL,
  PRIMARY KEY (`idEtat`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `etat`
--

INSERT INTO `etat` (`idEtat`, `libEtat`) VALUES
(1, 'En cours'),
(2, 'Refusé'),
(3, 'Accepté');

-- --------------------------------------------------------

--
-- Structure de la table `etudiant`
--

DROP TABLE IF EXISTS `etudiant`;
CREATE TABLE IF NOT EXISTS `etudiant` (
  `idEtu` int NOT NULL AUTO_INCREMENT,
  `nomEtu` varchar(50) NOT NULL,
  `prenomEtu` varchar(50) NOT NULL,
  `dateNaiss` date NOT NULL,
  `mailEtu` varchar(50) NOT NULL,
  `telEtu` varchar(10) NOT NULL,
  `mdpEtu` varchar(50) NOT NULL,
  `cvEtu` varchar(100) NOT NULL,
  `idCiv` int NOT NULL,
  `idType` int NOT NULL,
  PRIMARY KEY (`idEtu`),
  KEY `idCiv` (`idCiv`)
) ENGINE=MyISAM AUTO_INCREMENT=31 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `etudiant`
--

INSERT INTO `etudiant` (`idEtu`, `nomEtu`, `prenomEtu`, `dateNaiss`, `mailEtu`, `telEtu`, `mdpEtu`, `cvEtu`, `idCiv`, `idType`) VALUES
(1, 'jouvin', 'tanguy', '1998-12-29', 'tanguy.jouvin@hotmail.com', '0644831232', 'mdptanguy', '1CV Tanguy Jouvin.pdf', 2, 1),
(2, 'prud', 'yoann', '1996-10-12', 'yoann.prud@hotmail.com', '9876543210', 'mdpyoann', 'cvyoann.pdf', 2, 1),
(3, 'lou', 'celia', '2000-05-06', 'celia.lou@hotmail.com', '46372819', 'mdpcelia', 'cvpaul.pdf', 1, 1),
(4, 'malo', 'paul', '1999-03-03', 'paul.malo@hotmail.com', '0245678345', 'mdppaul', '11cvpaul.pdf', 2, 1),
(5, 'vaillant', 'louise', '1999-07-09', 'louise.vaillant@hotmail.com', '0283945738', 'mdplouise', 'cvlouise.pdf', 1, 1);

-- --------------------------------------------------------

--
-- Structure de la table `offreur`
--

DROP TABLE IF EXISTS `offreur`;
CREATE TABLE IF NOT EXISTS `offreur` (
  `idOff` int NOT NULL AUTO_INCREMENT,
  `nomOff` varchar(30) NOT NULL,
  `prenomOff` varchar(30) DEFAULT NULL,
  `adresseOff` varchar(50) NOT NULL,
  `villeOff` varchar(50) NOT NULL,
  `cpOff` int NOT NULL,
  `mailOff` varchar(50) NOT NULL,
  `telOff` varchar(10) NOT NULL,
  `logoOff` varchar(100) DEFAULT NULL,
  `mdpOff` varchar(50) NOT NULL,
  `idCiv` int DEFAULT '3',
  `siteWeb` varchar(100) DEFAULT NULL,
  `idType` int NOT NULL,
  PRIMARY KEY (`idOff`),
  KEY `idCiv` (`idCiv`)
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `offreur`
--

INSERT INTO `offreur` (`idOff`, `nomOff`, `prenomOff`, `adresseOff`, `villeOff`, `cpOff`, `mailOff`, `telOff`, `logoOff`, `mdpOff`, `idCiv`, `siteWeb`, `idType`) VALUES
(2, 'Socopa', '', 'Les Bordes', 'Cherré', 72400, 'socopa@hotmail.com', '283549859', '2logosocopa.png', 'mdpsocopa', 3, 'http://www.groupesocopa.fr', 2),
(3, 'E-leclerc', NULL, 'Lieu Dit la voie', 'Cherré', 72400, 'leclerc@hotmail.com', '0238257648', 'leclercLogo.jpg', 'mdpleclerc', 3, 'http://www.e-leclerc.com/la-ferte-bernard', 2),
(1, 'bfast-system', NULL, 'Avenue Michel Verdier', 'vibraye', 72320, 'bfast.system@hotmail.com', '0987654321', '1bfastLogo.jpg', 'mdpbfast', 3, 'https://www.bfast-system.com', 2),
(4, 'brouard', 'claude', 'lieu dit la bruyere', 'Dollon', 72390, 'claude.brouard@hotmail.com', '689344829', '', 'mdpclaude', 2, '', 3),
(5, 'carrefour', NULL, 'Rue Robert Collet', 'Le Mans', 72100, 'carrefour@hotmail.com', '0238264052', 'carrefourLogo.jpg', 'mdpcarrefour', 3, 'https://www.carrefour.fr', 2),
(11, 'dupond', 'lola', '16 rue de la rivière', 'dollon', 72390, 'lola.dupond@hotmail.com', '0634768102', NULL, 'mdplola', 1, NULL, 3);

-- --------------------------------------------------------

--
-- Structure de la table `typemembre`
--

DROP TABLE IF EXISTS `typemembre`;
CREATE TABLE IF NOT EXISTS `typemembre` (
  `idType` tinyint NOT NULL,
  `LibelleType` varchar(100) NOT NULL,
  PRIMARY KEY (`idType`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Déchargement des données de la table `typemembre`
--

INSERT INTO `typemembre` (`idType`, `LibelleType`) VALUES
(1, 'etudiant'),
(2, 'professionnel'),
(3, 'particulier');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
