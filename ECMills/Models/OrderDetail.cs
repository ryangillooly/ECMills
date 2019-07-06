
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
    
public partial class OrderDetail
{

    public short OrderID { get; set; }

    public bool IsContract { get; set; }

    public bool BearersRequired { get; set; }

    public bool Removed { get; set; }

    public string AshesNotes { get; set; }

    public string GraveNotes { get; set; }

    public string JewelleryNotes { get; set; }

    public string MinisterInfo { get; set; }

    public string MinisterTransport { get; set; }

    public byte CoffinID { get; set; }

    public string CoffinNotes { get; set; }

    public string CoffinLength { get; set; }

    public string CoffinWidth { get; set; }

    public string CoffinDepth { get; set; }

    public bool EmbalmingRequired { get; set; }

    public bool EmbalmingPermissionObtained { get; set; }

    public bool PostMortemComplete { get; set; }

    public System.DateTime JewelleryDateCollected { get; set; }

    public string JewelleryWhoCollected { get; set; }

    public System.DateTime JewelleryDateRemoved { get; set; }

    public string JewelleryWhoRemoved { get; set; }

    public string GraveNo { get; set; }



    public virtual Coffin Coffin { get; set; }

    public virtual Order Order { get; set; }

}

}
