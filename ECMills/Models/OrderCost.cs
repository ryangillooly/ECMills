
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
    
public partial class OrderCost
{

    public short OrderID { get; set; }

    public Nullable<decimal> Cars { get; set; }

    public Nullable<decimal> DeceasedRemoval { get; set; }

    public Nullable<decimal> Estimated { get; set; }

    public Nullable<decimal> Other { get; set; }

    public Nullable<decimal> Sup { get; set; }

    public Nullable<decimal> Total { get; set; }



    public virtual Order Order { get; set; }

}

}
