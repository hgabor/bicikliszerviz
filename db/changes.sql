USE bicikli;

ALTER TABLE Users ADD
	PrivateData NVARCHAR(50),
	ContactInfo NVARCHAR(50);

CREATE TABLE Bicycle (
	Id uniqueidentifier PRIMARY KEY,
	Type NVARCHAR(20) NOT NULL,
	Size INT NOT NULL,
	Error NVARCHAR(500) NOT NULL,
	UserId uniqueidentifier NOT NULL,
	CONSTRAINT fk_u_b FOREIGN KEY(UserId) REFERENCES Users(UserId));

CREATE TABLE Service (
	Id uniqueidentifier PRIMARY KEY,
	Username uniqueidentifier NOT NULL,
	Pwd NVARCHAR(20) NOT NULL,
	Name NVARCHAR(20) NOT NULL,
	Address NVARCHAR(50) NOT NULL,
	BicycleId uniqueidentifier NOT NULL,
	CONSTRAINT fk_b_s FOREIGN KEY(BicycleId) REFERENCES Bicycle(Id));

CREATE TABLE Ajanlat (
	ServiceId uniqueidentifier NOT NULL,
	BicycleId uniqueidentifier NOT NULL,
	PRIMARY KEY (ServiceId, BicycleId)
);
