/* Lógico_1: */

CREATE DATABASE fazendaSuinos;
GO

USE fazendaSuinos;
GO

CREATE TABLE Administrador (
	CodAdministrador INT IDENTITY(1,1),
	Nome VARCHAR(50),
	CPF VARCHAR(14),
	Telefone VARCHAR(12),
	CONSTRAINT PK_Administrador PRIMARY KEY (CodAdministrador)
);

CREATE TABLE Gerente (
    CodGerente INT IDENTITY(1,1),
	Nome VARCHAR(50),
	CPF VARCHAR(14),
	Telefone VARCHAR(12),
    Setor VARCHAR(30)
	CONSTRAINT PK_Gerente PRIMARY KEY (CodGerente)
);

CREATE TABLE Produtor (
    CodProdutor INT IDENTITY(1,1),
    Nome VARCHAR(50),
	CPF VARCHAR(14),
    CEP VARCHAR(9),
	Telefone VARCHAR(12)
	CONSTRAINT PK_Produtor PRIMARY KEY (CodProdutor)
);

CREATE TABLE Propriedade (
    CodPropriedade INT IDENTITY(1,1),
    Nome VARCHAR(50),
    CodProdutor INT
	CONSTRAINT PK_Propriedade PRIMARY KEY (CodPropriedade),
	CONSTRAINT FK_Propriedade_CodProdutor FOREIGN KEY (CodProdutor) REFERENCES Produtor(CodProdutor),
);

CREATE TABLE Lote (
    CodLote INT IDENTITY(1,1),
    Quantidade INT,
    Peso_Total FLOAT,
    Peso_Medio FLOAT,
    Observacoes TEXT,
	CodGerente INT,
    Situacao VARCHAR(20),
    Data_Alojamento DATE,
    Estimativa_Carregamento DATE,
	CONSTRAINT PK_Lote PRIMARY KEY (CodLote),
	CONSTRAINT FK_Lote_CodGerente FOREIGN KEY (CodGerente) REFERENCES Gerente(CodGerente),
);

CREATE TABLE Pocilga (
    CodPocilga INT IDENTITY(1,1),
    Capacidade INT,
    Descricao VARCHAR(100),
    CodPropriedade INT
	CONSTRAINT PK_Pocilga PRIMARY KEY (CodPocilga),
	CONSTRAINT FK_Pocilga_CodPropriedade FOREIGN KEY (CodPropriedade) REFERENCES Propriedade(CodPropriedade),
);

CREATE TABLE Controle_Mortalidade (
    CodMortalidade INT IDENTITY(1,1),
    Data DATE,
    Sexo CHAR,
    Peso FLOAT,
    Causa_Mortis VARCHAR(30),
    Mossa INT,
    CodLote INT
	CONSTRAINT PK_Controle_Mortalidade PRIMARY KEY (CodMortalidade),
	CONSTRAINT FK_Controle_Mortalidade_CodLote FOREIGN KEY (CodLote) REFERENCES Lote(CodLote),
);

CREATE TABLE Consumo_Racao (
    CodConsumo INT IDENTITY(1,1),
    Data DATE,
    Dia_Ciclo INT,
	Quantidade_Consumo FLOAT,
    CodLote INT
	CONSTRAINT PK_Consumo_Racao PRIMARY KEY (CodConsumo),
	CONSTRAINT FK_Consumo_Racao_CodLote FOREIGN KEY (CodLote) REFERENCES Lote(CodLote),
);

CREATE TABLE Peso_Medio (
    CodPeso_Medio INT IDENTITY(1,1),
    Data DATE,
	PesoMedio FLOAT,
    Dia_Ciclo INT,
    CodLote INT
	CONSTRAINT PK_Peso_Medio PRIMARY KEY (CodPeso_Medio),
	CONSTRAINT FK_Peso_Medio_CodLote FOREIGN KEY (CodLote) REFERENCES Lote(CodLote),
);

CREATE TABLE Tecnico (
    CodTecnico INT IDENTITY(1,1),
	Nome VARCHAR(50),
	CPF VARCHAR(14),
	Telefone VARCHAR(12),
    Especialidade VARCHAR(20)	 
	CONSTRAINT PK_Tecnico PRIMARY KEY (CodTecnico)
);

CREATE TABLE Controle_Vacinacao (
    CodPrescricao INT IDENTITY(1,1),
    Medicacao VARCHAR(100),
	Quantidade INT,
    Data_Inicial DATE,
    Dias_Uso INT,
    Dias_Carencia INT,
    Observacao TEXT,
    CodLote INT
	CONSTRAINT PK_Controle_Vacinacao PRIMARY KEY (CodPrescricao),
	CONSTRAINT FK_Controle_Vacinacao_CodLote FOREIGN KEY (CodLote) REFERENCES Lote(CodLote),
);

CREATE TABLE Visitante (
    CodVisitante INT IDENTITY(1,1),
    Nome VARCHAR(50),
    CPF VARCHAR(14),
    Telefone VARCHAR(12)
	CONSTRAINT PK_Visitante PRIMARY KEY (CodVisitante)
);

