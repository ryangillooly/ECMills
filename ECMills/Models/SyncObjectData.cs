
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
    
public partial class SyncObjectData
{

    public System.Guid ObjectId { get; set; }

    public int DataType { get; set; }

    public System.DateTime CreatedTime { get; set; }

    public Nullable<System.DateTime> DroppedTime { get; set; }

    public byte[] LastModified { get; set; }

    public byte[] ObjectData { get; set; }

}

}
