CREATE TABLE Tasks (
    Id INT PRIMARY KEY IDENTITY(1,1),              -- Id como chave prim�ria com incremento autom�tico
    Title NVARCHAR(100) NOT NULL,                  -- Title com limite de 100 caracteres
    Description NVARCHAR(MAX),                     -- Description sem limite de caracteres
    DateCreated DATETIME NOT NULL,                 -- DateCreated com data obrigat�ria
    DateConclusion DATETIME NULL,                  -- DateConclusion opcional
    Status INT NOT NULL                            -- Status como int, mapeando valores do enum
);