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
    
    public partial class Ref_Mailing
    {
        public Ref_Mailing()
        {
            this.UE_envoi = new HashSet<UE_envoi>();
            this.Util_Consentement = new HashSet<Util_Consentement>();
        }
    
        public int id_Mailing { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<UE_envoi> UE_envoi { get; set; }
        public virtual ICollection<Util_Consentement> Util_Consentement { get; set; }
    }
}
