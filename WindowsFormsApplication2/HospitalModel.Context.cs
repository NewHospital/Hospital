﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class hospitalEntities : DbContext
    {
        public hospitalEntities()
            : base("name=hospitalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillsType> BillsTypes { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<BuyingInvoice> BuyingInvoices { get; set; }
        public virtual DbSet<BuyingInvoiceDetail> BuyingInvoiceDetails { get; set; }
        public virtual DbSet<SupplierAddress> SupplierAddresses { get; set; }
        public virtual DbSet<SupplierContact> SupplierContacts { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<RoomsDegree> RoomsDegrees { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<ScientificDegree> ScientificDegrees { get; set; }
        public virtual DbSet<Specification> Specifications { get; set; }
        public virtual DbSet<bloodGroup> bloodGroups { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<DocfollowUp> DocfollowUps { get; set; }
        public virtual DbSet<Fellow> Fellows { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<PatientMeasure> PatientMeasures { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<DrugUnit> DrugUnits { get; set; }
        public virtual DbSet<Prescription> Prescriptions { get; set; }
        public virtual DbSet<PrescriptionDetail> PrescriptionDetails { get; set; }
        public virtual DbSet<VW_Prescription> VW_Prescription { get; set; }
    
        public virtual int AddInvoiceDetail(Nullable<int> invoiceId, Nullable<int> drugId, Nullable<decimal> pricePerUnit, Nullable<int> qnty, Nullable<System.DateTime> expdate)
        {
            var invoiceIdParameter = invoiceId.HasValue ?
                new ObjectParameter("InvoiceId", invoiceId) :
                new ObjectParameter("InvoiceId", typeof(int));
    
            var drugIdParameter = drugId.HasValue ?
                new ObjectParameter("DrugId", drugId) :
                new ObjectParameter("DrugId", typeof(int));
    
            var pricePerUnitParameter = pricePerUnit.HasValue ?
                new ObjectParameter("pricePerUnit", pricePerUnit) :
                new ObjectParameter("pricePerUnit", typeof(decimal));
    
            var qntyParameter = qnty.HasValue ?
                new ObjectParameter("Qnty", qnty) :
                new ObjectParameter("Qnty", typeof(int));
    
            var expdateParameter = expdate.HasValue ?
                new ObjectParameter("Expdate", expdate) :
                new ObjectParameter("Expdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddInvoiceDetail", invoiceIdParameter, drugIdParameter, pricePerUnitParameter, qntyParameter, expdateParameter);
        }
    
        public virtual int AddReservation(Nullable<int> patientId, Nullable<int> roomId, Nullable<System.DateTime> arriveDate, string discription)
        {
            var patientIdParameter = patientId.HasValue ?
                new ObjectParameter("patientId", patientId) :
                new ObjectParameter("patientId", typeof(int));
    
            var roomIdParameter = roomId.HasValue ?
                new ObjectParameter("RoomId", roomId) :
                new ObjectParameter("RoomId", typeof(int));
    
            var arriveDateParameter = arriveDate.HasValue ?
                new ObjectParameter("ArriveDate", arriveDate) :
                new ObjectParameter("ArriveDate", typeof(System.DateTime));
    
            var discriptionParameter = discription != null ?
                new ObjectParameter("Discription", discription) :
                new ObjectParameter("Discription", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddReservation", patientIdParameter, roomIdParameter, arriveDateParameter, discriptionParameter);
        }
    
        public virtual int Cproc_AddBillsType(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_AddBillsType", nameParameter);
        }
    
        public virtual int Cproc_AddBloodGroup(string bloodGroupName)
        {
            var bloodGroupNameParameter = bloodGroupName != null ?
                new ObjectParameter("BloodGroupName", bloodGroupName) :
                new ObjectParameter("BloodGroupName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_AddBloodGroup", bloodGroupNameParameter);
        }
    
        public virtual int Cproc_AddBuyInvoice(Nullable<int> supplierId, Nullable<System.DateTime> invoiceDate, string invAutoNumber)
        {
            var supplierIdParameter = supplierId.HasValue ?
                new ObjectParameter("supplierId", supplierId) :
                new ObjectParameter("supplierId", typeof(int));
    
            var invoiceDateParameter = invoiceDate.HasValue ?
                new ObjectParameter("invoiceDate", invoiceDate) :
                new ObjectParameter("invoiceDate", typeof(System.DateTime));
    
            var invAutoNumberParameter = invAutoNumber != null ?
                new ObjectParameter("InvAutoNumber", invAutoNumber) :
                new ObjectParameter("InvAutoNumber", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_AddBuyInvoice", supplierIdParameter, invoiceDateParameter, invAutoNumberParameter);
        }
    
        public virtual int Cproc_AddDiseases(string diseaseName)
        {
            var diseaseNameParameter = diseaseName != null ?
                new ObjectParameter("DiseaseName", diseaseName) :
                new ObjectParameter("DiseaseName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_AddDiseases", diseaseNameParameter);
        }
    
        public virtual int Cproc_AddDocFollowUp(Nullable<int> reservationId, Nullable<int> docId)
        {
            var reservationIdParameter = reservationId.HasValue ?
                new ObjectParameter("reservationId", reservationId) :
                new ObjectParameter("reservationId", typeof(int));
    
            var docIdParameter = docId.HasValue ?
                new ObjectParameter("DocId", docId) :
                new ObjectParameter("DocId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_AddDocFollowUp", reservationIdParameter, docIdParameter);
        }
    
        public virtual int Cproc_AddDrug(string drugName, Nullable<int> drugUnit, Nullable<decimal> pricePerUnit, Nullable<int> balance)
        {
            var drugNameParameter = drugName != null ?
                new ObjectParameter("DrugName", drugName) :
                new ObjectParameter("DrugName", typeof(string));
    
            var drugUnitParameter = drugUnit.HasValue ?
                new ObjectParameter("DrugUnit", drugUnit) :
                new ObjectParameter("DrugUnit", typeof(int));
    
            var pricePerUnitParameter = pricePerUnit.HasValue ?
                new ObjectParameter("PricePerUnit", pricePerUnit) :
                new ObjectParameter("PricePerUnit", typeof(decimal));
    
            var balanceParameter = balance.HasValue ?
                new ObjectParameter("balance", balance) :
                new ObjectParameter("balance", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_AddDrug", drugNameParameter, drugUnitParameter, pricePerUnitParameter, balanceParameter);
        }
    
        public virtual int Cproc_AddDrugUnits(string dtugUnitName)
        {
            var dtugUnitNameParameter = dtugUnitName != null ?
                new ObjectParameter("DtugUnitName", dtugUnitName) :
                new ObjectParameter("DtugUnitName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_AddDrugUnits", dtugUnitNameParameter);
        }
    
        public virtual int Cproc_AddFellow(string fellowname, string soSeNo, string phoneNumber, Nullable<int> patientId)
        {
            var fellownameParameter = fellowname != null ?
                new ObjectParameter("Fellowname", fellowname) :
                new ObjectParameter("Fellowname", typeof(string));
    
            var soSeNoParameter = soSeNo != null ?
                new ObjectParameter("SoSeNo", soSeNo) :
                new ObjectParameter("SoSeNo", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("phoneNumber", phoneNumber) :
                new ObjectParameter("phoneNumber", typeof(string));
    
            var patientIdParameter = patientId.HasValue ?
                new ObjectParameter("patientId", patientId) :
                new ObjectParameter("patientId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_AddFellow", fellownameParameter, soSeNoParameter, phoneNumberParameter, patientIdParameter);
        }
    
        public virtual int Cproc_AddNewDoc(string docName, string docAddress, string docphone, Nullable<int> docDegree, Nullable<int> docSpecification, Nullable<bool> gender)
        {
            var docNameParameter = docName != null ?
                new ObjectParameter("DocName", docName) :
                new ObjectParameter("DocName", typeof(string));
    
            var docAddressParameter = docAddress != null ?
                new ObjectParameter("DocAddress", docAddress) :
                new ObjectParameter("DocAddress", typeof(string));
    
            var docphoneParameter = docphone != null ?
                new ObjectParameter("Docphone", docphone) :
                new ObjectParameter("Docphone", typeof(string));
    
            var docDegreeParameter = docDegree.HasValue ?
                new ObjectParameter("DocDegree", docDegree) :
                new ObjectParameter("DocDegree", typeof(int));
    
            var docSpecificationParameter = docSpecification.HasValue ?
                new ObjectParameter("DocSpecification", docSpecification) :
                new ObjectParameter("DocSpecification", typeof(int));
    
            var genderParameter = gender.HasValue ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_AddNewDoc", docNameParameter, docAddressParameter, docphoneParameter, docDegreeParameter, docSpecificationParameter, genderParameter);
        }
    
        public virtual int Cproc_AddNewPatient(string patientName, Nullable<bool> gender, Nullable<System.DateTime> doB, string soSeNo, Nullable<int> bloodGroup, string phoneNumber, string address)
        {
            var patientNameParameter = patientName != null ?
                new ObjectParameter("patientName", patientName) :
                new ObjectParameter("patientName", typeof(string));
    
            var genderParameter = gender.HasValue ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(bool));
    
            var doBParameter = doB.HasValue ?
                new ObjectParameter("DoB", doB) :
                new ObjectParameter("DoB", typeof(System.DateTime));
    
            var soSeNoParameter = soSeNo != null ?
                new ObjectParameter("SoSeNo", soSeNo) :
                new ObjectParameter("SoSeNo", typeof(string));
    
            var bloodGroupParameter = bloodGroup.HasValue ?
                new ObjectParameter("BloodGroup", bloodGroup) :
                new ObjectParameter("BloodGroup", typeof(int));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("phoneNumber", phoneNumber) :
                new ObjectParameter("phoneNumber", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_AddNewPatient", patientNameParameter, genderParameter, doBParameter, soSeNoParameter, bloodGroupParameter, phoneNumberParameter, addressParameter);
        }
    
        public virtual int Cproc_AddPatientMeasure(Nullable<int> patientId, Nullable<int> diseaseId, string measureResult, Nullable<System.DateTime> timeOfMeasure, string remarks, Nullable<int> doctorId)
        {
            var patientIdParameter = patientId.HasValue ?
                new ObjectParameter("patientId", patientId) :
                new ObjectParameter("patientId", typeof(int));
    
            var diseaseIdParameter = diseaseId.HasValue ?
                new ObjectParameter("DiseaseId", diseaseId) :
                new ObjectParameter("DiseaseId", typeof(int));
    
            var measureResultParameter = measureResult != null ?
                new ObjectParameter("MeasureResult", measureResult) :
                new ObjectParameter("MeasureResult", typeof(string));
    
            var timeOfMeasureParameter = timeOfMeasure.HasValue ?
                new ObjectParameter("TimeOfMeasure", timeOfMeasure) :
                new ObjectParameter("TimeOfMeasure", typeof(System.DateTime));
    
            var remarksParameter = remarks != null ?
                new ObjectParameter("remarks", remarks) :
                new ObjectParameter("remarks", typeof(string));
    
            var doctorIdParameter = doctorId.HasValue ?
                new ObjectParameter("DoctorId", doctorId) :
                new ObjectParameter("DoctorId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_AddPatientMeasure", patientIdParameter, diseaseIdParameter, measureResultParameter, timeOfMeasureParameter, remarksParameter, doctorIdParameter);
        }
    
        public virtual int cproc_AddRooms(Nullable<int> roomDegree, string roomfloor, string roomNo)
        {
            var roomDegreeParameter = roomDegree.HasValue ?
                new ObjectParameter("RoomDegree", roomDegree) :
                new ObjectParameter("RoomDegree", typeof(int));
    
            var roomfloorParameter = roomfloor != null ?
                new ObjectParameter("Roomfloor", roomfloor) :
                new ObjectParameter("Roomfloor", typeof(string));
    
            var roomNoParameter = roomNo != null ?
                new ObjectParameter("RoomNo", roomNo) :
                new ObjectParameter("RoomNo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("cproc_AddRooms", roomDegreeParameter, roomfloorParameter, roomNoParameter);
        }
    
        public virtual int Cproc_AddRoomsDegree(string name, Nullable<decimal> feesDay, string discription)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var feesDayParameter = feesDay.HasValue ?
                new ObjectParameter("FeesDay", feesDay) :
                new ObjectParameter("FeesDay", typeof(decimal));
    
            var discriptionParameter = discription != null ?
                new ObjectParameter("Discription", discription) :
                new ObjectParameter("Discription", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_AddRoomsDegree", nameParameter, feesDayParameter, discriptionParameter);
        }
    
        public virtual int Cproc_AddSpecialization(string specificationName)
        {
            var specificationNameParameter = specificationName != null ?
                new ObjectParameter("SpecificationName", specificationName) :
                new ObjectParameter("SpecificationName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_AddSpecialization", specificationNameParameter);
        }
    
        public virtual int Cproc_AddSupplierAddress(Nullable<int> supplierID, string supplierAddress)
        {
            var supplierIDParameter = supplierID.HasValue ?
                new ObjectParameter("supplierID", supplierID) :
                new ObjectParameter("supplierID", typeof(int));
    
            var supplierAddressParameter = supplierAddress != null ?
                new ObjectParameter("supplierAddress", supplierAddress) :
                new ObjectParameter("supplierAddress", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_AddSupplierAddress", supplierIDParameter, supplierAddressParameter);
        }
    
        public virtual int Cproc_AddSupplierContact(string contactName, string jobtitle, string telephone, Nullable<int> addressId)
        {
            var contactNameParameter = contactName != null ?
                new ObjectParameter("contactName", contactName) :
                new ObjectParameter("contactName", typeof(string));
    
            var jobtitleParameter = jobtitle != null ?
                new ObjectParameter("jobtitle", jobtitle) :
                new ObjectParameter("jobtitle", typeof(string));
    
            var telephoneParameter = telephone != null ?
                new ObjectParameter("telephone", telephone) :
                new ObjectParameter("telephone", typeof(string));
    
            var addressIdParameter = addressId.HasValue ?
                new ObjectParameter("addressId", addressId) :
                new ObjectParameter("addressId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_AddSupplierContact", contactNameParameter, jobtitleParameter, telephoneParameter, addressIdParameter);
        }
    
        public virtual int Cproc_AddSuppliers(string supplierName)
        {
            var supplierNameParameter = supplierName != null ?
                new ObjectParameter("SupplierName", supplierName) :
                new ObjectParameter("SupplierName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_AddSuppliers", supplierNameParameter);
        }
    
        public virtual int Cproc_BuySerial()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_BuySerial");
        }
    
        public virtual int Cproc_DocDegrees(string scientificDegreeName)
        {
            var scientificDegreeNameParameter = scientificDegreeName != null ?
                new ObjectParameter("ScientificDegreeName", scientificDegreeName) :
                new ObjectParameter("ScientificDegreeName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_DocDegrees", scientificDegreeNameParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int Cproc_AddMeasure(Nullable<int> patientId, Nullable<int> diseaseId, string measureResult, string remark, Nullable<int> doctorId)
        {
            var patientIdParameter = patientId.HasValue ?
                new ObjectParameter("patientId", patientId) :
                new ObjectParameter("patientId", typeof(int));
    
            var diseaseIdParameter = diseaseId.HasValue ?
                new ObjectParameter("diseaseId", diseaseId) :
                new ObjectParameter("diseaseId", typeof(int));
    
            var measureResultParameter = measureResult != null ?
                new ObjectParameter("MeasureResult", measureResult) :
                new ObjectParameter("MeasureResult", typeof(string));
    
            var remarkParameter = remark != null ?
                new ObjectParameter("remark", remark) :
                new ObjectParameter("remark", typeof(string));
    
            var doctorIdParameter = doctorId.HasValue ?
                new ObjectParameter("doctorId", doctorId) :
                new ObjectParameter("doctorId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_AddMeasure", patientIdParameter, diseaseIdParameter, measureResultParameter, remarkParameter, doctorIdParameter);
        }
    
        public virtual int Cproc_AddPayment(Nullable<int> reservationId, string receiptSerial, Nullable<decimal> amount, string discription)
        {
            var reservationIdParameter = reservationId.HasValue ?
                new ObjectParameter("ReservationId", reservationId) :
                new ObjectParameter("ReservationId", typeof(int));
    
            var receiptSerialParameter = receiptSerial != null ?
                new ObjectParameter("ReceiptSerial", receiptSerial) :
                new ObjectParameter("ReceiptSerial", typeof(string));
    
            var amountParameter = amount.HasValue ?
                new ObjectParameter("amount", amount) :
                new ObjectParameter("amount", typeof(decimal));
    
            var discriptionParameter = discription != null ?
                new ObjectParameter("Discription", discription) :
                new ObjectParameter("Discription", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_AddPayment", reservationIdParameter, receiptSerialParameter, amountParameter, discriptionParameter);
        }
    
        public virtual int Cproc_Checkout(Nullable<int> reservationId, Nullable<System.DateTime> leaveDate, string discription)
        {
            var reservationIdParameter = reservationId.HasValue ?
                new ObjectParameter("ReservationId", reservationId) :
                new ObjectParameter("ReservationId", typeof(int));
    
            var leaveDateParameter = leaveDate.HasValue ?
                new ObjectParameter("leaveDate", leaveDate) :
                new ObjectParameter("leaveDate", typeof(System.DateTime));
    
            var discriptionParameter = discription != null ?
                new ObjectParameter("discription", discription) :
                new ObjectParameter("discription", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Cproc_Checkout", reservationIdParameter, leaveDateParameter, discriptionParameter);
        }
    }
}
