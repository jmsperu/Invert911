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
    
    public partial class i9Offense
    {
        public string ActivityCategory { get; set; }
        public string OffenseCode { get; set; }
        public string OffenseText { get; set; }
        public string OffenseDescriptionText { get; set; }
        public string OffenseViolatedStatuteNumber { get; set; }
        public string OffenseViolatedStatuteDescription { get; set; }
        public string OffenseAttemptedCompletedCode { get; set; }
        public string OffenseBiasMotivationCode { get; set; }
        public string OffenseBiasMotivationText { get; set; }
        public string OffenseBiasMotivationCauseCode { get; set; }
        public string OffenseBiasMotivationCauseText { get; set; }
        public string OffenseNumberofPremisesEntered { get; set; }
        public string OffenseForcedEntryCode { get; set; }
        public string OffensePointofEntryCode { get; set; }
        public string OffensePointofEntryText { get; set; }
        public string OffenseMethodofEntryCode { get; set; }
        public string OffenseMethodofEntryText { get; set; }
        public string OffenseSecurityTypeEntryCode { get; set; }
        public string OffenseSecurityTypeEntryText { get; set; }
        public string OffenseSecuritySystemsStatusEntryCode { get; set; }
        public string OffenseForcedExitCode { get; set; }
        public string OffensePointofExitCode { get; set; }
        public string OffensePointofExitText { get; set; }
        public string OffenseMethodofExitCode { get; set; }
        public string OffenseMethodofExitText { get; set; }
        public string OffenseSecurityTypeExitCode { get; set; }
        public string OffenseSecurityTypeExitText { get; set; }
        public string OffenseSecuritySystemsStatusExitCode { get; set; }
        public string OffenseLocation { get; set; }
        public string OffenseCriminalActivityCode { get; set; }
        public string OffenseCriminalActivityText { get; set; }
        public string OffenseForceUsedCode { get; set; }
        public string OffenseForceUsedText { get; set; }
        public string OffenseWeapon { get; set; }
        public System.Guid i9OffenseID { get; set; }
        public System.Guid i9LawIncidentID { get; set; }
    
        public virtual i9LawIncident i9LawIncident { get; set; }
    }
}
