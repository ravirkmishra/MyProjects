CREATE TABLE [dbo].[Student](  
    [StudentID] [int] IDENTITY(1,1) NOT NULL,  
    [Name] [varchar](50) NULL,  
    [Email] [varchar](500) NULL,  
    [Class] [varchar](50) NULL,  
    [EnrollYear] [varchar](50) NULL,  
    [City] [varchar](50) NULL,  
    [Country] [varchar](50) NULL,  
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED   
(  
    [StudentID] ASC  
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  
) ON [PRIMARY]  
  
GO  
  
SET ANSI_PADDING OFF  
GO  