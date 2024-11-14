-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 14/11/2024 às 00:58
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `parking_fatec`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `estacionamento`
--

CREATE TABLE `estacionamento` (
  `id` int(11) NOT NULL,
  `qntd_vagas_moto` int(11) DEFAULT NULL,
  `qntd_vagas_carro` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `estacionamento`
--

INSERT INTO `estacionamento` (`id`, `qntd_vagas_moto`, `qntd_vagas_carro`) VALUES
(1, 27, 29);

-- --------------------------------------------------------

--
-- Estrutura para tabela `motoristas`
--

CREATE TABLE `motoristas` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `cnh` varchar(11) NOT NULL,
  `ra_rm` varchar(14) DEFAULT NULL,
  `telefone` varchar(14) NOT NULL,
  `tipo` varchar(12) NOT NULL,
  `usuarios_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `motoristas`
--

INSERT INTO `motoristas` (`id`, `nome`, `email`, `cnh`, `ra_rm`, `telefone`, `tipo`, `usuarios_id`) VALUES
(1, 'Milk', 'milk@gmail.com', '11111111111', '1111111111111', '(11)11111-1111', '1', 1),
(2, 'Love', 'love@gmail.com', '22222222222', '', '(22)22222-2222', '2', 1),
(3, 'Film', 'film@gmail.com', '33333333333', '3333333333333', '(33)33333-3333', '0', 1),
(4, 'Fay', 'fay@fatec.sp.gov.br', '55555555555', '5555555555555', '(55)55555-5555', '0', 1),
(5, 'May', 'may@fatec.sp.gov.br', '66666666666', '6666666666666', '(66)66666-6666', '1', 1),
(6, 'Orm', 'orm@gmail.com', '77777777777', '6666666666666', '(77)77777-7777', '2', 1),
(7, 'Orm', 'orm@fatec.sp.gov.br', '44444444444', '4444444444444', '(44)44444-4444', '1', 1),
(8, 'julio', 'julio@gmail.com', '88888888888', NULL, '(88)88888-8888', '2', 1),
(9, 'eduarda', 'eduarda@fatec.sp.gov.br', '99999999999', '9999999999999', '(99)99999-9999', '0', 1);

-- --------------------------------------------------------

--
-- Estrutura para tabela `registros_entradas`
--

CREATE TABLE `registros_entradas` (
  `id` int(11) NOT NULL,
  `data_entrada` datetime NOT NULL,
  `horario_entrada` datetime NOT NULL,
  `veiculos_id` int(11) NOT NULL,
  `usuarios_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `registros_entradas`
--

INSERT INTO `registros_entradas` (`id`, `data_entrada`, `horario_entrada`, `veiculos_id`, `usuarios_id`) VALUES
(2, '2024-11-13 00:00:00', '2024-11-13 19:54:00', 2, 1),
(3, '2024-11-13 00:00:00', '2024-11-13 20:04:00', 1, 1),
(4, '2024-11-13 00:00:00', '2024-11-13 20:08:00', 1, 1),
(5, '2024-11-13 00:00:00', '2024-11-13 20:08:00', 1, 1),
(6, '2024-11-13 00:00:00', '2024-11-13 20:08:00', 1, 1),
(7, '2024-11-13 00:00:00', '2024-11-13 20:16:00', 1, 1),
(8, '2024-11-13 00:00:00', '2024-11-13 20:20:00', 1, 1),
(9, '2024-11-13 00:00:00', '2024-11-13 20:21:00', 2, 1),
(10, '2024-11-13 00:00:00', '2024-11-13 20:22:00', 1, 1),
(11, '2024-11-13 00:00:00', '2024-11-13 20:36:00', 1, 1),
(12, '2024-11-13 00:00:00', '2024-11-13 20:37:00', 2, 1),
(13, '2024-11-13 00:00:00', '2024-11-13 20:51:00', 1, 1),
(14, '2024-11-13 00:00:00', '2024-11-13 20:51:00', 3, 1);

-- --------------------------------------------------------

--
-- Estrutura para tabela `registros_saida`
--

CREATE TABLE `registros_saida` (
  `id` int(11) NOT NULL,
  `data_saida` datetime NOT NULL,
  `horario_saida` datetime NOT NULL,
  `modelo` varchar(30) NOT NULL,
  `veiculos_id` int(11) NOT NULL,
  `usuarios_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuarios`
--

CREATE TABLE `usuarios` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `senha` varchar(16) NOT NULL,
  `nivel_acesso` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `usuarios`
--

INSERT INTO `usuarios` (`id`, `nome`, `email`, `senha`, `nivel_acesso`) VALUES
(1, 'Eduarda Pontes', 'eduarda.pontes@fatec.sp.gov.br', '1234', 0),
(2, 'Folk ', 'folk@gmail.com', '1234', 1),
(3, 'Dawan', 'dawan@fatec.sp.gov.br', '1234', 0);

-- --------------------------------------------------------

--
-- Estrutura para tabela `veiculos`
--

CREATE TABLE `veiculos` (
  `id` int(11) NOT NULL,
  `placa` varchar(8) NOT NULL,
  `tipo` varchar(6) NOT NULL,
  `modelo` varchar(30) NOT NULL,
  `cor` varchar(15) NOT NULL,
  `motoristas_id` int(11) NOT NULL,
  `usuarios_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `veiculos`
--

INSERT INTO `veiculos` (`id`, `placa`, `tipo`, `modelo`, `cor`, `motoristas_id`, `usuarios_id`) VALUES
(1, '11111111', 'Moto', 'Honda 150', 'Preta', 1, 1),
(2, '44444444', 'Moto', 'Honda 160', 'Vermelha', 7, 1),
(3, '99999999', 'Carro', 'BMW', 'Branca', 9, 1);

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `estacionamento`
--
ALTER TABLE `estacionamento`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `motoristas`
--
ALTER TABLE `motoristas`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `cnh` (`cnh`),
  ADD KEY `usuarios_id` (`usuarios_id`);

--
-- Índices de tabela `registros_entradas`
--
ALTER TABLE `registros_entradas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `veiculos_id` (`veiculos_id`),
  ADD KEY `usuarios_id` (`usuarios_id`);

--
-- Índices de tabela `registros_saida`
--
ALTER TABLE `registros_saida`
  ADD PRIMARY KEY (`id`),
  ADD KEY `veiculos_id` (`veiculos_id`),
  ADD KEY `usuarios_id` (`usuarios_id`);

--
-- Índices de tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Índices de tabela `veiculos`
--
ALTER TABLE `veiculos`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `placa` (`placa`),
  ADD KEY `motoristas_id` (`motoristas_id`),
  ADD KEY `usuarios_id` (`usuarios_id`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `estacionamento`
--
ALTER TABLE `estacionamento`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `motoristas`
--
ALTER TABLE `motoristas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de tabela `registros_entradas`
--
ALTER TABLE `registros_entradas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT de tabela `registros_saida`
--
ALTER TABLE `registros_saida`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `veiculos`
--
ALTER TABLE `veiculos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `motoristas`
--
ALTER TABLE `motoristas`
  ADD CONSTRAINT `motoristas_ibfk_1` FOREIGN KEY (`usuarios_id`) REFERENCES `usuarios` (`id`);

--
-- Restrições para tabelas `registros_entradas`
--
ALTER TABLE `registros_entradas`
  ADD CONSTRAINT `registros_entradas_ibfk_1` FOREIGN KEY (`veiculos_id`) REFERENCES `veiculos` (`id`),
  ADD CONSTRAINT `registros_entradas_ibfk_2` FOREIGN KEY (`usuarios_id`) REFERENCES `usuarios` (`id`);

--
-- Restrições para tabelas `registros_saida`
--
ALTER TABLE `registros_saida`
  ADD CONSTRAINT `registros_saida_ibfk_1` FOREIGN KEY (`veiculos_id`) REFERENCES `veiculos` (`id`),
  ADD CONSTRAINT `registros_saida_ibfk_2` FOREIGN KEY (`usuarios_id`) REFERENCES `usuarios` (`id`);

--
-- Restrições para tabelas `veiculos`
--
ALTER TABLE `veiculos`
  ADD CONSTRAINT `veiculos_ibfk_1` FOREIGN KEY (`motoristas_id`) REFERENCES `motoristas` (`id`),
  ADD CONSTRAINT `veiculos_ibfk_2` FOREIGN KEY (`usuarios_id`) REFERENCES `usuarios` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
