USE [HPMIS]
GO
/****** 对象:  StoredProcedure [dbo].[sp_ClearDatabaseLog]    脚本日期: 06/05/2009 17:58:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_ClearDatabaseLog] 
(@Database varchar(30))
AS
BEGIN
	SET NOCOUNT ON;

	exec(N'USE '+@Database)
	--先执行如下语句：{tabale}为需要缩减的数据库
	exec(N'BACKUP LOG '+@Database+' WITH NO_LOG')

	declare  @fileid int
	--查询日志文件对应的fileid
	select @fileid=fileid from sysfiles where [name] like '%log%'
	--select * from sysfiles where [name] like '%log%'
	--缩减日志文件，{fileid}为刚才查询出来的日志文件对应的fileid号
	DBCC SHRINKFILE(@fileid)
END

