-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 19 Eyl 2022, 16:56:39
-- Sunucu sürümü: 10.4.24-MariaDB
-- PHP Sürümü: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `netflixdb`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullanici`
--

CREATE TABLE `kullanici` (
  `k_id` int(11) NOT NULL,
  `k_name` varchar(30) NOT NULL,
  `k_mail` varchar(50) NOT NULL,
  `k_pwd` varchar(20) NOT NULL,
  `k_birthday` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `kullanici`
--

INSERT INTO `kullanici` (`k_id`, `k_name`, `k_mail`, `k_pwd`, `k_birthday`) VALUES
(1, 'Barış', 'baris@hotmail.com', '123456', '9.11.2003'),
(32, 'Cemre', 'cemre@hotmail.com', '123456', '9.12.2004 ');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `kullaniciprogram`
--

CREATE TABLE `kullaniciprogram` (
  `izlemetarihi` varchar(50) NOT NULL,
  `izlemesuresi` varchar(50) NOT NULL,
  `guncelbolum` int(11) NOT NULL,
  `verilenpuan` varchar(11) DEFAULT NULL,
  `p_id` int(11) NOT NULL,
  `k_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `kullaniciprogram`
--

INSERT INTO `kullaniciprogram` (`izlemetarihi`, `izlemesuresi`, `guncelbolum`, `verilenpuan`, `p_id`, `k_id`) VALUES
('19.09.2022 16:18:34', '00:01:40', 1, '', 1, 1),
('19.09.2022 17:35:32', '00:03:22', 1, '5', 6, 1),
('17.09.2022 00:38:37', '00:01:41', 1, '', 15, 1),
('16.09.2022 22:53:49', '00:00:00', 1, '', 10, 1),
('16.09.2022 22:54:29', '00:00:00', 1, '0', 2, 1),
('17.09.2022 12:16:10', '00:00:18', 1, '', 36, 1),
('19.09.2022 17:30:30', '00:00:15', 1, '', 11, 1),
('19.09.2022 17:43:33', '00:00:13', 1, '6', 6, 32);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `program`
--

