-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Client :  127.0.0.1
-- Généré le :  Ven 29 Avril 2016 à 05:32
-- Version du serveur :  5.6.17
-- Version de PHP :  5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données :  `pimtls`
--

-- --------------------------------------------------------

--
-- Structure de la table `comment`
--

CREATE TABLE IF NOT EXISTS `comment` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `description` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `dateComment` varchar(50) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Structure de la table `commentaire`
--

CREATE TABLE IF NOT EXISTS `commentaire` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `corps` varchar(1500) NOT NULL,
  `owner` int(11) NOT NULL,
  `commented` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=31 ;

--
-- Contenu de la table `commentaire`
--

INSERT INTO `commentaire` (`id`, `corps`, `owner`, `commented`) VALUES
(1, 'je suis mistiri', 48, 0),
(2, 'ammaerr', 62, 0),
(3, 'ammarooo', 61, 0),
(4, 'i m mistiriii', 48, 0),
(5, 'msetriyaa hneee', 48, 0),
(6, 'mistirr hooooy', 48, 0),
(7, 'hrrrry', 48, 0),
(8, 'amaaaaar', 48, 0),
(9, 'ooooooo', 48, 0),
(10, 'amaroo sbifibii', 48, 0),
(11, 'amaroo SciFi bigddddd', 48, 62),
(12, '', 0, 0),
(13, 'amarr rawa7 mi soug', 48, 62),
(14, 'uuuiopnbjki', 48, 62),
(15, 'kkkouyg', 62, 62),
(16, 'je suis alle a la librairie.gradle sous le theme de sa mere de chez sa tente a vesoule vierson malade aussi de se fair la queue dans la toile dans notre jardin une porte et des mur je salut les pierres et les jardin', 62, 62),
(17, 'ddddd', 48, 48),
(18, 'weer', 48, 48),
(19, 'trÃ¨s trÃ¨s bien ', 62, 48),
(20, 'salut nannoussstiiiiii...', 54, 48),
(21, 'salut les gars...', 62, 48),
(22, 'hello...', 48, 48),
(23, 'hello .D', 48, 62),
(24, 'Tap', 48, 48),
(25, 'fffff...', 48, 62),
(26, 'Tappez votre commentaire...', 48, 62),
(27, 'Taqqqqqqqqqqqq', 48, 62),
(28, 'hhhhhhhhhhhhhh...', 48, 62),
(29, 'commentaire...', 48, 62),
(30, 'vvvvvvvvvvvvvvvv', 48, 62);

-- --------------------------------------------------------

--
-- Structure de la table `product`
--

