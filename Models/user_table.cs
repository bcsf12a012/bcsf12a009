//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class user_table
    {
        public user_table()
        {
            this.Announcment2 = new HashSet<Announcment2>();
            this.comments = new HashSet<comment>();
            this.like_table = new HashSet<like_table>();
            this.user_enrolled_in_classes2 = new HashSet<user_enrolled_in_classes2>();
        }
    
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string User_name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Roll_no { get; set; }
        public string ImageUrl { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual ICollection<Announcment2> Announcment2 { get; set; }
        public virtual ICollection<comment> comments { get; set; }
        public virtual ICollection<like_table> like_table { get; set; }
        public virtual ICollection<user_enrolled_in_classes2> user_enrolled_in_classes2 { get; set; }
    }
}
