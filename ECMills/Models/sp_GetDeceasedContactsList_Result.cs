
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
    
public partial class sp_GetDeceasedContactsList_Result
{

    public short DeceasedID { get; set; }

    public string ContactType { get; set; }

    public string Relationship { get; set; }

    public string Name { get; set; }

    public Nullable<System.DateTime> DateOfBirth { get; set; }

    public string Occupation { get; set; }

    public string AddressLine1 { get; set; }

    public string AddressLine2 { get; set; }

    public string City { get; set; }

    public string PostCode { get; set; }

    public string Notes { get; set; }

    public bool ConsentToBeContacted { get; set; }

    public bool AccountModerator { get; set; }

}

}
