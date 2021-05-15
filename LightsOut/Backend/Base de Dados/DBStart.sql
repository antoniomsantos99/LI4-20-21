CREATE TABLE [Utilizador] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [nome] nvarchar(255),
  [password] nvarchar(255)
)
GO

CREATE TABLE [Notificacao] (
  [id] int PRIMARY KEY,
  [nome] nvarchar(255),
  [idUtilizador] int
)
GO

CREATE TABLE [Prova] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [idEpoca] int,
  [nomeProva] nvarchar(255),
  [nomeCircuito] nvarchar(255),
  [data] datetime,
  [horaProva] time,
  [idNotificacao] int,
  [idLocalizacao] nvarchar(255)
)
GO

CREATE TABLE [Epoca] (
  [ano] int PRIMARY KEY
)
GO

CREATE TABLE [Localizacao] (
  [id] nvarchar(255) PRIMARY KEY,
  [nome] nvarchar(255),
  [nacionalidade] nvarchar(255),
  [latitude] float,
  [longitude] float
)
GO

CREATE TABLE [Qualificacao] (
  [idProva] int PRIMARY KEY,
  [idPiloto] nvarchar(255),
  [posicaoQualificacao] int,
  [qualificao1] time,
  [qualificao2] time,
  [qualificao3] time
)
GO

CREATE TABLE [Resultado] (
  [idProva] int PRIMARY KEY,
  [idPiloto] nvarchar(255),
  [posicaoFinal] int,
  [posicaoInicial] int,
  [tempo] time,
  [pontos] int,
  [estado] nvarchar(255)
)
GO

CREATE TABLE [Piloto] (
  [id] nvarchar(255) PRIMARY KEY,
  [nome] nvarchar(255),
  [numero] int,
  [dataNascimento] date,
  [nacionalidade] nvarchar(255),
  [equipaId] int
)
GO

CREATE TABLE [Equipa] (
  [id] int PRIMARY KEY IDENTITY(1, 1),
  [nome] nvarchar(255),
  [nacionalidade] nvarchar(255),
  [idEpoca] int
)
GO

CREATE TABLE [Pais] (
  [nome] nvarchar(255) PRIMARY KEY,
  [nacionalidade] nvarchar(255)
)
GO

ALTER TABLE [Notificacao] ADD FOREIGN KEY ([idUtilizador]) REFERENCES [Utilizador] ([id])
GO

ALTER TABLE [Prova] ADD FOREIGN KEY ([idEpoca]) REFERENCES [Epoca] ([ano])
GO

ALTER TABLE [Prova] ADD FOREIGN KEY ([idNotificacao]) REFERENCES [Notificacao] ([id])
GO

ALTER TABLE [Prova] ADD FOREIGN KEY ([idLocalizacao]) REFERENCES [Localizacao] ([id])
GO

ALTER TABLE [Localizacao] ADD FOREIGN KEY ([nacionalidade]) REFERENCES [Pais] ([nome])
GO

ALTER TABLE [Qualificacao] ADD FOREIGN KEY ([idProva]) REFERENCES [Prova] ([id])
GO

ALTER TABLE [Qualificacao] ADD FOREIGN KEY ([idPiloto]) REFERENCES [Piloto] ([id])
GO

ALTER TABLE [Resultado] ADD FOREIGN KEY ([idProva]) REFERENCES [Prova] ([id])
GO

ALTER TABLE [Resultado] ADD FOREIGN KEY ([idPiloto]) REFERENCES [Piloto] ([id])
GO

ALTER TABLE [Piloto] ADD FOREIGN KEY ([nacionalidade]) REFERENCES [Pais] ([nome])
GO

ALTER TABLE [Piloto] ADD FOREIGN KEY ([equipaId]) REFERENCES [Equipa] ([id])
GO

ALTER TABLE [Equipa] ADD FOREIGN KEY ([nacionalidade]) REFERENCES [Pais] ([nome])
GO

ALTER TABLE [Equipa] ADD FOREIGN KEY ([idEpoca]) REFERENCES [Epoca] ([ano])
GO
