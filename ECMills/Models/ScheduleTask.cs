
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
    
public partial class ScheduleTask
{

    public System.Guid Id { get; set; }

    public System.Guid SyncGroupId { get; set; }

    public long Interval { get; set; }

    public System.DateTime LastUpdate { get; set; }

    public byte State { get; set; }

    public Nullable<System.DateTime> ExpirationTime { get; set; }

    public Nullable<System.Guid> PopReceipt { get; set; }

    public byte DequeueCount { get; set; }

    public int Type { get; set; }



    public virtual syncgroup syncgroup { get; set; }

}

}
