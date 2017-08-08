Create table EmployeePersonalDetails (EmployeeID INTEGER IDENTITY(1,1) NOT NULL, FirstName VARCHAR(50), LastName VARCHAR(50), EmailID VARCHAR(50), MobileNumber VARCHAR(50), AlternateMobileNumber VARCHAR(50), AddressLine1 VARCHAR(100), AddressLine2 VARCHAR(100), AddressState VARCHAR(50), AddressCountry VARCHAR(50), AddressZipCode VARCHAR(50), HomeCountry VARCHAR(50), CONSTRAINT PK_EmployeePersonalDetails PRIMARY KEY CLUSTERED(EmployeeID ASC))

Create table EmployeeProjectDetails (ProjectID INTEGER IDENTITY(1,1) NOT NULL, ProjectName VARCHAR(50), ClientName VARCHAR(50), ProjectLocation VARCHAR(50), ProjectRoles VARCHAR(50), EmployeeID INTEGER NOT NULL, CONSTRAINT PK_EmployeeProjectDetails PRIMARY KEY CLUSTERED(ProjectID ASC), CONSTRAINT FK_Project_EmployeeID Foreign Key(EmployeeID) REFERENCES EmployeePersonalDetails(EmployeeID))

Create table EmployeeCompanyDetails (EmployeeID INTEGER IDENTITY(1,1) NOT NULL, CompanyName VARCHAR(50), CompanyContactNumber VARCHAR(20), CompanyLocation VARCHAR(50), CompanyWebsite VARCHAR(50), CONSTRAINT PK_EmployeeCompanyDetails PRIMARY KEY CLUSTERED(EmployeeID ASC), CONSTRAINT FK_Company_EmployeeID Foreign Key(EmployeeID) References EmployeePersonalDetails(EmployeeID))

Create table EmployeeTechnicalDetails (EmployeeID INTEGER IDENTITY(1,1) NOT NULL, ProgrammingLanguages VARCHAR(100), DatabasesKnown VARCHAR(100), ORMTechnologies VARCHAR(100), UITechnologies VARCHAR(100), CONSTRAINT PK_EmployeeTechnicalDetails PRIMARY KEY CLUSTERED(EmployeeID ASC), CONSTRAINT FK_Technical_EmployeeID Foreign Key(EmployeeID) References EmployeePersonalDetails(EmployeeID))

Create table EmployeeEducationalDetails (EmployeeID INTEGER IDENTITY(1,1) NOT NULL, CourseType VARCHAR(50), CourseSpecialization VARCHAR(50), CourseYearOfPassing VARCHAR(50), CONSTRAINT PK_EmployeeEducationalDetails PRIMARY KEY CLUSTERED(EmployeeID ASC), CONSTRAINT FK_Educational_EmployeeID Foreign Key(EmployeeID) References EmployeePersonalDetails(EmployeeID))

create nonclustered index idx_EmployeeID on EmployeeProjectDetails(EmployeeID)

ALTER TABLE EmployeeProjectDetails ADD CONSTRAINT FK_EmployeeID Foreign Key(EmployeeID) REFERENCES EmployeePersonalDetails(EmployeeID)

select COUNT(*) from EmployeePersonalDetails

CREATE PROCEDURE uspInsertDetails
@FirstName varchar(50),
@LastName varchar(50),
@EmailID varchar(50),
@MobileNumber varchar(50),
@AlternateMobileNumber varchar(50),
@AddressLine1 varchar(100),
@AddressLine2 varchar(100),
@State varchar(50),
@Country varchar(50),
@ZipCode varchar(50),
@HomeCountry varchar(50),
@ProjectName varchar(50),
@ClientName varchar(50),
@ProjectLocation varchar(50),
@ProjectRoles varchar(50),
@CompanyName varchar(50),
@CompanyContactNumber varchar(20),
@CompanyLocation varchar(50),
@CompanyWebsite varchar(50),
@ProgrammingLanguages varchar(100),
@Databases varchar(100),
@ORMTechnologies varchar(100),
@UITechnologies varchar(100),
@CourseType varchar(50),
@CourseSpecialization varchar(50),
@CourseYear varchar(50),
@Message varchar(Max) Output

