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
    
    public partial class i9PersonArrestee
    {
        public string Arrestee { get; set; }
        public string CountCode { get; set; }
        public string JuvenileDispositionCode { get; set; }
        public string ArresteeWeapon { get; set; }
        public long OffenseID { get; set; }
        public string ArresteeViolatedStatuteNumber { get; set; }
        public string ArresteeViolatedStatuteDescription { get; set; }
        public string ArresteeSequenceNumber { get; set; }
        public System.Guid i9PersonArresteeID { get; set; }
        public System.Guid i9PersonID { get; set; }
    
        public virtual i9Person i9Person { get; set; }
    }
}
