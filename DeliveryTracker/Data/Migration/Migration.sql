USE [DeliveryTracker.Models.AppDbContext]



 
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Schema]') AND type in (N'U'))  Drop Table [Schema] 
CREATE TABLE [dbo].[Schema](
	[Id] [int] IDENTITY(1, 1) NOT NULL , 
	[Version] [bigint] NOT NULL,
	[UtcDate]  [datetime] DEFAULT (GETUTCDATE()),
	[BuildNumber] [nvarchar](100)  , 
	[Status] [nvarchar](50) NULL ,
	[CreatedAt] [datetime] not null default(getdate()) ,
	[UpdatedAt] [datetime]  not null default(getdate())  
) ;
INSERT [Schema] ([Version] ) Values(1 )
GO




IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Deliveries]') AND type in (N'U'))  Drop Table [Deliveries]
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Customers]') AND type in (N'U'))  Drop Table [Customers]   
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Address] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT INTO  [Customers] ([Name] ,[Address])
     VALUES ('Fred F', 'Rock Quary') 
	 , ('Homer S', 'Springfield')  
	 , ('Barny R', 'Rock Quary')  
	 , ('Peter G', 'Pawtucket')  
	 , ('Jerry', 'house cat')  





	 
CREATE TABLE [dbo].[Deliveries](
	[DeliveryId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[IsDelivered] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DeliveryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO 
/****** Object:  ForeignKey [Delivery_Customer]    Script Date: 05/25/2012 13:09:10 ******/
ALTER TABLE [dbo].[Deliveries]  WITH CHECK ADD  CONSTRAINT [Delivery_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([CustomerId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Deliveries] CHECK CONSTRAINT [Delivery_Customer]
GO 
INSERT INTO  [Deliveries] ([CustomerId] ,[Description], [IsDelivered]) VALUES 
 (1, 'Nanocircuit Analyzer',	0)
,(2, 'Biros (Pack of 500)',	0)
,(1, 'FPGA Refill Cartridge',	0)
,(3, 'Luxury Silver Hatstand (Medium)',	0)
,(4, 'ASP.NET Karaoke 3 (XBox)',	0)
,(4, 'Party Beverage Multipack',	0)
,(1, 'Plasma Flux Inverter',	0)
,(2, 'Manilla Envelopes',	0)
,(4, 'T-Shirts (6 pack)',	0)
,(4, 'Hawaiian Pizzas (16 x 16")',	0)




