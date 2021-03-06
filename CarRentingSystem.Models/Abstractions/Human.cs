﻿namespace CarRentingSystem.Models.Concretes
{
    public abstract class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CityOfBirth { get; set; }
        public decimal IdentityNumberOfCountry { get; set; }
        public string Address { get; set; }
        public ushort LicenceNumber { get; set; }
        public string BeginningDateOfLicense { get; set; }
        public string EndingDateOfLicense { get; set; }
        public byte YearsOfLicenceUsed { get; set; }
    }
}