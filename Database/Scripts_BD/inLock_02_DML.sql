USE inlock;
GO

INSERT INTO Estudio(Nome)
VALUES ('Bandai Namco Entertainment'),('Marvelous Interactive Inc'),('Toys for Bob');
GO

INSERT INTO Jogo(IdEstudio,Nome,Descricao,DataLancamento,Valor)
VALUES (1,'Blue Protocol','Blue Protocol é visualmente deslumbrante e viciante, perfeito para novatos e veteranos em MMORPGs.','2024-03-09','0')
	  ,(2,'Harvest Moon: Animal Parade','Harvest Moon: Animal Parade combina o encanto da fazenda com aventuras memoráveis.','2008-10-30','74')
	  ,(3,'Spyro Reignited Trilogy','Spyro Trilogy traz nostalgia e inovação em uma combinação mágica.','2018-11-13','150');
GO

INSERT INTO TiposUsuario(Titulo)
VALUES ('Comum'),('Administrador');
GO

INSERT INTO Usuario(IdTipoUsuario,Email,Senha)
VALUES (1,'cliente@cliente.com','cliente')
      ,(2,'admin@admin.com','admin');
GO

