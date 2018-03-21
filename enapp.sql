-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 16-03-2018 a las 01:43:38
-- Versión del servidor: 10.1.21-MariaDB
-- Versión de PHP: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `enapp`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `examples`
--

CREATE TABLE `examples` (
  `ID` int(11) NOT NULL,
  `simplePresent` text NOT NULL,
  `simplePast` text NOT NULL,
  `pastParticiple` text NOT NULL,
  `type` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `examples`
--

INSERT INTO `examples` (`ID`, `simplePresent`, `simplePast`, `pastParticiple`, `type`) VALUES
(4, 'ADADASD', 'ASDASDA', 'DADAS', 'REGULAR'),
(5, 'ASDASDASDA', 'ASDASD', 'ASDASDASDASD', 'REGULAR'),
(6, 'I RUN', 'I RAN', 'I RUN', 'IRREGULAR'),
(7, 'SDASD', 'SDASD', 'SDASD', 'REGULAR'),
(8, 'SINGING', 'SINGING', 'SINGING', 'IRREGULAR'),
(9, 'ASDAFAS', 'KHGMJ', 'GHJKGHJHKJ', 'REGULAR'),
(10, 'DASDAS', 'SADAS', 'ASDSA', 'REGULAR'),
(11, 'SADLJ', 'LKIHIHIO', 'IUHIOHIO', 'REGULAR'),
(12, 'ASDAS', 'DASD', 'SADSA', 'REGULAR'),
(13, 'REQW', 'KUTUITG', 'HYIGUGG', 'REGULAR'),
(14, 'SDFDS', 'HKJH', 'JKG', 'REGULAR'),
(15, 'KJGKJG', 'KJGHJG', 'HJG', 'IRREGULAR'),
(16, 'ASFAS', 'KJNKJ', 'KLJKL', 'IRREGULAR'),
(17, 'XZDZSDF', 'SDFSAD', 'SDAFSADF', 'REGULAR'),
(18, 'SDFSDF', 'SDFSDF', 'ASDFSADF', 'REGULAR'),
(19, 'DSGSDG', 'SDGSDF', 'SDFSDF', 'REGULAR'),
(20, 'DFGSDFGZS', 'DGSDGSDF', 'SDFSDF', 'REGULAR'),
(21, ',JSDNFSADF', 'SDFSADF', 'SDFSADFASDF', 'REGULAR'),
(22, 'SDFGSDFG', 'DFGSDFG', 'SDFGSDFG', 'REGULAR'),
(23, 'DFGSDFA', 'SDFSADFASDF', 'SADFASDF', 'REGULAR'),
(24, 'GSFD', 'FAFDSDF', 'DFASDFASDF', 'REGULAR'),
(25, 'GSDFAW', 'SDFGASDFASD', 'SDFASDF', 'REGULAR'),
(26, 'DSFASDFAS', 'SADFASDF', 'SADFSADF', 'REGULAR'),
(27, 'FGSDGFASD', 'SDFZDFSFD', 'SDFGSDFSADF', 'REGULAR'),
(28, 'SDFASDF', 'SADFASDF', 'SADFASDF', 'REGULAR'),
(29, 'SDFSADF', 'SADFASDF', 'SADFASDF', 'REGULAR'),
(30, 'DSFGS', 'SDFSADF', 'SDFASDF', 'REGULAR');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pictureverbs`
--

CREATE TABLE `pictureverbs` (
  `ID` int(11) NOT NULL,
  `path` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `verbs`
--

CREATE TABLE `verbs` (
  `ID` int(11) NOT NULL,
  `infinitive` varchar(40) NOT NULL,
  `past` varchar(40) NOT NULL,
  `pronunciation` varchar(40) NOT NULL,
  `pastParticiple` varchar(40) NOT NULL,
  `gerund` varchar(40) NOT NULL,
  `spanish` varchar(40) NOT NULL,
  `type` varchar(10) NOT NULL,
  `imagen` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `verbs`
--

INSERT INTO `verbs` (`ID`, `infinitive`, `past`, `pronunciation`, `pastParticiple`, `gerund`, `spanish`, `type`, `imagen`) VALUES
(4, 'SASDS', 'ASDASDAS', 'ASD', 'ASDASDAS', 'ASDASD', 'AASDASDASD', 'REGULAR', 'SASDSADSADASD.gif'),
(5, 'RUN', 'RAN', 'RAN', 'RUN', 'RUNNING', 'CORRER', 'IRREGULAR', 'RUN.png'),
(6, 'SWIM', 'SWIM', 'SWIM', 'SWIM', 'SWIM', 'NADAR', 'REGULAR', 'SWIM.png'),
(7, 'SING', 'SANG', 'SING', 'SUNG', 'SINGING', 'CANTAR', 'IRREGULAR', 'SING.jpg'),
(8, 'ACCEPT', 'ACCEPTED', 'ED', 'ACCEPTED', 'ACCEPTING', 'ACEPTAR', 'REGULAR', 'ACCEPT.png'),
(9, 'ACT', 'ACTED', 'ED', 'ACTED', 'ACTING', 'ACTUAR', 'REGULAR', 'ACT.jpg'),
(10, 'ADD', 'ADDED', 'ED', 'ADDED', 'ADDING', 'AÑADIR', 'REGULAR', 'ADD.png'),
(11, 'ANSWER', 'ANSWRED', 'D', 'ANSWERED', 'ANSWERING', 'RESPONDER', 'REGULAR', 'ANSWER.jpg'),
(12, 'APPLY', 'APPLIED', 'D', 'APPLIED', 'APPLYING', 'APLICAR', 'REGULAR', 'APPLY.jpg'),
(13, 'ARRIVE', 'ARRIVED', 'D', 'ARRIVED', 'ARRIVING', 'LLEGAR', 'REGULAR', 'ARRIVE.png'),
(14, 'HIDE', 'HID', 'D', 'RISEHIDDENTN', 'HIDDING', 'ESCONDER', 'IRREGULAR', 'HIDE.jpg'),
(15, 'DO', 'DID', 'D', 'DONE', 'DOING', 'HACER', 'IRREGULAR', 'DO.png'),
(16, 'CARRY', 'CARRIED', 'D', 'CARRIED', 'CARRYING', 'CARGAR', 'REGULAR', 'CARRY.jpg'),
(17, 'CALL', 'CALLED', 'D', 'CALLED', 'CALLING', 'LLAMAR', 'REGULAR', 'CALL.gif'),
(18, 'CANCEL', 'CANCELED', 'D', 'CANCELED', 'CANCELING', 'CANCELAR', 'REGULAR', 'CANCEL.jpg'),
(19, 'CHANGE', 'CHANGED', 'T', 'CHANGED', 'CHANGING', 'CAMBIAR', 'REGULAR', 'CHANGE.jpg'),
(20, 'CLOSE', 'CLOSED', 'D', 'CLOSED', 'CLOSING', 'ERRAR', 'REGULAR', 'CLOSE.jpg'),
(21, 'CONFIRM', 'CONFIRMED', 'D', 'CONFIRMED', 'CONFIRMING', 'CONFIRMAR', 'REGULAR', 'CONFIRM.jpg'),
(22, 'COOK', 'COOKED', 'T', 'COOKED', 'COOKING', 'COCINAR', 'REGULAR', 'COOK.jpg'),
(23, 'COUNT', 'COUNTED', 'ED', 'COUNTED', 'COUNTING', 'CONTAR', 'REGULAR', 'COUNT.jpg'),
(24, 'END', 'ENDED', 'ED', 'ENDED', 'ENDING', 'ACABAR', 'REGULAR', 'END.png'),
(25, 'ERASE', 'ERASED', 'D', 'ERASED', 'ERASING', 'BORRAR', 'REGULAR', 'ERASE.jpg'),
(26, 'EXPECT', 'EXPECTED', 'ED', 'EXPECTED', 'EXPECTING', 'ESPERAR', 'REGULAR', 'EXPECT.jpg'),
(27, 'FILL', 'FILLED', 'D', 'FILLED', 'FILLING', 'LLENAR', 'REGULAR', 'FILL.jpg'),
(28, 'KNOCK', 'KNOCKED', 'T', 'KNOKED', 'KNOKING', 'GOLPEAR', 'REGULAR', 'KNOCK.png'),
(29, 'LISTEN', 'LISTENED', 'T', 'LISTENED', 'LISTENING', 'ESCUCHAR', 'REGULAR', 'LISTEN.jpg');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `examples`
--
ALTER TABLE `examples`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `pictureverbs`
--
ALTER TABLE `pictureverbs`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `verbs`
--
ALTER TABLE `verbs`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `examples`
--
ALTER TABLE `examples`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;
--
-- AUTO_INCREMENT de la tabla `pictureverbs`
--
ALTER TABLE `pictureverbs`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT de la tabla `verbs`
--
ALTER TABLE `verbs`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
