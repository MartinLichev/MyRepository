//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tenants
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<long> IDCard { get; set; }
        public Nullable<long> UniqueCitizenshipNumber { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public Nullable<long> PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
