CREATE PROC sp_PageView
@tbname     sysname,           	--Ҫ��ҳ��ʾ�ı���
@FieldKey   nvarchar(1000),  	--���ڶ�λ��¼������(Ωһ��)�ֶ�,�����Ƕ��ŷָ��Ķ���ֶ�
@PageCurrent int=1,           	--Ҫ��ʾ��ҳ��
@PageSize   int=10,            	--ÿҳ�Ĵ�С(��¼��)
@FieldShow nvarchar(1000)='',  	--�Զ��ŷָ���Ҫ��ʾ���ֶ��б�,�����ָ��,����ʾ�����ֶ�
@FieldOrder nvarchar(1000)='',  	--�Զ��ŷָ��������ֶ��б�,����ָ�����ֶκ���ָ��DESC/ASC����ָ������˳��
@Where    nvarchar(1000)='', 	--��ѯ����
@PageCount int OUTPUT         	--��ҳ��
AS
SET NOCOUNT ON
--�������Ƿ���Ч
IF OBJECT_ID(@tbname) IS NULL
BEGIN
	RAISERROR(N'����"%s"������',1,16,@tbname)
	RETURN
END
IF OBJECTPROPERTY(OBJECT_ID(@tbname),N'IsTable')=0
	AND OBJECTPROPERTY(OBJECT_ID(@tbname),N'IsView')=0
	AND OBJECTPROPERTY(OBJECT_ID(@tbname),N'IsTableFunction')=0
BEGIN
	RAISERROR(N'"%s"���Ǳ���ͼ���߱�ֵ����',1,16,@tbname)
	RETURN
END

--��ҳ�ֶμ��
IF ISNULL(@FieldKey,N'')=''
BEGIN
	RAISERROR(N'��ҳ������Ҫ����������Ωһ����',1,16)
	RETURN
END

--����������鼰�淶
IF ISNULL(@PageCurrent,0)<1 SET @PageCurrent=1
IF ISNULL(@PageSize,0)<1 SET @PageSize=10
IF ISNULL(@FieldShow,N'')=N'' SET @FieldShow=N'*'
IF ISNULL(@FieldOrder,N'')=N''
	SET @FieldOrder=N''
ELSE
	SET @FieldOrder=N'ORDER BY '+LTRIM(@FieldOrder)
IF ISNULL(@Where,N'')=N''
	SET @Where=N''
ELSE
	SET @Where=N'WHERE ('+@Where+N')'

--���@PageCountΪNULLֵ,�������ҳ��(������ƿ���ֻ�ڵ�һ�μ�����ҳ��,�Ժ����ʱ,����ҳ�����ظ��洢����,�����ٴμ�����ҳ��,���ڲ��������ҳ���Ĵ������,���Ը�@PageCount��ֵ)
IF @PageCount IS NULL
BEGIN
	DECLARE @sql nvarchar(4000)
	SET @sql=N'SELECT @PageCount=COUNT(*)'
		+N' FROM '+@tbname
		+N' '+@Where
	EXEC sp_executesql @sql,N'@PageCount int OUTPUT',@PageCount OUTPUT
	SET @PageCount=(@PageCount+@PageSize-1)/@PageSize
END

--�����ҳ��ʾ��TOPNֵ
DECLARE @TopN varchar(20),@TopN1 varchar(20)
SELECT @TopN=@PageSize,
	@TopN1=(@PageCurrent-1)*@PageSize

--��һҳֱ����ʾ
IF @PageCurrent=1
	EXEC(N'SELECT TOP '+@TopN
		+N' '+@FieldShow
		+N' FROM '+@tbname
		+N' '+@Where
		+N' '+@FieldOrder)
ELSE
BEGIN
	--�������
	IF @FieldShow=N'*'
		SET @FieldShow=N'a.*'

	--��������(Ωһ��)��������
	DECLARE @Where1 nvarchar(4000),@Where2 nvarchar(4000),
		@s nvarchar(1000),@Field sysname
	SELECT @Where1=N'',@Where2=N'',@s=@FieldKey
	WHILE CHARINDEX(N',',@s)>0
		SELECT @Field=LEFT(@s,CHARINDEX(N',',@s)-1),
			@s=STUFF(@s,1,CHARINDEX(N',',@s),N''),
			@Where1=@Where1+N' AND a.'+@Field+N'=b.'+@Field,
			@Where2=@Where2+N' AND b.'+@Field+N' IS NULL',
			@Where=REPLACE(@Where,@Field,N'a.'+@Field),
			@FieldOrder=REPLACE(@FieldOrder,@Field,N'a.'+@Field),
			@FieldShow=REPLACE(@FieldShow,@Field,N'a.'+@Field)
	SELECT @Where=REPLACE(@Where,@s,N'a.'+@s),
		@FieldOrder=REPLACE(@FieldOrder,@s,N'a.'+@s),
		@FieldShow=REPLACE(@FieldShow,@s,N'a.'+@s),
		@Where1=STUFF(@Where1+N' AND a.'+@s+N'=b.'+@s,1,5,N''),	
		@Where2=CASE
			WHEN @Where='' THEN N'WHERE ('
			ELSE @Where+N' AND ('
			END+N'b.'+@s+N' IS NULL'+@Where2+N')'

	--ִ�в�ѯ
	EXEC(N'SELECT TOP '+@TopN
		+N' '+@FieldShow
		+N' FROM '+@tbname
		+N' a LEFT JOIN(SELECT TOP '+@TopN1
		+N' '+@FieldKey
		+N' FROM '+@tbname
		+N' a '+@Where
		+N' '+@FieldOrder
		+N')b ON '+@Where1
		+N' '+@Where2
		+N' '+@FieldOrder)
END
