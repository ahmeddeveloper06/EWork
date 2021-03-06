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
    
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.CourseEnrollments = new HashSet<CourseEnrollment>();
            this.CourseReviews = new HashSet<CourseReview>();
        }
    
        public int ID { get; set; }
        public Nullable<int> TrainerID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string Name { get; set; }
        public Nullable<int> HoursCount { get; set; }
        public Nullable<int> Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Video { get; set; }
        public bool Active { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<System.DateTime> Created_At { get; set; }
        public Nullable<System.DateTime> Updated_At { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Trainer Trainer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseEnrollment> CourseEnrollments { get; set; }
        public virtual CourseMaterial CourseMaterial { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseReview> CourseReviews { get; set; }
    }
}
