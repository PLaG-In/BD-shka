CREATE TABLE [dbo].[Products] (
    [Product_Id]           INT   NOT NULL,
    [Barcode]              INT   NULL,
    [Product_type]         TEXT  NULL,
    [Number_of_products]   INT   NULL,
    [Price]                INT   NULL,
    [Manufacturer_country] TEXT  NULL,
    [Photo]                TEXT NULL,
    PRIMARY KEY CLUSTERED ([Product_Id] ASC)
);

