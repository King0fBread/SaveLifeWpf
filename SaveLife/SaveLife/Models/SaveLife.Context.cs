﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaveLife.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SaveLifeDBEntities : DbContext
    {
        private static SaveLifeDBEntities _context;
        public static SaveLifeDBEntities GetContext()
        {
            if(_context == null)
            {
                _context = new SaveLifeDBEntities();
            }
            return _context;
        }
        public SaveLifeDBEntities()
            : base("name=SaveLifeDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<SalesHistory> SalesHistories { get; set; }
    }
}
