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
    
    public partial class i9AttachmentData
    {
        public byte[] Data { get; set; }
        public System.Guid i9AttachmentDataID { get; set; }
        public System.Guid i9AttachmentID { get; set; }
        public System.Guid i9EventID { get; set; }
    
        public virtual i9Attachment i9Attachment { get; set; }
        public virtual i9Event i9Event { get; set; }
    }
}