CREATE TABLE IF NOT EXISTS `product` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` text COLLATE utf8_unicode_ci NOT NULL,
  `quantity` text COLLATE utf8_unicode_ci NOT NULL,
  `price` float NOT NULL,
  `category` text COLLATE utf8_unicode_ci NOT NULL,
  `date` text COLLATE utf8_unicode_ci NOT NULL,
  `ProductImage1` text COLLATE utf8_unicode_ci NOT NULL,
  `ProductImage1Title` text COLLATE utf8_unicode_ci NOT NULL,
  `ProductImage1Desc` text COLLATE utf8_unicode_ci NOT NULL,
  `ProductImage2` text COLLATE utf8_unicode_ci NOT NULL,
  `ProductImage2Title` text COLLATE utf8_unicode_ci NOT NULL,
  `ProductImage2Desc` text COLLATE utf8_unicode_ci NOT NULL,
  `ProductImage3` text COLLATE utf8_unicode_ci NOT NULL,
  `ProductImage3Title` text COLLATE utf8_unicode_ci NOT NULL,
  `ProductImage3Desc` text COLLATE utf8_unicode_ci NOT NULL,
  `owner` int(11) NOT NULL,
  `description` text COLLATE utf8_unicode_ci NOT NULL,
  `place` text COLLATE utf8_unicode_ci NOT NULL,
  `SubCategory` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=30 ;

--
-- Contenu de la table `product`
--

INSERT INTO `product` (`id`, `name`, `quantity`, `price`, `category`, `date`, `ProductImage1`, `ProductImage1Title`, `ProductImage1Desc`, `ProductImage2`, `ProductImage2Title`, `ProductImage2Desc`, `ProductImage3`, `ProductImage3Title`, `ProductImage3Desc`, `owner`, `description`, `place`, `SubCategory`) VALUES
(5, 'Cerise du cap bon', '23 kg', 22, 'Fruits', '12/12/2016', 'http://10.0.3.2:8888/pim1/uploads/cerise1.jpg', 'sdf', 'sdf', 'http://10.0.3.2:8888/pim1/uploads/cerise2.jpg', 'sdf', 'sdf', 'http://10.0.3.2:8888/pim1/uploads/cerise3.jpg', 'dsf', 'ssdf', 62, 'fzef', 'sdf', ''),
(6, 'Les Cerises Du Cap bon', '120 Kg', 13, 'Fruit', '12/12/2016', 'http://10.0.3.2:8888/pim1/uploads/cerise1.jpg', 'Les Meilleurs cerises', 'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud ', 'http://10.0.3.2:8888/pim1/uploads/cerise2.jpg', 'Dans Votre Panier', 'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo co', 'http://10.0.3.2:8888/pim1/uploads/cerise3.jpg', 'Degustez Les', 'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo co', 62, 'Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. ', 'Kelibia Nabeul "', ''),
(8, 'ble', '12', 14, 'Nourriture', '12/12/2016', 'http://10.0.3.2:8888/pim1/ProductImage/8.png', 'dgfdhgfdf', ',jf,ghfv,hgf', 'http://10.0.3.2:8888/pim1/ProductImage/10.png', 'jyfjfv,gfc', 'jyfjfv,gfc', 'http://10.0.3.2:8888/pim1/ProductImage/11.png', 'j;hfjgf,gf', 'j;hfjgf,gf', 48, 'ble', '', ''),
(9, 'noir', '123', 10, 'Nourriture', '12/12/2016', 'http://10.0.3.2:8888/pim1/ProductImage/9.png', 'dfghjk', 'dfghjkl', 'http://10.0.3.2:8888/pim1/ProductImage/11.png', 'dfghjkol', 'dfghjkol', 'http://10.0.3.2:8888/pim1/ProductImage/12.png', 'ertyuio', 'ertyuio', 62, 'noir', '', ''),
(10, 'bleu', '134', 56, 'Nourriture', '12/12/2016', 'http://10.0.3.2:8888/pim1/ProductImage/10.png', 'khgg', 'ggkjhgj', 'http://10.0.3.2:8888/pim1/ProductImage/12.png', 'kgjhjgh', 'kgjhjgh', 'http://10.0.3.2:8888/pim1/ProductImage/13.png', 'gkhjkjghghj', 'gkhjkjghghj', 62, 'bleu', '', 'A manger'),
(11, 'cool', '12', 23, 'Services', '12/12/2016', 'http://10.0.3.2:8888/pim1/ProductImage/11.png', 'Assurancia Assurancia', 'dysfonctionnement administratif gj', 'http://10.0.3.2:8888/pim1/ProductImage/13.png', 'Ghomeshi Ghomeshi Ghomeshi Ghomeshi Ghomeshi Ghomeshi Ghomeshi', 'Ghomeshi Ghomeshi Ghomeshi Ghomeshi Ghomeshi Ghomeshi Ghomeshi', 'http://10.0.3.2:8888/pim1/ProductImage/14.png', 'yuan de la composer avec', 'yuan de la composer avec', 48, 'cool', '', 'Education'),
(12, 'coolio', '12', 12, 'Nourriture', '12/12/12', 'http://10.0.3.2:8888/pim1/ProductImage/11.png', 'sdfqsd', 'qsdfqsd', 'http://10.0.3.2:8888/pim1/ProductImage/11.png', 'sqdfsd', 'sqdfsqd', 'http://10.0.3.2:8888/pim1/ProductImage/11.png', 'qsdfqsdf', 'qsdfqdsf', 62, 'sdfqsdfqsdf', 'fqsdfqsdf', 'Legumes'),
(13, 'casscade', '12', 12, 'Nourriture', '12/13/2012', 'http://10.0.3.2:8888/pim1/ProductImage/13.png', 'lkjhgdf', 'hgdhfgdf', 'http://10.0.3.2:8888/pim1/ProductImage/13.png', 'gdsfgsdfg', 'dsfgdsfgsd', 'http://10.0.3.2:8888/pim1/ProductImage/13.png', 'sdfgsdfg', 'dqsfsqdf', 62, 'fqsdfqsdf', 'fsqdfsqdf', 'Miel'),
(14, 'Plomberie', '1', 13, 'Services', '12/12/2019', '', '', '', '', '', '', '', '', '', 62, 'zesrdytfuygiuhijcfvgybhuknjil,kjgvhbkjnkgkuhlkj', 'kuhglkjh', 'Reparation'),
(15, 'Macbook Pro', '12', 330, 'Multimedia', '12/12/2016', 'http://10.0.3.2:8888/pim1/ProductImage/15.png', 'sdfqdf', 'qsdfqsdfqsdfsqdf', 'http://10.0.3.2:8888/pim1/ProductImage/17.png', 'qsdfqsdfqsdf', 'qsdfqsdfqsdf', 'http://10.0.3.2:8888/pim1/ProductImage/18.png', 'qsdfqdsfqsdfsqdfqdsfqd', 'qsdfqdsfqsdfsqdfqdsfqd', 48, 'sdfsqdfqsfqs df qsdf qsd fqs df qdf qs df qsd f qsdf qs df qsd fqs df qsdf qsdf', 'Tunis', 'Ordinateur'),
(16, 'Costume', '12', 12, 'Artisanat', '12/12/2016', '', 'dqsdqsdqs', 'fsdfsdqf', '', 'fqdsfsqdfqdsf', 'sqdfsqdfqsdfsdq', '', 'fsqdfsdqfqsdfqdsf', 'fsqdfqsdfqsdfqdsf', 62, 'qdfshdjfsdqfsdqfdqsfqsdfqdsfqsdff qsdfsdfqsdfdf', 'hghghghgigzefhqdj', 'Broderie'),
(17, 'Traiteur', '2', 123, 'Services', '12/12/2016', 'http://10.0.3.2:8888/pim1/ProductImage/17.png', 'jgfjg', 'rtdytfugkihoj', 'http://10.0.3.2:8888/pim1/ProductImage/19.png', 'ethdyfjugykhiu', 'ethdyfjugykhiu', 'http://10.0.3.2:8888/pim1/ProductImage/20.png', 'gsdhfjtgykhu', 'gsdhfjtgykhu', 48, 'qsfyyh uhjgjnb iuygkjhgjg', 'Kef', 'Cuisine'),
(19, 'Nom du produit ...', 'La quantitÃ© est ...', 0, 'Nourriture', '4/9/2016 12:00:00 AM', '', '', '', '', '', '', '', '', '', 62, 'Votre description ...', '', 'Viande'),
(20, 'Nom du produit ...', 'La quantitÃ© est ...', 0, 'Services', '4/9/2016 12:00:00 AM', '', '', '', '', '', '', '', '', '', 62, 'Votre description ...', '', 'Reparation'),
(21, 'Nom du produit ...', 'La quantitÃ© est ...', 5, 'Services', '4/9/2016 12:00:00 AM', '', '', '', '', '', '', '', '', '', 62, 'Votre description ...', '', 'Reparation'),
(22, 'batata', '200KG', 1000, 'Nourriture', '4/29/2016 12:00:00 AM', '', '', '', '', '', '', '', '', '', 62, 'batatabatata', '', 'Legume'),
(23, 'felfel', '300', 1500, 'Nourriture', '4/29/2016 12:00:00 AM', '', '', '', '', '', '', '', '', '', 62, 'felfel', '', 'Legume'),
(24, 'haha', '20', 300, 'Nourriture', '4/29/2016 12:00:00 AM', '', '', '', '', '', '', '', '', '', 62, 'hahahahahaha', '', 'Legume'),
(25, 'bbb', 'bbb', 333, 'Nourriture', '4/29/2016 12:00:00 AM', '', '', '', '', '', '', '', '', '', 62, 'bbbb', '', 'Legume'),
(26, 'jjjjj', 'jjjjj', 200, 'Nourriture', '4/29/2016 12:00:00 AM', '', '', '', '', '', '', '', '', '', 62, 'jjjjj', '', 'Legume'),
(27, 'tmatem', '30', 20, 'Nourriture', '4/29/2016 12:00:00 AM', 'hahha', '', '', '', '', '', '', '', '', 62, 'tmatem', '', 'Legume'),
(28, '7aja', '20', 40, 'Nourriture', '4/29/2016 12:00:00 AM', 'localhost/PIMTLS/Image/logo.png', '', '', '', '', '', '', '', '', 62, '7aja', '', 'Legume'),
(29, 'art', 'art', 30, 'Artisanat', '4/29/2016 12:00:00 AM', 'localhost/PIMTLS/Image/amine.PNG', '', '', '', '', '', '', '', '', 62, 'art', '', 'Poterie');

-- --------------------------------------------------------

--
-- Structure de la table `raiting`
--

CREATE TABLE IF NOT EXISTS `raiting` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `id_raiter` int(11) DEFAULT NULL,
  `id_raited` int(11) DEFAULT NULL,
  `id_product` int(11) DEFAULT NULL,
  `nombre` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `id_raiter` (`id_raiter`),
  KEY `id-raited` (`id_raited`),
  KEY `id_product` (`id_product`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=64 ;

--
-- Contenu de la table `raiting`
--

INSERT INTO `raiting` (`id`, `id_raiter`, `id_raited`, `id_product`, `nombre`) VALUES
(11, 48, 68, 5, 1),
(12, 48, NULL, 5, 1),
(13, 48, NULL, 5, 1),
(14, 48, NULL, 5, 5),
(15, 48, NULL, 5, 4),
(16, 48, NULL, 5, 3),
(17, 48, NULL, 5, 2),
(18, 48, NULL, 5, 1),
(23, 62, NULL, 8, 1),
(24, 62, NULL, 16, 4),
(25, 61, NULL, 16, 1),
(26, 61, NULL, 16, 2),
(27, 61, NULL, 16, 3),
(28, 61, NULL, 16, 4),
(29, 61, NULL, 16, 5),
(30, 61, NULL, 15, 2),
(31, 61, NULL, 15, 2),
(32, 61, NULL, 15, 3),
(33, 61, NULL, 15, 3),
(34, 61, NULL, 15, 4),
(35, 61, NULL, 15, 4),
(36, 61, NULL, 15, 5),
(37, 61, NULL, 15, 5),
(38, 61, NULL, 15, 5),
(39, 61, NULL, 15, 5),
(40, 61, NULL, 11, 2),
(41, 61, NULL, 11, 3),
(42, 61, NULL, 11, 4),
(43, 61, NULL, 11, 5),
(44, 61, NULL, 11, 1),
(45, 61, NULL, 11, 2),
(46, 61, NULL, 11, 3),
(47, 61, NULL, 11, 4),
(48, 61, NULL, 11, 5),
(49, 61, NULL, 15, 2),
(50, 61, NULL, 15, 3),
(51, 61, NULL, 15, 4),
(52, 61, NULL, 15, 5),
(53, 61, 62, NULL, 4),
(54, 48, 62, NULL, 1),
(55, 48, 62, NULL, 2),
(56, 48, 62, NULL, 3),
(57, 48, 62, NULL, 4),
(58, 48, 62, NULL, 5),
(63, 61, NULL, 8, 5);

-- --------------------------------------------------------

--
-- Structure de la table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `username_canonical` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `email` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `email_canonical` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `enabled` tinyint(1) DEFAULT NULL,
  `salt` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `password` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `last_login` datetime DEFAULT NULL,
  `locked` tinyint(1) DEFAULT NULL,
  `expired` tinyint(1) DEFAULT NULL,
  `expires_at` datetime DEFAULT NULL,
  `confirmation_token` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `password_requested_at` datetime DEFAULT NULL,
  `roles` longtext COLLATE utf8_unicode_ci COMMENT '(DC2Type:array)',
  `credentials_expired` tinyint(1) DEFAULT NULL,
  `credentials_expire_at` datetime DEFAULT NULL,
  `nom` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `prenom` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `tel` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `adresse` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `Description` varchar(1500) COLLATE utf8_unicode_ci NOT NULL,
  `ImagePath` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `rate` int(11) NOT NULL,
  `Ratedby` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `UNIQ_8D93D649A0D96FBF` (`email_canonical`),
  UNIQUE KEY `UNIQ_8D93D64992FC23A8` (`username_canonical`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci AUTO_INCREMENT=80 ;

--
-- Contenu de la table `user`
--

INSERT INTO `user` (`id`, `username`, `username_canonical`, `email`, `email_canonical`, `enabled`, `salt`, `password`, `last_login`, `locked`, `expired`, `expires_at`, `confirmation_token`, `password_requested_at`, `roles`, `credentials_expired`, `credentials_expire_at`, `nom`, `prenom`, `tel`, `adresse`, `Description`, `ImagePath`, `rate`, `Ratedby`) VALUES
(1, 'username', '', 'email', '', 0, '', 'password', NULL, 0, 0, NULL, NULL, NULL, '', 0, NULL, 'firstname', 'lastname', 'age', 'adresse', '', '', 0, 0),
(39, 'llll', NULL, 'uuu', NULL, NULL, NULL, 'rrrrrr', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'eeee', 'ddddd', '7777', 'fffff', '', '', 0, 0),
(40, 'usernameyyy', NULL, 'emailuuu', NULL, NULL, NULL, 'password', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'firstname', 'lastname', 'age', 'adresse', '', '', 0, 0),
(41, 'usernameyyyyss', NULL, 'emailzzzz', NULL, NULL, NULL, 'password', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'firstname', 'lastname', '55', 'adresse', '', '', 0, 0),
(42, 'aaa', NULL, 'aaa', NULL, NULL, NULL, 'aaa', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'aaa', 'aaaa', '555', 'aaa', '', '', 0, 0),
(43, 'rrr', NULL, 'tttt', NULL, NULL, NULL, 'iiii', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'eee', 'rrr', '555', 'ttt', '', '', 0, 0),
(44, 'mimi', NULL, 'm@m', NULL, NULL, NULL, 'm', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'mariem', 'bk', '25887378', 'bizerte', '', '', 0, 0),
(45, 'a', NULL, 'a', NULL, NULL, NULL, 'a', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'a', 'v', '5', 'a', '', '', 0, 0),
(46, 's', NULL, 's', NULL, NULL, NULL, 's', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 's', 's', '5', 's', '', '', 0, 0),
(47, 'h', NULL, 'rrr', NULL, NULL, NULL, 'h', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'g', 'g', 'h', 'h', '', '', 0, 0),
(48, 'yy', NULL, 'yy', NULL, NULL, NULL, 'yy', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'yy', 'yy', '90', 'yy', '', '', 3, 0),
(49, 'Barbouche', NULL, 'hassan.barbouche@esprit.tn', NULL, NULL, NULL, 'nuttertools', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Barbouche', 'hassan', '9799944', 'Rue el homs', 'Jeune Agriculteur originaire d''Elkef ,vendeur de plusieurs produit agricole : orange,fraise,ognion carotte', '', 0, 0),
(50, 'tt', NULL, 'tt', NULL, NULL, NULL, 'tt', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'tt', 'tt', '23', 'tt', 'tt', 'http://10.0.3.2:8888/pim1/uploads/0.png', 0, 0),
(51, 'pp', NULL, 'pp', NULL, NULL, NULL, 'pp', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'pp', 'pp', '09', 'pp', 'pp', 'http://localhost/pim1/uploads/0.png', 0, 0),
(52, 'ii', NULL, 'ii', NULL, NULL, NULL, 'ii', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'ii', 'ii', '88', 'ii', 'ii', 'http://10.0.3.2:8888/pim1/uploads/gplay.png', 0, 0),
(53, 'oo', NULL, 'oo', NULL, NULL, NULL, 'oo', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'oo', 'oo', '99', '09', 'oo', 'http://10.0.3.2:8888/pim1/uploads/0.png', 0, 0),
(54, 'Mazouni', NULL, 'Mazouni.anas@esprit.tn', NULL, NULL, NULL, 'mazouni', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Mazouni', 'Anas', '21456887', 'Gamarth Tunis', 'Agriculeteur de fraise a gamarth tunis', 'http://10.0.3.2:8888/pim1/uploads/0.png', 0, 0),
(55, 'zz', NULL, 'zz', NULL, NULL, NULL, 'zz', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'zz', 'zz', '11', 'zz', 'zz', 'http://10.0.3.2:8888/pim1/uploads/0.png', 0, 0),
(56, 'aa', NULL, 'aa', NULL, NULL, NULL, 'aa', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'aa', 'aa', '11', 'aa', 'aa', 'http://10.0.3.2:8888/pim1/uploads/0.png', 0, 0),
(57, 'dd', NULL, 'dd', NULL, NULL, NULL, 'dd', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'dd', 'dd', '11', 'dd', 'dd', 'http://10.0.3.2:8888/pim1/uploads/0.png', 0, 0),
(58, 'ff', NULL, 'ff', NULL, NULL, NULL, 'ff', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'ff', 'ff', '23', 'ff', 'ff', 'http://10.0.3.2:8888/pim1/uploads/0.png', 0, 0),
(59, 'mm', NULL, 'mm', NULL, NULL, NULL, 'mm', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'mm', 'mm', '77', 'mm', 'mm', 'http://10.0.3.2:8888/pim1/uploads/0.png', 0, 0),
(60, 'cc', NULL, 'cc', NULL, NULL, NULL, 'cc', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'cc', 'cc', '11', 'cc', 'cc', 'http://10.0.3.2:8888/pim1/uploads/60.png', 0, 0),
(61, 'gg', NULL, 'gg', NULL, NULL, NULL, 'gg', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'gg', 'gggg', '66', 'gg', 'gg', 'http://10.0.3.2:8888/pim1/uploads/61.png', 0, 0),
(62, 'Hassan', NULL, 'hassan.barbouche@esprit.tn', NULL, NULL, NULL, 'hassan', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Barbouche', 'Hassan', '789', '6 rue d''Alger El Kef 7100', 'sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex', 'http://10.0.3.2:8888/pim1/uploads/61.png', 0, 0),
(63, '', NULL, '', NULL, NULL, NULL, 'alaeddine', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'ala eddine', 'haouala', '53822829', 'tunis', 'he suis ala et patati patata ', '', 0, 0),
(64, '', NULL, '', NULL, NULL, NULL, 'alaeddine', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'ala eddine', 'haouala', '53822829', 'tunis', 'he suis ala et patati patata ', '', 0, 0),
(65, '', NULL, '', NULL, NULL, NULL, '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Votre prÃ©nom ...', 'Votre nom ...', 'Votre Telephone ...', 'Votre adresse ...', 'Votre description ...', '', 0, 0),
(66, '', NULL, '', NULL, NULL, NULL, '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Votre prÃ©nom ...', 'Votre nom ...', 'Votre Telephone ...', 'Votre adresse ...', 'Votre description ...', '', 0, 0),
(67, '', NULL, '', NULL, NULL, NULL, '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Votre prÃ©nom ...', 'Votre nom ...', 'Votre Telephone ...', '', 'Votre description ...', '', 0, 0),
(68, '', NULL, '', NULL, NULL, NULL, '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Votre prÃ©nom ...', '', '', '', '', '', 0, 0),
(69, '', NULL, '', NULL, NULL, NULL, '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Votre prÃ©nom ...', '', '', '', '', '', 0, 0),
(70, '', NULL, '', NULL, NULL, NULL, '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'ttttt', '', '', '', '', '', 0, 0),
(71, '', NULL, '', NULL, NULL, NULL, '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'nom', '', '', '', '', '', 0, 0),
(72, '', NULL, '', NULL, NULL, NULL, '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'kkk', '', '', '', '', '', 0, 0),
(73, '', NULL, '', NULL, NULL, NULL, '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Votre prÃ©nom ...', 'Votre nom ...', 'Votre Telephone ...', 'Votre adresse ...', 'Votre description ...', '', 0, 0),
(74, 'Votre pseudo ...', NULL, '', NULL, NULL, NULL, '', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Votre prÃ©nom ...', 'Votre nom ...', 'Votre Telephone ...', 'Votre adresse ...', 'Votre description ...', '', 0, 0),
(75, 'Votre pseudo ...', NULL, 'Votre e-mail ...', NULL, NULL, NULL, 'qqqq', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'Votre prÃ©nom ...', 'Votre nom ...', 'Votre Telephone ...', 'Votre adresse ...', 'Votre description ...', '', 0, 0),
(76, 'haifa', NULL, 'haifa', NULL, NULL, NULL, 'haifa', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'haifa', 'haifa', '234', 'haifa', 'haifa', '', 0, 0),
(77, 'haifa', NULL, 'haifa', NULL, NULL, NULL, 'haifa', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'haifa', 'haifa2', '234', 'haifa', 'haifa', '', 0, 0),
(78, 'fifi', NULL, 'fifi', NULL, NULL, NULL, 'fifi', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'fifi', 'fifi', '222', 'fifi', 'fifi', 'localhost/PIMTLS/Image/logo.png', 0, 0),
(79, 'doudou', NULL, 'doudou', NULL, NULL, NULL, 'doudou', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 'doudou', 'doudou', '222', 'doudou', 'doudou', 'localhost/PIMTLS/Image/logo.png', 0, 0);

--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `raiting`
--
ALTER TABLE `raiting`
  ADD CONSTRAINT `fk_id_product` FOREIGN KEY (`id_product`) REFERENCES `product` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_id_raited` FOREIGN KEY (`id_raited`) REFERENCES `user` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_id_raiter` FOREIGN KEY (`id_raiter`) REFERENCES `user` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
