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
    
    public partial class comment
    {
        public int Id { get; set; }
        public Nullable<int> anouncment_id { get; set; }
        public Nullable<int> user_id { get; set; }
        public string description { get; set; }
        public string User_pic { get; set; }
    
        public virtual user_table user_table { get; set; }
    }
}
