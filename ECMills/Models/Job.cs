
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
    
public partial class Job
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Job()
    {

        this.MessageQueues = new HashSet<MessageQueue>();

    }


    public System.Guid JobId { get; set; }

    public bool IsCancelled { get; set; }

    public System.DateTime InitialInsertTimeUTC { get; set; }

    public int JobType { get; set; }

    public string InputData { get; set; }

    public int TaskCount { get; set; }

    public int CompletedTaskCount { get; set; }

    public Nullable<System.Guid> TracingId { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<MessageQueue> MessageQueues { get; set; }

}

}
