USE fazendaSuinos;

INSERT INTO Administrador (Nome, CPF, Telefone) VALUES
('João Silva', '123.456.789-00', '1234567890'),
('Maria Oliveira', '987.654.321-00', '0987654321'),
('Pedro Souza', '456.123.789-00', '2345678901'),
('Ana Costa', '321.654.987-00', '3456789012'),
('Lucas Lima', '789.123.456-00', '4567890123');

INSERT INTO Gerente (Nome, CPF, Telefone, Setor) VALUES
('Carlos Dias', '321.987.654-00', '5678901234', 'Produção'),
('Juliana Mendes', '654.321.987-00', '6789012345', 'Logística'),
('Rafael Alves', '789.654.321-00', '7890123456', 'Saúde Animal'),
('Fernanda Ramos', '987.321.654-00', '8901234567', 'Alimentação'),
('Rodrigo Ferreira', '123.789.654-00', '9012345678', 'Administração');

INSERT INTO Produtor (Nome, CPF, CEP, Telefone) VALUES
('José Santos', '147.258.369-00', '12345-678', '0123456789'),
('Paula Almeida', '369.258.147-00', '87654-321', '9876543210'),
('Ricardo Barbosa', '258.369.147-00', '56789-123', '8765432109'),
('Sandra Pereira', '147.369.258-00', '65432-109', '7654321098'),
('Bruno Moreira', '369.147.258-00', '43210-987', '6543210987');

INSERT INTO Propriedade (Nome, CodProdutor) VALUES
('Fazenda Santa Maria', 1),
('Fazenda Boa Vista', 2),
('Fazenda Esperança', 3),
('Fazenda Nova Era', 4),
('Fazenda Primavera', 5);

INSERT INTO Lote (Quantidade, Peso_Total, Peso_Medio, Observacoes, CodGerente, Situacao, Data_Alojamento, Estimativa_Carregamento) VALUES
(100, 1000.0, 10.0, 'Nenhuma', 1, 'Ativo', '2024-01-01', '2024-06-01'),
(150, 1500.0, 10.0, 'Nenhuma', 2, 'Ativo', '2024-02-01', '2024-07-01'),
(200, 2000.0, 10.0, 'Nenhuma', 3, 'Ativo', '2024-03-01', '2024-08-01'),
(250, 2500.0, 10.0, 'Nenhuma', 4, 'Ativo', '2024-04-01', '2024-09-01'),
(300, 3000.0, 10.0, 'Nenhuma', 5, 'Ativo', '2024-05-01', '2024-10-01');

INSERT INTO Pocilga (Capacidade, Descricao, CodPropriedade) VALUES
(50, 'Pocilga A', 1),
(60, 'Pocilga B', 2),
(70, 'Pocilga C', 3),
(80, 'Pocilga D', 4),
(90, 'Pocilga E', 5);

INSERT INTO Controle_Mortalidade (Data, Sexo, Peso, Causa_Mortis, Mossa, CodLote) VALUES
('2024-01-15', 'M', 10.0, 'Doença', 1, 1),
('2024-02-15', 'F', 12.0, 'Acidente', 2, 2),
('2024-03-15', 'M', 11.0, 'Desconhecida', 3, 3),
('2024-04-15', 'F', 13.0, 'Doença', 4, 4),
('2024-05-15', 'M', 14.0, 'Acidente', 5, 5);

