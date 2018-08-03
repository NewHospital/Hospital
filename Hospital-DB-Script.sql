Create database hospital 
Go 
use Hospital 
Go 
create schema publicSchema  
Go 
create schema PatientSector
Go 
create schema MedicalSector
Go 
create schema pharmacy 
go 
create schema Buying 
go 
create schema Accounts
Go
Create schema Hosting
go 

create rule publicSchema.MoreZero as 
@Value > 0 
Go 
create rule publicschema.NotLessZero as 
@value >= 0
go 
create rule publicschema.checkdate as 
@date >= year (getdate ())

Go

-- Creating Doctors specification table 
create table MedicalSector.Specification (
SpecificationId int primary key not null identity (1,1) , 
SpecificationName nvarchar (50) not null unique 
)
Go 
-- Creating scientific degrees for doctors table 
Create table MedicalSector.ScientificDegree (
ScientificDegreeId int not null primary key identity (1,1),
ScientificDegreeName nvarchar (50) not null
)

Go 
-- Create Doctors table 
Create table  MedicalSector. Doctors (
DoctorId int not null primary key identity (1,1), 
DocName nvarchar (50) not null unique nonclustered,
DocAddress nvarchar (50),
DocPhone nvarchar (20) ,
DocDegree int not null constraint Fk_ScientificDegreeId_Doctors  foreign key references MedicalSector.ScientificDegree (ScientificDegreeId), 
DocSpecification int not null  constraint FK_Specification_Doctors foreign key references MedicalSector.Specification (SpecificationId), 
MagId int constraint FK_Doctors foreign key references MedicalSector.Doctors (DoctorId)
)
Go 

--Table blood Groups
Create table PatientSector.bloodGroups (
BloodID	Int Primary key,
BloodGroupName Nvarchar(5) Not null
)
-- Table Patient
go
create table PatientSector.Patient(
PatientID int IDENTITY(1,1) primary key not null ,
PatientName Nvarchar (50) Not null constraint IX_PatientName unique nonclustered,
Gender	Bit Not null ,
DOB	Datetime2 Not null,
SoSecNo	Int Not null constraint IX_SoSecNo unique NONCLUSTERED,
BloodGroup Int Not null constraint Fk_bloodGroups_Patient foreign key references PatientSector.bloodGroups (BloodID) , 
PhoneNumber	Nvarchar (50) , 
Address	Nvarchar (50) 
)

-- Table Fellow
go
Create table PatientSector.Fellow (
FellowID Int Primary key identity (1,1),
FellowName Nvarchar (50) Not null constraint Ix_FellowName unique nonclustered,
SoSecNo	Int Not null constraint IX_SoSecNo2 unique NONCLUSTERED,
PhoneNumber	Nvarchar (20),
PatientId Int Not null constraint Fk_Patient_Fellow foreign key references PatientSector.Patient (PatientID),
)
-- Table Diseases
go
Create table PatientSector.Diseases (
DiseaseId Int Primary key identity (1,1),
DiseaseName	Nvarchar(50) Not null unique,
)
 -- Table medical History
go
Create table PatientSector.medicalHistory (
PatientID Int Not null constraint Fk_Patient_medicalHistory foreign key references PatientSector.Patient (PatientID) ,
DiseaseID Int Not null constraint Fk_Diseases_medicalHistory foreign key references PatientSector.Diseases (DiseaseID) 
CONSTRAINT PK_medicalHistory PRIMARY KEY  (PatientID, DiseaseID)
)
-- Table Patient Measures
go
create table PatientSector.PatientMeasures (
PatientID Int Not null constraint Fk_Patient_PatientMeasures foreign key references PatientSector.Patient (PatientID),
DiseaseID Int Not null constraint Fk_Diseases_PatientMeasures foreign key references PatientSector.Diseases (DiseaseID),
MeasureResult nvarchar (50) not null ,
TimeOfMeasure datetime2 not null,
Remarks	Nvarchar (50), 
constraint PK_PatientMeasures primary key (PatientID, DiseaseID,TimeOfMeasure)
)
-- Table Rooms Degree
go
Create table Hosting.RoomsDegree (
RoomDegreeID Int Not null Primary key identity (1,1),
DegreeName Nvarchar (50) Not null, 
FeesPerDay Decimal Not null,
Discription	Nvarchar (50)	
)
exec sp_bindrule 'publicSchema.MoreZero', 'Hosting.RoomsDegree.FeesPerDay'
-- Table Rooms
go
Create table Hosting.Rooms (
RoomId Int Not null Primary key identity (1,1),
RoomNo Nvarchar(50) Not null,
RoomFloor Nvarchar (50),
RoomDegree Int Not null constraint Fk_Patient_Rooms foreign key references Hosting.RoomsDegree (RoomDegreeID)
)

-- Table Reservations
go
create table PatientSector.Reservations (
ReservationID Int Not null Primary key,
patientId Int Not null constraint Fk_Patient_Reservations foreign key references PatientSector.Patient (PatientID),
RoomID Int Not null constraint Fk_Rooms_Reservations foreign key references Hosting.Rooms (RoomID),
ArriveDate Datetime2 Not null, 
LeaveDate Datetime2,
IsActive Bit Not null default 1,
Discription	Nvarchar(50)
)
-- Table Doc follow
go 
Create table PatientSector.DocfollowUp (
DoctorID Int Not null constraint Fk_Doctors_DocfollowUp foreign key references MedicalSector.Doctors (DoctorID),
ReservationID Int Not null constraint Fk_Reservations_DocfollowUp foreign key references PatientSector.Reservations (ReservationID),
IsActive Bit Not null default 1, 
Constraint Pk_DocfollowUp primary key (DoctorID,ReservationID)
)
Go 

