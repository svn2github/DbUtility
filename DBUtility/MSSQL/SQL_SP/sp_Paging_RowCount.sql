USE [HPMIS]
GO
/****** 对象:  StoredProcedure [dbo].[Hwj_Paging_RowCount]    脚本日期: 05/27/2009 10:23:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Hwj_Paging_RowCount]
(
@Tables varchar(1000),
@PK varchar(100),
@Sort varchar(200) = NULL,
@PageNumber int = 1,
@PageSize int = 10,
@Fields varchar(1000) = '*',
@Filter varchar(1000) = NULL,
@Group varchar(1000) = NULL,
@_PTotalCount int output)
AS
Begin
/*Default Sorting*/
IF @Sort IS NULL OR @Sort = ''
	SET @Sort = @PK

/*Find the @PK type*/
DECLARE @SortTable varchar(100)
DECLARE @SortName varchar(100)
DECLARE @strSortColumn varchar(200)
DECLARE @operator char(2)
DECLARE @type varchar(100)
DECLARE @prec int

/*Set sorting variables.*/	
IF CHARINDEX('DESC',@Sort)>0
	BEGIN
		SET @strSortColumn = REPLACE(@Sort, 'DESC', '')
		SET @operator = '<='
	END
ELSE
	BEGIN
		IF CHARINDEX('ASC', @Sort) = 0
			SET @strSortColumn = REPLACE(@Sort, 'ASC', '')
		SET @operator = '>='
	END


IF CHARINDEX('.', @strSortColumn) > 0
	BEGIN
		SET @SortTable = SUBSTRING(@strSortColumn, 0, CHARINDEX('.',@strSortColumn))
		SET @SortName = SUBSTRING(@strSortColumn, CHARINDEX('.',@strSortColumn) + 1, LEN(@strSortColumn))
	END
ELSE
	BEGIN
		SET @SortTable = @Tables
		SET @SortName = @strSortColumn
	END

SELECT @type=t.name, @prec=c.prec
FROM sysobjects o 
JOIN syscolumns c on o.id=c.id
JOIN systypes t on c.xusertype=t.xusertype
WHERE o.name = @SortTable AND c.name = @SortName

IF CHARINDEX('char', @type) > 0
   SET @type = @type + '(' + CAST(@prec AS varchar) + ')'

DECLARE @strPageSize varchar(50)
DECLARE @strStartRow varchar(50)
DECLARE @strFilter varchar(1000)
DECLARE @strSimpleFilter varchar(1000)
DECLARE @strGroup varchar(1000)

/*Default Page Number*/
IF @PageNumber < 1
	SET @PageNumber = 1

/*Set paging variables.*/
SET @strPageSize = CAST(@PageSize AS varchar(50))
SET @strStartRow = CAST(((@PageNumber - 1)*@PageSize + 1) AS varchar(50))

/*Set filter & group variables.*/
IF @Filter IS NOT NULL AND @Filter != ''
	BEGIN
		SET @strFilter = ' WHERE ' + @Filter + ' '
		SET @strSimpleFilter = ' AND ' + @Filter + ' '
	END
ELSE
	BEGIN
		SET @strSimpleFilter = ''
		SET @strFilter = ''
	END
IF @Group IS NOT NULL AND @Group != ''
	SET @strGroup = ' GROUP BY ' + @Group + ' '
ELSE
	SET @strGroup = ''

IF @type='char'
	SET @type='char(50)'
/*Execute dynamic query*/
	
EXEC(
'
DECLARE @SortColumn ' + @type + '
SELECT Top ' + @strStartRow + ' @SortColumn=' + @strSortColumn + ' FROM ' + @Tables +' (nolock) '+ @strFilter + ' ' + @strGroup + ' ORDER BY ' + @Sort + '
SELECT Top ' + @strPageSize + ' ' + @Fields + ' FROM ' + @Tables + ' (nolock) WHERE ' + @strSortColumn + @operator + ' @SortColumn ' + @strSimpleFilter + ' ' + @strGroup + ' ORDER BY ' + @Sort + '
'
)
/*Row Count*/
DECLARE @sqls nvarchar(500)
IF @Group IS NOT NULL AND @Group != ''
BEGIN
	--select @_PTotalCount=count(1) from (select count(1) as i from tbBloodInfo group by hpcode) as a
	set @sqls='select @a=count(1) from (select count(1) as i from '+@Tables +' (nolock) '+ @strFilter + ' ' + @strGroup + ') as tb' 
END
ELSE
BEGIN
	set @sqls='select @a=count(1) from '+@Tables +' (nolock) '+ @strFilter 
END
	exec sp_executesql @sqls,N'@a int output',@_PTotalCount output 
End





