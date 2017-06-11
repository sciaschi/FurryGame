//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tools.CrashReporter.CrashReportWebSite.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bugg
    {
        public Bugg()
        {
            this.UserGroups = new HashSet<UserGroup>();
            this.Crashes = new HashSet<Crash>();
            this.Crashes1 = new HashSet<Crash>();
        }
    
        public int Id { get; set; }
        public string TTPID { get; set; }
        public string Pattern { get; set; }
        public Nullable<int> NumberOfCrashes { get; set; }
        public Nullable<int> NumberOfUsers { get; set; }
        public Nullable<System.DateTime> TimeOfFirstCrash { get; set; }
        public Nullable<System.DateTime> TimeOfLastCrash { get; set; }
        public string Status { get; set; }
        public string FixedChangeList { get; set; }
        public Nullable<short> CrashType { get; set; }
        public string BuildVersion { get; set; }
        public Nullable<int> PatternId { get; set; }
        public Nullable<int> ErrorMessageId { get; set; }
    
        public virtual ErrorMessage ErrorMessage { get; set; }
        public virtual CallStackPattern CallStackPattern { get; set; }
        public virtual ICollection<UserGroup> UserGroups { get; set; }
        public virtual ICollection<Crash> Crashes { get; set; }
        public virtual ICollection<Crash> Crashes1 { get; set; }
    }
}
