﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShowData.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class QuaestorClickItSharedEntities1 : DbContext
    {
        public QuaestorClickItSharedEntities1()
            : base("name=QuaestorClickItSharedEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<Get_Mn_Info_Result> Get_Mn_Info(string tx_id)
        {
            var tx_idParameter = tx_id != null ?
                new ObjectParameter("tx_id", tx_id) :
                new ObjectParameter("tx_id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get_Mn_Info_Result>("Get_Mn_Info", tx_idParameter);
        }
    }
}