AS
BEGIN
	--Begin transaction T1
		Begin try
			Insert into EmployeePersonalDetails (FirstName, LastName, EmailID, MobileNumber, AlternateMobileNumber, AddressLine1, AddressLine2, AddressState, AddressCountry, AddressZipCode, HomeCountry) values (@FirstName, @LastName, @EmailID, @MobileNumber, @AlternateMobileNumber, @AddressLine1, @AddressLine2, @State, @Country, @ZipCode, @HomeCountry)
			Insert into EmployeeCompanyDetails (CompanyName, CompanyContactNumber, CompanyLocation, CompanyWebsite) values (@CompanyName, @CompanyContactNumber, @CompanyLocation, @CompanyWebsite)
			Insert into EmployeeTechnicalDetails (ProgrammingLanguages, DatabasesKnown, ORMTechnologies, UITechnologies) values (@ProgrammingLanguages, @Databases, @ORMTechnologies, @UITechnologies)
			Insert into EmployeeProjectDetails (ProjectName, ClientName, ProjectLocation, ProjectRoles, EmployeeID) values (@ProjectName, @ClientName, @ProjectLocation, @ProjectRoles, (select EmployeeID from EmployeePersonalDetails where EmailID = @EmailID And MobileNumber = @MobileNumber))
			Insert into EmployeeEducationalDetails (CourseType, CourseSpecialization, CourseYearOfPassing) values (@CourseType, @CourseSpecialization, @CourseYear)
			set @Message = 'success'
		--	return
		End try
		Begin Catch
			set @Message = ERROR_MESSAGE()
		--	rollback transaction T1
		--	return
		End Catch
	--Commit transaction T1
END	

drop procedure uspInsertDetails

CREATE PROCEDURE uspTempInsertDetails
@FirstName varchar(50),
@LastName varchar(50),
@EmailID varchar(50),
@MobileNumber varchar(50),
@AlternateMobileNumber varchar(50),
@AddressLine1 varchar(100),
@AddressLine2 varchar(100),
@State varchar(50),
@Country varchar(50),
@ZipCode varchar(50),
@HomeCountry varchar(50),
@ProjectName varchar(50),
@ClientName varchar(50),
@ProjectLocation varchar(50),
@ProjectRoles varchar(50),
@CompanyName varchar(50),
@CompanyContactNumber varchar(20),
@CompanyLocation varchar(50),
@CompanyWebsite varchar(50),
@ProgrammingLanguages varchar(100),
@Databases varchar(100),
@ORMTechnologies varchar(100),
@UITechnologies varchar(100),
@CourseType varchar(50),
@CourseSpecialization varchar(50),
@CourseYear varchar(50),
@Message varchar(Max) Output

AS
BEGIN

			Insert into EmployeePersonalDetails (FirstName, LastName, EmailID, MobileNumber, AlternateMobileNumber, AddressLine1, AddressLine2, AddressState, AddressCountry, AddressZipCode, HomeCountry) values (@FirstName, @LastName, @EmailID, @MobileNumber, @AlternateMobileNumber, @AddressLine1, @AddressLine2, @State, @Country, @ZipCode, @HomeCountry)
			Insert into EmployeeCompanyDetails (CompanyName, CompanyContactNumber, CompanyLocation, CompanyWebsite) values (@CompanyName, @CompanyContactNumber, @CompanyLocation, @CompanyWebsite)
			Insert into EmployeeTechnicalDetails (ProgrammingLanguages, DatabasesKnown, ORMTechnologies, UITechnologies) values (@ProgrammingLanguages, @Databases, @ORMTechnologies, @UITechnologies)
			Insert into EmployeeProjectDetails (ProjectName, ClientName, ProjectLocation, ProjectRoles, EmployeeID) values (@ProjectName, @ClientName, @ProjectLocation, @ProjectRoles, (select EmployeeID from EmployeePersonalDetails where EmailID = @EmailID And MobileNumber = @MobileNumber))
			Insert into EmployeeEducationalDetails (CourseType, CourseSpecialization, CourseYearOfPassing) values (@CourseType, @CourseSpecialization, @CourseYear)
			set @Message = 'success'

END


select * from EmployeePersonalDetails
select * from EmployeeCompanyDetails
select * from EmployeeProjectDetails
select * from EmployeeTechnicalDetails
select * from EmployeeEducationalDetails

delete from EmployeePersonalDetails
delete from EmployeeCompanyDetails
delete from EmployeeProjectDetails
delete from EmployeeTechnicalDetails
delete from EmployeeEducationalDetails

drop table EmployeePersonalDetails
drop table EmployeeCompanyDetails
drop table EmployeeProjectDetails
drop table EmployeeTechnicalDetails
drop table EmployeeEducationalDetails