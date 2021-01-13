﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanceGladiatorProjectApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbproject_NEWEntities : DbContext
    {
        public dbproject_NEWEntities()
            : base("name=dbproject_NEWEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Admin> tbl_Admin { get; set; }
        public virtual DbSet<tbl_Card> tbl_Card { get; set; }
        public virtual DbSet<tbl_Customer> tbl_Customer { get; set; }
        public virtual DbSet<tbl_EMI> tbl_EMI { get; set; }
        public virtual DbSet<tbl_FAQ> tbl_FAQ { get; set; }
        public virtual DbSet<tbl_Product> tbl_Product { get; set; }
        public virtual DbSet<tbl_Transaction> tbl_Transaction { get; set; }
    
        public virtual ObjectResult<proc_ActivateCustomer_Result> proc_ActivateCustomer(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_ActivateCustomer_Result>("proc_ActivateCustomer", idParameter);
        }
    
        public virtual int proc_ActivatedCustomer(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_ActivatedCustomer", idParameter);
        }
    
        public virtual ObjectResult<proc_AdminLoginCheck_Result> proc_AdminLoginCheck(string un, string pass)
        {
            var unParameter = un != null ?
                new ObjectParameter("un", un) :
                new ObjectParameter("un", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_AdminLoginCheck_Result>("proc_AdminLoginCheck", unParameter, passParameter);
        }
    
        public virtual ObjectResult<proc_LoginCheck_Result> proc_LoginCheck(string un, string pass)
        {
            var unParameter = un != null ?
                new ObjectParameter("un", un) :
                new ObjectParameter("un", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_LoginCheck_Result>("proc_LoginCheck", unParameter, passParameter);
        }
    
        public virtual ObjectResult<proc_ActivateCard_Result> proc_ActivateCard(Nullable<int> customerId)
        {
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("customerId", customerId) :
                new ObjectParameter("customerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_ActivateCard_Result>("proc_ActivateCard", customerIdParameter);
        }
    
        public virtual ObjectResult<proc_updateCardAmountEmiPayment_Result> proc_updateCardAmountEmiPayment(Nullable<int> emi_id, Nullable<int> card_id, Nullable<decimal> amt)
        {
            var emi_idParameter = emi_id.HasValue ?
                new ObjectParameter("emi_id", emi_id) :
                new ObjectParameter("emi_id", typeof(int));
    
            var card_idParameter = card_id.HasValue ?
                new ObjectParameter("card_id", card_id) :
                new ObjectParameter("card_id", typeof(int));
    
            var amtParameter = amt.HasValue ?
                new ObjectParameter("amt", amt) :
                new ObjectParameter("amt", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_updateCardAmountEmiPayment_Result>("proc_updateCardAmountEmiPayment", emi_idParameter, card_idParameter, amtParameter);
        }
    
        public virtual ObjectResult<proc_updateCardAmountProductPurchase_Result> proc_updateCardAmountProductPurchase(Nullable<int> cardId, Nullable<int> productId, Nullable<decimal> emiPerMonth)
        {
            var cardIdParameter = cardId.HasValue ?
                new ObjectParameter("cardId", cardId) :
                new ObjectParameter("cardId", typeof(int));
    
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("productId", productId) :
                new ObjectParameter("productId", typeof(int));
    
            var emiPerMonthParameter = emiPerMonth.HasValue ?
                new ObjectParameter("emiPerMonth", emiPerMonth) :
                new ObjectParameter("emiPerMonth", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_updateCardAmountProductPurchase_Result>("proc_updateCardAmountProductPurchase", cardIdParameter, productIdParameter, emiPerMonthParameter);
        }
    }
}
