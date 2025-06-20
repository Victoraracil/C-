-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost
-- Tiempo de generación: 08-11-2018 a las 14:47:54
-- Versión del servidor: 5.7.22-0ubuntu0.16.04.1
-- Versión de PHP: 7.0.30-0ubuntu0.16.04.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `academia`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alumnos`
--

CREATE TABLE `alumnos` (
  `dni` varchar(9) NOT NULL DEFAULT '0',
  `nombre` varchar(20) NOT NULL DEFAULT '',
  `apellidos` varchar(30) NOT NULL DEFAULT '',
  `telefono` varchar(9) DEFAULT NULL,
  `poblacion` varchar(20) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `alumnos`
--

INSERT INTO `alumnos` (`dni`, `nombre`, `apellidos`, `telefono`, `poblacion`) VALUES
('11111111', 'Vicente', 'Martínez Martínez', '964567899', 'San Juan'),
('22222222', 'Roberto', 'Hidalgo García', '965567898', 'Muchamiel'),
('33333333', 'Sergio', 'Murcia Pérez', '966787777', 'Villafranqueza'),
('44444444', 'Asunción', 'Pérez Pérez', '965325476', 'Campello'),
('55555555', 'Juan Jose', 'Guarinos Huesca', '965995687', 'Alicante'),
('66666666', 'Alicia', 'Pérez Herrero', '966788887', 'Alicante'),
('77777777', 'Jose', 'Martínez Pujol', '966799999', 'San Juan'),
('88888888', 'Antonio', 'Onrrubia Pérez', '966788888', 'San Vicente'),
('99999999', 'Laura', 'Vegara Garcia', '966787777', 'Agost');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cursos`
--

CREATE TABLE `cursos` (
  `codigo` int(11) NOT NULL,
  `titulo` varchar(30) NOT NULL DEFAULT '',
  `n_plazas` tinyint(4) NOT NULL DEFAULT '0',
  `precio` int(11) NOT NULL DEFAULT '0',
  `lugar_realizacion` varchar(30) NOT NULL DEFAULT ''
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `cursos`
--

INSERT INTO `cursos` (`codigo`, `titulo`, `n_plazas`, `precio`, `lugar_realizacion`) VALUES
(1, 'PHP', 9, 300, 'Alicante'),
(2, 'Dreamweaver', 11, 150, 'Campello'),
(3, 'Linux', 19, 200, 'Alicante'),
(4, 'Delphi', 9, 300, 'San Juan'),
(5, 'Oracle', 14, 250, 'Alicante'),
(6, 'CSharp', 12, 100, 'Alicante'),
(7, 'ASP.NET', 20, 200, 'Agost'),
(8, 'J2EE', 21, 300, 'Alicante'),
(9, 'SQL Server', 30, 400, 'Muchamiel'),
(10, 'Lliurex', 10, 500, 'San Juan'),
(11, 'Active Directory', 15, 600, 'San Vicente');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `matriculas`
--

CREATE TABLE `matriculas` (
  `dni` varchar(8) NOT NULL DEFAULT '',
  `codigo` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `matriculas`
--

INSERT INTO `matriculas` (`dni`, `codigo`) VALUES
('11111111', 1),
('22222222', 5),
('33333333', 1),
('33333333', 11),
('44444444', 3),
('55555555', 6),
('66666666', 7),
('77777777', 8),
('88888888', 9),
('99999999', 10);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `alumnos`
--
ALTER TABLE `alumnos`
  ADD PRIMARY KEY (`dni`);

--
-- Indices de la tabla `cursos`
--
ALTER TABLE `cursos`
  ADD PRIMARY KEY (`codigo`);

--
-- Indices de la tabla `matriculas`
--
ALTER TABLE `matriculas`
  ADD PRIMARY KEY (`dni`,`codigo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `cursos`
--
ALTER TABLE `cursos`
  MODIFY `codigo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
