CREATE DATABASE StockMarket

CREATE TABLE Company (
	CompanyId int primary key NOT NULL identity(1,1),
    CompanyCode nvarchar(10) NOT NULL UNIQUE,
    CompanyName nvarchar(30) NOT NULL,
    CompanyCEO nvarchar(30) NOT NULL,
	CompanyTurnOver int NOT NULL,
	CompanyWebsite nvarchar(200) NOT NULL,
	StockExchange nvarchar(5) NOT NULL
);

insert into Company (CompanyCode, CompanyName, CompanyCEO, CompanyTurnOver, CompanyWebsite, StockExchange)
values('TCS','Tata','Ratan',10,'https://tcs.com','NSE')


CREATE TABLE Stock
(
StockId int primary key not null identity(1,1),
StockPrice decimal(30,2) not null,
CompanyCode nvarchar(10) ,
StockDate DATETIME,
FOREIGN KEY (CompanyCode) REFERENCES Company(CompanyCode)
)

