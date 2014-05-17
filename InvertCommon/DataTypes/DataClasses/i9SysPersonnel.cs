//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Invert911.InvertCommon.DataTypes.DataClasses
{
    using System;
    using System.Collections.Generic;
    
    public partial class i9SysPersonnel
    {
        public i9SysPersonnel()
        {
            this.i9SysPersonnelAddress = new HashSet<i9SysPersonnelAddress>();
            this.i9SysPersonnelAssignment = new HashSet<i9SysPersonnelAssignment>();
            this.i9SysPersonnelPhone = new HashSet<i9SysPersonnelPhone>();
        }
    
        public string Officer { get; set; }
        public string OfficerActivityTypeCode { get; set; }
        public string OfficerActivityTypeText { get; set; }
        public string OfficerAssignmentTypeCode { get; set; }
        public string OfficerAssignmentTypeText { get; set; }
        public string OfficerLEOKATypeCode { get; set; }
        public string OfficerORI { get; set; }
        public string BadgeNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Password { get; set; }
        public Nullable<bool> Enabled { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public System.Guid i9SysPersonnelID { get; set; }
        public System.Guid i9AgencyID { get; set; }
        public string Email { get; set; }
        public System.DateTime DateTimeInserted { get; set; }
        public System.DateTime DateTimeUpdated { get; set; }
        public Nullable<System.Guid> ActivationGuid { get; set; }
    
        public virtual i9Agency i9Agency { get; set; }
        public virtual ICollection<i9SysPersonnelAddress> i9SysPersonnelAddress { get; set; }
        public virtual ICollection<i9SysPersonnelAssignment> i9SysPersonnelAssignment { get; set; }
        public virtual ICollection<i9SysPersonnelPhone> i9SysPersonnelPhone { get; set; }
    }
}
