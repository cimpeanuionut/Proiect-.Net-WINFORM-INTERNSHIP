---------------------------------------------------------------Clienti--------------------------------------------------------------------------

CREATE Procedure InsertClient
@ClientName nvarchar(512),
@ClientSurname nvarchar(512),
@ClientCode nvarchar(100),
@PhoneNo nvarchar(100),
@Email nvarchar(256)
as
begin

Declare @ClientId int

exec GetNextId 0, 'TClient',  @ClientId out, 0, 1

insert into TClient (ClientId, ClientName, ClientSurname, ClientCode, PhoneNo, Email )
VALUES (@ClientId, @ClientName, @ClientSurname, @ClientCode, @PhoneNo, @Email)

Return @ClientId

end----------------------------------------------------------------------------------------------------------------------------------------------

go

CREATE PROCEDURE PaginationGetClient
@ClientName nvarchar(512),
@ClientSurname nvarchar(512),
@ClientCode nvarchar(100),
@ClientId int,
@skip_page int,
@take_page int
AS
BEGIN

if (@take_page is null or @take_page = 0)
select @take_page = 10
  
SELECT ClientId, ClientName, ClientSurname, ClientCode, PhoneNo, Email    

FROM TClient
where lower(ClientName) Like case when isnull(@ClientName, '')=''
							then lower(ClientName)
							else '%' +  lower(@ClientName) + '%'
							end
and lower(ClientSurname) LIKE case when  isnull(@ClientSurname, '')=''
							 then lower(ClientSurname)
							 else '%' +  lower(@ClientSurname) + '%'
							 end
and lower(ClientCode) LIKE case when  isnull(@ClientCode, '')=''
						  then lower(ClientCode)
						  else '%' +  lower(@ClientCode) + '%'
						  end
and ClientId = 	case when  isnull(@ClientId, 0)=0
						  then ClientId
						  else @ClientId
						  end	
ORDER BY ClientId
OFFSET @skip_page ROWS
FETCH NEXT @take_page ROWS ONLY
						     

END
------------------------------------------------------------------------------------------------------------------------------------------------
go

CREATE Procedure DeleteClient
@ClientId int
as
begin

delete tid
from TInvoiceDetail tid
join TInvoice ti on tid.InvoiceId = ti.InvoiceId
join TClient tc on ti.ClientId = tc.ClientId
where tc.ClientId = @ClientId

delete tiv
from TInvoice tiv
join TClient tc on tc.ClientId = tiv.ClientId
where tc.ClientId = @ClientId

delete TCA
from TClientAddress TCA
where TCA.ClientId = @ClientId

delete TC
from TClient TC
where ClientId = @ClientId

end
------------------------------------------------------------------------------------------------------------------------------------------------

go

CREATE Procedure UpdateClient
@ClientName nvarchar(512),
@ClientSurname nvarchar(512),
@ClientCode nvarchar(100),
@PhoneNo nvarchar(100),
@Email nvarchar(256),
@ClientId int
as
begin

update tc set
tc.ClientName = @ClientName,
tc.ClientSurname = @ClientSurname,
tc.ClientCode = @ClientCode,
tc.PhoneNo = @PhoneNo,
tc.Email = @Email
from TClient tc
where tc.ClientId = @ClientId
end
-----------------------------------------------------------------------------------------------------------------------------------------------
go

Create procedure VerifyDeleteClient
@ClientId int
as
begin

select tc.ClientId from TClient tc
join TInvoice ti on ti.ClientId = tc.ClientId
where tc.ClientId = @ClientId

end

------------------------------------------------------------------------------------------------------------------------------------------------
go

CREATE Procedure GetTotalRowClient
@ClientName nvarchar(200),
@ClientSurname nvarchar(200),
@ClientCode nvarchar(200)
as
begin
Declare @TotalRows int
Select @TotalRows = COUNT(*) from TClient
where lower(ClientName) Like case when isnull(@ClientName, '')=''
							then lower(ClientName)
							else '%' +  lower(@ClientName) + '%'
							end
and lower(ClientSurname) LIKE case when  isnull(@ClientSurname, '')=''
							 then lower(ClientSurname)
							 else '%' +  lower(@ClientSurname) + '%'
							 end
and lower(ClientCode) LIKE case when  isnull(@ClientCode, '')=''
						  then lower(ClientCode)
						  else '%' +  lower(@ClientCode) + '%'
						  end

Return @TotalRows
end
------------------------------------------------------------------------------------------------------------------------------------------------
go
CREATE Procedure GetClientAddress
@ClientId int,
@ClientAddressId int
as
begin

select tca.ClientAddressId, tca.ClientId, tca.CityId, tca.CountyId, tca.StreetName, tca.StreetNo, tci.CityName, tco.CountyName
from TClientAddress tca
join TCity tci on tca.CityId = tci.CityId
join TCounty tco on tca.CountyId = tco.CountyId
where tca.ClientId = @ClientId 
	  and tca.ClientAddressId = case when isnull(@ClientAddressId, 0)=0
								then tca.ClientAddressId
								else   @ClientAddressId
								end

