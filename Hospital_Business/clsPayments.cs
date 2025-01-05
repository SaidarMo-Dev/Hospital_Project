
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

    public class clsPayments
    {

        enum enMode { AddNew, Update};

        enMode _Mode;

        public int PaymentID { set; get; }
public DateTime PaymentDate { set; get; }
public string PaymentMethod { set; get; }
public string Notes { set; get; }
public int AmountPaid { set; get; }


        
 

public clsPayments()
{
    this._Mode = enMode.AddNew;

 this.PaymentID = -1;
this.PaymentDate = DateTime.Now;
this.PaymentMethod = " ";
this.Notes = " ";
this.AmountPaid = -1;
 

 
}

private clsPayments( int PaymentID,DateTime PaymentDate,string PaymentMethod,string Notes,int AmountPaid)
{
    this._Mode = enMode.Update;

 this.PaymentID = PaymentID;
this.PaymentDate = PaymentDate;
this.PaymentMethod = PaymentMethod;
this.Notes = Notes;
this.AmountPaid = AmountPaid;
 
 
 


}

public static clsPayments FindByID(int PaymentID )
{
    DateTime PaymentDate = DateTime.Now;
string PaymentMethod = " ";
string Notes = " ";
int AmountPaid = -1;
 
    
    if (clsPaymentsDataAccess.GetPaymentsInfoByID(PaymentID,ref PaymentDate,ref PaymentMethod,ref Notes,ref AmountPaid))
    {
        return new clsPayments(PaymentID,PaymentDate,PaymentMethod,Notes,AmountPaid);

    }

    return null;

}

    private bool _AddNewPayments()
{ 
    this.PaymentID = clsPaymentsDataAccess.AddNewPayments(this.PaymentDate,this.PaymentMethod,this.Notes,this.AmountPaid);

    return (this.PaymentID != -1); 
            
}private bool _UpdatePayments()
{
    return clsPaymentsDataAccess.UpdatePayments(this.PaymentID,this.PaymentDate,this.PaymentMethod,this.Notes,this.AmountPaid);
}

 public bool Save()
{
    switch (_Mode)
    {
        case enMode.AddNew :
            
            if ( _AddNewPayments())
            {

                _Mode = enMode.Update;
                return true;
            }
            else 
                return false;

        case enMode.Update :
            
            return _UpdatePayments(); 
           
        default :
            return false;

    }

} public static bool DeletePayments( int PaymentID )
{
    return clsPaymentsDataAccess.DeletePayments(PaymentID);

}
public static DataTable GetListPayments()
{

    return clsPaymentsDataAccess.GetListPayments();
}

public static bool IsPaymentsExisteByID( int PaymentID )
{
    return clsPaymentsDataAccess.IsPaymentsExisteByID(PaymentID);

}

   }
}