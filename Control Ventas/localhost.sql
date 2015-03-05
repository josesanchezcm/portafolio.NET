-- phpMyAdmin SQL Dump
-- version 3.4.5
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 15-07-2013 a las 18:35:35
-- Versión del servidor: 5.5.16
-- Versión de PHP: 5.3.8

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `zapateria`
--
CREATE DATABASE `zapateria` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `zapateria`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cliente`
--

CREATE TABLE IF NOT EXISTS `cliente` (
  `run` varchar(15) NOT NULL,
  `nombres` varchar(60) NOT NULL,
  `apellidos` varchar(60) NOT NULL,
  `fono` varchar(20) NOT NULL,
  `direccion` varchar(60) NOT NULL,
  `email` varchar(60) NOT NULL,
  `tipo` varchar(5) NOT NULL,
  PRIMARY KEY (`run`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`run`, `nombres`, `apellidos`, `fono`, `direccion`, `email`, `tipo`) VALUES
('17749290-6', 'Johani Alejandro', 'De la Hoz Gutiérrez', '74379731', 'Ejército Chileno #212', 'johani_alejandro@hotmail.com', '2'),
('17749349-k', 'Catalina Elisa', 'Morales Medina', '98765432', 'las violetas 0348', 'cata@gmail.com', '1');

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `datos_cliente`
--
CREATE TABLE IF NOT EXISTS `datos_cliente` (
`run` varchar(15)
,`nombres` varchar(60)
,`apellidos` varchar(60)
,`fono` varchar(20)
,`direccion` varchar(60)
,`email` varchar(60)
,`nombre_tipo` varchar(30)
);
-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `datos_todos`
--
CREATE TABLE IF NOT EXISTS `datos_todos` (
`run` varchar(15)
,`nombres` varchar(60)
,`apellidos` varchar(60)
,`fono` varchar(20)
,`direccion` varchar(60)
,`email` varchar(60)
,`nombre_tipo` varchar(30)
,`descuento` int(11)
);
-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `datos_venta`
--
CREATE TABLE IF NOT EXISTS `datos_venta` (
`run` varchar(15)
,`nombres` varchar(60)
,`apellidos` varchar(60)
,`id_venta` int(11)
,`subtotal_compra` int(11)
,`iva` int(11)
,`neto_compra` int(11)
,`articulos_vendidos` int(11)
,`total_recaudado` int(11)
,`dia` varchar(5)
,`mes` varchar(5)
,`año` varchar(5)
);
-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `datos_zapato`
--
CREATE TABLE IF NOT EXISTS `datos_zapato` (
`codigo` int(11)
,`marca` varchar(30)
,`numero` int(11)
,`precio` int(11)
,`nombre_tipo` varchar(20)
,`stock` int(11)
,`tipo` int(11)
);
-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `reportes_venta`
--
CREATE TABLE IF NOT EXISTS `reportes_venta` (
`run` varchar(15)
,`nombres` varchar(60)
,`apellidos` varchar(60)
,`id_venta` int(11)
,`sum(subtotal_compra)` decimal(32,0)
,`iva` int(11)
,`sum(neto_compra)` decimal(32,0)
,`sum(articulos_vendidos)` decimal(32,0)
,`sum(total_recaudado)` decimal(32,0)
);
-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_cliente`
--

