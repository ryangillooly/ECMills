
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
    
public partial class subscription
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public subscription()
    {

        this.agents = new HashSet<agent>();

        this.syncgroups = new HashSet<syncgroup>();

        this.userdatabases = new HashSet<userdatabase>();

    }


    public System.Guid id { get; set; }

    public string name { get; set; }

    public Nullable<System.DateTime> creationtime { get; set; }

    public Nullable<System.DateTime> lastlogintime { get; set; }

    public int tombstoneretentionperiodindays { get; set; }

    public Nullable<int> policyid { get; set; }

    public byte subscriptionstate { get; set; }

    public Nullable<System.Guid> WindowsAzureSubscriptionId { get; set; }

    public Nullable<bool> EnableDetailedProviderTracing { get; set; }

    public string syncserveruniquename { get; set; }

    public string version { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<agent> agents { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<syncgroup> syncgroups { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<userdatabase> userdatabases { get; set; }

}

}
