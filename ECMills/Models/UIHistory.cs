
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace ECMills.Models
{

using System;
    using System.Collections.Generic;
    
public partial class UIHistory
{

    public System.Guid id { get; set; }

    public System.DateTime completionTime { get; set; }

    public int taskType { get; set; }

    public int recordType { get; set; }

    public System.Guid serverid { get; set; }

    public System.Guid agentid { get; set; }

    public System.Guid databaseid { get; set; }

    public System.Guid syncgroupId { get; set; }

    public string detailEnumId { get; set; }

    public string detailStringParameters { get; set; }

    public Nullable<bool> isWritable { get; set; }

}

}
