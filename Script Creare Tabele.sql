Create table TERPUser
(
UserId int Primary Key,
UserName nvarchar(256) not null unique,
UserPassword nvarchar(512)  not null,
LastLogin datetime



insert into TableSysInfo
(
TableName,
NextId,
IdIncludesSiteId
) 
select 'TERPUser', 1, 0

Declare @UserId int

exec GetNextId 0, 'TERPUser',  @UserId out, 0, 1

insert into TERPUser ( UserId, UserName, UserPassword, LastLogin)
select @UserId, 'Ionut', '12345', null

select * from TERPUser
------


Create table TClient
(
ClientId int primary key,
ClientName nvarchar(512) not null,
ClientSurname nvarchar(512) not null,
ClientCode nvarchar(100) not null unique,
PhoneNo nvarchar(100),
Email nvarchar(256)
)


insert into TableSysInfo
(
TableName,
NextId,
IdIncludesSiteId
) 
select 'TClient', 1, 0


Create Table TClientAddress
(
ClientAddressId int Primary Key,
ClientId int not null foreign key references TClient(ClientId),
CityId int not null foreign key references TCity(CityId),
CountyId int not null foreign key references TCounty(CountyId),
StreetName nvarchar(256),
StreetNo nvarchar(50)
)

Create Table TCity
(
CityId int Primary Key,
CityName nvarchar(256) not null
)

Create Table TCounty
(
CountyId int Primary Key,
CountyName nvarchar(256) not null
)

Create Table TItem
(
ItemId int Primary Key,
ItemName nvarchar(512) not null,
ItemCode nvarchar(100) not null,
MeasuringUnitName nvarchar(100) not null,
ItemDescription nvarchar(1024)
)

Create Table TInvoice
(
InvoiceId int Primary Key,
InvoiceNumber nvarchar(100) not null,
InvoiceDate DateTime not null,
ClientId int not null foreign key references TClient(ClientId),
ClientAddressId int not null foreign key references TClientAddress(ClientAddressId),
UserId int not null foreign key references TERPUser(UserId),
Observation nvarchar(1024)
)

Create Table TInvoiceDetail
(
InvoiceDetailId int,
InvoiceId int,
ItemId int not null foreign key references TItem(ItemId),
Qtty decimal(10,4) not null,
Price decimal(14,4) not null,
Amount decimal (14,4),
Observation nvarchar(1024),
Primary Key (InvoiceDetailId, InvoiceId),
foreign Key (InvoiceId) references TInvoice(InvoiceId)

)
