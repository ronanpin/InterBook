//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InterBook2._0.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Util_Info_Entreprise
    {
        public Util_Info_Entreprise()
        {
            this.Utils = new HashSet<Util>();
        }
    
        public int id_Util_Info_Entreprise { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public string Ville { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string APE { get; set; }
        public Nullable<int> Logo { get; set; }
        public string Siret { get; set; }
        public string Siren { get; set; }
        public string SiteWeb { get; set; }
    
        public virtual ICollection<Util> Utils { get; set; }
    }
}