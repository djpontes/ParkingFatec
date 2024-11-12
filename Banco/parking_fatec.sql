-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 12/11/2024 às 23:38
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
(6, 'Orm', 'orm@gmail.com', '77777777777', '6666666666666', '(77)77777-7777', '2', 1);

-- --------------------------------------------------------

--
-- Estrutura para tabela `registros`
--

CREATE TABLE `registros` (
  `id` int(11) NOT NULL,
  `data_entrada` date NOT NULL,
  `horario_entrada` time NOT NULL,
  `data_saida` date NOT NULL,
  `horario_saida` time NOT NULL,
  `veiculos_id` int(11) NOT NULL
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
(1, 'Eduarda Pontes', 'eduarda.pontes@fatec.sp.gov.br', '1234', 0);

-- --------------------------------------------------------

--
-- Estrutura para tabela `usuarios_registros`
--

CREATE TABLE `usuarios_registros` (
  `id` int(11) NOT NULL,
  `usuarios_id` int(11) NOT NULL,
  `registros_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

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
(1, '11111111', 'Moto', 'Honda 150', 'Preta', 1, 1);

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
-- Índices de tabela `registros`
--
ALTER TABLE `registros`
  ADD PRIMARY KEY (`id`),
  ADD KEY `veiculos_id` (`veiculos_id`);

--
-- Índices de tabela `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- Índices de tabela `usuarios_registros`
--
ALTER TABLE `usuarios_registros`
  ADD PRIMARY KEY (`id`),
  ADD KEY `usuarios_id` (`usuarios_id`),
  ADD KEY `registros_id` (`registros_id`);

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `motoristas`
--
ALTER TABLE `motoristas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT de tabela `registros`
--
ALTER TABLE `registros`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `usuarios_registros`
--
ALTER TABLE `usuarios_registros`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `veiculos`
--
ALTER TABLE `veiculos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `motoristas`
--
ALTER TABLE `motoristas`
  ADD CONSTRAINT `motoristas_ibfk_1` FOREIGN KEY (`usuarios_id`) REFERENCES `usuarios` (`id`);

--
-- Restrições para tabelas `registros`
--
ALTER TABLE `registros`
  ADD CONSTRAINT `registros_ibfk_1` FOREIGN KEY (`veiculos_id`) REFERENCES `veiculos` (`id`);

--
-- Restrições para tabelas `usuarios_registros`
--
ALTER TABLE `usuarios_registros`
  ADD CONSTRAINT `usuarios_registros_ibfk_1` FOREIGN KEY (`usuarios_id`) REFERENCES `usuarios` (`id`),
  ADD CONSTRAINT `usuarios_registros_ibfk_2` FOREIGN KEY (`registros_id`) REFERENCES `registros` (`id`);

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
