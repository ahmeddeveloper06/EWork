//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EWork.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trainee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trainee()
        {
            this.CourseEnrollments = new HashSet<CourseEnrollment>();
            this.CourseReviews = new HashSet<CourseReview>();
        }
    
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> GenderID { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Image { get; set; }
        public bool Active { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<int> Created_By { get; set; }
        public Nullable<int> Updated_By { get; set; }
        public Nullable<System.DateTime> Created_At { get; set; }
        public Nullable<System.DateTime> Updated_At { get; set; }
        public string AspNetUserId { get; set; }
        public Nullable<int> CityID { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual City City { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseEnrollment> CourseEnrollments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseReview> CourseReviews { get; set; }
        public virtual Gender Gender { get; set; }
    }
}
