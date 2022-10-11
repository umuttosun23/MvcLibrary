//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcLibrary.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transactions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Transactions()
        {
            this.Status = false;
        }
    
        public int ID { get; set; }
        public Nullable<int> Book_Id { get; set; }
        public Nullable<int> Member_Id { get; set; }
        public Nullable<byte> Employee_Id { get; set; }
        public Nullable<System.DateTime> Checkout_Date { get; set; }
        public Nullable<System.DateTime> Return_Date { get; set; }
        public Nullable<System.DateTime> MemberBookReturnDate { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual Tbl_Book Tbl_Book { get; set; }
        public virtual Tbl_Employee Tbl_Employee { get; set; }
        public virtual Tbl_Member Tbl_Member { get; set; }
    }
}