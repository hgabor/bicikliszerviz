USE bicikli;

DECLARE @AdminUser NVARCHAR(50);
SET @AdminUser = 'hali';

DECLARE @AppId UniqueIdentifier;
SET @AppId = (SELECT ApplicationId FROM Applications WHERE ApplicationName = '/');

IF OBJECT_ID('dbo.Offer', 'U') IS NOT NULL
	DROP TABLE Offer;
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

CREATE TABLE Offer (
	ServiceId uniqueidentifier NOT NULL REFERENCES Service(UserId),
	BicycleId uniqueidentifier NOT NULL REFERENCES Bicycle(Id) ON DELETE CASCADE,
	
	Cost NUMERIC(20) NOT NULL,
	Times NUMERIC(3) NOT NULL,
	Selected BIT NOT NULL DEFAULT 0,
	PRIMARY KEY (ServiceId, BicycleId)
);

DELETE FROM UsersInRoles
	WHERE RoleId IN (SELECT RoleId FROM Roles WHERE RoleName = 'admin');
DELETE FROM Roles WHERE RoleName = 'admin';
INSERT INTO Roles (ApplicationId, RoleId, RoleName)
	VALUES (@AppId, newid(), 'admin');

DELETE FROM UsersInRoles
	WHERE RoleId IN (SELECT RoleId FROM Roles WHERE RoleName = 'service');
DELETE FROM Roles WHERE RoleName = 'service';
INSERT INTO Roles (ApplicationId, RoleId, RoleName)
	VALUES (@AppId, newid(), 'service');

INSERT INTO UsersInRoles (UserId, RoleId) VALUES (
	(SELECT UserId FROM Users WHERE UserName = @AdminUser),
	(SELECT RoleId FROM Roles WHERE RoleName = 'admin')
);

