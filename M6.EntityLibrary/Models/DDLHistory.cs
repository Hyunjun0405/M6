//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace M6.EntityLibrary.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DDLHistory
    {
        public int ID { get; set; }
        public string EventType { get; set; }
        public Nullable<System.DateTime> PostTime { get; set; }
        public string LoginName { get; set; }
        public string UserName { get; set; }
        public string HostName { get; set; }
        public string DatabaseName { get; set; }
        public string SchemaName { get; set; }
        public string ObjectName { get; set; }
        public string ObjectType { get; set; }
        public string CommandText { get; set; }
    }
}
