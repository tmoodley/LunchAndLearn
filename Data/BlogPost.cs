//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Post { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<int> UpdateBy { get; set; }
    }
}
