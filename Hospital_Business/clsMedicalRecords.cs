
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using Hospital_DataAccessLayer;


namespace Hospital_Business
{

    public class clsMedicalRecords
    {

        enum enMode { AddNew, Update};

        enMode _Mode;

        public int MedicalRecordID { set; get; }
public string VisitDescription { set; get; }
public string Diagnosis { set; get; }
public string AdditionalNotes { set; get; }
public int CreatedByUserID { set; get; }


        public clsUser UsersInfo { set; get; }

 

public clsMedicalRecords()
{
    this._Mode = enMode.AddNew;

 this.MedicalRecordID = -1;
this.VisitDescription = " ";
this.Diagnosis = " ";
this.AdditionalNotes = " ";
this.CreatedByUserID = -1;
 

 this.UsersInfo = null ;

}

private clsMedicalRecords( int MedicalRecordID,string VisitDescription,string Diagnosis,string AdditionalNotes,int CreatedByUserID)
{
    this._Mode = enMode.Update;

 this.MedicalRecordID = MedicalRecordID;
this.VisitDescription = VisitDescription;
this.Diagnosis = Diagnosis;
this.AdditionalNotes = AdditionalNotes;
this.CreatedByUserID = CreatedByUserID;
 
 
 this.UsersInfo = clsUser.FindByID(CreatedByUserID);



}

public static clsMedicalRecords FindByID(int MedicalRecordID )
{
    string VisitDescription = " ";
string Diagnosis = " ";
string AdditionalNotes = " ";
int CreatedByUserID = -1;
 
    
    if (clsMedicalRecordsDataAccess.GetMedicalRecordsInfoByID(MedicalRecordID,ref VisitDescription,ref Diagnosis,ref AdditionalNotes,ref CreatedByUserID))
    {
        return new clsMedicalRecords(MedicalRecordID,VisitDescription,Diagnosis,AdditionalNotes,CreatedByUserID);

    }

    return null;

}

    private bool _AddNewMedicalRecords()
{ 
    this.MedicalRecordID = clsMedicalRecordsDataAccess.AddNewMedicalRecords(this.VisitDescription,this.Diagnosis,this.AdditionalNotes,this.CreatedByUserID);

    return (this.MedicalRecordID != -1); 
            
}private bool _UpdateMedicalRecords()
{
    return clsMedicalRecordsDataAccess.UpdateMedicalRecords(this.MedicalRecordID,this.VisitDescription,this.Diagnosis,this.AdditionalNotes,this.CreatedByUserID);
}

 public bool Save()
{
    switch (_Mode)
    {
        case enMode.AddNew :
            
            if ( _AddNewMedicalRecords())
            {

                _Mode = enMode.Update;
                return true;
            }
            else 
                return false;

        case enMode.Update :
            
            return _UpdateMedicalRecords(); 
           
        default :
            return false;

    }

} public static bool DeleteMedicalRecords( int MedicalRecordID )
{
    return clsMedicalRecordsDataAccess.DeleteMedicalRecords(MedicalRecordID);

}
public static DataTable GetListMedicalRecords()
{

    return clsMedicalRecordsDataAccess.GetListMedicalRecords();
}

public static bool IsMedicalRecordsExisteByID( int MedicalRecordID )
{
    return clsMedicalRecordsDataAccess.IsMedicalRecordsExisteByID(MedicalRecordID);

}

   }
}