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
    
    public partial class Ref_Culture
    {
        public Ref_Culture()
        {
            this.Ref_Pays = new HashSet<Ref_Pays>();
            this.Ref_Declinaison_Culture = new HashSet<Ref_Declinaison_Culture>();
        }
    
        public int id_Culture { get; set; }
        public string description { get; set; }
    
        public virtual ICollection<Ref_Pays> Ref_Pays { get; set; }
        public virtual ICollection<Ref_Declinaison_Culture> Ref_Declinaison_Culture { get; set; }
    }
}
