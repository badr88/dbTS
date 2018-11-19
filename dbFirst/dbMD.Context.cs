﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dbFirst
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TESTEntities : DbContext
    {
        public TESTEntities()
            : base("name=TESTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<ZKLC_CustomerCards> ZKLC_CustomerCards { get; set; }
        public virtual DbSet<ZKLC_Customers> ZKLC_Customers { get; set; }
        public virtual DbSet<ZKLC_RequestLogs> ZKLC_RequestLogs { get; set; }
        public virtual DbSet<ZKLC_Transfers> ZKLC_Transfers { get; set; }
    
        [DbFunction("TESTEntities", "GetSysTabs")]
        public virtual IQueryable<GetSysTabs_Result> GetSysTabs(Nullable<int> schID, string type)
        {
            var schIDParameter = schID.HasValue ?
                new ObjectParameter("schID", schID) :
                new ObjectParameter("schID", typeof(int));
    
            var typeParameter = type != null ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetSysTabs_Result>("[TESTEntities].[GetSysTabs](@schID, @type)", schIDParameter, typeParameter);
        }
    
        public virtual ObjectResult<ZKLC_SetTransfer_Result> ZKLC_SetTransfer(string cardN, string fIO, Nullable<decimal> amount, string comments, Nullable<int> sts, string rUrl, string rIP)
        {
            var cardNParameter = cardN != null ?
                new ObjectParameter("cardN", cardN) :
                new ObjectParameter("cardN", typeof(string));
    
            var fIOParameter = fIO != null ?
                new ObjectParameter("FIO", fIO) :
                new ObjectParameter("FIO", typeof(string));
    
            var amountParameter = amount.HasValue ?
                new ObjectParameter("amount", amount) :
                new ObjectParameter("amount", typeof(decimal));
    
            var commentsParameter = comments != null ?
                new ObjectParameter("comments", comments) :
                new ObjectParameter("comments", typeof(string));
    
            var stsParameter = sts.HasValue ?
                new ObjectParameter("sts", sts) :
                new ObjectParameter("sts", typeof(int));
    
            var rUrlParameter = rUrl != null ?
                new ObjectParameter("rUrl", rUrl) :
                new ObjectParameter("rUrl", typeof(string));
    
            var rIPParameter = rIP != null ?
                new ObjectParameter("rIP", rIP) :
                new ObjectParameter("rIP", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ZKLC_SetTransfer_Result>("ZKLC_SetTransfer", cardNParameter, fIOParameter, amountParameter, commentsParameter, stsParameter, rUrlParameter, rIPParameter);
        }
    }
}