CREATE TABLE Fornecedor (
    CodFornecedor INT IDENTITY(1,1),
    CNPJ VARCHAR(19),
    Razao_Social VARCHAR(100),
    CEP VARCHAR(9),
    Telefone VARCHAR(12)
	CONSTRAINT PK_Fornecedor PRIMARY KEY (CodFornecedor)
);

CREATE TABLE LotePocilga (
	CodPocilga INT,
	CodLote INT,
	CONSTRAINT FK_LotePocilga_Pocilga FOREIGN KEY (CodPocilga) REFERENCES Pocilga(CodPocilga),
	CONSTRAINT FK_LotePocilga_Lote FOREIGN KEY (CodLote) REFERENCES Lote(CodLote)
);

CREATE TABLE Visita (
    CodVisita INT IDENTITY(1,1),
    Finalidade VARCHAR(100),
    Cod_Ult INT,
    Observacoes TEXT,
    CodVisitante INT,
	CodPocilga INT,
	Data_Ult DATE,
	Data DATE
	CONSTRAINT PK_Visita PRIMARY KEY (CodVisita),
	CONSTRAINT FK_Visita_CodVisitante FOREIGN KEY (CodVisitante) REFERENCES Visitante(CodVisitante),
	CONSTRAINT FK_Visita_CodPocilga FOREIGN KEY (CodPocilga) REFERENCES Pocilga(CodPocilga)
);

CREATE TABLE Produto (
    CodProduto INT IDENTITY(1,1),
    Nome VARCHAR(40),
    Categoria VARCHAR(3),
    Tipo VARCHAR(30),
    Validade DATE
	CONSTRAINT PK_Produto PRIMARY KEY (CodProduto)
);

CREATE TABLE FornecimentoRacao (
    CodFornecimentoRacao INT IDENTITY(1,1),
	DataForn DATE,
    NomeProduto VARCHAR(40),
    Categoria VARCHAR(3),
    Tipo VARCHAR(30),
    Validade DATE,
    Quantidade FLOAT,
    Unidade VARCHAR(20),
	CodLote INT,
    CodProduto INT,
    CodFornecedor INT,
    CONSTRAINT PK_FornecimentoRacao PRIMARY KEY (CodFornecimentoRacao),
    CONSTRAINT FK_FornecimentoRacao_CodProduto FOREIGN KEY (CodProduto) REFERENCES Produto(CodProduto),
    CONSTRAINT FK_FornecimentoRacao_CodFornecedor FOREIGN KEY (CodFornecedor) REFERENCES Fornecedor(CodFornecedor),
	CONSTRAINT FK_FornecimentoRacao_CodLote FOREIGN KEY (CodLote) REFERENCES Lote(CodLote)
);

CREATE TABLE FornecimentoMedicamento (
    CodFornecimentoMedicamento INT IDENTITY(1,1),
	DataForn DATE,
    NomeProduto VARCHAR(40),
    Categoria VARCHAR(3),
    Tipo VARCHAR(30),
    Validade DATE,
    Quantidade FLOAT,
    Unidade VARCHAR(20),
	CodLote INT,
    CodProduto INT,
    CodFornecedor INT,
    CONSTRAINT PK_FornecimentoMedicamento PRIMARY KEY (CodFornecimentoMedicamento),
    CONSTRAINT FK_FornecimentoMedicamento_CodProduto FOREIGN KEY (CodProduto) REFERENCES Produto(CodProduto),
    CONSTRAINT FK_FornecimentoMedicamento_CodFornecedor FOREIGN KEY (CodFornecedor) REFERENCES Fornecedor(CodFornecedor),
	CONSTRAINT FK_FornecimentoMedicamento_CodLote FOREIGN KEY (CodLote) REFERENCES Lote(CodLote)
);

CREATE TABLE Agenda (
	CodAtividade INT IDENTITY(1,1),
	Finalizada BIT DEFAULT 0,
	Atividade VARCHAR(20),
	DataAtividade DATE,
	Oculto BIT DEFAULT 0,
	CodVacinacao INT,
	CodRacao INT,
	CodMortalidade INT,
	CodVisita INT,
	CodLote INT
	CONSTRAINT PK_Agenda PRIMARY KEY (CodAtividade),
	CONSTRAINT FK_Agenda_CodVacinacao FOREIGN KEY (CodVacinacao) REFERENCES Controle_Vacinacao(CodPrescricao),
	CONSTRAINT FK_Agenda_CodRacao FOREIGN KEY (CodRacao) REFERENCES Consumo_Racao(CodConsumo),
	CONSTRAINT FK_Agenda_Mortalidade FOREIGN KEY (CodMortalidade) REFERENCES Controle_Mortalidade(CodMortalidade),
	CONSTRAINT FK_Agenda_CodLote FOREIGN KEY (CodLote) REFERENCES Lote(CodLote),
	CONSTRAINT FK_Agenda_CodVisita FOREIGN KEY (CodVisita) REFERENCES Visita(CodVisita)
);