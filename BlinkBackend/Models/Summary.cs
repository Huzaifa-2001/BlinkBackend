//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlinkBackend.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Summary
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Summary()
        {
            this.GetMovie = new HashSet<GetMovie>();
        }
    
        public int Summary_ID { get; set; }
        public Nullable<int> Sent_ID { get; set; }
        public Nullable<int> Movie_ID { get; set; }
        public Nullable<int> Writer_ID { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
        public string Summary1 { get; set; }
        public string Episode { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GetMovie> GetMovie { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
