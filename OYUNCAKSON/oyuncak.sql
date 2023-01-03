-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 03 Oca 2023, 14:21:34
-- Sunucu sürümü: 8.0.27
-- PHP Sürümü: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `oyuncak`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `admin`
--

DROP TABLE IF EXISTS `admin`;
CREATE TABLE IF NOT EXISTS `admin` (
  `id` int NOT NULL AUTO_INCREMENT,
  `isim` varchar(150) NOT NULL,
  `sifre` varchar(150) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `bilgiler`
--

DROP TABLE IF EXISTS `bilgiler`;
CREATE TABLE IF NOT EXISTS `bilgiler` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(150) NOT NULL,
  `surname` varchar(150) NOT NULL,
  `email` varchar(150) NOT NULL,
  `telefon` varchar(150) NOT NULL,
  `sifre` varchar(150) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Tablo döküm verisi `bilgiler`
--

INSERT INTO `bilgiler` (`id`, `name`, `surname`, `email`, `telefon`, `sifre`) VALUES
(1, 'zsf', 'sdfsedf', 'swdfg', 'sdf', 'sdf'),
(2, 'ry', 'rt5y', 'r', '45', 'er45');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `cocuklar`
--

DROP TABLE IF EXISTS `cocuklar`;
CREATE TABLE IF NOT EXISTS `cocuklar` (
  `id` int NOT NULL AUTO_INCREMENT,
  `isim` varchar(150) NOT NULL,
  `date` varchar(150) NOT NULL,
  `cinsiyet` varchar(150) NOT NULL,
  `karakter` varchar(150) NOT NULL,
  `ilgi` varchar(150) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Tablo döküm verisi `cocuklar`
--

INSERT INTO `cocuklar` (`id`, `isim`, `date`, `cinsiyet`, `karakter`, `ilgi`) VALUES
(1, 'sdf', '27 Aralık 2022 Salı', 'KIZ ', 'içinekapanık', 'spor'),
(2, 'fese', '27 Aralık 2022 Salı', 'KIZ ', 'sosyal', 'doğa'),
(3, 'saffe', '27 Aralık 2022 Salı', 'vds', 'dsv', 'dvs'),
(4, 'wdf', '27 Aralık 2022 Salı', 'KIZ ', 'içinekapanık', 'doğa'),
(5, 'dsvrbr', '27 Aralık 2022 Salı', 'ERKEK', 'eğlenceli', 'spor'),
(6, 'dsdsv', '27 Aralık 2022 Salı', 'ERKEK', 'içinekapanık', 'spor'),
(7, 'wegt5', '27 Aralık 2022 Salı', 'ERKEK', 'içinekapanık', 'doğa');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `fav`
--

DROP TABLE IF EXISTS `fav`;
CREATE TABLE IF NOT EXISTS `fav` (
  `id` int NOT NULL AUTO_INCREMENT,
  `oyuncak` varchar(150) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `getirsepet`
--

DROP TABLE IF EXISTS `getirsepet`;
CREATE TABLE IF NOT EXISTS `getirsepet` (
  `id` int NOT NULL AUTO_INCREMENT,
  `isim` varchar(50) NOT NULL,
  `fiyat` varchar(50) NOT NULL,
  `adet` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `giris`
--

DROP TABLE IF EXISTS `giris`;
CREATE TABLE IF NOT EXISTS `giris` (
  `id` int NOT NULL,
  `mail` int NOT NULL,
  `sifre` int NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Tablo döküm verisi `giris`
--

INSERT INTO `giris` (`id`, `mail`, `sifre`) VALUES
(0, 0, 0),
(0, 0, 0),
(0, 0, 0),
(0, 0, 0),
(0, 0, 0),
(0, 0, 0),
(0, 0, 0),
(0, 0, 0),
(0, 0, 0),
(0, 0, 0),
(0, 0, 0),
(0, 0, 0),
(0, 0, 0);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `iaade`
--

DROP TABLE IF EXISTS `iaade`;
CREATE TABLE IF NOT EXISTS `iaade` (
  `id` int NOT NULL AUTO_INCREMENT,
  `bilgi` varchar(150) NOT NULL,
  `neden` varchar(150) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kategoriys`
--

DROP TABLE IF EXISTS `kategoriys`;
CREATE TABLE IF NOT EXISTS `kategoriys` (
  `id` int NOT NULL,
  `kategori` int NOT NULL,
  `yas` int NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Tablo döküm verisi `kategoriys`
--

INSERT INTO `kategoriys` (`id`, `kategori`, `yas`) VALUES
(0, 0, 5),
(0, 0, 0),
(0, 0, 1),
(0, 0, 5),
(0, 0, 5),
(0, 0, 5),
(0, 0, 3),
(0, 0, 3),
(0, 0, 7),
(0, 0, 3),
(0, 0, 3),
(0, 0, 7),
(0, 0, 0),
(0, 0, 10),
(0, 0, 5);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `mgz`
--

DROP TABLE IF EXISTS `mgz`;
CREATE TABLE IF NOT EXISTS `mgz` (
  `id` int NOT NULL AUTO_INCREMENT,
  `magazalar` varchar(150) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sepet`
--

DROP TABLE IF EXISTS `sepet`;
CREATE TABLE IF NOT EXISTS `sepet` (
  `id` int NOT NULL AUTO_INCREMENT,
  `sepet` varchar(150) NOT NULL,
  `isim` varchar(150) NOT NULL,
  `fiyat` varchar(150) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=26 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Tablo döküm verisi `sepet`
--

INSERT INTO `sepet` (`id`, `sepet`, `isim`, `fiyat`) VALUES
(23, '-1', 'bahce2', 'bahce8'),
(22, '-1', 'bahce3', '568 TL'),
(21, '-1', 'muzık2', '413.90 TL'),
(20, '', '', ''),
(19, '1', 'araba1', '238.90 TL'),
(18, '1', 'araba2', '253.90 TL'),
(17, '4', 'araba1', '238.90 TL'),
(15, '3', 'araba1', '238.90 TL'),
(16, '2', 'araba2', '238.90 TL'),
(24, '-1', 'bahce6', '568 TL'),
(25, 'bahce2 - bahce8-  Adet :-1', '', '');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
