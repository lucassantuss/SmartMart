-- Projeto Interdisciplinar

-- Integrantes do Grupo:
-- Nome: Danilo Rodrigues Dantas -> RA: 081210027
-- Nome: Lucas Ara�jo dos Santos -> RA: 081210009 
-- Nome: Maik Soares Luiz        -> RA: 081210040
-- Nome: Renan C�sar de Araujo   -> RA: 081210033

create database Projeto_Interdisciplinar
use Projeto_Interdisciplinar

-- Cria��o da tabela Fornecedores
CREATE TABLE Fornecedores (
  IDFornecedor INT PRIMARY KEY NOT NULL,
  NomeFornecedor VARCHAR(100) NOT NULL,
  EnderecoFornecedor VARCHAR(200),
  EmailFornecedor VARCHAR(100),
  TelefoneFornecedor VARCHAR(20)
);

-- Cria��o da tabela Clientes
CREATE TABLE Clientes (
  IDCliente INT PRIMARY KEY NOT NULL,
  NomeCliente VARCHAR(100) NOT NULL,
  EnderecoCliente VARCHAR(200),
  EmailCliente VARCHAR(100),
  TelefoneCliente VARCHAR(20)
);

-- Cria��o da tabela Produtos
CREATE TABLE Produtos (
  IDProduto INT PRIMARY KEY NOT NULL,
  NomeProduto VARCHAR(100) NOT NULL,
  FotoProduto VARBINARY(MAX),
  DescricaoProduto VARCHAR(200),
  PrecoProduto DECIMAL(10, 2) NOT NULL,
  EstoqueProduto INT
);

-- Cria��o da tabela Pedidos
CREATE TABLE Pedidos (
  IDPedido INT PRIMARY KEY NOT NULL,
  IDCliente INT NOT NULL,
  DataPedido DATE,
  ValorTotal DECIMAL(10, 2),
  FOREIGN KEY (IDCliente) REFERENCES Clientes(IDCliente)
);

-- Cria��o da tabela Itens do Pedido
CREATE TABLE ItensPedido (
  IDItemPedido INT PRIMARY KEY NOT NULL,
  IDPedido INT NOT NULL,
  IDProduto INT NOT NULL,
  Quantidade INT,
  ValorUnitario DECIMAL(10, 2),
  FOREIGN KEY (IDPedido) REFERENCES Pedidos(IDPedido),
  FOREIGN KEY (IDProduto) REFERENCES Produtos(IDProduto)
);

-- Cria��o da tabela Usu�rios
CREATE TABLE Usuarios (
  IDUsuario INT PRIMARY KEY NOT NULL,
  NomeUsuario VARCHAR(100),
  FotoUsuario VARBINARY(MAX),
  LoginUsuario VARCHAR(50) NOT NULL,
  SenhaUsuario VARCHAR(50) NOT NULL,
  IDCliente INT NOT NULL, -- Se o usu�rio estiver associado a um cliente espec�fico
  FOREIGN KEY (IDCliente) REFERENCES Clientes(IDCliente)
);