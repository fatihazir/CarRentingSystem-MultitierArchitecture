//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentingSystem.DataAccess.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Managers
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CityOfBirth { get; set; }
        public decimal IdentityNumberOfCountry { get; set; }
        public string Address { get; set; }
        public string BeginningDateOfLicense { get; set; }
        public string EndingDateOfLicense { get; set; }
        public byte YearsOfLicenceUsed { get; set; }
    
        public virtual Companies Companies { get; set; }
    }
}
