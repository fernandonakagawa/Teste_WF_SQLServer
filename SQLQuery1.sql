CREATE DATABASE Game;

USE [Game];
CREATE TABLE Ranking (
	idRanking int identity(1,1),
	nome varchar(20),
	pontos int not null default 0,
	PRIMARY KEY (idRanking)
);

INSERT INTO Ranking (nome, pontos) VALUES
('Fernando', 10000),
('Renato', 10001),
('Dhayvison', 20000);

SELECT * FROM Ranking;

SELECT TOP(10) * FROM Ranking ORDER BY pontos DESC;



