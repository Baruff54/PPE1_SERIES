-- --------------------------------------------------------
-- Hôte:                         127.0.0.1
-- Version du serveur:           5.7.33 - MySQL Community Server (GPL)
-- SE du serveur:                Win64
-- HeidiSQL Version:             11.1.0.6116
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Listage de la structure de la base pour series
CREATE DATABASE IF NOT EXISTS `series` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `series`;

-- Listage de la structure de la table series. episode
CREATE TABLE IF NOT EXISTS `episode` (
  `id` int(11) NOT NULL,
  `idSaison` int(11) NOT NULL,
  `idSerie` int(11) NOT NULL,
  `nom` varchar(50) DEFAULT NULL,
  `duree` time DEFAULT NULL,
  PRIMARY KEY (`id`,`idSaison`,`idSerie`),
  KEY `FK_episode_saison` (`idSaison`),
  KEY `FK_episode_serie` (`idSerie`),
  CONSTRAINT `FK_episode_saison` FOREIGN KEY (`idSaison`) REFERENCES `saison` (`id`),
  CONSTRAINT `FK_episode_serie` FOREIGN KEY (`idSerie`) REFERENCES `serie` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Listage des données de la table series.episode : ~0 rows (environ)
/*!40000 ALTER TABLE `episode` DISABLE KEYS */;
/*!40000 ALTER TABLE `episode` ENABLE KEYS */;

-- Listage de la structure de la table series. evaluer
CREATE TABLE IF NOT EXISTS `evaluer` (
  `idIdentifiant` int(11) DEFAULT NULL,
  `idEpisode` int(11) DEFAULT NULL,
  KEY `FK__identifiant` (`idIdentifiant`),
  KEY `FK__episode` (`idEpisode`),
  CONSTRAINT `FK__episode` FOREIGN KEY (`idEpisode`) REFERENCES `episode` (`id`),
  CONSTRAINT `FK__identifiant` FOREIGN KEY (`idIdentifiant`) REFERENCES `identifiant` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Listage des données de la table series.evaluer : ~0 rows (environ)
/*!40000 ALTER TABLE `evaluer` DISABLE KEYS */;
/*!40000 ALTER TABLE `evaluer` ENABLE KEYS */;

-- Listage de la structure de la table series. identifiant
CREATE TABLE IF NOT EXISTS `identifiant` (
  `id` int(11) NOT NULL,
  `login` varchar(50) DEFAULT NULL,
  `mdp` varchar(64) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Listage des données de la table series.identifiant : ~0 rows (environ)
/*!40000 ALTER TABLE `identifiant` DISABLE KEYS */;
/*!40000 ALTER TABLE `identifiant` ENABLE KEYS */;

-- Listage de la structure de la table series. partager
CREATE TABLE IF NOT EXISTS `partager` (
  `idIdentifiant` int(11) DEFAULT NULL,
  `idAmi` int(11) DEFAULT NULL,
  `demande` tinyint(4) DEFAULT NULL,
  KEY `FK_partager_identifiant` (`idIdentifiant`),
  KEY `FK_partager_identifiant_2` (`idAmi`),
  CONSTRAINT `FK_partager_identifiant` FOREIGN KEY (`idIdentifiant`) REFERENCES `identifiant` (`id`),
  CONSTRAINT `FK_partager_identifiant_2` FOREIGN KEY (`idAmi`) REFERENCES `identifiant` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Listage des données de la table series.partager : ~0 rows (environ)
/*!40000 ALTER TABLE `partager` DISABLE KEYS */;
/*!40000 ALTER TABLE `partager` ENABLE KEYS */;

-- Listage de la structure de la table series. saison
CREATE TABLE IF NOT EXISTS `saison` (
  `id` int(11) NOT NULL,
  `idSerie` int(11) NOT NULL,
  PRIMARY KEY (`id`,`idSerie`),
  KEY `FK_saison_serie` (`idSerie`),
  CONSTRAINT `FK_saison_serie` FOREIGN KEY (`idSerie`) REFERENCES `serie` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Listage des données de la table series.saison : ~0 rows (environ)
/*!40000 ALTER TABLE `saison` DISABLE KEYS */;
/*!40000 ALTER TABLE `saison` ENABLE KEYS */;

-- Listage de la structure de la table series. serie
CREATE TABLE IF NOT EXISTS `serie` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nom` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- Listage des données de la table series.serie : ~0 rows (environ)
/*!40000 ALTER TABLE `serie` DISABLE KEYS */;
/*!40000 ALTER TABLE `serie` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
