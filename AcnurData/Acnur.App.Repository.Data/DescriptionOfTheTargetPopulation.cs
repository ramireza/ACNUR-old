//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Acnur.App.Repository.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class DescriptionOfTheTargetPopulation
    {
        public int IdDescriptionOfTheTargetPopulation { get; set; }
        public int IdDataProject { get; set; }
        public int IdTypeBeneficiaries { get; set; }
        public int IdTypePopulation { get; set; }
        public int WomenBetween0And4 { get; set; }
        public int WomenBetween5And11 { get; set; }
        public int WomenBetween12And17 { get; set; }
        public int WomenBetween18And59 { get; set; }
        public int WomenBetween60AndMore { get; set; }
        public int MenBetween0And4 { get; set; }
        public int MenBetween5And11 { get; set; }
        public int MenBetween12And17 { get; set; }
        public int MenBetween18And59 { get; set; }
        public int MenBetween60AndMore { get; set; }
        public int TotalFamilies { get; set; }
        public int TotalPeople { get; set; }
        public Nullable<int> TotalCivilServant { get; set; }
        public string NarrativeDescriptionOfTheDirectBeneficiaries { get; set; }
    }
}