INSERT INTO Consumo_Racao (Data, Dia_Ciclo, Quantidade_Consumo, CodLote) VALUES
-- Lote 1
('2024-01-10', 10, 100.0, 1),
('2024-02-10', 30, 150.0, 1),
('2024-03-10', 60, 200.0, 1),
('2024-04-10', 90, 225.0, 1),
('2024-05-10', 120, 270.0, 1),
-- Lote 2
('2024-03-01', 10, 110.0, 2),
('2024-04-01', 30, 160.0, 2),
('2024-05-01', 60, 210.0, 2),
('2024-06-01', 90, 235.0, 2),
('2024-07-01', 120, 280.0, 2),
-- Lote 3
('2024-04-10', 10, 120.0, 3),
('2024-05-10', 30, 170.0, 3),
('2024-06-10', 60, 220.0, 3),
('2024-07-10', 90, 245.0, 3),
('2024-08-10', 120, 290.0, 3),
-- Lote 4
('2024-05-20', 10, 130.0, 4),
('2024-06-20', 30, 180.0, 4),
('2024-07-20', 60, 230.0, 4),
('2024-08-20', 90, 255.0, 4),
('2024-09-20', 120, 300.0, 4),
-- Lote 5
('2024-07-01', 10, 140.0, 5),
('2024-08-01', 30, 190.0, 5),
('2024-09-01', 60, 240.0, 5),
('2024-10-01', 90, 265.0, 5),
('2024-11-01', 120, 310.0, 5);

INSERT INTO Peso_Medio (Data, PesoMedio, Dia_Ciclo, CodLote) VALUES
('2024-01-20', 10.0, 20, 1),
('2024-02-20', 11.0, 30, 2),
('2024-03-20', 12.0, 40, 3),
('2024-04-20', 13.0, 50, 4),
('2024-05-20', 14.0, 60, 5);

INSERT INTO Tecnico (Nome, CPF, Telefone, Especialidade) VALUES
('Roberto Silva', '147.369.258-00', '0123456789', 'Sanidade'),
('Patrícia Santos', '369.147.258-00', '9876543210', 'Nutrição'),
('Renato Lima', '258.369.147-00', '8765432109', 'Reprodução'),
('Camila Rocha', '147.258.369-00', '7654321098', 'Bem-estar'),
('Alexandre Souza', '258.147.369-00', '6543210987', 'Manejo');

INSERT INTO Controle_Vacinacao (Medicacao, Quantidade, Data_Inicial, Dias_Uso, Dias_Carencia, Observacao, CodLote) VALUES
('Vacina A', 100, '2024-01-01', 30, 15, 'Nenhuma', 1),
('Vacina B', 150, '2024-02-01', 30, 15, 'Nenhuma', 2),
('Vacina C', 200, '2024-03-01', 30, 15, 'Nenhuma', 3),
('Vacina D', 250, '2024-04-01', 30, 15, 'Nenhuma', 4),
('Vacina E', 300, '2024-05-01', 30, 15, 'Nenhuma', 5);

INSERT INTO Visitante (Nome, CPF, Telefone) VALUES
('Fernando Torres', '123.456.789-00', '1234567890'),
('Eliane Farias', '987.654.321-00', '0987654321'),
('Gustavo Lima', '456.123.789-00', '2345678901'),
('Luciana Costa', '321.654.987-00', '3456789012'),
('Tiago Oliveira', '789.123.456-00', '4567890123');

INSERT INTO Produto (Nome, Categoria, Tipo, Validade) VALUES ('Ração A', 'RA', 'Tipo 1', '2024-12-31');
INSERT INTO Produto (Nome, Categoria, Tipo, Validade) VALUES ('Ração B', 'RA', 'Tipo 2', '2024-12-31');
INSERT INTO Produto (Nome, Categoria, Tipo, Validade) VALUES ('Ração C', 'RA', 'Tipo 3', '2024-12-31');
INSERT INTO Produto (Nome, Categoria, Tipo, Validade) VALUES ('Ração D', 'RA', 'Tipo 4', '2024-12-31');
INSERT INTO Produto (Nome, Categoria, Tipo, Validade) VALUES ('Ração E', 'RA', 'Tipo 5', '2024-12-31');
INSERT INTO Produto (Nome, Categoria, Tipo, Validade) VALUES ('Vacina A', 'VA', 'Tipo 1', '2024-12-31');
INSERT INTO Produto (Nome, Categoria, Tipo, Validade) VALUES ('Vacina B', 'VA', 'Tipo 2', '2024-12-31');
INSERT INTO Produto (Nome, Categoria, Tipo, Validade) VALUES ('Vacina C', 'VA', 'Tipo 3', '2024-12-31');
INSERT INTO Produto (Nome, Categoria, Tipo, Validade) VALUES ('Vacina D', 'VA', 'Tipo 4', '2024-12-31');
INSERT INTO Produto (Nome, Categoria, Tipo, Validade) VALUES ('Vacina E', 'VA', 'Tipo 5', '2024-12-31');

