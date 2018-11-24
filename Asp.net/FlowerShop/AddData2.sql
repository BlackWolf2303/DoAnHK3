SET IDENTITY_INSERT [dbo].[Role] ON
INSERT INTO [dbo].[Role] ([Id], [Name], [Created], [Modified], [Deleted]) VALUES (1, N'Role 1', N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
INSERT INTO [dbo].[Role] ([Id], [Name], [Created], [Modified], [Deleted]) VALUES (2, N'Role 2', N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
INSERT INTO [dbo].[Role] ([Id], [Name], [Created], [Modified], [Deleted]) VALUES (3, N'Role 3', N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
INSERT INTO [dbo].[Role] ([Id], [Name], [Created], [Modified], [Deleted]) VALUES (4, N'Role 4', N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
INSERT INTO [dbo].[Role] ([Id], [Name], [Created], [Modified], [Deleted]) VALUES (5, N'Role 5', N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
INSERT INTO [dbo].[Role] ([Id], [Name], [Created], [Modified], [Deleted]) VALUES (6, N'Role 6', N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
INSERT INTO [dbo].[Role] ([Id], [Name], [Created], [Modified], [Deleted]) VALUES (7, N'Role 7', N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[Account] ON
INSERT INTO [dbo].[Account] ([Id], [Name], [Email], [Password], [Phone], [Address], [Status], [Created], [Modified], [Deleted], [RoleId]) VALUES (1, N'Account 1', N'Account1@gmail.com', N'1234', N'090', N'Address 1', 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 4)
INSERT INTO [dbo].[Account] ([Id], [Name], [Email], [Password], [Phone], [Address], [Status], [Created], [Modified], [Deleted], [RoleId]) VALUES (2, N'Account 2', N'Account2@gmail.com', N'1234', N'090', N'Address 2', 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 2)
INSERT INTO [dbo].[Account] ([Id], [Name], [Email], [Password], [Phone], [Address], [Status], [Created], [Modified], [Deleted], [RoleId]) VALUES (3, N'Account 3', N'Account3@gmail.com', N'1234', N'090', N'Address 3', 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 3)
INSERT INTO [dbo].[Account] ([Id], [Name], [Email], [Password], [Phone], [Address], [Status], [Created], [Modified], [Deleted], [RoleId]) VALUES (4, N'Account 4', N'Account4@gmail.com', N'1234', N'090', N'Address 4', 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 4)
INSERT INTO [dbo].[Account] ([Id], [Name], [Email], [Password], [Phone], [Address], [Status], [Created], [Modified], [Deleted], [RoleId]) VALUES (5, N'Account 5', N'Account5@gmail.com', N'1234', N'090', N'Address 5', 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 5)
SET IDENTITY_INSERT [dbo].[Account] OFF
SET IDENTITY_INSERT [dbo].[Discount] ON
INSERT INTO [dbo].[Discount] ([Id], [Name], [Percent], [Created], [Modified], [Deleted]) VALUES (1, N'Discount 1', 10, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
INSERT INTO [dbo].[Discount] ([Id], [Name], [Percent], [Created], [Modified], [Deleted]) VALUES (2, N'Discount 2', 20, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
INSERT INTO [dbo].[Discount] ([Id], [Name], [Percent], [Created], [Modified], [Deleted]) VALUES (3, N'Discount 3', 30, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
INSERT INTO [dbo].[Discount] ([Id], [Name], [Percent], [Created], [Modified], [Deleted]) VALUES (4, N'Discount 4', 40, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
INSERT INTO [dbo].[Discount] ([Id], [Name], [Percent], [Created], [Modified], [Deleted]) VALUES (5, N'Discount 5', 50, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
INSERT INTO [dbo].[Discount] ([Id], [Name], [Percent], [Created], [Modified], [Deleted]) VALUES (6, N'Discount 6', 60, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
SET IDENTITY_INSERT [dbo].[Discount] OFF
SET IDENTITY_INSERT [dbo].[Order] ON
INSERT INTO [dbo].[Order] ([Id], [Total], [Status], [Created], [Modified], [Deleted], [AccountId], [DiscountId]) VALUES (1, 200, 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 1, 1)
INSERT INTO [dbo].[Order] ([Id], [Total], [Status], [Created], [Modified], [Deleted], [AccountId], [DiscountId]) VALUES (2, 300, 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 2, 2)
INSERT INTO [dbo].[Order] ([Id], [Total], [Status], [Created], [Modified], [Deleted], [AccountId], [DiscountId]) VALUES (3, 400, 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 3, 3)
INSERT INTO [dbo].[Order] ([Id], [Total], [Status], [Created], [Modified], [Deleted], [AccountId], [DiscountId]) VALUES (4, 500, 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 4, 4)
INSERT INTO [dbo].[Order] ([Id], [Total], [Status], [Created], [Modified], [Deleted], [AccountId], [DiscountId]) VALUES (5, 600, 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 5, 5)
SET IDENTITY_INSERT [dbo].[Order] OFF
SET IDENTITY_INSERT [dbo].[Category] ON
INSERT INTO [dbo].[Category] ([Id], [Name], [Status], [Created], [Modified], [Deleted]) VALUES (2, N'Category 1', 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
INSERT INTO [dbo].[Category] ([Id], [Name], [Status], [Created], [Modified], [Deleted]) VALUES (3, N'Category 2', 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
INSERT INTO [dbo].[Category] ([Id], [Name], [Status], [Created], [Modified], [Deleted]) VALUES (4, N'Category 3', 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
INSERT INTO [dbo].[Category] ([Id], [Name], [Status], [Created], [Modified], [Deleted]) VALUES (5, N'Category 4', 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
INSERT INTO [dbo].[Category] ([Id], [Name], [Status], [Created], [Modified], [Deleted]) VALUES (6, N'Category 5', 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
INSERT INTO [dbo].[Category] ([Id], [Name], [Status], [Created], [Modified], [Deleted]) VALUES (7, N'Category 6', 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
INSERT INTO [dbo].[Category] ([Id], [Name], [Status], [Created], [Modified], [Deleted]) VALUES (8, N'Category 7', 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
INSERT INTO [dbo].[Category] ([Id], [Name], [Status], [Created], [Modified], [Deleted]) VALUES (9, N'Category 8', 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0)
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Product] ON
INSERT INTO [dbo].[Product] ([Id], [Name], [Description], [Price], [Quantity], [Stock], [Created], [Modified], [Deleted], [CategoryId]) VALUES (1, N'Product 1', N'Des Pro 1', 20, 50, 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 2)
INSERT INTO [dbo].[Product] ([Id], [Name], [Description], [Price], [Quantity], [Stock], [Created], [Modified], [Deleted], [CategoryId]) VALUES (2, N'Product 2', N'Des Pro 2', 30, 50, 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 2)
INSERT INTO [dbo].[Product] ([Id], [Name], [Description], [Price], [Quantity], [Stock], [Created], [Modified], [Deleted], [CategoryId]) VALUES (3, N'Product 3', N'Des Pro 3', 23, 50, 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 3)
INSERT INTO [dbo].[Product] ([Id], [Name], [Description], [Price], [Quantity], [Stock], [Created], [Modified], [Deleted], [CategoryId]) VALUES (4, N'Product 4', N'Des Pro 4', 41, 50, 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 4)
INSERT INTO [dbo].[Product] ([Id], [Name], [Description], [Price], [Quantity], [Stock], [Created], [Modified], [Deleted], [CategoryId]) VALUES (5, N'Product 5', N'Des Pro 5', 21, 50, 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 5)
INSERT INTO [dbo].[Product] ([Id], [Name], [Description], [Price], [Quantity], [Stock], [Created], [Modified], [Deleted], [CategoryId]) VALUES (6, N'Product 6', N'Des Pro 6', 64, 50, 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 7)
INSERT INTO [dbo].[Product] ([Id], [Name], [Description], [Price], [Quantity], [Stock], [Created], [Modified], [Deleted], [CategoryId]) VALUES (7, N'Product 7', N'Des Pro 7', 23, 50, 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 8)
INSERT INTO [dbo].[Product] ([Id], [Name], [Description], [Price], [Quantity], [Stock], [Created], [Modified], [Deleted], [CategoryId]) VALUES (8, N'Product 8', N'Des Pro 8', 73, 50, 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 4)
INSERT INTO [dbo].[Product] ([Id], [Name], [Description], [Price], [Quantity], [Stock], [Created], [Modified], [Deleted], [CategoryId]) VALUES (9, N'Product 9', N'Des Pro 9', 33, 50, 1, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 2)
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[OrderDetail] ON
INSERT INTO [dbo].[OrderDetail] ([Id], [Price], [Quantity], [Created], [Modified], [Deleted], [ProductId], [OrderId]) VALUES (3, 200, 12, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 1, 1)
INSERT INTO [dbo].[OrderDetail] ([Id], [Price], [Quantity], [Created], [Modified], [Deleted], [ProductId], [OrderId]) VALUES (4, 200, 12, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 2, 1)
INSERT INTO [dbo].[OrderDetail] ([Id], [Price], [Quantity], [Created], [Modified], [Deleted], [ProductId], [OrderId]) VALUES (5, 200, 12, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 3, 1)
INSERT INTO [dbo].[OrderDetail] ([Id], [Price], [Quantity], [Created], [Modified], [Deleted], [ProductId], [OrderId]) VALUES (6, 200, 12, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 5, 1)
INSERT INTO [dbo].[OrderDetail] ([Id], [Price], [Quantity], [Created], [Modified], [Deleted], [ProductId], [OrderId]) VALUES (7, 200, 12, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 1, 2)
INSERT INTO [dbo].[OrderDetail] ([Id], [Price], [Quantity], [Created], [Modified], [Deleted], [ProductId], [OrderId]) VALUES (8, 200, 12, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 3, 2)
INSERT INTO [dbo].[OrderDetail] ([Id], [Price], [Quantity], [Created], [Modified], [Deleted], [ProductId], [OrderId]) VALUES (9, 200, 12, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 1, 4)
INSERT INTO [dbo].[OrderDetail] ([Id], [Price], [Quantity], [Created], [Modified], [Deleted], [ProductId], [OrderId]) VALUES (10, 200, 12, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 4, 4)
INSERT INTO [dbo].[OrderDetail] ([Id], [Price], [Quantity], [Created], [Modified], [Deleted], [ProductId], [OrderId]) VALUES (11, 200, 12, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 5, 3)
INSERT INTO [dbo].[OrderDetail] ([Id], [Price], [Quantity], [Created], [Modified], [Deleted], [ProductId], [OrderId]) VALUES (12, 200, 12, N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 4, 3)
SET IDENTITY_INSERT [dbo].[OrderDetail] OFF
SET IDENTITY_INSERT [dbo].[Image] ON
INSERT INTO [dbo].[Image] ([Id], [Name], [Path], [Created], [Modified], [Deleted], [ProductId]) VALUES (7, N'Image 1', N'Path 1', N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 1)
INSERT INTO [dbo].[Image] ([Id], [Name], [Path], [Created], [Modified], [Deleted], [ProductId]) VALUES (8, N'Image 2', N'Path 2', N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 2)
INSERT INTO [dbo].[Image] ([Id], [Name], [Path], [Created], [Modified], [Deleted], [ProductId]) VALUES (9, N'Image 3', N'Path 3', N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 3)
INSERT INTO [dbo].[Image] ([Id], [Name], [Path], [Created], [Modified], [Deleted], [ProductId]) VALUES (10, N'Image 4', N'Path 4', N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 4)
INSERT INTO [dbo].[Image] ([Id], [Name], [Path], [Created], [Modified], [Deleted], [ProductId]) VALUES (11, N'Image 5', N'Path 5', N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 5)
INSERT INTO [dbo].[Image] ([Id], [Name], [Path], [Created], [Modified], [Deleted], [ProductId]) VALUES (12, N'Image 6', N'Path 6', N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 6)
INSERT INTO [dbo].[Image] ([Id], [Name], [Path], [Created], [Modified], [Deleted], [ProductId]) VALUES (13, N'Image 7', N'Path 7', N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 7)
INSERT INTO [dbo].[Image] ([Id], [Name], [Path], [Created], [Modified], [Deleted], [ProductId]) VALUES (14, N'Image 8', N'Path 8', N'2012-12-12 00:00:00', N'2012-12-12 00:00:00', 0, 8)
SET IDENTITY_INSERT [dbo].[Image] OFF
