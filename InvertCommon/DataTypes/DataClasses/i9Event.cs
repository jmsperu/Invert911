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
    
    public partial class i9Event
    {
        public i9Event()
        {
            this.i9Arrest = new HashSet<i9Arrest>();
            this.i9Attachment = new HashSet<i9Attachment>();
            this.i9AttachmentData = new HashSet<i9AttachmentData>();
            this.i9AttachmentLink = new HashSet<i9AttachmentLink>();
            this.i9AVLEvent = new HashSet<i9AVLEvent>();
            this.i9CADServiceCall = new HashSet<i9CADServiceCall>();
            this.i9Citation = new HashSet<i9Citation>();
            this.i9FieldContact = new HashSet<i9FieldContact>();
            this.i9Gang = new HashSet<i9Gang>();
            this.i9LawIncident = new HashSet<i9LawIncident>();
            this.i9Location = new HashSet<i9Location>();
            this.i9Narrative = new HashSet<i9Narrative>();
            this.i9Organization = new HashSet<i9Organization>();
            this.i9Pawn = new HashSet<i9Pawn>();
            this.i9Person = new HashSet<i9Person>();
            this.i9PersonSMT = new HashSet<i9PersonSMT>();
            this.i9Property = new HashSet<i9Property>();
            this.i9RelatedRecord = new HashSet<i9RelatedRecord>();
            this.i9Structure = new HashSet<i9Structure>();
            this.i9Vehicle = new HashSet<i9Vehicle>();
            this.i9VehicleRecovery = new HashSet<i9VehicleRecovery>();
            this.i9VehicleTowed = new HashSet<i9VehicleTowed>();
            this.i9Warrant = new HashSet<i9Warrant>();
        }
    
        public string i9EventType { get; set; }
        public System.Guid i9EventID { get; set; }
        public System.Guid i9AgencyID { get; set; }
    
        public virtual i9Agency i9Agency { get; set; }
        public virtual ICollection<i9Arrest> i9Arrest { get; set; }
        public virtual ICollection<i9Attachment> i9Attachment { get; set; }
        public virtual ICollection<i9AttachmentData> i9AttachmentData { get; set; }
        public virtual ICollection<i9AttachmentLink> i9AttachmentLink { get; set; }
        public virtual ICollection<i9AVLEvent> i9AVLEvent { get; set; }
        public virtual ICollection<i9CADServiceCall> i9CADServiceCall { get; set; }
        public virtual ICollection<i9Citation> i9Citation { get; set; }
        public virtual i9EventType i9EventType1 { get; set; }
        public virtual ICollection<i9FieldContact> i9FieldContact { get; set; }
        public virtual ICollection<i9Gang> i9Gang { get; set; }
        public virtual ICollection<i9LawIncident> i9LawIncident { get; set; }
        public virtual ICollection<i9Location> i9Location { get; set; }
        public virtual ICollection<i9Narrative> i9Narrative { get; set; }
        public virtual ICollection<i9Organization> i9Organization { get; set; }
        public virtual ICollection<i9Pawn> i9Pawn { get; set; }
        public virtual ICollection<i9Person> i9Person { get; set; }
        public virtual ICollection<i9PersonSMT> i9PersonSMT { get; set; }
        public virtual ICollection<i9Property> i9Property { get; set; }
        public virtual ICollection<i9RelatedRecord> i9RelatedRecord { get; set; }
        public virtual ICollection<i9Structure> i9Structure { get; set; }
        public virtual ICollection<i9Vehicle> i9Vehicle { get; set; }
        public virtual ICollection<i9VehicleRecovery> i9VehicleRecovery { get; set; }
        public virtual ICollection<i9VehicleTowed> i9VehicleTowed { get; set; }
        public virtual ICollection<i9Warrant> i9Warrant { get; set; }
    }
}