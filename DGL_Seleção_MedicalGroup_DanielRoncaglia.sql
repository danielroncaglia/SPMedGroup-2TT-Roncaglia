--Cria��o de software (web e mobile) de cl�nica m�dica
--Atividade do curso t�cnico Desenvolvimento de Sistemas
--Senai Inform�tica S�o Paulo - 2019
--Instrutores: Helena Strada e Fernando Henrique Guerra
--Aluno: Daniel Roncaglia Correia dos Santos

-- DQL - LINGUAGEM DE CONSULTA DE DADOS

--FAZ A SELE��O DE DADOS NAS TABELAS DO BANCO DE DADOS - QUERY
USE SENAI_MEDICAL_GROUP_2TT;

--SELECIONA OS DADOS DA TABELA CONSULTA
SELECT * FROM CONSULTAS;

--SELECIONA OS HOR�RIOS DA TABELA CONSULTA
SELECT DATA_HORARIO FROM CONSULTAS;

--SELECIONA AS CONSULTAS DO PACIENTE 2
SELECT * FROM CONSULTAS WHERE ID_PACIENTE = 2;

--SELECIONA A TABELA CONSULTAS MOSTRANDO O NOME E INFORMA��ES DOS M�DICOS
SELECT * FROM MEDICOS INNER JOIN CONSULTAS ON MEDICOS.ID_MEDICO = CONSULTAS.ID_MEDICO;

--SELECIONA A PACIENTES MOSTRANDOS CONSULTAS REALIZADAS E AGENDADAS
SELECT * FROM PACIENTES RIGHT JOIN CONSULTAS ON PACIENTES.ID_PACIENTE = CONSULTAS.ID_PACIENTE;

--SELECIONA A TABELA M�DICOS MOSTRANDO AS ESPECIALIDADES DISPON�VEIS
SELECT * FROM MEDICOS LEFT JOIN ESPECIALIDADES ON MEDICOS.ID_ESPECIALIDADE = ESPECIALIDADES.ID_ESPECIALIDADE;

--SELECIONA A TABELA CONSULTAS MOSTRANDO O NOME E INFORMA��ES DOS M�DICOS E DOS PACIENTES
SELECT * FROM CONSULTAS 
INNER JOIN MEDICOS ON CONSULTAS.ID_MEDICO = MEDICOS.ID_MEDICO
INNER JOIN PACIENTES ON CONSULTAS.ID_PACIENTE = PACIENTES.ID_PACIENTE;

--FAZER PROCEDURE, VIEWS E �NDICES