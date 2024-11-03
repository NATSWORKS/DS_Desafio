CREATE TABLE Tasks (
    Id INT PRIMARY KEY IDENTITY(1,1),              -- Id como chave primária com incremento automático
    Title NVARCHAR(100) NOT NULL,                  -- Title com limite de 100 caracteres
    Description NVARCHAR(MAX),                     -- Description sem limite de caracteres
    DateCreated DATETIME NOT NULL,                 -- DateCreated com data obrigatória
    DateConclusion DATETIME NULL,                  -- DateConclusion opcional
    Status INT NOT NULL                            -- Status como int, mapeando valores do enum
);