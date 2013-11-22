USE bicikli;

--ALTER TABLE Users ADD
--	PrivateData NVARCHAR(50),
--	ContactInfo NVARCHAR(50);

IF OBJECT_ID('dbo.Ajanlat', 'U') IS NOT NULL
	DROP TABLE Ajanlat;
IF OBJECT_ID('dbo.Service', 'U') IS NOT NULL
	DROP TABLE Service;
IF OBJECT_ID('dbo.Bicycle', 'U') IS NOT NULL
	DROP TABLE Bicycle;


CREATE TABLE Bicycle (
	Id uniqueidentifier PRIMARY KEY DEFAULT newid(),
	UserId uniqueidentifier NOT NULL,
	
	Type NVARCHAR(20) NOT NULL,
	Size INT NOT NULL,
	Fault TEXT NOT NULL,
	
	CONSTRAINT fk_u_b FOREIGN KEY(UserId) REFERENCES Users(UserId));

CREATE TABLE Service (
	UserId uniqueidentifier PRIMARY KEY REFERENCES Users(UserId),
	Name NVARCHAR(20) NOT NULL,
	Address NVARCHAR(50) NOT NULL
);

CREATE TABLE Ajanlat (
	ServiceId uniqueidentifier NOT NULL REFERENCES Service(UserId),
	BicycleId uniqueidentifier NOT NULL REFERENCES Bicycle(Id),
	
	Cost NUMERIC(20) NOT NULL,
	Times NUMERIC(3) NOT NULL,
	PRIMARY KEY (ServiceId, BicycleId)
);
