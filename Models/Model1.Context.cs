﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Notic_board_2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Notice_boardEntities2 : DbContext
    {
        public Notice_boardEntities2()
            : base("name=Notice_boardEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Announcment2> Announcment2 { get; set; }
        public virtual DbSet<comment> comments { get; set; }
        public virtual DbSet<Klass> Klasses { get; set; }
        public virtual DbSet<like_table> like_table { get; set; }
        public virtual DbSet<user_enrolled_in_classes2> user_enrolled_in_classes2 { get; set; }
        public virtual DbSet<user_table> user_table { get; set; }
    }
}
