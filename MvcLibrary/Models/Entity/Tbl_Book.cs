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
    
    public partial class Tbl_Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Book()
        {
            this.Status = true;
            this.Transactions = new HashSet<Transactions>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<byte> Category_ID { get; set; }
        public Nullable<int> Writer_ID { get; set; }
        public string PublicationYear { get; set; }
        public Nullable<int> Publisher_ID { get; set; }
        public string PageCount { get; set; }
        public Nullable<bool> Status { get; set; }
        public string ImageUrl { get; set; }
    
        public virtual Tbl_Categories Tbl_Categories { get; set; }
        public virtual Tbl_Publisher Tbl_Publisher { get; set; }
        public virtual Tbl_Writer Tbl_Writer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}