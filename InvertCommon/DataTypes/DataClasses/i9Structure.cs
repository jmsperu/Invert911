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
    
    public partial class i9Structure
    {
        public string StructureTypeCode { get; set; }
        public string StructureTypeText { get; set; }
        public string StructureOccupiedCode { get; set; }
        public string StructureOccupiedText { get; set; }
        public System.Guid i9StructureID { get; set; }
        public System.Guid i9EventID { get; set; }
    
        public virtual i9Event i9Event { get; set; }
    }
}
