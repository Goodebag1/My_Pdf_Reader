﻿CREATE TABLE [dbo].[tbllogin]
(
	[USERNAME] NVARCHAR(50) NOT NULL PRIMARY KEY DEFAULT USER, 
    [PASSWORD] NVARCHAR(50) NOT NULL DEFAULT 12345, 
    [PICTURE] IMAGE NULL, 
    [FULLNAME] NCHAR(10) NOT NULL
)