CREATE TABLE IF NOT EXISTS `tipo_cliente` (
  `id_tipo` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_tipo` varchar(30) NOT NULL,
  `descuento` int(11) NOT NULL,
  PRIMARY KEY (`id_tipo`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;

--
-- Volcado de datos para la tabla `tipo_cliente`
--

INSERT INTO `tipo_cliente` (`id_tipo`, `nombre_tipo`, `descuento`) VALUES
(1, 'normal', 0),
(2, 'ocacional', 10),
(3, 'habitual', 20),
(4, 'frecuente', 25);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tipo_zapato`
--

CREATE TABLE IF NOT EXISTS `tipo_zapato` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `nombre_tipo` varchar(20) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Volcado de datos para la tabla `tipo_zapato`
--

INSERT INTO `tipo_zapato` (`codigo`, `nombre_tipo`) VALUES
(1, 'deportivo'),
(2, 'escolar'),
(3, 'hombre'),
(4, 'mujer'),
(5, 'niño'),
(6, 'infantil'),
(7, 'urbano');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

CREATE TABLE IF NOT EXISTS `venta` (
  `id_venta` int(11) NOT NULL AUTO_INCREMENT,
  `id_cliente` varchar(15) NOT NULL,
  `subtotal_compra` int(11) NOT NULL,
  `iva` int(11) NOT NULL,
  `neto_compra` int(11) NOT NULL,
  `articulos_vendidos` int(11) NOT NULL,
  `descuento` int(11) NOT NULL,
  `total_recaudado` int(11) NOT NULL,
  `dia` varchar(5) NOT NULL,
  `mes` varchar(5) NOT NULL,
  `año` varchar(5) NOT NULL,
  PRIMARY KEY (`id_venta`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=17 ;

--
-- Volcado de datos para la tabla `venta`
--

INSERT INTO `venta` (`id_venta`, `id_cliente`, `subtotal_compra`, `iva`, `neto_compra`, `articulos_vendidos`, `descuento`, `total_recaudado`, `dia`, `mes`, `año`) VALUES
(9, '17130892-5', 34000, 19, 40460, 1, 25, 30345, '12', '7', '2013'),
(10, '17749349-k', 34000, 19, 40460, 1, 0, 40460, '10', '2', '2010'),
(11, '10861848-5', 34000, 19, 40460, 1, 10, 36414, '12', '7', '2013'),
(12, '17130892-5', 68000, 19, 80920, 2, 25, 60690, '15', '7', '2013'),
(13, '17130892-5', 34000, 19, 40460, 1, 25, 30345, '15', '7', '2013'),
(14, '10861848-5', 34000, 19, 40460, 1, 10, 36414, '15', '6', '2010'),
(15, '17749349-k', 136000, 19, 161840, 4, 0, 161840, '15', '7', '2013'),
(16, '17749290-6', 34000, 19, 40460, 1, 10, 36414, '15', '7', '2013');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `zapato`
--

CREATE TABLE IF NOT EXISTS `zapato` (
  `codigo` int(11) NOT NULL AUTO_INCREMENT,
  `marca` varchar(30) NOT NULL,
  `numero` int(11) NOT NULL,
  `precio` int(11) NOT NULL,
  `tipo` int(11) NOT NULL,
  `stock` int(11) NOT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Volcado de datos para la tabla `zapato`
--

INSERT INTO `zapato` (`codigo`, `marca`, `numero`, `precio`, `tipo`, `stock`) VALUES
(2, 'nike', 35, 34000, 1, 3),
(3, 'catterpilar', 42, 36000, 3, 0),
(5, 'columbia', 34, 34000, 3, 7);

-- --------------------------------------------------------

--
-- Estructura para la vista `datos_cliente`
--
DROP TABLE IF EXISTS `datos_cliente`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `datos_cliente` AS select `c`.`run` AS `run`,`c`.`nombres` AS `nombres`,`c`.`apellidos` AS `apellidos`,`c`.`fono` AS `fono`,`c`.`direccion` AS `direccion`,`c`.`email` AS `email`,`tc`.`nombre_tipo` AS `nombre_tipo` from (`cliente` `c` join `tipo_cliente` `tc` on((`c`.`tipo` = `tc`.`id_tipo`)));

-- --------------------------------------------------------

--
-- Estructura para la vista `datos_todos`
--
DROP TABLE IF EXISTS `datos_todos`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `datos_todos` AS select `c`.`run` AS `run`,`c`.`nombres` AS `nombres`,`c`.`apellidos` AS `apellidos`,`c`.`fono` AS `fono`,`c`.`direccion` AS `direccion`,`c`.`email` AS `email`,`tc`.`nombre_tipo` AS `nombre_tipo`,`tc`.`descuento` AS `descuento` from (`cliente` `c` join `tipo_cliente` `tc` on((`c`.`tipo` = `tc`.`id_tipo`)));

-- --------------------------------------------------------

--
-- Estructura para la vista `datos_venta`
--
DROP TABLE IF EXISTS `datos_venta`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `datos_venta` AS select `c`.`run` AS `run`,`c`.`nombres` AS `nombres`,`c`.`apellidos` AS `apellidos`,`v`.`id_venta` AS `id_venta`,`v`.`subtotal_compra` AS `subtotal_compra`,`v`.`iva` AS `iva`,`v`.`neto_compra` AS `neto_compra`,`v`.`articulos_vendidos` AS `articulos_vendidos`,`v`.`total_recaudado` AS `total_recaudado`,`v`.`dia` AS `dia`,`v`.`mes` AS `mes`,`v`.`año` AS `año` from (`cliente` `c` join `venta` `v` on((`c`.`run` = `v`.`id_cliente`)));

-- --------------------------------------------------------

--
-- Estructura para la vista `datos_zapato`
--
DROP TABLE IF EXISTS `datos_zapato`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `datos_zapato` AS select `z`.`codigo` AS `codigo`,`z`.`marca` AS `marca`,`z`.`numero` AS `numero`,`z`.`precio` AS `precio`,`tz`.`nombre_tipo` AS `nombre_tipo`,`z`.`stock` AS `stock`,`z`.`tipo` AS `tipo` from (`zapato` `z` join `tipo_zapato` `tz` on((`z`.`tipo` = `tz`.`codigo`)));

-- --------------------------------------------------------

--
-- Estructura para la vista `reportes_venta`
--
DROP TABLE IF EXISTS `reportes_venta`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `reportes_venta` AS select `datos_venta`.`run` AS `run`,`datos_venta`.`nombres` AS `nombres`,`datos_venta`.`apellidos` AS `apellidos`,`datos_venta`.`id_venta` AS `id_venta`,sum(`datos_venta`.`subtotal_compra`) AS `sum(subtotal_compra)`,`datos_venta`.`iva` AS `iva`,sum(`datos_venta`.`neto_compra`) AS `sum(neto_compra)`,sum(`datos_venta`.`articulos_vendidos`) AS `sum(articulos_vendidos)`,sum(`datos_venta`.`total_recaudado`) AS `sum(total_recaudado)` from `datos_venta` group by `datos_venta`.`run`;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
