//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace $safeprojectname$
{
    using System;
    using System.Collections.Generic;
    
    public partial class SecurityQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SecurityQuestion()
        {
            this.UserSecurityQuestionAndAnswers = new HashSet<UserSecurityQuestionAndAnswer>();
        }
    
        public int Id { get; set; }
        public string Text { get; set; }
        public bool SystemDefault { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserSecurityQuestionAndAnswer> UserSecurityQuestionAndAnswers { get; set; }
    }
}
