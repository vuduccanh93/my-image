CREATE TABLE [CreditCards] (
    [ID] INTEGER IDENTITY(0,1) NOT NULL,
    [Number] VARBINARY(MAX),
    [Exp_date] VARCHAR(17),
    [Holder_name] VARCHAR(50),
    [L_three_letter] VARCHAR(3),
    CONSTRAINT [PK_CreditCards] PRIMARY KEY ([ID])
)