-- Drug Unit Table
create table pharmacy.DrugUnits
(
	DrugUnitId int not null primary key identity(1,1),
	DrugUnitName nvarchar(50) not null 
)

GO
-- Drug Table
create table pharmacy.Drugs
(
	DrugId int not null primary key identity(1,1),
	DrugName nvarchar(50) not null unique nonclustered,
	DrugUnit int not null constraint FK_DrugUnits_Drugs foreign key references pharmacy.DrugUnits(DrugUnitId),
	PricePerUnit Decimal not null ,
	Balance int constraint def_Balance default(0) not null
)
Exec sp_bindrule 'publicschema.NotLessZero', 'Pharmacy.Drugs.Balance'
Exec sp_bindrule 'publicSchema.MoreZero', 'Pharmacy.Drugs.PricePerUnit'

Go
-- Suppliers table
create table Buying.Suppliers
(
	SupplierId int not null primary key identity(1,1),
	SupplierName nvarchar(50) not null ,
)
go 
Create table Buying.SupplierAddress 
(
AddressId int not null primary key identity (1,1),
SupplierId int not null constraint FK_Suppliers_SupplierAddress foreign key references Buying.Suppliers (SupplierId),
SupplierAdress nvarchar (50) not null
)

Go
-- Supplier Contact table
create table Buying.SupplierContact
(
	ContactName nvarchar(50) not null ,
	JobTitle nvarchar (50) ,
	ContactPhone nvarchar(50) not null, 
	AddressId int not null constraint FK_SupplierAddress_SupplierContact foreign key references Buying.SupplierAddress (AddressId),
	Constraint PK_SupplierContact primary key (ContactName, AddressId)
)

Go
-- Buying Invoice table
create table Buying.BuyingInvoice
(
	InvoiceId int not null primary key identity(1,1),
	InvoiceDate datetime2 not null,
	SupplierId int not null constraint FK_Suppliers_BuyingInvoice foreign key references Buying.Suppliers(SupplierId),
	InvoiceNumber nvarchar(50) not null constraint IX_InvoiceNumber unique nonclustered
)

Go
-- Buying Invoice Detail table
create table Buying.BuyingInvoiceDetail
(
	InvoiceId int not null constraint FK_BuyingInvoice_BuyingInvoiceDetail foreign key references Buying.BuyingInvoice(InvoiceId),
	DrugId int not null constraint FK_Drugs_BuyingInvoiceDetail foreign key references Pharmacy.Drugs(DrugId),
	Qnty int not null,
	pricePerUnit Decimal not null,
	ExpDate datetime2 not null ,  
	constraint PK_BuyingInvoiceDetail PRIMARY KEY (InvoiceId, DrugId)
)
Exec sp_bindrule 'publicSchema.MoreZero', 'Buying.BuyingInvoiceDetail.Qnty'
Exec sp_bindrule 'publicSchema.MoreZero','Buying.BuyingInvoiceDetail.pricePerUnit'
Exec sp_bindrule 'publicschema.checkdate', 'Buying.BuyingInvoiceDetail.ExpDate' 


Go
-- Prescription table
create table Pharmacy.Prescription
(
	PrescriptionId int not null primary key identity(1,1),
	prescriptionDate datetime2 not null,
	DocId int not null constraint FK_Doctors_Prescription foreign key references MedicalSector.Doctors(DoctorId),
	ReservationID int not null constraint FK_Reservations_Prescription foreign key references PatientSector.Reservations(ReservationID),
)

Go
-- Prescription Detail table
create table Pharmacy.PrescriptionDetail
(
	PrescriptionId int not null constraint FK_Prescription_PrescriptionDetail foreign key references Pharmacy.Prescription(PrescriptionId),
	DrugId int not null constraint FK_Drugs_PrescriptionDetail foreign key references Pharmacy.Drugs(DrugId),
	Qnty decimal not null ,
	IsReceived bit not null default 0,
	constraint PK_PrescriptionDetail PRIMARY KEY (PrescriptionId, DrugId)
)
Exec sp_bindrule 'publicSchema.MoreZero', 'Pharmacy.PrescriptionDetail.Qnty'

Go 
create table Accounts.BillsTypes
(
 TypeId int primary key not null identity (1,1) ,
 TypeName nvarchar(50) not null
)
Go 
create table Accounts.Bills
(
 BillId int primary key not null identity (1,1) ,
 ReservationID int not null constraint FK_Reservations_Bills foreign key references PatientSector.Reservations (ReservationID) ,
 BillNo nvarchar(50) not null unique nonclustered,
 BillDate datetime2 not null,
 Amount Decimal not null,
 Discription nvarchar(50) not null,
 BillType int not null constraint FK_BillsTypes_Bills foreign key references Accounts.BillsTypes (TypeId)
 )
Exec sp_bindrule 'publicSchema.MoreZero', 'Accounts.Bills.Amount'


go
create table Accounts.Payments
(
 PaymentId int primary key not null identity (1,1),
 paymentDate datetime2 not null,
 ReservationId int not null constraint FK_Reservations_Payments foreign key references PatientSector.Reservations (ReservationId),
 ReceiptSerial nvarchar(50) not null unique nonclustered ,
 Amount Decimal not null,
 Discription nvarchar (100)
)
Exec sp_bindrule 'publicSchema.MoreZero', 'Accounts.Payments.Amount'


alter authorization on database:: hospital to sa 

