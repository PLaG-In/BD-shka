CREATE TABLE [dbo].[Sellings] (
    [Sellings_ID]    INT  NOT NULL,
    [Seller_ID]      INT  NULL,
    [Product_ID]     INT  NULL,
    [Number_of_sell] INT  NULL,
    [Data]           DATE NULL,
    PRIMARY KEY CLUSTERED ([Sellings_ID] ASC),
    CONSTRAINT [FK_Sellings_Products] FOREIGN KEY ([Product_ID]) REFERENCES [dbo].[Products] ([Product_Id]),
    CONSTRAINT [FK_Sellings_Sellers] FOREIGN KEY ([Seller_ID]) REFERENCES [dbo].[Sellers] ([Seller_ID])
);

