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
    
    public partial class Util_Postal
    {
        public Util_Postal()
        {
            this.Utils = new HashSet<Util>();
        }
    
        public int idu_Postal { get; set; }
        public Nullable<int> id_Civilite { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adresse1 { get; set; }
        public string adresse2 { get; set; }
        public string cp { get; set; }
        public Nullable<int> id_Ville { get; set; }
        public Nullable<int> id_Pays { get; set; }
        public Nullable<System.DateTime> dCrea { get; set; }
    
        public virtual Ref_Pays Ref_Pays { get; set; }
        public virtual Ref_Ville Ref_Ville { get; set; }
        public virtual ICollection<Util> Utils { get; set; }
    }
}
