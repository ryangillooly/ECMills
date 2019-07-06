
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
    
public partial class OrderItem
{

    public short OrderID { get; set; }

    public byte LineItem { get; set; }

    public int ItemID { get; set; }

    public byte ItemTypeID { get; set; }

    public byte ItemSubTypeID { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public decimal VAT { get; set; }

    public decimal Total { get; set; }

    public decimal Cost { get; set; }



    public virtual OrderItemSubType OrderItemSubType { get; set; }

    public virtual OrderItemType OrderItemType { get; set; }

    public virtual Order Order { get; set; }

}

}