INSERT INTO Fornecedor (CNPJ, Razao_Social, CEP, Telefone) VALUES
('12.345.678/0001-00', 'Fornecedor A', '12345-678', '0123456789'),
('98.765.432/0001-00', 'Fornecedor B', '87654-321', '9876543210'),
('23.456.789/0001-00', 'Fornecedor C', '56789-123', '8765432109'),
('87.654.321/0001-00', 'Fornecedor D', '65432-109', '7654321098'),
('34.567.890/0001-00', 'Fornecedor E', '43210-987', '6543210987');

INSERT INTO LotePocilga (CodPocilga, CodLote) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5);

INSERT INTO Visita (Finalidade, Cod_Ult, Observacoes, CodVisitante, CodPocilga, Data_Ult, Data) VALUES
('Inspeção de rotina', 1, 'Nenhuma', 1, 1, '2024-01-01', '2024-01-10'),
('Visita técnica', 2, 'Nenhuma', 2, 2, '2024-02-01', '2024-02-10'),
('Fiscalização', 3, 'Nenhuma', 3, 3, '2024-03-01', '2024-03-10'),
('Consulta veterinária', 4, 'Nenhuma', 4, 4, '2024-04-01', '2024-04-10'),
('Avaliação', 5, 'Nenhuma', 5, 5, '2024-05-01', '2024-05-10');

INSERT INTO FornecimentoRacao (DataForn, NomeProduto, Categoria, Tipo, Validade, Quantidade, Unidade, CodLote, CodProduto, CodFornecedor) VALUES
('2024-01-05', 'Ração A', 'RAC', 'Tipo Ração A', '2024-12-31', 100.0, 'Kg', 1, 1, 1),
('2024-02-05', 'Ração B', 'RAC', 'Tipo Ração B', '2024-11-30', 150.0, 'Kg', 2, 2, 2),
('2024-03-05', 'Ração C', 'RAC', 'Tipo Ração C', '2024-10-31', 200.0, 'Kg', 3, 3, 3),
('2024-04-05', 'Ração D', 'RAC', 'Tipo Ração D', '2024-09-30', 250.0, 'Kg', 4, 4, 4),
('2024-05-05', 'Ração E', 'RAC', 'Tipo Ração E', '2024-08-31', 300.0, 'Kg', 5, 5, 5);

INSERT INTO FornecimentoMedicamento (DataForn, NomeProduto, Categoria, Tipo, Validade, Quantidade, Unidade, CodLote, CodProduto, CodFornecedor) VALUES
('2024-01-10', 'Medicamento A', 'MED', 'Tipo Med A', '2024-12-31', 10.0, 'Litro', 1, 1, 1),
('2024-02-10', 'Medicamento B', 'MED', 'Tipo Med B', '2024-11-30', 15.0, 'Litro', 2, 2, 2),
('2024-03-10', 'Medicamento C', 'MED', 'Tipo Med C', '2024-10-31', 20.0, 'Litro', 3, 3, 3),
('2024-04-10', 'Medicamento D', 'MED', 'Tipo Med D', '2024-09-30', 25.0, 'Litro', 4, 4, 4),
('2024-05-10', 'Medicamento E', 'MED', 'Tipo Med E', '2024-08-31', 30.0, 'Litro', 5, 5, 5);