end

------------------------------------------------------------------------------------------------------------------------------------------------
go

Create procedure GetCity
as
begin

select CityId, CityName from TCity

end

------------------------------------------------------------------------------------------------------------------------------------------------
go

Create procedure GetCounty
as
begin

select CountyId, CountyName from TCounty

end

------------------------------------------------------------------------------------------------------------------------------------------------

go

CREATE Procedure AddClientAddress
@ClientId int,
@StreetName nvarchar(256),
@StreetNo   nvarchar(50),
@CityName	nvarchar(256),
@CountyName nvarchar(256)
as
begin

Declare @ClientAddressId int

exec GetNextId 0, 'TClientAddress',  @ClientAddressId out, 0, 1

Declare @CityId int, @CountyId int

select @CityId = CityId
from TCity
where CityName = @CityName

select @CountyId = CountyId
from TCounty
where CountyName = @CountyName

Insert into TClientAddress(ClientAddressId, ClientId, CityId, CountyId, StreetName, StreetNo)
Values (@ClientAddressId, @ClientId, @CityId, @CountyId, @StreetName, @StreetNo)

end
------------------------------------------------------------------------------------------------------------------------------------------------
go

CREATE procedure DeleteClientAddress
@ClientAddressId int
as
begin

delete tid
from TInvoiceDetail tid
join TInvoice ti on tid.InvoiceId = tid.InvoiceId
join TClientAddress tca on ti.ClientAddressId = tca.ClientAddressId
where tca.ClientAddressId = @ClientAddressId

delete tiv
from TInvoice tiv
join TClientAddress tca on tca.ClientAddressId = tiv.ClientAddressId
where tca.ClientAddressId = @ClientAddressId

delete tca
from TClientAddress tca
where tca.ClientAddressId = @ClientAddressId

end
------------------------------------------------------------------------------------------------------------------------------------------------
go

Create procedure UpdateClientAddress
@ClientAddressId int,
@StreetName nvarchar(256),
@StreetNo   nvarchar(50),
@CityName	nvarchar(256),
@CountyName nvarchar(256)
as
begin

Declare @CityId int, @CountyId int

select @CityId = CityId
from TCity
where CityName = @CityName

select @CountyId = CountyId
from TCounty
where CountyName = @CountyName

update tca set
tca.StreetName = @StreetName,
tca.StreetNo = @StreetNo,
tca.CityId = @CityId,
tca.CountyId = @CountyId
from TClientAddress tca
where tca.ClientAddressId = @ClientAddressId

end

------------------------------------------------------------------------------------------------------------------------------------------------
go
--------------------------------------------------------------------Facturi---------------------------------------------------------------------

CREATE procedure InsertInvoice
@InvoiceNumber nvarchar(100),
@InvoiceDate DateTime,
@ClientFullName nvarchar(512),
@ClientAddress nvarchar(1024),
@UserId int,
@Observation nvarchar(1024)
as
begin


Declare @InvoiceId int

exec GetNextId 0, 'TInvoice',  @InvoiceId out, 0, 1

Declare @ClientId int, @ClientAddressId int

select @ClientId = tc.ClientId
from TClient tc
where tc.ClientName + ' ' + tc.ClientSurname = @ClientFullName

select @ClientAddressId = tca.ClientAddressId
from TClientAddress tca
join TCity tcity on tca.CityId = tcity.CityId
join TCounty tcounty on tca.CountyId = tcounty.CountyId
where tca.StreetName + ' '+ tca.StreetNo + ' ' + tcity.CityName + ' ' + tcounty.CountyName = @ClientAddress

insert into TInvoice (InvoiceId, InvoiceNumber, InvoiceDate, ClientId, ClientAddressId, UserId, Observation )
VALUES (@InvoiceId, @InvoiceNumber, @InvoiceDate, @ClientId, @ClientAddressId, @UserId, @Observation)




Return @InvoiceId


end

------------------------------------------------------------------------------------------------------------------------------------------------
go

CREATE procedure GetInvoices
@InvoiceId int,
@StartDate DateTime,
@EndDate DateTime,
@InvoiceNumber nvarchar(100),
@ClientFullName nvarchar(512)
as
begin

if @StartDate is null
	set @StartDate='20000101'
if @EndDate is null
	set @EndDate='20501231'

select ti.InvoiceId, ti.ClientId, ti.ClientAddressId, ti.InvoiceNumber, ti.InvoiceDate, ti.Observation,
tc.ClientName +' ' + tc.ClientSurname ClientFullName,
isnull(tca.StreetName,'') + ' ' + isnull(tca.StreetNo,'') + ' ' + city.CityName + ' ' + county.CountyName ClientAddress
from TInvoice ti
join TClient tc on ti.ClientId = tc.ClientId
join TClientAddress tca on ti.ClientAddressId = tca.ClientAddressId 
join TCity city on tca.CityId = city.CityId
join TCounty county on tca.CountyId = county.CountyId
where ti.InvoiceId = 	case when  isnull(@InvoiceId, 0)=0
						  then ti.InvoiceId
						  else @InvoiceId
						  end	
	 and LOWER(ti.InvoiceNumber) Like case when isnull(@InvoiceNumber, '')=''
							then LOWER(ti.InvoiceNumber)
							else '%' +  LOWER(@InvoiceNumber) + '%'
							end	
     and tc.ClientName +' ' + tc.ClientSurname Like case when isnull(@ClientFullName, '')=''
								then tc.ClientName +' ' + tc.ClientSurname
								else '%' +  @ClientFullName + '%'
								end
	and CONVERT(date,ti.InvoiceDate) BETWEEN Convert(date,@StartDate) AND Convert(date,@EndDate); 
	
