//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PolicyM
    {
        public int IdPolicy { get; set; }
        public string TypePolicy { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Start { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }
        public string TypeRisk { get; set; }
        public Nullable<bool> Active { get; set; }
        public string UserCreate { get; set; }
        public System.DateTime DateCreate { get; set; }
    }
}