CREATE TABLE `program` (
  `p_id` int(11) NOT NULL,
  `p_name` varchar(50) NOT NULL,
  `p_tip` varchar(30) NOT NULL,
  `p_bolumsayisi` int(11) NOT NULL,
  `p_uzunluk` int(11) NOT NULL,
  `p_puan` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `program`
--

INSERT INTO `program` (`p_id`, `p_name`, `p_tip`, `p_bolumsayisi`, `p_uzunluk`, `p_puan`) VALUES
(1, 'Recep İvedik 6', 'Film', 1, 142, 8.3),
(2, 'Assassıns Creed', 'Film', 1, 119, 8.7),
(3, 'Alaca Karanlık', 'Film', 1, 123, 7.8),
(4, 'Yüzüklerin Efendisi İki Kule', 'Film', 1, 157, 9.3),
(5, 'Maske', 'Film', 1, 133, 5.8),
(6, 'Kara Şövalye', 'Film', 1, 137, 9.6),
(7, 'Sherlock Holmes', 'Film', 1, 143, 6.4),
(8, 'Yüzüklerin Efendisi Kralın Dönüşü', 'Film', 1, 161, 8.9),
(9, 'Transformers Kayıp Çağ', 'Film', 1, 155, 7.4),
(10, 'Başlangıç', 'Film', 1, 148, 8.4),
(11, 'Interstellar', 'Film', 1, 161, 9.4),
(12, 'Harry Potter ve Ölüm Yadigarları', 'Film', 1, 117, 7.8),
(13, 'Jurassic World', 'Film', 1, 136, 7.7),
(14, 'Fantastik Canavarlar', 'Film', 1, 154, 8.3),
(15, 'Ninja Kaplumbağalar', 'Film', 1, 97, 8.6),
(16, 'Kuşlarla Dans', 'Film', 1, 94, 8.1),
(17, 'Mission Blue', 'Film', 1, 101, 7.5),
(18, 'Mercan Peşinde', 'Film', 1, 132, 6.4),
(19, 'Dream Big', 'Film', 1, 105, 7.3),
(20, 'Aydaki Son Adam', 'Film', 1, 136, 8),
(21, 'Plastik Okyanus', 'Film', 1, 118, 8.5),
(22, 'Rakamlarla Tahmin', 'Film', 1, 135, 7.4),
(23, 'Ben Efsaneyim', 'Film', 1, 112, 9.1),
(24, 'Arif V 216', 'Film', 1, 121, 9.3),
(25, 'PK', 'Film', 1, 145, 7.5),
(26, 'Örümcek Adam', 'Film', 1, 128, 8.1),
(27, 'Jurassic Park', 'Film', 1, 113, 5.5),
(28, 'Frankenstein', 'Film', 1, 152, 6.2),
(29, 'Gezegenimiz', 'Film', 1, 96, 9),
(30, '72 Sevimli Hayvan', 'Film', 1, 122, 7.7),
(31, 'Kuşçular', 'Film', 1, 124, 6.3),
(32, 'Marsta Keşif', 'Film', 1, 134, 5.8),
(33, 'Pandemic', 'Film', 1, 115, 7.1),
(34, 'Pokemon', 'Film', 1, 122, 8.4),
(35, 'Şirinler', 'Film', 1, 117, 7.6),
(36, 'Charlienin Çikolata Fabrikası', 'Film', 1, 114, 9.2),
(37, 'Alvin ve Sincaplar', 'Film', 1, 102, 7.9),
(38, 'Scooby Doo', 'Film', 1, 101, 6.8),
(39, 'Kungfu Panda', 'Film', 1, 103, 7.2),
(40, 'Mr Bean Tatilde', 'Film', 1, 142, 8.3),
(41, 'Shrek', 'Film', 1, 133, 5.8),
(42, 'Mega Zeka', 'Film', 1, 117, 9.2),
(43, 'Bizi Hatırla', 'Film', 1, 136, 6.2),
(44, 'Delibal', 'Film', 1, 154, 7.8),
(45, 'Kardeşim Benim', 'Film', 1, 97, 8.6),
(46, 'Dangal', 'Film', 1, 94, 8.1),
(47, 'Yerçekimi', 'Film', 1, 101, 7.5),
(48, 'Jaws', 'Film', 1, 132, 6.4),
(49, 'Da Vinci Şifresi', 'Film', 1, 105, 7.3),
(50, 'Marwel Iron Fist', 'Dizi', 15, 15, 6.8),
(51, 'Ejderhalar', 'Dizi', 35, 30, 7.9),
(52, 'Diriliş Ertuğrul', 'Dizi', 50, 20, 8.2),
(53, 'Trol Avcıları Arcadia Hikayeleri', 'Dizi', 40, 25, 6.5),
(54, 'How I Met Your Mother', 'Dizi', 50, 20, 9.8),
(55, 'Leyla ile Mecnun', 'Dizi', 60, 30, 6.5),
(56, 'Beni Böyle Sev', 'Dizi', 30, 20, 8),
(57, 'Patron Bebek Yine İş Başında', 'Dizi', 15, 20, 7),
(58, 'Atiye', 'Dizi', 10, 50, 5.6),
(59, 'Maşa ve Koca Ayı', 'Dizi', 15, 45, 8.3),
(60, 'Süngerbob', 'Dizi', 50, 15, 7.1),
(61, 'Stranger Things', 'Dizi', 60, 25, 6.9),
(62, 'The Originals', 'Dizi', 70, 20, 8.2),
(63, 'Angry Birds', 'Dizi', 60, 35, 8.8),
(64, 'Criminal', 'Dizi', 50, 20, 5.1),
(65, 'Beyblade', 'Dizi', 40, 30, 7.3),
(66, 'Sonic X', 'Dizi', 35, 20, 6.2),
(67, 'Kungfu Panda Muhteşem Sırlar', 'Dizi', 25, 20, 8.4),
(68, 'The Blacklist', 'Dizi', 30, 15, 7.6),
(69, 'Dünyanın En Sıradışı Evleri', 'TV Show', 20, 25, 8.3),
(70, 'Car Masters', 'TV Show', 15, 30, 9.1),
(71, 'Büyük Tasarımlar', 'TV Show', 10, 30, 6.2),
(72, 'Basketball or Nothing', 'TV Show', 15, 25, 8.1),
(73, 'The Big Family Cooking', 'TV Show', 20, 30, 7.2),
(74, 'Sıradışı Kulübeler', 'TV Show', 25, 20, 5.9);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tur`
--

CREATE TABLE `tur` (
  `t_id` int(11) NOT NULL,
  `t_name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `tur`
--

INSERT INTO `tur` (`t_id`, `t_name`) VALUES
(1, 'Aksiyon ve Macera'),
(2, 'Bilim Kurgu ve Fantastik Yapımlar'),
(3, 'Romantik'),
(4, 'Drama'),
(5, 'Çocuk ve Aile'),
(6, 'Belgesel'),
(7, 'Komedi'),
(8, 'Bilim ve Doğa'),
(9, 'Korku'),
(10, 'Gerilim'),
(11, 'Anime'),
(12, 'Reality Program');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `turprogram`
--

CREATE TABLE `turprogram` (
  `p_id` int(11) NOT NULL,
  `t_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Tablo döküm verisi `turprogram`
--

INSERT INTO `turprogram` (`p_id`, `t_id`) VALUES
(1, 1),
(2, 1),
(2, 2),
(3, 1),
(3, 3),
(4, 1),
(4, 2),
(5, 1),
(5, 2),
(6, 1),
(6, 2),
(7, 1),
(8, 1),
(8, 2),
(9, 1),
(10, 1),
(11, 1),
(11, 4),
(12, 1),
(12, 2),
(12, 5),
(13, 1),
(14, 1),
(14, 5),
(15, 1),
(15, 2),
(16, 6),
(17, 6),
(18, 6),
(19, 6),
(20, 6),
(21, 6),
(22, 6),
(23, 2),
(24, 2),
(24, 7),
(25, 2),
(25, 3),
(26, 1),
(26, 2),
(27, 1),
(27, 2),
(28, 1),
(28, 2),
(28, 9),
(29, 6),
(29, 8),
(30, 6),
(30, 8),
(31, 6),
(31, 8),
(32, 6),
(32, 8),
(33, 6),
(33, 8),
(34, 5),
(35, 5),
(35, 7),
(36, 5),
(36, 7),
(37, 5),
(38, 5),
(39, 1),
(39, 5),
(40, 5),
(41, 5),
(41, 7),
(42, 5),
(42, 7),
(43, 4),
(44, 3),
(44, 4),
(45, 4),
(45, 7),
(46, 4),
(47, 2),
(47, 4),
(48, 10),
(49, 10),
(50, 1),
(51, 1),
(51, 5),
(52, 1),
(53, 1),
(53, 5),
(54, 3),
(55, 3),
(56, 3),
(56, 4),
(57, 5),
(57, 7),
(58, 1),
(58, 3),
(59, 5),
(60, 5),
(60, 7),
(61, 1),
(61, 9),
(62, 4),
(62, 9),
(63, 5),
(63, 7),
(64, 10),
(65, 5),
(65, 11),
(66, 1),
(66, 11),
(67, 1),
(68, 1),
(68, 10),
(69, 12),
(70, 12),
(71, 12),
(72, 12),
(73, 12),
(74, 12);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `kullanici`
--
ALTER TABLE `kullanici`
  ADD PRIMARY KEY (`k_mail`),
  ADD UNIQUE KEY `k_id` (`k_id`);

--
-- Tablo için indeksler `kullaniciprogram`
--
ALTER TABLE `kullaniciprogram`
  ADD KEY `p_id` (`p_id`),
  ADD KEY `k_id` (`k_id`);

--
-- Tablo için indeksler `program`
--
ALTER TABLE `program`
  ADD PRIMARY KEY (`p_id`);

--
-- Tablo için indeksler `tur`
--
ALTER TABLE `tur`
  ADD PRIMARY KEY (`t_id`);

--
-- Tablo için indeksler `turprogram`
--
ALTER TABLE `turprogram`
  ADD KEY `t_id` (`t_id`),
  ADD KEY `p_id` (`p_id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `kullanici`
--
ALTER TABLE `kullanici`
  MODIFY `k_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;

--
-- Dökümü yapılmış tablolar için kısıtlamalar
--

--
-- Tablo kısıtlamaları `kullaniciprogram`
--
ALTER TABLE `kullaniciprogram`
  ADD CONSTRAINT `kullaniciprogram_ibfk_1` FOREIGN KEY (`p_id`) REFERENCES `program` (`p_id`),
  ADD CONSTRAINT `kullaniciprogram_ibfk_2` FOREIGN KEY (`k_id`) REFERENCES `kullanici` (`k_id`);

--
-- Tablo kısıtlamaları `turprogram`
--
ALTER TABLE `turprogram`
  ADD CONSTRAINT `turprogram_ibfk_1` FOREIGN KEY (`t_id`) REFERENCES `tur` (`t_id`),
  ADD CONSTRAINT `turprogram_ibfk_2` FOREIGN KEY (`p_id`) REFERENCES `program` (`p_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