end

------------------------------------------------------------------------------------------------------------------------------------------------
go

CREATE procedure DeleteInvoice
@InvoiceId int
as
begin

delete tid
from TInvoiceDetail tid
join TInvoice ti on  tid.InvoiceId = ti.InvoiceId
where ti.InvoiceId = @InvoiceId

delete tiv
from TInvoice tiv
where tiv.InvoiceId = @InvoiceId

end
------------------------------------------------------------------------------------------------------------------------------------------------
go

CREATE procedure UpdateInvoice
@InvoiceId int,
@InvoiceNumber nvarchar(100),
@InvoiceDate DateTime,
@Observation nvarchar(1024),
@ClientFullName nvarchar(512),
@ClientAddress nvarchar(512)

as
begin

Declare @ClientId int, @ClientAddressId int

select @ClientId = tc.ClientId
from TClient tc
where tc.ClientName + ' ' + tc.ClientSurname = @ClientFullName

select @ClientAddressId = tca.ClientAddressId
from TClientAddress tca
join TCity city on tca.CityId = city.CityId
join TCounty county on tca.CountyId = county.CountyId
where tca.StreetName + ' ' + tca.StreetNo + ' '+ city.CityName + ' ' + county.CountyName = @ClientAddress


update iv set
iv.InvoiceNumber = @InvoiceNumber,
iv.InvoiceDate = @InvoiceDate,
iv.Observation = @Observation,
iv.ClientId = @ClientId,
iv.ClientAddressId = @ClientAddressId
from TInvoice iv
where iv.InvoiceId = @InvoiceId


end
------------------------------------------------------------------------------------------------------------------------------------------------
go

Create procedure InsertInvoiceDetail
@InvoiceId int,
@ItemId int,
@Qtty decimal,
@Price decimal,
@Amount decimal,
@Observation nvarchar(1024)
as
begin

Declare @InvoiceDetailId int

exec GetNextId 0, 'TInvoiceDetail',  @InvoiceDetailId out, 0, 1

insert into TInvoiceDetail ( InvoiceDetailId, InvoiceId, ItemId, Qtty, Price, Amount, Observation)
Values (@InvoiceDetailId, @InvoiceId, @ItemId, @Qtty, @Price, @Amount, @Observation)

end
------------------------------------------------------------------------------------------------------------------------------------------------
go

Create procedure UpdateInvoiceDetail
@InvoiceDetailId int,
@ItemId int,
@Qtty decimal,
@Price decimal,
@Amount decimal,
@Observation nvarchar(1024)
as
begin

update tid set
tid.ItemId = @ItemId,
tid.Qtty = @Qtty,
tid.Price = @Price,
tid.Amount = @Amount,
tid.Observation = @Observation
from TInvoiceDetail tid
where tid.InvoiceDetailId = @InvoiceDetailId

end
------------------------------------------------------------------------------------------------------------------------------------------------
go

Create procedure DeleteInvoiceDetail
@InvoiceDetailId int
as
begin

delete tid
from TInvoiceDetail tid
where tid.InvoiceDetailId = @InvoiceDetailId

end
------------------------------------------------------------------------------------------------------------------------------------------------
go

CREATE procedure GetInvoiceDetail
@InvoiceId int,
@InvoiceDetailId int
as
begin

select tid.InvoiceDetailId, tid.InvoiceId,tid.ItemId, ti.ItemName ,tid.Qtty, tid.Price, tid.Amount, tid.Observation
from TInvoiceDetail tid
join TItem ti on tid.ItemId = ti.ItemId
where tid.InvoiceId = @InvoiceId 
		and tid.InvoiceDetailId = case when isnull(@InvoiceDetailId, 0)=0
										then tid.InvoiceDetailId
										else @InvoiceDetailId
										end

end
------------------------------------------------------------------------------------------------------------------------------------------------
go

--------------------------------------------------------------------------ITEM------------------------------------------------------------------

CREATE procedure GetItem
as
begin

select ItemId,ItemName, ItemCode, MeasuringUnitName, ItemDescription from TItem
end

--------------------------------------------------------------LASTLOGIN-------------------------------------------------------------------------

Create Procedure UpdateLastLogin
@LastLogin DateTime,
@UserId int
as
begin

update tu
set tu.LastLogin = @LastLogin
from TERPUser tu
where tu.UserId = @UserId

end


