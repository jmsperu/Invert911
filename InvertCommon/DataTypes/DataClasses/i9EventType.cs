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
    
    public partial class i9EventType
    {
        public i9EventType()
        {
            this.i9Event = new HashSet<i9Event>();
        }
    
        public string EventDesc { get; set; }
        public string i9EventType1 { get; set; }
    
        public virtual ICollection<i9Event> i9Event { get; set; }
    }
}
