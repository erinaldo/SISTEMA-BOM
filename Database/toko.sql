-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 15, 2017 at 04:54 PM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `toko`
--
CREATE DATABASE IF NOT EXISTS `toko` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `toko`;

DELIMITER $$
--
-- Procedures
--
DROP PROCEDURE IF EXISTS `fill_calendar`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `fill_calendar` (IN `start_date` DATE, IN `end_date` DATE)  BEGIN
DECLARE crt_date DATE;
  SET crt_date=start_date;
  WHILE crt_date <= end_date DO
    INSERT INTO tabel_kosong_tanggal VALUES(DATE_FORMAT(crt_date,'%m-%d'));
    SET crt_date = ADDDATE(crt_date, INTERVAL 1 DAY);
  END WHILE;
END$$

DROP PROCEDURE IF EXISTS `fill_tabel_kosong`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `fill_tabel_kosong` ()  BEGIN
DECLARE i INT;
  SET i=1;
  WHILE i <= 1000 DO
    INSERT INTO tabel_kosong VALUES(i);
    SET i = i+1;
  END WHILE;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `tabel_barang`
--

DROP TABLE IF EXISTS `tabel_barang`;
CREATE TABLE `tabel_barang` (
  `kode_barang` varchar(12) NOT NULL,
  `nama_barang` varchar(30) NOT NULL,
  `tipe_barang` varchar(15) NOT NULL,
  `stok_barang` int(11) NOT NULL,
  `harga_modal` double NOT NULL,
  `harga_grosir` double NOT NULL,
  `harga_retail` double NOT NULL,
  `keterangan` varchar(100) NOT NULL,
  `tgl_update` date NOT NULL,
  `terjual` int(11) NOT NULL,
  `profit` double NOT NULL,
  `terhapus` enum('Y','N') NOT NULL DEFAULT 'N'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tabel_barang_keluar`
--

DROP TABLE IF EXISTS `tabel_barang_keluar`;
CREATE TABLE `tabel_barang_keluar` (
  `no` int(11) NOT NULL,
  `kode_barang` varchar(12) NOT NULL,
  `stok_keluar` int(11) NOT NULL,
  `tgl` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `invoice` varchar(15) NOT NULL,
  `harga_jual` double NOT NULL,
  `laba` double NOT NULL,
  `diskon` double NOT NULL,
  `isorder` enum('Y','N') NOT NULL DEFAULT 'N'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tabel_barang_masuk`
--

DROP TABLE IF EXISTS `tabel_barang_masuk`;
CREATE TABLE `tabel_barang_masuk` (
  `no` int(11) NOT NULL,
  `kode_barang` varchar(12) NOT NULL,
  `stok_masuk` int(11) NOT NULL,
  `tgl_update` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `invoice` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tabel_barang_retur`
--

DROP TABLE IF EXISTS `tabel_barang_retur`;
CREATE TABLE `tabel_barang_retur` (
  `no` int(11) NOT NULL,
  `kode_barang` varchar(12) NOT NULL,
  `stok_retur` int(11) NOT NULL,
  `tgl` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `invoice` varchar(15) NOT NULL,
  `harga_jual` double NOT NULL,
  `rugi` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tabel_customer`
--

DROP TABLE IF EXISTS `tabel_customer`;
CREATE TABLE `tabel_customer` (
  `id_customer` varchar(12) NOT NULL,
  `nama` varchar(25) NOT NULL,
  `alamat` varchar(50) NOT NULL,
  `asal` varchar(20) NOT NULL,
  `telp` varchar(15) NOT NULL,
  `hutang_lama` int(11) NOT NULL,
  `catatan` varchar(200) NOT NULL,
  `terdaftar_bln` date NOT NULL,
  `terhapus` enum('Y','N') NOT NULL DEFAULT 'N'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_customer`
--

INSERT INTO `tabel_customer` (`id_customer`, `nama`, `alamat`, `asal`, `telp`, `hutang_lama`, `catatan`, `terdaftar_bln`, `terhapus`) VALUES
('C-000-000', 'Cash', 'Cash', 'Cash', '0', 0, 'Cash', '0100-01-01', 'N');

-- --------------------------------------------------------

--
-- Table structure for table `tabel_enkripsi`
--

DROP TABLE IF EXISTS `tabel_enkripsi`;
CREATE TABLE `tabel_enkripsi` (
  `enkripsi` int(1) NOT NULL DEFAULT '0',
  `div` int(4) DEFAULT NULL,
  `0,5` varchar(2) DEFAULT NULL,
  `0` varchar(2) DEFAULT NULL,
  `1` varchar(2) DEFAULT NULL,
  `2` varchar(2) DEFAULT NULL,
  `3` varchar(2) DEFAULT NULL,
  `4` varchar(2) DEFAULT NULL,
  `5` varchar(2) DEFAULT NULL,
  `6` varchar(2) DEFAULT NULL,
  `7` varchar(2) DEFAULT NULL,
  `8` varchar(2) DEFAULT NULL,
  `9` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_enkripsi`
--

INSERT INTO `tabel_enkripsi` (`enkripsi`, `div`, `0,5`, `0`, `1`, `2`, `3`, `4`, `5`, `6`, `7`, `8`, `9`) VALUES
(1, 1, 'Z', 'H', 'S', 'L', 'Y', 'K', 'U', 'R', 'N', 'I', 'A');

-- --------------------------------------------------------

--
-- Table structure for table `tabel_invoice_keluar`
--

DROP TABLE IF EXISTS `tabel_invoice_keluar`;
CREATE TABLE `tabel_invoice_keluar` (
  `invoice` varchar(15) NOT NULL,
  `id_customer` varchar(12) NOT NULL,
  `nama_sales` varchar(25) NOT NULL,
  `tipe_penjualan` enum('Retail','Grosir','Order Barang') NOT NULL,
  `tgl_update` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `belanja` double NOT NULL,
  `qty_belanja` int(11) NOT NULL,
  `retur` double NOT NULL,
  `qty_retur` int(11) NOT NULL,
  `pembayaran` double NOT NULL,
  `diskon` double NOT NULL,
  `profit` double NOT NULL,
  `rugi` double NOT NULL,
  `hutang_lama` double NOT NULL,
  `hutang_baru` double NOT NULL,
  `issmall` tinyint(4) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tabel_invoice_masuk`
--

DROP TABLE IF EXISTS `tabel_invoice_masuk`;
CREATE TABLE `tabel_invoice_masuk` (
  `invoice` varchar(15) NOT NULL,
  `id_supplier` varchar(12) DEFAULT NULL,
  `tgl_update` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `total_pembelian` double NOT NULL,
  `total_masuk` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `tabel_kosong`
--

DROP TABLE IF EXISTS `tabel_kosong`;
CREATE TABLE `tabel_kosong` (
  `no` int(5) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_kosong`
--

INSERT INTO `tabel_kosong` (`no`) VALUES
(1),
(2),
(3),
(4),
(5),
(6),
(7),
(8),
(9),
(10),
(11),
(12),
(13),
(14),
(15),
(16),
(17),
(18),
(19),
(20),
(21),
(22),
(23),
(24),
(25),
(26),
(27),
(28),
(29),
(30),
(31),
(32),
(33),
(34),
(35),
(36),
(37),
(38),
(39),
(40),
(41),
(42),
(43),
(44),
(45),
(46),
(47),
(48),
(49),
(50),
(51),
(52),
(53),
(54),
(55),
(56),
(57),
(58),
(59),
(60),
(61),
(62),
(63),
(64),
(65),
(66),
(67),
(68),
(69),
(70),
(71),
(72),
(73),
(74),
(75),
(76),
(77),
(78),
(79),
(80),
(81),
(82),
(83),
(84),
(85),
(86),
(87),
(88),
(89),
(90),
(91),
(92),
(93),
(94),
(95),
(96),
(97),
(98),
(99),
(100),
(101),
(102),
(103),
(104),
(105),
(106),
(107),
(108),
(109),
(110),
(111),
(112),
(113),
(114),
(115),
(116),
(117),
(118),
(119),
(120),
(121),
(122),
(123),
(124),
(125),
(126),
(127),
(128),
(129),
(130),
(131),
(132),
(133),
(134),
(135),
(136),
(137),
(138),
(139),
(140),
(141),
(142),
(143),
(144),
(145),
(146),
(147),
(148),
(149),
(150),
(151),
(152),
(153),
(154),
(155),
(156),
(157),
(158),
(159),
(160),
(161),
(162),
(163),
(164),
(165),
(166),
(167),
(168),
(169),
(170),
(171),
(172),
(173),
(174),
(175),
(176),
(177),
(178),
(179),
(180),
(181),
(182),
(183),
(184),
(185),
(186),
(187),
(188),
(189),
(190),
(191),
(192),
(193),
(194),
(195),
(196),
(197),
(198),
(199),
(200),
(201),
(202),
(203),
(204),
(205),
(206),
(207),
(208),
(209),
(210),
(211),
(212),
(213),
(214),
(215),
(216),
(217),
(218),
(219),
(220),
(221),
(222),
(223),
(224),
(225),
(226),
(227),
(228),
(229),
(230),
(231),
(232),
(233),
(234),
(235),
(236),
(237),
(238),
(239),
(240),
(241),
(242),
(243),
(244),
(245),
(246),
(247),
(248),
(249),
(250),
(251),
(252),
(253),
(254),
(255),
(256),
(257),
(258),
(259),
(260),
(261),
(262),
(263),
(264),
(265),
(266),
(267),
(268),
(269),
(270),
(271),
(272),
(273),
(274),
(275),
(276),
(277),
(278),
(279),
(280),
(281),
(282),
(283),
(284),
(285),
(286),
(287),
(288),
(289),
(290),
(291),
(292),
(293),
(294),
(295),
(296),
(297),
(298),
(299),
(300),
(301),
(302),
(303),
(304),
(305),
(306),
(307),
(308),
(309),
(310),
(311),
(312),
(313),
(314),
(315),
(316),
(317),
(318),
(319),
(320),
(321),
(322),
(323),
(324),
(325),
(326),
(327),
(328),
(329),
(330),
(331),
(332),
(333),
(334),
(335),
(336),
(337),
(338),
(339),
(340),
(341),
(342),
(343),
(344),
(345),
(346),
(347),
(348),
(349),
(350),
(351),
(352),
(353),
(354),
(355),
(356),
(357),
(358),
(359),
(360),
(361),
(362),
(363),
(364),
(365),
(366),
(367),
(368),
(369),
(370),
(371),
(372),
(373),
(374),
(375),
(376),
(377),
(378),
(379),
(380),
(381),
(382),
(383),
(384),
(385),
(386),
(387),
(388),
(389),
(390),
(391),
(392),
(393),
(394),
(395),
(396),
(397),
(398),
(399),
(400),
(401),
(402),
(403),
(404),
(405),
(406),
(407),
(408),
(409),
(410),
(411),
(412),
(413),
(414),
(415),
(416),
(417),
(418),
(419),
(420),
(421),
(422),
(423),
(424),
(425),
(426),
(427),
(428),
(429),
(430),
(431),
(432),
(433),
(434),
(435),
(436),
(437),
(438),
(439),
(440),
(441),
(442),
(443),
(444),
(445),
(446),
(447),
(448),
(449),
(450),
(451),
(452),
(453),
(454),
(455),
(456),
(457),
(458),
(459),
(460),
(461),
(462),
(463),
(464),
(465),
(466),
(467),
(468),
(469),
(470),
(471),
(472),
(473),
(474),
(475),
(476),
(477),
(478),
(479),
(480),
(481),
(482),
(483),
(484),
(485),
(486),
(487),
(488),
(489),
(490),
(491),
(492),
(493),
(494),
(495),
(496),
(497),
(498),
(499),
(500),
(501),
(502),
(503),
(504),
(505),
(506),
(507),
(508),
(509),
(510),
(511),
(512),
(513),
(514),
(515),
(516),
(517),
(518),
(519),
(520),
(521),
(522),
(523),
(524),
(525),
(526),
(527),
(528),
(529),
(530),
(531),
(532),
(533),
(534),
(535),
(536),
(537),
(538),
(539),
(540),
(541),
(542),
(543),
(544),
(545),
(546),
(547),
(548),
(549),
(550),
(551),
(552),
(553),
(554),
(555),
(556),
(557),
(558),
(559),
(560),
(561),
(562),
(563),
(564),
(565),
(566),
(567),
(568),
(569),
(570),
(571),
(572),
(573),
(574),
(575),
(576),
(577),
(578),
(579),
(580),
(581),
(582),
(583),
(584),
(585),
(586),
(587),
(588),
(589),
(590),
(591),
(592),
(593),
(594),
(595),
(596),
(597),
(598),
(599),
(600),
(601),
(602),
(603),
(604),
(605),
(606),
(607),
(608),
(609),
(610),
(611),
(612),
(613),
(614),
(615),
(616),
(617),
(618),
(619),
(620),
(621),
(622),
(623),
(624),
(625),
(626),
(627),
(628),
(629),
(630),
(631),
(632),
(633),
(634),
(635),
(636),
(637),
(638),
(639),
(640),
(641),
(642),
(643),
(644),
(645),
(646),
(647),
(648),
(649),
(650),
(651),
(652),
(653),
(654),
(655),
(656),
(657),
(658),
(659),
(660),
(661),
(662),
(663),
(664),
(665),
(666),
(667),
(668),
(669),
(670),
(671),
(672),
(673),
(674),
(675),
(676),
(677),
(678),
(679),
(680),
(681),
(682),
(683),
(684),
(685),
(686),
(687),
(688),
(689),
(690),
(691),
(692),
(693),
(694),
(695),
(696),
(697),
(698),
(699),
(700),
(701),
(702),
(703),
(704),
(705),
(706),
(707),
(708),
(709),
(710),
(711),
(712),
(713),
(714),
(715),
(716),
(717),
(718),
(719),
(720),
(721),
(722),
(723),
(724),
(725),
(726),
(727),
(728),
(729),
(730),
(731),
(732),
(733),
(734),
(735),
(736),
(737),
(738),
(739),
(740),
(741),
(742),
(743),
(744),
(745),
(746),
(747),
(748),
(749),
(750),
(751),
(752),
(753),
(754),
(755),
(756),
(757),
(758),
(759),
(760),
(761),
(762),
(763),
(764),
(765),
(766),
(767),
(768),
(769),
(770),
(771),
(772),
(773),
(774),
(775),
(776),
(777),
(778),
(779),
(780),
(781),
(782),
(783),
(784),
(785),
(786),
(787),
(788),
(789),
(790),
(791),
(792),
(793),
(794),
(795),
(796),
(797),
(798),
(799),
(800),
(801),
(802),
(803),
(804),
(805),
(806),
(807),
(808),
(809),
(810),
(811),
(812),
(813),
(814),
(815),
(816),
(817),
(818),
(819),
(820),
(821),
(822),
(823),
(824),
(825),
(826),
(827),
(828),
(829),
(830),
(831),
(832),
(833),
(834),
(835),
(836),
(837),
(838),
(839),
(840),
(841),
(842),
(843),
(844),
(845),
(846),
(847),
(848),
(849),
(850),
(851),
(852),
(853),
(854),
(855),
(856),
(857),
(858),
(859),
(860),
(861),
(862),
(863),
(864),
(865),
(866),
(867),
(868),
(869),
(870),
(871),
(872),
(873),
(874),
(875),
(876),
(877),
(878),
(879),
(880),
(881),
(882),
(883),
(884),
(885),
(886),
(887),
(888),
(889),
(890),
(891),
(892),
(893),
(894),
(895),
(896),
(897),
(898),
(899),
(900),
(901),
(902),
(903),
(904),
(905),
(906),
(907),
(908),
(909),
(910),
(911),
(912),
(913),
(914),
(915),
(916),
(917),
(918),
(919),
(920),
(921),
(922),
(923),
(924),
(925),
(926),
(927),
(928),
(929),
(930),
(931),
(932),
(933),
(934),
(935),
(936),
(937),
(938),
(939),
(940),
(941),
(942),
(943),
(944),
(945),
(946),
(947),
(948),
(949),
(950),
(951),
(952),
(953),
(954),
(955),
(956),
(957),
(958),
(959),
(960),
(961),
(962),
(963),
(964),
(965),
(966),
(967),
(968),
(969),
(970),
(971),
(972),
(973),
(974),
(975),
(976),
(977),
(978),
(979),
(980),
(981),
(982),
(983),
(984),
(985),
(986),
(987),
(988),
(989),
(990),
(991),
(992),
(993),
(994),
(995),
(996),
(997),
(998),
(999),
(1000);

-- --------------------------------------------------------

--
-- Table structure for table `tabel_kosong_bulan`
--

DROP TABLE IF EXISTS `tabel_kosong_bulan`;
CREATE TABLE `tabel_kosong_bulan` (
  `bulan` varchar(2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_kosong_bulan`
--

INSERT INTO `tabel_kosong_bulan` (`bulan`) VALUES
('01'),
('02'),
('03'),
('04'),
('05'),
('06'),
('07'),
('08'),
('09'),
('10'),
('11'),
('12');

-- --------------------------------------------------------

--
-- Table structure for table `tabel_kosong_tanggal`
--

DROP TABLE IF EXISTS `tabel_kosong_tanggal`;
CREATE TABLE `tabel_kosong_tanggal` (
  `tgl` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_kosong_tanggal`
--

INSERT INTO `tabel_kosong_tanggal` (`tgl`) VALUES
('01-01'),
('01-02'),
('01-03'),
('01-04'),
('01-05'),
('01-06'),
('01-07'),
('01-08'),
('01-09'),
('01-10'),
('01-11'),
('01-12'),
('01-13'),
('01-14'),
('01-15'),
('01-16'),
('01-17'),
('01-18'),
('01-19'),
('01-20'),
('01-21'),
('01-22'),
('01-23'),
('01-24'),
('01-25'),
('01-26'),
('01-27'),
('01-28'),
('01-29'),
('01-30'),
('01-31'),
('02-01'),
('02-02'),
('02-03'),
('02-04'),
('02-05'),
('02-06'),
('02-07'),
('02-08'),
('02-09'),
('02-10'),
('02-11'),
('02-12'),
('02-13'),
('02-14'),
('02-15'),
('02-16'),
('02-17'),
('02-18'),
('02-19'),
('02-20'),
('02-21'),
('02-22'),
('02-23'),
('02-24'),
('02-25'),
('02-26'),
('02-27'),
('02-28'),
('03-01'),
('03-02'),
('03-03'),
('03-04'),
('03-05'),
('03-06'),
('03-07'),
('03-08'),
('03-09'),
('03-10'),
('03-11'),
('03-12'),
('03-13'),
('03-14'),
('03-15'),
('03-16'),
('03-17'),
('03-18'),
('03-19'),
('03-20'),
('03-21'),
('03-22'),
('03-23'),
('03-24'),
('03-25'),
('03-26'),
('03-27'),
('03-28'),
('03-29'),
('03-30'),
('03-31'),
('04-01'),
('04-02'),
('04-03'),
('04-04'),
('04-05'),
('04-06'),
('04-07'),
('04-08'),
('04-09'),
('04-10'),
('04-11'),
('04-12'),
('04-13'),
('04-14'),
('04-15'),
('04-16'),
('04-17'),
('04-18'),
('04-19'),
('04-20'),
('04-21'),
('04-22'),
('04-23'),
('04-24'),
('04-25'),
('04-26'),
('04-27'),
('04-28'),
('04-29'),
('04-30'),
('05-01'),
('05-02'),
('05-03'),
('05-04'),
('05-05'),
('05-06'),
('05-07'),
('05-08'),
('05-09'),
('05-10'),
('05-11'),
('05-12'),
('05-13'),
('05-14'),
('05-15'),
('05-16'),
('05-17'),
('05-18'),
('05-19'),
('05-20'),
('05-21'),
('05-22'),
('05-23'),
('05-24'),
('05-25'),
('05-26'),
('05-27'),
('05-28'),
('05-29'),
('05-30'),
('05-31'),
('06-01'),
('06-02'),
('06-03'),
('06-04'),
('06-05'),
('06-06'),
('06-07'),
('06-08'),
('06-09'),
('06-10'),
('06-11'),
('06-12'),
('06-13'),
('06-14'),
('06-15'),
('06-16'),
('06-17'),
('06-18'),
('06-19'),
('06-20'),
('06-21'),
('06-22'),
('06-23'),
('06-24'),
('06-25'),
('06-26'),
('06-27'),
('06-28'),
('06-29'),
('06-30'),
('07-01'),
('07-02'),
('07-03'),
('07-04'),
('07-05'),
('07-06'),
('07-07'),
('07-08'),
('07-09'),
('07-10'),
('07-11'),
('07-12'),
('07-13'),
('07-14'),
('07-15'),
('07-16'),
('07-17'),
('07-18'),
('07-19'),
('07-20'),
('07-21'),
('07-22'),
('07-23'),
('07-24'),
('07-25'),
('07-26'),
('07-27'),
('07-28'),
('07-29'),
('07-30'),
('07-31'),
('08-01'),
('08-02'),
('08-03'),
('08-04'),
('08-05'),
('08-06'),
('08-07'),
('08-08'),
('08-09'),
('08-10'),
('08-11'),
('08-12'),
('08-13'),
('08-14'),
('08-15'),
('08-16'),
('08-17'),
('08-18'),
('08-19'),
('08-20'),
('08-21'),
('08-22'),
('08-23'),
('08-24'),
('08-25'),
('08-26'),
('08-27'),
('08-28'),
('08-29'),
('08-30'),
('08-31'),
('09-01'),
('09-02'),
('09-03'),
('09-04'),
('09-05'),
('09-06'),
('09-07'),
('09-08'),
('09-09'),
('09-10'),
('09-11'),
('09-12'),
('09-13'),
('09-14'),
('09-15'),
('09-16'),
('09-17'),
('09-18'),
('09-19'),
('09-20'),
('09-21'),
('09-22'),
('09-23'),
('09-24'),
('09-25'),
('09-26'),
('09-27'),
('09-28'),
('09-29'),
('09-30'),
('10-01'),
('10-02'),
('10-03'),
('10-04'),
('10-05'),
('10-06'),
('10-07'),
('10-08'),
('10-09'),
('10-10'),
('10-11'),
('10-12'),
('10-13'),
('10-14'),
('10-15'),
('10-16'),
('10-17'),
('10-18'),
('10-19'),
('10-20'),
('10-21'),
('10-22'),
('10-23'),
('10-24'),
('10-25'),
('10-26'),
('10-27'),
('10-28'),
('10-29'),
('10-30'),
('10-31'),
('11-01'),
('11-02'),
('11-03'),
('11-04'),
('11-05'),
('11-06'),
('11-07'),
('11-08'),
('11-09'),
('11-10'),
('11-11'),
('11-12'),
('11-13'),
('11-14'),
('11-15'),
('11-16'),
('11-17'),
('11-18'),
('11-19'),
('11-20'),
('11-21'),
('11-22'),
('11-23'),
('11-24'),
('11-25'),
('11-26'),
('11-27'),
('11-28'),
('11-29'),
('11-30'),
('12-01'),
('12-02'),
('12-03'),
('12-04'),
('12-05'),
('12-06'),
('12-07'),
('12-08'),
('12-09'),
('12-10'),
('12-11'),
('12-12'),
('12-13'),
('12-14'),
('12-15'),
('12-16'),
('12-17'),
('12-18'),
('12-19'),
('12-20'),
('12-21'),
('12-22'),
('12-23'),
('12-24'),
('12-25'),
('12-26'),
('12-27'),
('12-28'),
('12-29'),
('12-30'),
('12-31'),
('00-00');

-- --------------------------------------------------------

--
-- Table structure for table `tabel_log`
--

DROP TABLE IF EXISTS `tabel_log`;
CREATE TABLE `tabel_log` (
  `tanggal` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `user` varchar(10) NOT NULL,
  `jenis_kegiatan` varchar(50) NOT NULL,
  `keterangan` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_log`
--

INSERT INTO `tabel_log` (`tanggal`, `user`, `jenis_kegiatan`, `keterangan`) VALUES
('2017-02-13 17:33:38', 'admin', 'Login', 'Login'),
('2017-02-13 17:36:53', 'admin', 'Logout', 'Logout'),
('2017-02-13 17:37:03', 'admin', 'Login', 'Login'),
('2017-02-13 17:39:17', 'admin', 'Logout', 'Logout'),
('2017-02-13 21:49:41', 'admin', 'Login', 'Login'),
('2017-02-13 21:50:52', 'admin', 'Logout', 'Logout'),
('2017-02-15 15:38:03', 'admin', 'Login', 'Login'),
('2017-02-15 15:42:16', 'admin', 'Login', 'Login'),
('2017-02-15 15:43:24', 'admin', 'Login', 'Login'),
('2017-02-15 15:50:51', 'admin', 'Logout', 'Logout'),
('2017-02-15 15:52:59', 'admin', 'Login', 'Login'),
('2017-02-15 15:54:08', 'admin', 'Logout', 'Logout');

-- --------------------------------------------------------

--
-- Table structure for table `tabel_perusahaan`
--

DROP TABLE IF EXISTS `tabel_perusahaan`;
CREATE TABLE `tabel_perusahaan` (
  `no` int(11) NOT NULL,
  `nama_toko` varchar(23) NOT NULL,
  `alamat_lengkap` varchar(30) NOT NULL,
  `alamat` varchar(15) NOT NULL,
  `telp` varchar(15) NOT NULL,
  `catatan` tinytext NOT NULL,
  `catatan_kaki` tinytext NOT NULL,
  `logo_perusahaan` blob NOT NULL,
  `pemilik_foto` blob NOT NULL,
  `pemilik_nama` varchar(23) NOT NULL,
  `pemilik_alamat` varchar(30) NOT NULL,
  `pemilik_telp` varchar(15) NOT NULL,
  `pemilik_catatan` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_perusahaan`
--

INSERT INTO `tabel_perusahaan` (`no`, `nama_toko`, `alamat_lengkap`, `alamat`, `telp`, `catatan`, `catatan_kaki`, `logo_perusahaan`, `pemilik_foto`, `pemilik_nama`, `pemilik_alamat`, `pemilik_telp`, `pemilik_catatan`) VALUES
(0, 'PT Makmur', 'Jalan Kota', 'Medan Area', '00000000000', 'WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW\r\nWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW', 'Terima kasih atas kunjungan Anda.\r\n\r\nBarang yang sudah dibeli, tidak dapat ditukar atau dikembalikan.', 0x89504e470d0a1a0a0000000d49484452000000300000003008060000005702f9870000000467414d410000b18f0bfc61050000001974455874536f6674776172650041646f626520496d616765526561647971c9653c00000a19494441546843d5d67b5c54651a07f0d72ccd60d0616e30333017a8052f19e25d51f192a96944eaa222a682822082c8a08cdce5ee1ddc2445341515b044d050d1d494d0d0acd4dab2d8ae565b4a2ad8cdfdedf38e630b330714d6fee08fefe7e53ce77ddff37bce9c390303d0ae0916db13c1627b22586c4f048bed8960b13d112cb62756053b43e5c3a623634586ca7062207ea457e33972e351a6883dc2643115cc36ea30eb17bb89ddd8a7640d1532565f29670dc7a5ace184c4345ae6b52a34def821f0a0b0ab69acea6aa8bc4960564bb52d746e3879c80dc41c6d3b0357c928941d8d06714ce519e9d2ca1f14c663bfa9124fc239f53434e955705a710a8ef1c7215d761434672735a078680d88171f68bb250799d87088d9c71c7e566238f48dc258095df61974df74113d0b3e468f2d97d163f325d3b17bde87786ac30770caa8863cf6c897f2658723a8814ecd3570fba4fd8335205d58d2768bf73169f48129d225e5d79c524ea27bfe6553585d76359489c7a0883d0c59cc9b268af8b7a05c560ea5b10cce5967a058760852c3c153d4807ba3063ad61f9579ff7242127bf3a87c3c35f08865de26079c347c6fdb4596fa4a224a7fd5665599eeb4530a3d2651fb611f510a492459bc1f52223154403e3d0bbd3c0662e2245fa8a72543469f163f278aacb84a0df4bfb14f35b1be5c5173fb4d392e6de97da1b6f86f2ebf9d165be5b52a08067b306ef60bf7d669334ee1a99c7390f1e06125902c7a03d288c6f65123e5903fed8d99be93f0c9c50b70f7180cf182dda673a2f032f45d9a577fbd5083863d4a5c7ac5e3ca9ee53ed293ebbdd877853aabbc5605456851eb85153169c8ee37d47187e0baf21dc8428b200ddd0359583129b2504c414be134c417ee6a3906f47483f6e9a1a635b285c5b00f2d816ed1767cf48fdea8cded716787f1a529db8d93d96b4ba7b00fd2fa5ae5b52a3806ef6c8bfeaa45c5775cd34fc091eea443f04e38ccdf0945d0f63ff163c79042b20b8ed49c72f64668064c80baf708a866ac824368b1f97c2144f3f72227613a7e58f9e47fde4d1d78999c399fd6bff4abd56e132cf33639e0d441db5a4d15b82d476f3c08e7f02228e76c8572ee36a822f6429f5409b7f4e370493c02557831d5b74235efb5bb820ba15ab0e7aee05de6fa761359d02ef409d9802bc93dd190aec24f69ba2f7ecad64dfd71added6326f9303ce79ce96d6999ddf5913bce3235d44099c666d862a702bba679dc20bafff0bb32aae2280f8957f83b17b3e875b7225d4b3f341eb48418b24b30b313538eef7cb4b7ba7d7256bc5b7b29d58fd7a67abbc5605e5ac4dad13f0aa1b7d0abfab5ede0c8780cdf0587716330e7c8b71bb3f83077fe7d3fbbe07e95bf011066cff141ac37e28fdf3a0e2cdcedad4225940c11dcdac8d7aff05d16c7fdc2856b16284555eab82dc7f636bf9c8fd5f816c5a2e5c971fc4f345b5e8b9e10234ab6ba05f7b0e2e66fa3534ae7f0f7a7ac52a025e8582d628666e6c96694f22f1cf1b269ab185d9cdc837b1cc6b55b09f96db5ac9f6d372e842afa0cfdab3705f53035d66355ce9c7c9c512fd2abb645543468f90bd5f0eeca7e73621a69a68f25ad8f8ae81dd9475a0bdf9e84535768f655eab42d7a9eb5aeb88dde43590d217549f56052dfd9fa36b49ea29d8d3e3c3d7d05a131efaf117b24d817b451761dcfa9308d87511f34baffcd13fbeccad475411eb155d6c6299d7aa60f3d26a66ebbb8ad93c009ae760ebbbfa9a8d4f36c4f45671487a1b8a84e32d380179dc3188fc36c0f6c595b07d69353a4dcca4bbbc1623320f23e2d0975871fe16323eb88df4f71b9076a1be968808bbc732af55413c3e85895ecc66a2173299c827eb7ea6138826654214b61722e35b102dab6c5e2c858f2c83690de93c2e15ae2105082bffdc143af5bd5b487af7e7c64a086bcc32af5541db2f8449a809f1c40c92d6b249e9afd3886e14e6b188323cbae4101e8daa685647c311d804e443fc7c2a6cc626e369fac58d7be79ae96e533821d348eb1a70e913c83403c3986c5c12934c48353523443a3e452719bfe296f4b9247a0472d031e2203a869737eb918837d129b818b427ba8e8e877b609e297cea857aa1e0483c5bf76dd2d99fbbd1dfad6b40ef398fb9780631edc050a618b39cc9c62692042bd2e712b37978fa1ba259afe1f1d0327409d927a0145d42cbf14410fd9f333103923171908f4f4658e9a774e76f0b86374b204dc2739679ad0abc017ddff9641ed30c5ec41ca809ce71b4f17fc618758a67e3eb1cc61821a7505d03f7a26b10e1a3991d1ddb05bd6122f62f80625c0a681f8887c76074c2eb48fff017a1d0f7d41231697b03ba7ec14cd73f8469864430b5770c538d5cca54e651392ab69046388e5e8e6ed3b7c16e7609ec5e2e22c584ff5d82ae01bb21f1cb87e2f90c28472e23349f4635351171e0337a749a7dee391f62159eb3cc6b5568dac00213e7a1914c3d3c9aa94710efe8996a6f031c471921f2dd88ced377e171bf1d78e2efdb603b7933babdb801d20959701c130ff50803d4c39780cfa79b00c590c5e837670352cedf4472cd0da1e05c2a110ccf59e6b52a5835302094e9062d645afa24345e519ecec396d4110ac7ef6a1c94de46a8bce9ce0e37c089ea1aafc52412ce5e51e0f31a73e8bf103e696548bff8ab50706e13e94004c3739679ad0a2d34f08c6668e4d7049cd624a291bbf596a807862370dbbb48a3773e85f9532249a8be9e9e54231cba31cbbc5685661a784e3738fc2a415b69072d846e483816975fc18aa6afce2fe8953925eef48fecaf68404e0dac247f10fc3f347d43f0d48828c4547e450d98bec03f259cb9be2aa1fa9a32e96c1d7b980dc8a8016f7dbff939fa7ec1ff26682b2d8556f7590067cf1068fb04a2e7b331883d7ef51249a42fb18e1a60d4007bd80df426abc849bd67d097e426416b693de6f1f13f8346cefca3c7a039efd8bbcd4f711969f432bc7dbdf3a2d24f58f2b91becaf6ae0ae3e415c17bd47a04aef317710f125f349bc8bc7dcd52ecfccd94a769142b31d545f4f5638f69c17dc7b70806f556ef763df156aaa6ad6771f16e73f9a4507f8b1dcf2232cb2f49fccf83e586ccdaf2cbefafa5fda00a306c8dc262824a3c0ac23631dc823661dc9a3e431d289fb65bbaab82e4ffbf1b55ccdbada54f5c0fc69123bf31c3ef7deba0eb1efdd6131676eb384f3f52ce15ccb2cf35a151ea401ba280fc9c348892351132dd11357f264b68ffdb8ef325d1bbecf74c5f71924d5153591da1cf31c3e97afe16bf91e7cafc732aabe62e9555fb38cd3cdb3cc6b55b85f0374217ed7ed893be94b069361c49b8c22a3c9983c1f87f4ca20e7e282a98ed934eea998edb4638c8bcd54f31c3e97afe16bf91e7c2fbe6787da384f56bbbc4fb32cf35a15ee875f848808bf8bddc933c4930c2083c81032d4cccbecde313fc7e7f0b97c0d5fcbf7e07bf13d3b085db32582c596d04538feecf2c7a80bb125fc111013099111b999c2ecde313fc7e7f0b97c0d5fcbf7e07bf13d05afd912c1624bf845ee837f422d115af327a16bb644b0d89e0816db13c1627b22586c4f048bed07d87f0104e0ad908e635aa40000000049454e44ae426082, 0x89504e470d0a1a0a0000000d4948445200000080000000800806000000c33e61cb000000206348524d00007a25000080830000f9ff000080e9000075300000ea6000003a980000176f925fc546000000097048597300000b0c00000b0c013f4022c80000360c49444154785eed9c777c5555f6f6f78c658ae3ccfc46c70ad23b0448efbd901ed23be924f4d03ba1f70e22080802765050b0d111011144a429bd05d2139a8a65bdebd9f79e9b9bb8839013e6fdcc903fbe9f7bb3ef29fbace7d96baf7deeb9114454cf038cb2b19e070765633d0f0ecac67a1e1c948df53c38281beb79705036d6f3e0a06cace7c141d958cf8383b2510fefbdb2f0bef0c1ea2562dec83ea2479083c8eb1e2d06c5f989614941fcda450c89f7170363f9efe41026580c88f115a3d2c2c590c440d93e22a5abc88df21683138344df48efa77b86b9fb65f83bf44df5b55d98e465b529deadd3ee18978ebb639c2d76c7ba5b7e1aeb6eb53cdecb6e70828f43504aa0c7b38c48eae22ab2a383455280a7c88a0c126961fe2227b6ab4809ed22ba85f889b48860317e487f3177d2383167e2d8fb862ae67a5036ea41255e5d70370618de2d8c0911fda37d1e199210d8ac5f84a773af10e798de61ae83bb07d82dccf0b3fd34c5b37351b27b474a74eb4809ae1d29cec5826219169fa29d2c28c2b18324dca13d85d9330e1d8ac39d3aaf8b72b349490ff37b2229c04b748f0aae37404da8c4ab0b6a34008b3f342100a3fe611ee53e3d831d6764fa5a1fc9f0b1bc95eedd99245e9d288de9e6d19192dd3b51120cc0247974a66e5e9d29c5c792b1a2642f2b8ae7cfa39c3b5257870e146ad79e42806d7b0ab66d47c1761d2e7675b61a961ed6e5898cf040d1232ebcde00d551895717a80c309c53fec0189fbff70e71ee95e5677d40131baf692c2cc07b360365fa5a5256176bea196c47fda39c68709c2b8d48f6a0d1a99e3426cdcbc4a8144f1a96e44efd635ca847a80325795b51b8a305055ab7930458b7a5409bf6a7a2bd9cba758f0913a99c09ea0d60864abcbac0dc0063b36364eaef17ee1e9ae56b7534c3bb1365184587d8398136d4b7ab030d60a187b0d0c359d051dd3ca4c06333bc695ca68f09fc2d4937be32e3b97d429601fc3d9c8d9213624f512e1da98b553ba62df959b6a12087ce6f2706783d97c226a83780119578758166004ef162747ac4df7302ed5762b443f80c163edbdf9a72239d58ec4aa1c7661ac41e6b26343ec3c84706e81bee483d82ed29d3df86d2fdac298d49ef6243dd83eca84f04678978371ad9cd531a6262775fb96fcfae8ea80bc8a7735bf2eddc86fcacda9d8df07472c9880cad3700508957177cb0fa65b16074aec8f2b37a3e27d06e77860fd27d67eaee674503a39c652ad744cfe3d7d1a95e3492851e9ae0c662bbd0c06867ead3d55e4e0329bc1fea005904325a1118c54560240a4059041a403d90caa6e8c7e718c3e79894ed2ba789245f6bf2b56c4bde9dda908745cb8ab82e9e4113860e14f3268f570a5757a862ae0765a31e54e2d505c800b387e6344df5687f0ce2833ea1f69cda3d4da91cc220e5f7e67664844c5f2bae012c4d35418a67274937cfce94ec8162b01325b875a2785e11c008bc14a4681881896433c00858090471111864d38e22d90c395c1720132023f40a77a22e5c17787684095afd9819dd350422c104c804f70355ccf5a06cd4c35b2fcda85b16cd106b97ce15f346f47e8647ef51089fc9f33c46b436e247f2fc9e1be148dd79746b626bc59f3969dc96ca9fdd8b01e46ac0be835c0d04b209500344b011901126b10906c5bb52a06d0772efd09a5cdb36bfc126705b387d8a982b4d50f7a862ae0765a31e56cf9d5877cc99205e5f30452c9938e42f3901b69fa5797594d53ce66f8cfabc742f99fe310d603ac068af2eba394a0330776b8060ce04810c8a40a4ff645f1b6942148930811b9bc0dda2d5d53e29894da68e1a2e260e1b5ce7a862ae0765a31e964f1b5567bc32638c58366584c88df45c92ee6921c5478a1fc7d539467dcf205b590066b0f0c80a2ad135d2997b3140040cc0e2ab0c10804cc0a9dfbb535beaead49146705f5058fa59b727e7762dc8c7dae2f3bc81b97f9a3a66a4983c72589da28ab91e948d7a5838ba5f9db168ec003122252421cdb3038bd89906f1da7c3c8b3f3cd14da67b880fe13554c26b68064861f1ef660af83d03f8b3017805405e3cff63f463f53190cde9c9a6706ad38242dd9d460ee9d95d0ccec912837232eb0c55ccf5a06cd4c3e2f183eb84a59386891903321a647a772ac63abf1f2fd990f651d567f9b1a82ce6dd8a0f2a0b411880c5af668058330320fd4738fe8e01587c180053018a407f9bf63213f4e065a273bb566c82e63f64c64676ce1b942b46e6f6ae335431d783b2510ff347f6d5cd8251fc3aa28fe817eeb63c8d537f8f405b39d70ee3918f69a0baf8776b00a47f7303244a0374ac34001777e60680f8e606c06ac03405981900f704dc2d5a53106f87e568b4872539b4e6a9c0a6d396c13db2fe30ac778e18da2bbb4e50c55c0fca463dcc1c94a59b394373c4d8ee31f63cefff02c131bf62cecfe2624f5b05dcab01b4f91f06d0d23f0ca0a5ff581efd30805600e20b21888f9b3ea1766606e0918ef48f1a0006f0c1bd00368017a77e572e0223dd3acb4ce0c5ed762d9b50cfe478ffc573668a05d326d709aa98eb41d9a88749bd9374922c26f44c14390176efa1eaef1fe94479bceece09e039bf96e2cbf99fc5bf5301683040e50ac064002dfd5737803103981b005301d27f66b003658538907debe6e46bdbf9b38139990f0f463dd0433faa98eb41d9a88739c37be9621ea7ff71397136e95e1d7fc6cd1cdc74c17d7da47095f84025ba39aaf47fc70210f3bfc20048ffe60690e9bf9a01e452b0635b2e08dd288033877deb66141be0ebd6273559f4ec96a01b55ccf5a06cd4c32c4edfb5653618d643f40d775b82b97f608c330d897755cef91ae642638a18dfcd530a6ede6e9efea5018ce9bfcafc7f2f05607503407cc6830de06ed1869c380b44b95b527698a3cc0281cef6afe466a689be69dd74a38ab91e948d7a5898d7bfd6bc346e90983128eb2916bc2cdbdf4acefbc8023519c05c6488de23d086364deb46ddf1a58ef1a610da2babffbb4dff1695f3bf7901c8a33fc02cfd6b05a01cfdf84ec06800d4022eed5b514fdc2ae6fd1cdbb42cca8c897c6a6076a6e8cf46d0832ae67a5036ea61529fe45a33b55faa1892181097ea6141fd231ce55d3edce1fb3df1412a8fec011cf0f3ef0ea13c5e93e3a91fcd00e6a31f06308c7e75faaf3effa300bcabf9df680037a3019005c25df85cbe3664dbb219c50775891b9493a514f55e50c55c0fca463d4ce99ba28354d13bc4f9d50caf4e3424ce85b271b3c77897ef4ee203083e25c3972ab68ea54f66a551929b4535f1ef34faef3dfdab0a408c7ecd002e0cdea707d9932b67033f3beb15980640bf8cd45aa38ab91e948d7a983120b3760ccc1293fba6fc39cbd7fa64cf201bf93047f5d1af125e23c1b503ad9d9040659bf3e8eaa6513431d587e25d3ad430f7df45f5ff3b06a85e006ae95f3300706cdb8ae2bcac29c8de829cdbb7399b1ad5f5afdde36344565c74ad51c55c0fca463d4ce6655c6dc0e81f99126699e6d9f1977ee10ed42bd8d634f7ab043707737c8ebf0d1d5dd39f0a3e1a4d451f8fa123fcbe3bb725ba5ab0010ca95f3380497ca47ff3d1cfa8aaff7b4bff950670c6c8e7fd50103ab469f973949f57db6ee1a122292cb8d6a862ae0765a31ec666c7d68af13d12f0646f3c9ef2c16d5f7c97af125b45028ff417fb8552298ffefc8d239951fc7e2ced7c315ba6fe78ce0e9577fe0c06d02a7f55f1573dfdc30001e606b0fcad01aa8f7ea04d03d16c00c7362d28ccd335242d2a5ca44484d51a55ccf5a06cd4435ef7985a312e275ef48df0188e3b7fdaba5f25767550fcf508e0d1ffda002ae4910ff1253c0d946e1947db1666533a9b29cab1bd22f5df69f4572dfee4ed5f3680a9faff9df4af1900c560985327febb1505ba380cce888d1430416d51c55c0fca463d0c4d0aae15c3ba8588ec408717b1ecc3bdffbb3500e6feb7c7f1dccf62e76f1afd1b4ab78ca743abfad39018370ab76b4bd14e1dee58f95719fd4cf59b3f9a01aaa77fc3f2afd200105f1a80eb00d400de308d8de5dcf8607f1117d8a5d6a862ae0765a31efa84bbd79a4c3f9b753080e19ebf5a707320feccec001ef97974e5431efd9b8ce0bd19c59bc7cbd737c62552ba9f0d85d8b4a570fb7652782df56b95bf36fa610039fa65faafb9f8ab5efd57378073bbd6e463d55ed6029e569d562604070898a0b6a862ae0765a31ede7871fa3df3e6a219e2f5055345df70f70f327db9f0bb8bf91fcbbc61b16e74e6dde154f8c95885f05c0f9871f5e3b154b66d229d5a379c568c88a59e218e2c360b6cd58682d910f8114895cabf86d10ff155377f9406686f30803b6f830ce06b67fd664e52bcc84e8cad35aa98eb41d9a887d11991b562547a84c80eb0db7037a33f99c5c74d9f136f0d318deeea82e77f3896ae7ca4318eae7c0cc653e1e68954be630a5dfa701ced7ab92fcded174e3d439d29caa51375b16c433e1d5b924fa7564c6bc363dfdc8651efcba2e309602f06a3de03a243649ee3b1dcb36bd5826c5a3627eb16cdc8a655f34a0330780fa378585abc13e9e725227d3d6b8d2ae67a5036ea2137caab56f48ff216d9fe766be4f7fd0ad13592dd2da857901d1d5add9f4ab64cf88df095828f37f0c90466225d059f4e3251b8793295ed9846e53ba7f3e793e8c85b2368e3ec1c7a71500c8dcf0ca4fed19e94e6ef4051ae9614e6d89182ec2ce44aa08b359e09e494ceaffeb65c28da77e22adf8632829c6840ac174ded194a43127db0ec331940d2ae257571b05d939b95aebcc173b7a862ae0765a31ec672455f1bc6e5c489de61ae53f11bbeeaa2e3eb5c1485b8db8747c1be5cd18f4ab7568a5f457416bc52ecc9749585beba798a91a906b64c3362785fb0751a156f9f41e5bb6651c567b3a96ce70c2ade368d2e7d34914eafcfa3e3ef8ca4c36f0ca3afd60ca603ab07d141e6d09a4174e48dc1f4dddae1746ec3282ae069a8840bce1b3b26d1c9b543c9d7ba83cc0c9a019cd8009e96168bbb7ab98930cfdaa38ab91e948d7a18911a5e2b3005f032303bd5b3a3141bdfe099f0c26d5c6e6723ec5ed2cb24be49f8df88ae896d10ba60cb747e9dce42cfb807a653e1b61954b46d3a9b613a95b0210c4ca192ad93a978cb242ada3c81eb8ff154c0f5c5958f2ab350c9e671d43bc283a783e6260338b46941fe8eb6e35223c344b7f0905aa38ab91e948d7a189d15532bf2b2e3c4c0387f77fc8217b76fcde9e6d1892b7e0bfa7876261772930cc2634ed7d23b84d744c7c866f10c22cea4826d6016156c9f6d648ea4b01a86766d1b06fb605f1c838f8563ca634b63f1b9704e3ef7958fb90fe80bf7493340f9f689722ab06cd6cc64007c2d1ceeed9ed02b2549a010ac2daa98eb41d9a887b13909b5625ccf24312a33faf1542fcbf3b86f8ffbf7da3dfc58a7f6f4da987883f8726ed746bc36da0da3bc527483e09ab0853be632f30cec9c5f33da3692b9867d718c6d464318cd20330ab28b3402f701468019391be5b311ca79b5b12a2f89acb82034a4ff56c800bf720168951ad995477268ad51c55c0fca463dcc189c537b86f4143921ae2b93dc3a48e141b4633b9a92e5cf297722157caa8d78a3f072fe360a6f26ba147ca799d8bb1650d1ae85063e7bf1ce18b7c33e86fd711c83210c868219aa67053323b04161d48fe665932daf0c9c7819e8d8b6258c70353d26e29f3dbb258a1e4909b54615733d281bf53067646ead999f37500c4b8de812e7dc4e7e7183ffde911bee4c67d68fa2a22d1c6053aac7dc0ee10da3bd50a66de32897a2698243d445465ea2a2dd60b181cf8dafd5df631b6c2bf779918d6030058ea9658902991dccb242958c30894ab94ed8b9a4af2c0221be439be6f83af8b5fedd3384845702b54515733d281bf5b07ce6845ab362f644b164ea9847d3fcecf7c7f39c1f69df8e16e486ff52b18b032c473de678f3115f6db49b46388ba789fdf91249f19e9799a5662cab46e567459fbf6cdccfdc147c4c3603ce61ca0cc669c26004ce08c61aa16cfb34dabdacbf4cfd30805dab6614e3ef1333b867b634c0001da862ae0765a31e964ccdab352f3330c2f08c98a068c7b6f20b9c21b11e3cc2a6325abac7a8e754af09bf6bbe61b49b46b926ba51f0bd2ceedee5cc2b06f6bd4225fb5628c16786edb03df63318c364081c5bcb0e30829c26cc33c24c392d94ed9a493b5eeecf855f0b793f80d3ff259efbff999d102bb2f03c800e5431d783b2510f5306e6e862eaa01e62f2806c91e26bb7268ae77ffcdf9e636bc750c94e43ca35ccf186116f12de38da8bab8bae89fdc54a23af32aba8647f0dc8cf01b6353785d110d20c4623c8ac609611ccb2c1b5dd7369c39c5ef2aea03d8ffe304fd749437ae588413dba8b813a51c55c0fca463dcc1e355037f3c60e1513fa653d1de36c7126c4ba35ad9dd69daeede1d1661af598e339d54304a46993f086916e127d3f8b29c55d4d255f8235cc6b5472a006f099dc86b7c53e2653f0b1cccd8073c9ac606e044336401f6fec5d488b472453a7a68d91feaf67c446361ad6b79718c453805e5431d783b2510f2f4d1953272c993e4e8cc84ab00ab1695d322e2390caf77090ab8f7a39b71b8597a3dd38ca219c51f05216b5f4c0eb060ebe61e4cd1a307eae6daf19c2dc0cd58c60c80830c1225336b8fec5221a911642168d5ea0107797317d3352450faefe7ba6e84715733d281bf5f0c6cb0bea84b796bd28de5cba50a407b9bb247874be746ae3542addc3813609cfa31e6919c2235d4be18da39c4773a5e06f52d9576f51e9576f53d921f08e91b5d5d0dadf366c8b7d3453f0b10c190266d0b28266846554c47dd1b241c9ee4594bf6d2e45b8d9f014d0f4787a6cd4e3fd32d3449ff4943a4115733d281bf5f03a8b5717bcc1e2c30869411e22c6d3b1f5a685030f5cff92836d36ea2b533d46bcd968378a5ef69599d85fafa3b2c3ef9af15e35cc3ec3b69a29aa980199c1dc08c6a9c12c1bdce03eee583192ac9a35becd459bd3b86183c5e881fdeb0c55ccf5a06cd4c3fbab97d40d6b5ee6d7c56252df64b16c627f71fc9325cd4bf72dbd59bc17e263d46b733c8f7ad388370a0fe1be36885e0e41bf798fcabf59cf6ca0f2231aef57c3d88e6d785bec6332038e25cd804cc2464046c0f420a7064c0b2b4dd9e0c6c1153430c19f423cdd7b2e9937572c993f572c9e37a7ce50c55c0fca463d947fb7ad6ef8d6f0fafdd95de2f685dde2d6d99d8203be0641ae32ea8da9be5278c3482fe7516d10dd28f0d10f988d54a1716c53558cedd8a6fc086f8b7d34336819c2dc08dad460960dae1d5c4587d64da56057c7697943068a6979a3c5e4d123ea1455ccf5a06cd4c38d53dbeb981de23abf5e3fbd53541cddd48153eef7da5c8f945cc62352ceed10e7308b2f47bb61845768a24b913fa48ae31f19f9982a4e54036ddae7d8d6680a691c69062d2b681901b582b14690c5e26aba71680d8dcd89991be8e62ef2860c12a33865d735aa98eb41d9a8876bdf7e7a1fd92c4abf7a6b81417cc5a8c788378ef6aaa243e44fe8da894f898fc36cae01fe8cb7c1b6264318cd50c508dad450251baca1e2036fac7f67c934f1dac2c962cbda57c4e6b5cbeb1c55ccf5a06cd4c38db39fdf3fceed11d74f6efb3707fcaa417cc3a82fc7a8ff8df046d135c1bfdbc26ca56b27b7111f83d95e8d6df233b90db635190266d08c60cc08726ae06c606e8203afdfe0e3b4f8b5e888a0a2c3e2e7ab5f3187ea1c55ccf5a06cd4c38d339fdd5fceeee6a96063a6accecd46bd615e378e7893f0e6a2b3c8a776303b0d9c06bb8c18db24bc0d6f6b32038ec1c732640518c13835986703ee0b9b62f48db37b7e6bda3a4615733d281bf5f0fd857ddc5104e23ec1590081600136c8428f0b368c4c293ecfe552788ce0935b2b45378acd066276139b88f9bc2a68977c66660aa3194c59818d80cca26503a30998bd374eef7a04e6e463dc17ae33b7cefd1718e0fce11de276fe2171f3c297e2e6c50375cf05bc1e44501ab300f972e49b46bd21d5cb142f8587909ae8107a0fdd38b797d95703fc19b6311a02fbca634823202318a60653364026f866c335deb6f3f7f947c4f7970fdf176e313f151c15f9c7f72863ae0765a31e56bdb24c949ffb4afc54784cc8a05cb94f5c3d0613f8724afea9527c1ef5a778d463f462b4cb916e14fdfc3eba79fe0bba79613ff3650dece7edbea86a061841660564046336d04cc0d301b72543a05b97bf16b72edd1f7ebc7258dcb8f09558b9f42565ccf5a06cd4c382f9f3c4fab75f133f141c13b70b8f4ba17eb88ff028cd95d5fd7795a3de30e20dc25711fde201e620ddbaf815ddbc5415d9c69fc96db0ed79de479a0146d03282211be05c3827bf9ffafd956fd406ad036e313f5c3d2a7e2a3a2e36bcbd5a4c99344519733d281bf5b078d18b62febc7962cba677c5cfc527c5afa5a704959e1654715650d919f14bc92971bbe83bf163c109be389de018578ee21ec13cc3c8378a6f1af12ce24508cfa243e4cb8798af99c3742bbf1a68939ff13630853483c108868c60cc06d204b2b678e38782e37ffcb1f88cf8b1f8944e4e8b9f4a383665e7045dbb20e8c625f9fa6bf979f9baf3930d62eae42962f68c19ca98eb41d9a80718002c60136cfd70bdf8f6abdd62ff8e8fc4a7ebdf1007777d24ce7ef3b9b876f9b8e1e26e5c163f975d103f969c17b74b6b0bef5f74fa211ead2baa8e7a73e135d1bf211e55f4fd95a3ccb16a1c959fc96db0ed25de4733028e758eb381561f9cdbbb91457bec76f96571bbfc52adf989a19bf92cf22571e3ea49917ff2a0f866df56b16fdb07e2f0deade2c28983e2b32d9bc4f4a953c5ace9d3ffbb0c0016ce9f2f5e5ab4480c1f3a440475e92262222344b7c404d1b747b618357480f8e0ed95a2e4dbcfc42f17f7885b58e29dde556bae1dfff8612ed4769804bb04f131e2594c4df4ab2c74c171e604f32dfd6004ef0d6dfc19b681194c46385469029e1ef81c672a8ebcfff7ebdf6d15bc42c07d895a71fbdc4e71f3cc2eb1e7d37562eaf831a25faf1cd1b37b96888f89168e763622393e4ecc9e39534c9f02f16748f1ffeb0c0096bdbc44e48d1a2922c34245527c2c132712626244a09f9f080af0177dbba788f50b078bc21d73c5f53df345d18e39a270fbbd53c4146c9e3a878dc082b38018f52ca2417883e852f0c293068a4e5545b67f6734049b413382960df28fc87b037c8e6d85db66f23967d78ab25d73c48dcfe78a2f5f1b2146f44a125d43824564d7301117152932525358f878e1e1e224d2bb258bf973e69884ff9f31407242bce8c644848688e888ae2225898310162e06e6248bcd2bf244f1aef9a262378c30970376f714ed9827ae7c387644fe07238947a851448ce8e395c243e8e2d3cc19fab1e46c157e2806674c66905941ee8facf12dc15857f0c38f4da33695ec5d264af62ebf27cabe582e6e7db5429cdcbc582c9a364a24c4c688a88828111b152112e36244525cacc84a4f93b179a00c9091d24dc4454789b0d03011111e29c60dcc127b560e12a59f8e15259f8e6351f3ee9e4da37be4bf3f8cf2370ca5d2fdab0da35e135513bdf4bc910bf4639919b2ed9cd10cbc4fa1d12c9c1570a72ffffde1f2b8f91f0c7ffff2fa41e26ec9674a3e1c262eae1f2a564dea2e92a2bb8ab09030163e5224c6c6d61b4033407444384f0dd122212e8103122b668dee23be5e375154ec9a294a77cc10055ba6fd0ed3c5d58fc665b0402cd248baccaf7844eb2617853f965d342045e7d7f24b74bb3c9f6e5730782dbf2cdb2ab7019778de3f209ff4b9fcc1083e26184e57368dd954b4eb45f17b147ff6a2b8b677b1a860362f1b2972bb278b70367844589888e7eb05f5065018202d3949062639a91ba7c9683173689af8faf521a262db4451f4e978f5c8d7d834ba97fcd730f207a386dfedc9e7f4bf5e27d3f8edeb05f4d3f542ba7dad80b94a3ff12bc07bb4699ffd507452dee6c5b3fe865f1cf3b1f0b32f3e361b6057e1b659e24e94ee9a2bae7d3e4f7cf1c638313d6fb048884f6463c7cb022f3abc6bbd017ecf00321869a922363a5284048772a0a2c4ab73478b539b17899b87df1225fb57fd86d22fd720138c6223187e4482df11c81f86ce96bf25c0f3fc1015051d46fccf374be9e75be506f83db2018a46dce7c7a35da67db7cd32fce0838f0933e46f1c79aa68d7c2478af6bc2c78bb2a1473dbf5832bc5771fcf130b26f4176141012c7e82484d4a1429bcfaa937c03d1a203e264ac4707b7478b8484a4814d9e92962f7f68fc5ad6b25a2ac285f945cbd284a0a8c14e63f7cf5f8aeedf88956c1e629f2871a853b8cbf16c283a4f259fe45525c3cc0812f910c5ff96e96f7f4f1748f7cd41bdb68cffde3974078e61fcffbe3e75f6c80ab5fbcfe5371fe19b7523e67e9d5f39212e65a49beb85551283efd60ade891992e9292924548608048e7ebab37804e03c4464688ee1c1c6c979692225e7fed35515458246eddfa5e54545c13d7ae5f17c52525be578b4aa9f0fc312afc7ca9fcbd2046bdfcb188e90152e33384003f10914ff71a31b5e3193fe3839ed2108b0dbf47608a8e6fa7e292522a292d5b7ee3e62d016e721f6efffcb3b878e9b258b278312fe7a2456a72b214332c28b0de00756900dc1c49e3c060fbe143068b9d3b76886f4f1c1787bf3e242e5fbab8aab0b0808a4acaa8b8e032157fb389055c4cbc0493cfecc92786f1e40e1edec0b3047890c38c52f98897f1e91eed814f1801bf38daff1a155d3846c565156c8062e2f35c3e75eae45fcf9c3e254e9dfc4eac59f5aae899dd5d0a9cc8cbbb4c5ecfd71be03e1900374b6002dc3019989b2b56bffaaa189f9797cc42fc525c5c4c4545852c52091597b211ce7ec582e229de352c329e1bc453c2e64f08bf6ffc4edff0f0273ed39ef2910f9be261cfe35ba9b8f02a1faf9c8a8b8ba8c460009a3461fcf4450b1688bcd1a34428cff5b826888dbed71be03f6000fc9d9d9121ba67a4bb32d7ce9f3b2bc581482620dad58b54faed3616178f8e6da8fae4907ceecfecd9bfa39b0c8680098e6ca4928bc738ddf3316028e331710e30b07f2e65676624436088897ed71b80f94f182023b51b6f97fc2807b47fd790a0eb6c00ba70fedc6f0d0058bc129eb74b2f9da08a6fb7ca3b7ae68f8a191efd323eec617c3ab8ecec7e2a292e90e297705601daf134030c1e3480ba8604df8e0aef3a96fbf737085d6f00e67e1a00fb65723b6fe712e8e7bb273c3484783f4a4f49a67367cf506969e54835092681686552d48a8b870d5f1b6b5f1d03bcc7f7fce7f65359c14514790c8c6310bfba0130cd0ce8d79722c242292a3c8cb82f87e2a2227d20364c5a6f803a3600be28c9c9ccc06b93f0e0a0f97e5e9e3f07fb77a1d8a84816a02b25c6c5d2f1e3c7a8bc9ce77da35026c18c021a4cc0a2969652398b8cfb01bf5efe827ebe846706bea28aab67a9149982c52f955903db57eeab1d0f26bb72259fb8e8630384c83eb0d0c47da2d000ffc5dcc7e6596969989aea0da0db00b1d12c7a8488ea1af604ef3f8a835cecebe94e5dbc3d29b26b28c544864b036024eeddbb87ae5de32add4c7c5029be818ab252ba555146f90545b4fbd8493af8dd7774a3ac84bebf564ee56506f15506d04c50c6fb9fe56c93929428cf8b0cc4a292bf8f37f97a7ab0113ccaf8daf25293139fec1a1c24a7ac7a03dca301904691f239384ff048efcb413debe3e12603ece3e14e18fd9c19a4f8087e48803f6d58ff1eddb871bd460340b86b2cfc854b97e9836f8b29f09d7324261ea647a67d43a1ef9ca10d47ae5049c115dea65c6e5b930160b2035fee670386111b539e1f7d09e52c80be697df4f3f4381fe8e7d39f8df224ae0926a837c0ef18006b689ecf119c86a181012359f80bdeeeae32a01a0830522f82af11d8c5975e7a7121ddbc794369808af272ba7ae50a1ddcb38bfce77e42cfce394ae99b8b2960dd25fad3842f490cd94d7f9a78907abeba830eedfb9c0a0bb8566023a80c8073bcbb6e2d0575f1abd20718c28f33138c6ae8ab1b79bbbb21235ce26b19c3d359237c058c29adde00660640c184910f03b0b08ec1fe7e4b3970a55eae2e1c40d72a78b9b998028ff4ab11e4ef4779a347fe660a8080a80b8e1d3d4a6bdf7987d6bdf91ab9cedf4da2cf66faeb881d14fce619eab9bd84ac161f2591bb955a8dfb84d6bebe86055e47df7ecbab0636819c0e8ce26b06983b7b160abf2a7d80019089d04755bff9b52cc0d7e795ae41812e715151f29a93e2e21e5c03e06f9ec37143e7190e5c1a8f9a9d9eae2ebf7ab83813c4f772e3c0b99a8320baf1d22b88031e426c20133cc2e44ae0e2c50b54cae95b131f05dbde3d7b68d5abafd207efbf4f97ce9da6255f9792eb8aefe88f7d3692c87a8f9a4ffe9cba7f729522d75fa2dcf527e8f2d953723ac13e5feedf6faa0bcc8f3930b7af9c86ccfba0e1cba39fafa35adf0dfdf7e46bc3677cad9ff3fe59bcba790e056e5242dc8363003c138882880360c945dd720e48a1bbb313417819a01af0e06d780449f1c34382293cb4125e8f53704017fa6cd74eba76fd9a2175335bb76ea135ab57d3175feca3e2a222fae5d6351afcf641f25a7a448ade64ec3612896be88f996f53c7e97be9dd230574fb66855ce6edd9f339ad5eb58a76eed82145c7f190118e1ef94666a0b0e0c02a7d00e85b104f47e8abea1a3470adb8667e5fcc3178958d638bba279b570effd306c0c571eafb97bf8fd75c7727c7ef190e84a30cd89d3018c4498e7488cdd57555382b60fe5df9ca72ba75eba6146cc7f6edf4eebbebe8f4e953721ac028be55514a5b0f9da68733dea4d6137751cfad4514b0ec30fd29fd0dfa63fa9bb4e7f879ba790d4bc11259379ce415c2bab56be9b3cf76c9c2f0261f7bfd7bef52171f2f794e153086a7ab4160d5b598836ddc38066e4e0eb7bb787b2d4a498c7f0a05e3ffa4016278bee735bc035fdc0917073b5cf45de3ea682f8b2a888d00abf0f7f5a641fd73651d8011bf7ddb3679cf1ec299e66f5eeeed3e79851e9efc15b57be938f5da564ca1ebf3e9cffcf71f271da483e70ae492502bfa609cab57afd0962d9be9e08103f4fdf7b768c2b8b1bc0cf552f601c0045cf8c93eabaea5265c1dec31184ef140716703fdef1860f9d297c584b179828316e2ea605701f1119c7b01fba0f88301900554684bc32ff6eda5239ca6318a81263ef8bebc98961dc8a7a88d85bc0a28a2168b8e9318b5971e1aff2539bd7e9eb69c2a619354adfab5f47ff8ebafe9c4f163d42d2941a6f9d0203eaf02f43184a723d575fc1e32360ef6379dec6c2233d352c482b973fffb0cc0cbb12a2c5db21877c57c1c6cac6e39dbdbca8bbc57b09fbdb5a50cac0c70a0bf122cbf5e59be4c4e03e6c26bdc6071e7ec2fa2ce4bbf23317a0f2fff7651a3b9872993cd10b0f6220dd874927eac50dc4e6603e098eff1f20f538deadc200c06651338da5a91b35dedae1570ac7e4c88890a9c377b9698396d5a155431d783b2510fd3a64c924c9d3c49cc9c315de4f6e9d5c2c1dab2885d2d85ac1d76d4be750b6ad3bc899c5f4339d522d0083a8a3f0ddc23c03480512bbf163613b1aca4882e5d2da446d3bf20d16f0b3d366e0f05bd739e7af03460b9e41889fedbc8f9a50374930d80ef0fccf705b8c93476cc68f2e6a9c8fc9ce803fa82f48fcfdab56c466d19f575dc1d8895a3ad7569ef1ed96d66cf9ccef19c2ca61b51c55c0fca463d8c1e315c82797fd8e0418ff09cbf1da3d7c9d61a17552bb02f02d3b15d6b6adaf0396906cc9b017e3ef22610ee038040fe1b82205d63ee37370184dd7ce43cfd61e836b25f7a9cfaec28a5f0b5e7e8f131bb48f4f9989e9eb48f7a7c7a85ae14f1528fcd622e3e6a8153a74eca2f7e02b8d6d0ce87a9007d40216bd1a695ec1b5e31faf55e2f62c6b1db3d65e28447e7ce9ac9e91f3f0d9bae8cb91e948d7ac8eddd5b3230b79fe81a1c9863d3b923a7346ba435dd6064d85975a676ad5ac860b76ed6843c5c9d4c62004f3717e2da83aef372503e21c4262862116ff1fcffe6d7f994f86101256fbc4c4da6ed23d16b2389019f90fb8a1394c32b02bb458769e7f10b7483b73537006efebcbe66b5bca1230d67341dfe6edba2a9ec0b463efa2647afbc5e7de018d69d2c706fa1f784b163e58002aa98eb41d9a80776ac4c5543070f7c9203721141819beb0a076b3603838c802f86200846be06daba25c6d3e54b97a4f8b8ad5bc446a8282da2bced97a8f5cc2f59f80f4864afa7a653f650da47572861c3457a62d43612e9efd2aa3da7e8876b55eb001c272b234dde88c23964e661600454fc2e3c4569fd52f5b9b620766cfccb3cadfd1b26183766b432e67a5036eaa147f74cd12b275b7080865a77ec202fc2ceb253dd603c16d2a43fafc5213e5272755027ac7f779dbc7183655c4951015dc8bf424f0ffb9044b7b7e85fc33653f8db67a837cfff56f3d81059ebd810ef91dde223b4f2eb22bace6691e661e36059f9e9271fcb5bbaf8c6affab9a421f81569dbbc8f75021fcb8a63c8c5efb0a183068841fdfb2963ae0765a31ef0bd7d5a72d2e37c016791fe6def03b82780a0c3042a3cd800fdfaf49222c200d74a0ae9bd7ddfd263b91bc97bf951297cd0ea13f4b77e9c09925ea3a7877f42899c05c2de3a43def33ea3624c1d4c01670fd41243070d24771727e5b900fae2c39947d557bd2086f6569dcfa6a7243fde232b5319733d281bf5d02ba7bbe81a1418d2b9433bb2e139ac2e4146c11cebefeb259f09e8e2a306691953c1e7bb3f33dcd029cca7570f5ce6e55e31c5bc7d9a9e1ec29920fe55fa43fa5be4fad221eabba3849c16702648584d4ff75f4fe72f5f910f82623581af7e71e7cf978f59f53cdc070dee0b6e44615a421f557dd743e7f66d29322c247840bf3eca98eb41d9a807dccfe614bc0c9d4630ea1aa46229b2b7c71d71e55502af460cdfe615e453ee7bc7e9f9611fb3f02b4924aea296e3b652faa6cb94f8de397a6a206782e857e8e9811b29febdf3f4e5e97cf96c00be08c29d3fdca4f9ed39d0070d98c34bd608aa3eeb05b1f4767359daa7670f65ccf5a06cd4436a52c29fad3b753869c919c0caa26e41567175b297c1c608c7a8ac096f0f360a8b73e08bbd74f27c3e3dd6fd0d12312be8f9a11f52ecda33d4734b21759ebe5b9a4124ad22db39fba817af045a4fd849e3ded9473f5c2fa58307be94e91da6c33d862a989f8ffb823e61697a3fae1bc7e44cf01d4fad7f56c55c0fca463d44760db1edd8b6f5af10ab7387b6754a271e09ad9a36e675b7831c793e9e6e46dc9520254fca1b411f1f3c43cf0dfd88a239fdf7dd5e4c1e2f7d458f66bcc9a37e393d35e07d4ade708152debf484fe66e20d17519755fb9976edf28a7b16346c9290702573fb634a0f1fce88b878b23b56ad658f651d5777db423c434322cd44e15733d281bf5e0e1ec98829b219ddab5a973900adbb76a412d9bbc206fbef87ab9cb916ec0ed37e09e40a8af07cdfaf020f5d85141feaf1ca1c77bbd2b857f38fd0d725b7490fa7041885791bc5a6603c7850769cade623ac8733f6a0d4f3767e5b1b5f3a20fe84bcb268db86fcd651f557dd70b62ca99284d15733d281bf5c0f3e538dca963c7de17108cb62d9a51f3c60de57d738c442f773c2cf2db2771244eb6e494984b7fed8d797e390bbd8a2ca6eca21e9b0b287edd597ab2df7a4e5bcbe89fbddfa5c4f5e729f2add3d4886b851efd06939b838dfa98c673e1dcae8e76d482fb821b42e89baacf754187d62d7173689a2ae67a5036eac1d6b2e32a8c5238f67ed0a14d4b199036cd9b52b3179e277cf1826521eeca61b456c7dbcd895c9c9ce86f492f528b713b2995537df62757a9c3a41d5c10aee0ca7f2559722dd06b4b11b9bdc8998097857f8a9b4f2e2e782ac9898f81e39ae32ccf8573e2dce803bea3902271df547dae0b60002e08d7ab62ae0765a31eac3ab6dfd48e5321b2c0fd04c1d66ec362a98411891b402adced2d29246718e56c2b27db597be98f296be4a87faaff065e059ca70c5e0d3c3f7823b72da5a7877e4ade29b9e4e9606ddc9f4d500536159f8b0b5d6ac2e7461fd017551feb141e545c5fec53c55c0fca463dd85a767aa90d070526b8df2030980e9a3478567e51a4098ea787aac073b40f8bf7afc4b93c0daca4bf64be497ecbbe91f3bfd3fcfd721520629693cdbc8394b57a37f9b8e1492587df1c473344c7b6ade439716ef441d5b7ba06e7b2b468bf4515733d281bf5101d1ee6d9828b347c257adfe1a068af1004c673e36522c44261668ea7831575f08e22dbd95fc8278162de3a454ff4e18230e265fa5bf6db14c57fa77d78953c22ba919b9de56ff6c7974e38769b164d4ce257e9c37d0631e5eb4a52c55c0fcac69a784888df65f0805ce1606339038511e6e9fb4f13d37bccc7cd1b359473334c60fec8959ba33d7939d950c4acf7a8691ecfffd1cb48c4be42d6337653ef6d45e4b1f4183d1935815c6c3b939b73d5c7b9702cbe263e7603c39ccf46ab7eeefb471359643adbdbccee95d3fd0faa989ba3d2ed4e281b6b4275c2eaf4efd34b4486053fc429793e966b58b7e36bdbd6bc46bebff039385830004628d722e4ce6b738c5af9c81532036781f62e8124e25ea167067c40495cf5677e984f2f0cfd484e019ddd02781b6bb92df6c1be980aac2cdacb63e2d838c7fdbf1ec3f1b1b46cd5b4d135ae3706a524c6cb7f8aa18ab9392addee84b2b1265427ac061caaf1479bce16316c80d3089cf162fe03349623a6f1f3cf70e5dc422ed3b4e7ed8093657bf21eb2887a7f76839ce6eea33ff02a40c4bf468d238793875d27d376d204fc8ae20bc7c231716cf539eb0ec4a945e317a865e3176e5bb469b9cac9cec6a25a5c557137a1d2ed4e281b6b42714229b49187988799478c3ccafc890b97e7786938822fec045228d6eff202393b605ebb1fc863f339201cde237dc308ce0eb6e46cdb897c8242e9c99e6f92e8fa32fda3e7bbd465d15ef2eee2cf9f7566f16de5b6f6bc0ff635887f1ffbcbc7061824cd5e68c026687c8a8bbe599c756c113f631cb59822be88b316f3df1842a5db9d5036d684d98934e1d119740c1dfd33f357e631e671e6efcc3f987f32fff7ec53ff6ed8ae558b4c4e6d1ff2c55e6fca73292e589a822ffe7e81d48da5a2152fdb30b2717bd8d9b21d3dd7a52759cefa927aedba4ed143a79143c736f2336c63c9d307f693699f0dab3aae3e0cb584810630d7059eef5774eed02ea9e1b3cfbc807819e386f8218e8827e28af822ce8837e2ae99c16404956e7742d95813da49189c146e4447d03174129d7e92799a7996798e69c0346470514d98a64cb3a68d5e706bd1a4d100bef0779a356af01d0bf44b9306cf49a12a035319205d70b0b15e6ff4dcd372c9e6648767eeb8ca7773a5a89507a9f5a037c8c6d2929cedac64f1882557a3e79e31f64571bcbba6f21a702c807e303fb3014e732df141cba68d26376ffc42e413fffc4747c4c5181fc409f142dc103fc411f1445c115fc419f146dc117fe8003dfe2306d046beb9f8e8103af73c838ee3225a30ad98364c3ba63d83b9ac13d399b164ac18eb3f3ff2b043a306cf27b66cda782c8bf53a07ea1053caa3ef17a45f0386d168c010cc7b05fbbdf0ecd33295e3491b371b0b6ae89d4a8ddce3f97d47e2698a5371436ac4dba8f6af091c57eb1bfa69de5ffefc66d386cf9fe754bfadd90b0d97703619d9b8c1f3717f7df45167be761b5cbf310e8807e282f8204e8817e286f8218e8827e28af822ce8837e25edd047f50e97627948d358113184f84132215c189ff66e05474b025838e6b62e3c270a1768cbd1147c68941105c1857c6cd883be3f18fbf3d16fac273cfa6376dd47058d3860d5ee411f32e07720707f41b0eece526cf3f7b8347f4af18d5953cc3023f2505d05ecddf6b22697fe3660ee679d407788fb6064f3f69dab6fab11a3ef36fb373497e62a1cb1b3778f61cf7ed104f69dbd14f1efd4b5e78ee99d10d9e7d3afba927fe15c306f7c53519c1f569d78aebc6f5230e8807e2a2c508f142dc103fcd14882be28b3823de883be20f1dfee306c0fcf3170673d4530cd2153a06b7c2bd48697034dc8d620617e5c068e22b8537e269c48bf1ae86cf5f1e7d24f0fffefe78dc33ff7e22a77183e70633631b3dffec4c1edd8b399daee0d7b739b56e6cf8cc53db59bcdd5c737cc1e638cc021ee1bf8ff2eb3116f838679b132cfcb7bc5238f1fc534f1c69f8ec53875b356bbcbf518367773ffff4933bb818fba8e1b3ff5edbaa5993550d9e79eae5d6cd9bce6bd2e0f9292cee48febbdf334f3e91fe8fc71e8b7af4a18702b85f10d9c748f53ee33ab46bba93113413204e8817e286f8218e8827e28af822ce8837e28ef84307e8f1ff2503a038f917f30c834e61fe42ba6acdb465b4d4afa57d80b40777e302b5cc808b363748f50ca1a1054d338d395a706b4213e16e50ed6f4ef5739bf7cbbcbfe623dc5c604d645c3fe2a04d075a8c102f6d2a401c114fc415f1459c116fc41df1ff8f6680ea590027c73c848a552b00b5e20ff35523462bfe9a33486170312e08f31b2e0ea94dab133a30b87000d76b35838616208c0c5943540381548120df2baae380eae7d4fa622e9e06fa8febd0ae09d787ebd4ae19d78f38201e880be28338215e881be287386ac5a0560822de883be26f1afd8c52b73ba16cac099cc0887926c03a1569081dfa1b8379492efd18b8f40906f315c005c0bdda2a01050d2e0ec0d9b858cd388d19cd3c1aa89411200d8c0a731040cd642a10e8df43b51fd08e5dfd9ce6fdd12a790df41fd7a10909709dda35e3fab52a1f71417cb458216e881fe2887822ae882fe28c7823eea691cf486d54badd0965634d68273182936a4630bf09246f003170274067b5fb039a4990ba704100f39876bf40338eb97934e07c2d380073a00602a78140d60402fd7ba8f6d3303f8ff9f9cdfb857e9af75b1351131268d7acc500f1d0c4058817e2a6c510f1d46e0821cee6eb7f93f840a5db9d5036d684f9898c681dd040a7aaa3994333487534c36868176d0e82a1616e261508644d20d0bf876a3f0dd5f93434d13454d7617e9d9aa0d5d162a5895c9dea31afa2894ab73ba16cac89ea27bb0bcc3b69de690dd505025c7c4d6801aa095550eb0ad5f9cc51f55743759d401597eab1bb6b54badd0965634da84e789f300fc6ff0aaaebac7354badd0965633d0f0ecac67a1e1c948df53c38281beb79705036d6f3e0a06cace7c141d958cf830289ff07bccda3a8b4a46d8f0000000049454e44ae426082, 'ADmin', 'Admin', 'Upload', 'adMIN');

-- --------------------------------------------------------

--
-- Table structure for table `tabel_preferensi_brgmasuk`
--

DROP TABLE IF EXISTS `tabel_preferensi_brgmasuk`;
CREATE TABLE `tabel_preferensi_brgmasuk` (
  `no` tinyint(4) NOT NULL DEFAULT '1',
  `id_supplier` varchar(12) DEFAULT NULL,
  `autotipebarang` enum('Semua','Tertentu') DEFAULT 'Semua',
  `tertentu` text,
  `isihargaretail` enum('Manual','Auto') DEFAULT 'Manual',
  `autoretail` tinyint(4) DEFAULT '0',
  `kertaslabel` enum('A4','DoubleLine') DEFAULT 'A4'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_preferensi_brgmasuk`
--

INSERT INTO `tabel_preferensi_brgmasuk` (`no`, `id_supplier`, `autotipebarang`, `tertentu`, `isihargaretail`, `autoretail`, `kertaslabel`) VALUES
(1, 'S-000-000', 'Tertentu', 'Baru,', 'Auto', 13, 'DoubleLine');

-- --------------------------------------------------------

--
-- Table structure for table `tabel_preferensi_order`
--

DROP TABLE IF EXISTS `tabel_preferensi_order`;
CREATE TABLE `tabel_preferensi_order` (
  `no` tinyint(1) NOT NULL DEFAULT '1',
  `id_customer` varchar(12) DEFAULT NULL,
  `sales` varchar(30) DEFAULT NULL,
  `nota` enum('Big','Simple') DEFAULT 'Big'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_preferensi_order`
--

INSERT INTO `tabel_preferensi_order` (`no`, `id_customer`, `sales`, `nota`) VALUES
(1, 'C-000-000', '< Kasir >', 'Big');

-- --------------------------------------------------------

--
-- Table structure for table `tabel_preferensi_penjualan`
--

DROP TABLE IF EXISTS `tabel_preferensi_penjualan`;
CREATE TABLE `tabel_preferensi_penjualan` (
  `no` int(1) NOT NULL DEFAULT '1',
  `id_customer` varchar(12) DEFAULT NULL,
  `sales` varchar(30) DEFAULT NULL,
  `autoprint` enum('AutoSmall','AutoBig','Manual') DEFAULT 'Manual',
  `diskon1` tinyint(4) DEFAULT '10',
  `diskon2` tinyint(4) DEFAULT '20',
  `diskon3` tinyint(4) DEFAULT '30',
  `diskon4` tinyint(4) DEFAULT '40',
  `isautodiskon` tinyint(4) DEFAULT '0',
  `diskonauto` tinyint(4) DEFAULT '0',
  `headersmall` tinytext,
  `footersmall` tinytext
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_preferensi_penjualan`
--

INSERT INTO `tabel_preferensi_penjualan` (`no`, `id_customer`, `sales`, `autoprint`, `diskon1`, `diskon2`, `diskon3`, `diskon4`, `isautodiskon`, `diskonauto`, `headersmall`, `footersmall`) VALUES
(1, 'C-000-000', '< Kasir >', 'Manual', 15, 20, 25, 30, 1, 20, 'Test', 'Terima Kasih atas kunjungannya ya :)\r\nHEHEHEHE....');

-- --------------------------------------------------------

--
-- Table structure for table `tabel_sales`
--

DROP TABLE IF EXISTS `tabel_sales`;
CREATE TABLE `tabel_sales` (
  `nama` varchar(30) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `tgl_lahir` date NOT NULL,
  `no_hp` varchar(12) NOT NULL,
  `tgl_daftar` date NOT NULL,
  `terhapus` enum('Y','N') NOT NULL DEFAULT 'N'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_sales`
--

INSERT INTO `tabel_sales` (`nama`, `alamat`, `tgl_lahir`, `no_hp`, `tgl_daftar`, `terhapus`) VALUES
('< Kasir >', 'Kasir', '0001-01-01', '0', '0001-01-01', 'N');

-- --------------------------------------------------------

--
-- Table structure for table `tabel_set_authority`
--

DROP TABLE IF EXISTS `tabel_set_authority`;
CREATE TABLE `tabel_set_authority` (
  `tipe_authority` varchar(11) NOT NULL,
  `infoperusahaan` tinyint(1) NOT NULL DEFAULT '0',
  `tambahsales` tinyint(1) NOT NULL DEFAULT '0',
  `editsales` tinyint(1) NOT NULL DEFAULT '0',
  `tambahtipe` tinyint(1) NOT NULL DEFAULT '0',
  `edittipe` tinyint(1) NOT NULL DEFAULT '0',
  `settinglabel` tinyint(1) NOT NULL DEFAULT '0',
  `tema` tinyint(1) NOT NULL DEFAULT '0',
  `clientserver` tinyint(1) NOT NULL DEFAULT '0',
  `backupdb` tinyint(1) NOT NULL DEFAULT '0',
  `restoredb` tinyint(1) NOT NULL DEFAULT '0',
  `exportdb` tinyint(1) NOT NULL DEFAULT '0',
  `importdb` tinyint(1) NOT NULL DEFAULT '0',
  `logactivity` tinyint(1) NOT NULL DEFAULT '0',
  `tambahcustomer` tinyint(1) NOT NULL DEFAULT '0',
  `lihatdatacustomer` tinyint(1) NOT NULL DEFAULT '0',
  `editcustomer` tinyint(1) NOT NULL DEFAULT '0',
  `printcustomer` tinyint(1) NOT NULL DEFAULT '0',
  `tambahsupplier` tinyint(1) NOT NULL DEFAULT '0',
  `lihatlistdatasupplier` tinyint(1) NOT NULL DEFAULT '0',
  `editsupplier` tinyint(1) NOT NULL DEFAULT '0',
  `printsupplier` tinyint(1) NOT NULL DEFAULT '0',
  `lihatproduk` tinyint(1) NOT NULL DEFAULT '0',
  `editproduk` tinyint(1) NOT NULL DEFAULT '0',
  `printproduk` tinyint(1) NOT NULL DEFAULT '0',
  `lihatprofit` tinyint(1) NOT NULL DEFAULT '0',
  `lihattotalpersediaan` tinyint(1) NOT NULL DEFAULT '0',
  `cetaklabel` tinyint(1) NOT NULL DEFAULT '0',
  `editmodalterjualprofit` tinyint(1) NOT NULL DEFAULT '0',
  `penjualannormal` tinyint(1) NOT NULL DEFAULT '0',
  `penjualanfast` tinyint(1) NOT NULL DEFAULT '0',
  `penjualanorder` tinyint(1) NOT NULL DEFAULT '0',
  `barangmasuk` tinyint(1) NOT NULL DEFAULT '0',
  `tipegrosir` tinyint(1) NOT NULL DEFAULT '0',
  `tiperetail` tinyint(1) NOT NULL DEFAULT '0',
  `diskonpenjualan` tinyint(1) NOT NULL DEFAULT '0',
  `returpenjualan` tinyint(1) NOT NULL DEFAULT '0',
  `hutangcustomer` tinyint(1) NOT NULL DEFAULT '0',
  `juallebihstok` tinyint(1) NOT NULL DEFAULT '0',
  `laporanpenjualanharian` tinyint(1) NOT NULL DEFAULT '0',
  `laporandetailpenjualanharian` tinyint(1) NOT NULL DEFAULT '0',
  `laporanpenjualanall` tinyint(1) NOT NULL DEFAULT '0',
  `laporanpenjualanfilter` tinyint(1) NOT NULL DEFAULT '0',
  `laporanprofit` tinyint(1) NOT NULL DEFAULT '0',
  `laporanbrgmasukall` tinyint(1) NOT NULL DEFAULT '0',
  `laporanbrgmasukfilter` tinyint(1) NOT NULL DEFAULT '0',
  `laporanhutangcustomer` tinyint(1) NOT NULL DEFAULT '0',
  `laporanbestseller` tinyint(1) NOT NULL DEFAULT '0',
  `printlaporan` tinyint(1) NOT NULL DEFAULT '0',
  `seleksitanggallaporan` tinyint(1) NOT NULL DEFAULT '0',
  `tutupcounter` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_set_authority`
--

INSERT INTO `tabel_set_authority` (`tipe_authority`, `infoperusahaan`, `tambahsales`, `editsales`, `tambahtipe`, `edittipe`, `settinglabel`, `tema`, `clientserver`, `backupdb`, `restoredb`, `exportdb`, `importdb`, `logactivity`, `tambahcustomer`, `lihatdatacustomer`, `editcustomer`, `printcustomer`, `tambahsupplier`, `lihatlistdatasupplier`, `editsupplier`, `printsupplier`, `lihatproduk`, `editproduk`, `printproduk`, `lihatprofit`, `lihattotalpersediaan`, `cetaklabel`, `editmodalterjualprofit`, `penjualannormal`, `penjualanfast`, `penjualanorder`, `barangmasuk`, `tipegrosir`, `tiperetail`, `diskonpenjualan`, `returpenjualan`, `hutangcustomer`, `juallebihstok`, `laporanpenjualanharian`, `laporandetailpenjualanharian`, `laporanpenjualanall`, `laporanpenjualanfilter`, `laporanprofit`, `laporanbrgmasukall`, `laporanbrgmasukfilter`, `laporanhutangcustomer`, `laporanbestseller`, `printlaporan`, `seleksitanggallaporan`, `tutupcounter`) VALUES
('Cashier 1st', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1),
('Cashier 2nd', 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0),
('Cashier 3rd', 1, 1, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0),
('Manager', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1),
('Owner', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tabel_status_transaksi`
--

DROP TABLE IF EXISTS `tabel_status_transaksi`;
CREATE TABLE `tabel_status_transaksi` (
  `no` int(11) NOT NULL,
  `tanggal` date NOT NULL,
  `invoice` varchar(30) NOT NULL,
  `status` char(8) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_status_transaksi`
--

INSERT INTO `tabel_status_transaksi` (`no`, `tanggal`, `invoice`, `status`) VALUES
(1, '2017-02-14', 'Penjualan-SmallNota', 'Gagal'),
(2, '2017-02-14', 'Penjualan-Order', 'Gagal'),
(3, '2017-02-14', 'F-Penjualan (Small Nota) 1', 'Gagal'),
(4, '2017-02-14', 'F-Penjualan (Big Nota) 1', 'Gagal'),
(5, '2017-02-14', 'F-Penjualan (Order Barang) 1', 'Gagal'),
(6, '2017-02-14', 'F-Barang Masuk 1', 'Gagal'),
(7, '2017-02-14', 'Barang Masuk', 'Gagal'),
(8, '2017-02-14', 'Barang Masuk', 'Gagal'),
(9, '2017-02-14', 'F-Barang Masuk 1', 'Gagal'),
(10, '2017-02-14', 'Barang Masuk', 'Gagal'),
(11, '2017-02-15', 'F-Penjualan (Small Nota) 1', 'Gagal'),
(12, '2017-02-15', 'F-Penjualan (Big Nota) 1', 'Gagal'),
(13, '2017-02-15', 'F-Penjualan (Order Barang) 1', 'Gagal'),
(14, '2017-02-15', 'F-Barang Masuk 1', 'Gagal'),
(15, '2017-02-15', 'F-Penjualan (Small Nota) 1', 'Gagal'),
(16, '2017-02-15', 'F-Penjualan (Big Nota) 1', 'Gagal'),
(17, '2017-02-15', 'F-Penjualan (Order Barang) 1', 'Gagal'),
(18, '2017-02-15', 'F-Barang Masuk 1', 'Gagal');

-- --------------------------------------------------------

--
-- Table structure for table `tabel_supplier`
--

DROP TABLE IF EXISTS `tabel_supplier`;
CREATE TABLE `tabel_supplier` (
  `id_supplier` varchar(12) NOT NULL,
  `nama` varchar(25) DEFAULT NULL,
  `alamat` varchar(50) DEFAULT NULL,
  `asal` varchar(20) DEFAULT NULL,
  `telp` varchar(15) DEFAULT NULL,
  `catatan` varchar(200) DEFAULT NULL,
  `terdaftar_bln` date DEFAULT NULL,
  `terhapus` enum('Y','N') NOT NULL DEFAULT 'N'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_supplier`
--

INSERT INTO `tabel_supplier` (`id_supplier`, `nama`, `alamat`, `asal`, `telp`, `catatan`, `terdaftar_bln`, `terhapus`) VALUES
('S-000-000', '< Supplier >', 'Supplier', 'Supplier', '-', 'Data supplier bawaaan', '2017-02-14', 'N');

-- --------------------------------------------------------

--
-- Table structure for table `tabel_temp_checking`
--

DROP TABLE IF EXISTS `tabel_temp_checking`;
CREATE TABLE `tabel_temp_checking` (
  `no` int(11) NOT NULL,
  `invoice` varchar(20) NOT NULL,
  `kode_barang` varchar(20) NOT NULL,
  `nama_barang` varchar(30) NOT NULL,
  `qty` int(11) NOT NULL,
  `harga` double NOT NULL,
  `tipe` enum('G','R','O') NOT NULL,
  `sales` varchar(30) NOT NULL,
  `customer` varchar(30) NOT NULL,
  `tempat` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_temp_checking`
--

INSERT INTO `tabel_temp_checking` (`no`, `invoice`, `kode_barang`, `nama_barang`, `qty`, `harga`, `tipe`, `sales`, `customer`, `tempat`) VALUES
(1, 'test', 'test', 'test', 1, 1, 'G', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `tabel_temp_keluar`
--

DROP TABLE IF EXISTS `tabel_temp_keluar`;
CREATE TABLE `tabel_temp_keluar` (
  `invoice` varchar(15) NOT NULL,
  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_temp_keluar`
--

INSERT INTO `tabel_temp_keluar` (`invoice`, `time`) VALUES
('OB-170214-0001', '2017-02-13 17:35:59'),
('OB-170215-0001', '2017-02-15 15:47:04'),
('OB-170215-0002', '2017-02-15 15:53:25'),
('PN-170214-0001', '2017-02-13 17:35:18'),
('PN-170214-0002', '2017-02-13 17:35:48'),
('PN-170214-0003', '2017-02-13 17:35:54'),
('PN-170215-0001', '2017-02-15 15:46:51'),
('PN-170215-0002', '2017-02-15 15:46:58'),
('PN-170215-0003', '2017-02-15 15:53:06'),
('PN-170215-0004', '2017-02-15 15:53:21');

-- --------------------------------------------------------

--
-- Table structure for table `tabel_temp_masuk`
--

DROP TABLE IF EXISTS `tabel_temp_masuk`;
CREATE TABLE `tabel_temp_masuk` (
  `invoice` varchar(15) NOT NULL,
  `time` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_temp_masuk`
--

INSERT INTO `tabel_temp_masuk` (`invoice`, `time`) VALUES
('BM-170214-0001', '2017-02-13 17:36:18'),
('BM-170214-0002', '2017-02-13 17:37:26'),
('BM-170214-0003', '2017-02-13 21:49:52'),
('BM-170215-0001', '2017-02-15 15:47:09'),
('BM-170215-0002', '2017-02-15 15:53:29');

-- --------------------------------------------------------

--
-- Table structure for table `tabel_temp_retur`
--

DROP TABLE IF EXISTS `tabel_temp_retur`;
CREATE TABLE `tabel_temp_retur` (
  `no` int(11) NOT NULL,
  `invoice` varchar(20) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `id_barang` varchar(12) DEFAULT NULL,
  `nama_barang` varchar(30) DEFAULT NULL,
  `harga_deal` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1 COMMENT='Untuk menyimpan sementara nota retur';

-- --------------------------------------------------------

--
-- Table structure for table `tabel_tipe_barang`
--

DROP TABLE IF EXISTS `tabel_tipe_barang`;
CREATE TABLE `tabel_tipe_barang` (
  `kode_tipe` varchar(4) NOT NULL,
  `tipe` varchar(15) NOT NULL,
  `keterangan` varchar(100) NOT NULL,
  `terhapus` enum('Y','N') NOT NULL DEFAULT 'N'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_tipe_barang`
--

INSERT INTO `tabel_tipe_barang` (`kode_tipe`, `tipe`, `keterangan`, `terhapus`) VALUES
('DFT', 'Default', 'Default', 'N');

--
-- Triggers `tabel_tipe_barang`
--
DROP TRIGGER IF EXISTS `fix_kode_barang`;
DELIMITER $$
CREATE TRIGGER `fix_kode_barang` AFTER UPDATE ON `tabel_tipe_barang` FOR EACH ROW BEGIN
UPDATE tabel_barang, tabel_tipe_barang SET tabel_barang.kode_barang = 
REPLACE(tabel_barang.kode_barang, 
SUBSTRING_INDEX(tabel_barang.kode_barang,  '-', 1 ) ,  tabel_tipe_barang.kode_tipe)
WHERE tabel_barang.tipe_barang = tabel_tipe_barang.tipe;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Stand-in structure for view `tabel_trans_barang_masuk`
-- (See below for the actual view)
--
DROP VIEW IF EXISTS `tabel_trans_barang_masuk`;
CREATE TABLE `tabel_trans_barang_masuk` (
`invoice` varchar(15)
,`id_supplier` varchar(12)
,`nama` varchar(25)
,`tgl_update` timestamp
,`kode_barang` varchar(12)
,`nama_barang` varchar(30)
,`stok_masuk` int(11)
,`harga_modal` double
,`harga_grosir` double
,`harga_retail` double
);

-- --------------------------------------------------------

--
-- Table structure for table `tabel_user`
--

DROP TABLE IF EXISTS `tabel_user`;
CREATE TABLE `tabel_user` (
  `id` varchar(15) NOT NULL,
  `password` varchar(50) NOT NULL,
  `hak_user` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabel_user`
--

INSERT INTO `tabel_user` (`id`, `password`, `hak_user`) VALUES
('admin', '21232f297a57a5a743894a0e4a801fc3', 'Owner');

-- --------------------------------------------------------

--
-- Table structure for table `tabe_set_label`
--

DROP TABLE IF EXISTS `tabe_set_label`;
CREATE TABLE `tabe_set_label` (
  `no` tinyint(1) NOT NULL,
  `nama_perusahaan` varchar(30) NOT NULL,
  `logo_perusahaan` tinyint(1) NOT NULL DEFAULT '1',
  `nama_barang` tinyint(1) NOT NULL DEFAULT '1',
  `id_barang` tinyint(1) NOT NULL DEFAULT '1',
  `barcode` tinyint(1) NOT NULL DEFAULT '1',
  `harga_grosir` tinyint(1) NOT NULL DEFAULT '1',
  `harga_retail` tinyint(1) NOT NULL DEFAULT '1',
  `stat_nama_perusahaan` tinyint(1) NOT NULL DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tabe_set_label`
--

INSERT INTO `tabe_set_label` (`no`, `nama_perusahaan`, `logo_perusahaan`, `nama_barang`, `id_barang`, `barcode`, `harga_grosir`, `harga_retail`, `stat_nama_perusahaan`) VALUES
(1, 'PT MJ', 1, 1, 1, 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Structure for view `tabel_trans_barang_masuk`
--
DROP TABLE IF EXISTS `tabel_trans_barang_masuk`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `tabel_trans_barang_masuk`  AS  select `tabel_invoice_masuk`.`invoice` AS `invoice`,`tabel_invoice_masuk`.`id_supplier` AS `id_supplier`,`tabel_supplier`.`nama` AS `nama`,`tabel_invoice_masuk`.`tgl_update` AS `tgl_update`,`tabel_barang_masuk`.`kode_barang` AS `kode_barang`,`tabel_barang`.`nama_barang` AS `nama_barang`,`tabel_barang_masuk`.`stok_masuk` AS `stok_masuk`,`tabel_barang`.`harga_modal` AS `harga_modal`,`tabel_barang`.`harga_grosir` AS `harga_grosir`,`tabel_barang`.`harga_retail` AS `harga_retail` from (((`tabel_invoice_masuk` join `tabel_supplier`) join `tabel_barang_masuk`) join `tabel_barang`) where ((`tabel_invoice_masuk`.`id_supplier` = `tabel_supplier`.`id_supplier`) and (`tabel_invoice_masuk`.`invoice` = `tabel_barang_masuk`.`invoice`) and (`tabel_barang_masuk`.`kode_barang` = `tabel_barang`.`kode_barang`)) order by `tabel_invoice_masuk`.`invoice` ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tabel_barang`
--
ALTER TABLE `tabel_barang`
  ADD PRIMARY KEY (`kode_barang`),
  ADD KEY `tipe_barang` (`tipe_barang`);

--
-- Indexes for table `tabel_barang_keluar`
--
ALTER TABLE `tabel_barang_keluar`
  ADD PRIMARY KEY (`no`),
  ADD KEY `invoice` (`invoice`),
  ADD KEY `kode_barang` (`kode_barang`);

--
-- Indexes for table `tabel_barang_masuk`
--
ALTER TABLE `tabel_barang_masuk`
  ADD PRIMARY KEY (`no`),
  ADD KEY `kode_barang` (`kode_barang`),
  ADD KEY `invoice` (`invoice`);

--
-- Indexes for table `tabel_barang_retur`
--
ALTER TABLE `tabel_barang_retur`
  ADD PRIMARY KEY (`no`),
  ADD KEY `invoice` (`invoice`),
  ADD KEY `kode_barang` (`kode_barang`);

--
-- Indexes for table `tabel_customer`
--
ALTER TABLE `tabel_customer`
  ADD PRIMARY KEY (`id_customer`);

--
-- Indexes for table `tabel_enkripsi`
--
ALTER TABLE `tabel_enkripsi`
  ADD PRIMARY KEY (`enkripsi`);

--
-- Indexes for table `tabel_invoice_keluar`
--
ALTER TABLE `tabel_invoice_keluar`
  ADD PRIMARY KEY (`invoice`),
  ADD KEY `id_customer` (`id_customer`),
  ADD KEY `id_sales` (`nama_sales`);

--
-- Indexes for table `tabel_invoice_masuk`
--
ALTER TABLE `tabel_invoice_masuk`
  ADD PRIMARY KEY (`invoice`),
  ADD KEY `id_supplier_idx` (`id_supplier`),
  ADD KEY `invoice` (`invoice`);

--
-- Indexes for table `tabel_perusahaan`
--
ALTER TABLE `tabel_perusahaan`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `tabel_preferensi_brgmasuk`
--
ALTER TABLE `tabel_preferensi_brgmasuk`
  ADD PRIMARY KEY (`no`),
  ADD KEY `FK_tabel_preferensi_brgmasuk_tabel_supplier` (`id_supplier`);

--
-- Indexes for table `tabel_preferensi_order`
--
ALTER TABLE `tabel_preferensi_order`
  ADD PRIMARY KEY (`no`),
  ADD KEY `FK_tabel_preferensi_order_tabel_customer` (`id_customer`),
  ADD KEY `FK_tabel_preferensi_order_tabel_sales` (`sales`);

--
-- Indexes for table `tabel_preferensi_penjualan`
--
ALTER TABLE `tabel_preferensi_penjualan`
  ADD PRIMARY KEY (`no`),
  ADD KEY `FK_tabel_prefensi_penjualan_tabel_customer` (`id_customer`),
  ADD KEY `FK_tabel_prefensi_penjualan_tabel_sales` (`sales`);

--
-- Indexes for table `tabel_sales`
--
ALTER TABLE `tabel_sales`
  ADD PRIMARY KEY (`nama`);

--
-- Indexes for table `tabel_set_authority`
--
ALTER TABLE `tabel_set_authority`
  ADD PRIMARY KEY (`tipe_authority`);

--
-- Indexes for table `tabel_status_transaksi`
--
ALTER TABLE `tabel_status_transaksi`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `tabel_supplier`
--
ALTER TABLE `tabel_supplier`
  ADD PRIMARY KEY (`id_supplier`);

--
-- Indexes for table `tabel_temp_checking`
--
ALTER TABLE `tabel_temp_checking`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `tabel_temp_keluar`
--
ALTER TABLE `tabel_temp_keluar`
  ADD PRIMARY KEY (`invoice`);

--
-- Indexes for table `tabel_temp_masuk`
--
ALTER TABLE `tabel_temp_masuk`
  ADD PRIMARY KEY (`invoice`);

--
-- Indexes for table `tabel_temp_retur`
--
ALTER TABLE `tabel_temp_retur`
  ADD PRIMARY KEY (`no`);

--
-- Indexes for table `tabel_tipe_barang`
--
ALTER TABLE `tabel_tipe_barang`
  ADD PRIMARY KEY (`kode_tipe`),
  ADD KEY `tipe` (`tipe`);

--
-- Indexes for table `tabel_user`
--
ALTER TABLE `tabel_user`
  ADD PRIMARY KEY (`id`),
  ADD KEY `FK_tabel_user_tabel_set_authority` (`hak_user`);

--
-- Indexes for table `tabe_set_label`
--
ALTER TABLE `tabe_set_label`
  ADD PRIMARY KEY (`no`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tabel_barang_keluar`
--
ALTER TABLE `tabel_barang_keluar`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tabel_barang_masuk`
--
ALTER TABLE `tabel_barang_masuk`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tabel_barang_retur`
--
ALTER TABLE `tabel_barang_retur`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tabel_perusahaan`
--
ALTER TABLE `tabel_perusahaan`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tabel_status_transaksi`
--
ALTER TABLE `tabel_status_transaksi`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT for table `tabel_temp_checking`
--
ALTER TABLE `tabel_temp_checking`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tabel_temp_retur`
--
ALTER TABLE `tabel_temp_retur`
  MODIFY `no` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tabe_set_label`
--
ALTER TABLE `tabe_set_label`
  MODIFY `no` tinyint(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `tabel_barang`
--
ALTER TABLE `tabel_barang`
  ADD CONSTRAINT `tabel_barang_ibfk_4` FOREIGN KEY (`tipe_barang`) REFERENCES `tabel_tipe_barang` (`tipe`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tabel_barang_keluar`
--
ALTER TABLE `tabel_barang_keluar`
  ADD CONSTRAINT `tabel_barang_keluar_ibfk_3` FOREIGN KEY (`kode_barang`) REFERENCES `tabel_barang` (`kode_barang`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tabel_barang_keluar_ibfk_4` FOREIGN KEY (`invoice`) REFERENCES `tabel_invoice_keluar` (`invoice`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tabel_barang_masuk`
--
ALTER TABLE `tabel_barang_masuk`
  ADD CONSTRAINT `tabel_barang_masuk_ibfk_10` FOREIGN KEY (`invoice`) REFERENCES `tabel_invoice_masuk` (`invoice`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tabel_barang_masuk_ibfk_9` FOREIGN KEY (`kode_barang`) REFERENCES `tabel_barang` (`kode_barang`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tabel_barang_retur`
--
ALTER TABLE `tabel_barang_retur`
  ADD CONSTRAINT `tabel_barang_retur_ibfk_3` FOREIGN KEY (`kode_barang`) REFERENCES `tabel_barang` (`kode_barang`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tabel_barang_retur_ibfk_4` FOREIGN KEY (`invoice`) REFERENCES `tabel_invoice_keluar` (`invoice`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tabel_invoice_keluar`
--
ALTER TABLE `tabel_invoice_keluar`
  ADD CONSTRAINT `tabel_invoice_keluar_ibfk_4` FOREIGN KEY (`nama_sales`) REFERENCES `tabel_sales` (`nama`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `tabel_invoice_keluar_ibfk_5` FOREIGN KEY (`id_customer`) REFERENCES `tabel_customer` (`id_customer`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tabel_invoice_masuk`
--
ALTER TABLE `tabel_invoice_masuk`
  ADD CONSTRAINT `tabel_invoice_masuk_ibfk_3` FOREIGN KEY (`id_supplier`) REFERENCES `tabel_supplier` (`id_supplier`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `tabel_preferensi_brgmasuk`
--
ALTER TABLE `tabel_preferensi_brgmasuk`
  ADD CONSTRAINT `FK_tabel_preferensi_brgmasuk_tabel_supplier` FOREIGN KEY (`id_supplier`) REFERENCES `tabel_supplier` (`id_supplier`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tabel_preferensi_order`
--
ALTER TABLE `tabel_preferensi_order`
  ADD CONSTRAINT `FK_tabel_preferensi_order_tabel_customer` FOREIGN KEY (`id_customer`) REFERENCES `tabel_customer` (`id_customer`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_tabel_preferensi_order_tabel_sales` FOREIGN KEY (`sales`) REFERENCES `tabel_sales` (`nama`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tabel_preferensi_penjualan`
--
ALTER TABLE `tabel_preferensi_penjualan`
  ADD CONSTRAINT `FK_tabel_prefensi_penjualan_tabel_customer` FOREIGN KEY (`id_customer`) REFERENCES `tabel_customer` (`id_customer`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `FK_tabel_prefensi_penjualan_tabel_sales` FOREIGN KEY (`sales`) REFERENCES `tabel_sales` (`nama`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `tabel_user`
--
ALTER TABLE `tabel_user`
  ADD CONSTRAINT `FK_tabel_user_tabel_set_authority` FOREIGN KEY (`hak_user`) REFERENCES `tabel_set_authority` (`tipe_authority`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
