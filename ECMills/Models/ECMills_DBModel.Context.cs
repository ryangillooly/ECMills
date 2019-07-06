﻿

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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Data.Entity.Core.Objects;
using System.Linq;


public partial class ECMills_DBConnection : DbContext
{
    public ECMills_DBConnection()
        : base("name=ECMills_DBConnection")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<provision_marker_dss> provision_marker_dss { get; set; }

    public virtual DbSet<schema_info_dss> schema_info_dss { get; set; }

    public virtual DbSet<scope_config_dss> scope_config_dss { get; set; }

    public virtual DbSet<scope_info_dss> scope_info_dss { get; set; }

    public virtual DbSet<Ceremony> Ceremonies { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Coffin> Coffins { get; set; }

    public virtual DbSet<CommitallLocationType> CommitallLocationTypes { get; set; }

    public virtual DbSet<CommittalLocation> CommittalLocations { get; set; }

    public virtual DbSet<Deceased> Deceaseds { get; set; }

    public virtual DbSet<DeceasedAddressType> DeceasedAddressTypes { get; set; }

    public virtual DbSet<DeceasedContactsContactType> DeceasedContactsContactTypes { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    public virtual DbSet<MaritalStatu> MaritalStatus { get; set; }

    public virtual DbSet<Memorial> Memorials { get; set; }

    public virtual DbSet<MemorialContactPoint> MemorialContactPoints { get; set; }

    public virtual DbSet<Officiant> Officiants { get; set; }

    public virtual DbSet<OfficiantContactPoint> OfficiantContactPoints { get; set; }

    public virtual DbSet<OrderChecklist> OrderChecklists { get; set; }

    public virtual DbSet<OrderCost> OrderCosts { get; set; }

    public virtual DbSet<OrderDetail> OrderDetails { get; set; }

    public virtual DbSet<OrderItemSubType> OrderItemSubTypes { get; set; }

    public virtual DbSet<OrderItemType> OrderItemTypes { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderStatu> OrderStatus { get; set; }

    public virtual DbSet<OrderSubStatu> OrderSubStatus { get; set; }

    public virtual DbSet<OrderSubType> OrderSubTypes { get; set; }

    public virtual DbSet<OrderType> OrderTypes { get; set; }

    public virtual DbSet<Organist> Organists { get; set; }

    public virtual DbSet<Religion> Religions { get; set; }

    public virtual DbSet<ReligiousDenomination> ReligiousDenominations { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<TransportType> TransportTypes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<action> actions { get; set; }

    public virtual DbSet<agent> agents { get; set; }

    public virtual DbSet<agent_instance> agent_instance { get; set; }

    public virtual DbSet<agent_version> agent_version { get; set; }

    public virtual DbSet<configuration> configurations { get; set; }

    public virtual DbSet<EnumType> EnumTypes { get; set; }

    public virtual DbSet<MetaInformation> MetaInformations { get; set; }

    public virtual DbSet<scaleunitlimit> scaleunitlimits { get; set; }

    public virtual DbSet<ScheduleTask> ScheduleTasks { get; set; }

    public virtual DbSet<subscription> subscriptions { get; set; }

    public virtual DbSet<syncgroup> syncgroups { get; set; }

    public virtual DbSet<syncgroupmember> syncgroupmembers { get; set; }

    public virtual DbSet<SyncObjectData> SyncObjectDatas { get; set; }

    public virtual DbSet<task> tasks { get; set; }

    public virtual DbSet<userdatabase> userdatabases { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<MessageQueue> MessageQueues { get; set; }

    public virtual DbSet<MetaInformation1> MetaInformation1 { get; set; }

    public virtual DbSet<Schedule> Schedules { get; set; }

    public virtual DbSet<ScheduleTask1> ScheduleTask1 { get; set; }

    public virtual DbSet<DeceasedAddress> DeceasedAddresses { get; set; }

    public virtual DbSet<DeceasedContact> DeceasedContacts { get; set; }

    public virtual DbSet<DeceasedContactsPointOfContact> DeceasedContactsPointOfContacts { get; set; }

    public virtual DbSet<Jewellery> Jewelleries { get; set; }

    public virtual DbSet<Music> Musics { get; set; }

    public virtual DbSet<Office> Offices { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Transport> Transports { get; set; }

    public virtual DbSet<Visitor> Visitors { get; set; }

    public virtual DbSet<UIHistory> UIHistories { get; set; }

    public virtual DbSet<vw_GetDeceasedAddressList> vw_GetDeceasedAddressList { get; set; }

    public virtual DbSet<vw_GetDeceasedContactsList> vw_GetDeceasedContactsList { get; set; }

    public virtual DbSet<vw_GetDeceasedList> vw_GetDeceasedList { get; set; }

    public virtual DbSet<vw_GetDeceasedProfile> vw_GetDeceasedProfile { get; set; }

    public virtual DbSet<vw_RowCountForAllTables> vw_RowCountForAllTables { get; set; }

    public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }

    public virtual DbSet<vw_GetDeceasedContactsContactDetails> vw_GetDeceasedContactsContactDetails { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<vw_GetUserNotifications> vw_GetUserNotifications { get; set; }


    public virtual ObjectResult<sp_GetDeceasedAddressList_Result> sp_GetDeceasedAddressList(Nullable<short> deceasedID)
    {

        var deceasedIDParameter = deceasedID.HasValue ?
            new ObjectParameter("DeceasedID", deceasedID) :
            new ObjectParameter("DeceasedID", typeof(short));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetDeceasedAddressList_Result>("sp_GetDeceasedAddressList", deceasedIDParameter);
    }


    public virtual ObjectResult<sp_GetDeceasedContactsList_Result> sp_GetDeceasedContactsList(Nullable<short> deceasedID)
    {

        var deceasedIDParameter = deceasedID.HasValue ?
            new ObjectParameter("DeceasedID", deceasedID) :
            new ObjectParameter("DeceasedID", typeof(short));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetDeceasedContactsList_Result>("sp_GetDeceasedContactsList", deceasedIDParameter);
    }


    public virtual ObjectResult<sp_GetDeceasedList_Result> sp_GetDeceasedList()
    {

        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetDeceasedList_Result>("sp_GetDeceasedList");
    }


    public virtual ObjectResult<sp_GetDeceasedProfile_Result> sp_GetDeceasedProfile(Nullable<short> deceasedID)
    {

        var deceasedIDParameter = deceasedID.HasValue ?
            new ObjectParameter("DeceasedID", deceasedID) :
            new ObjectParameter("DeceasedID", typeof(short));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetDeceasedProfile_Result>("sp_GetDeceasedProfile", deceasedIDParameter);
    }


    public virtual ObjectResult<sp_GetDeceasedContactsContactDetails_Result> sp_GetDeceasedContactsContactDetails(Nullable<short> deceasedID)
    {

        var deceasedIDParameter = deceasedID.HasValue ?
            new ObjectParameter("DeceasedID", deceasedID) :
            new ObjectParameter("DeceasedID", typeof(short));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetDeceasedContactsContactDetails_Result>("sp_GetDeceasedContactsContactDetails", deceasedIDParameter);
    }


    public virtual ObjectResult<sp_GetUserNotifications_Result> sp_GetUserNotifications(Nullable<short> userID)
    {

        var userIDParameter = userID.HasValue ?
            new ObjectParameter("UserID", userID) :
            new ObjectParameter("UserID", typeof(short));


        return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetUserNotifications_Result>("sp_GetUserNotifications", userIDParameter);
    }

}

}

