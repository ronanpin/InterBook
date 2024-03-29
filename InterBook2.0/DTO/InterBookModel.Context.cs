﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class InterBookEntities : DbContext
    {
        public InterBookEntities()
            : base("name=InterBookEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ref_Profession> Ref_Profession { get; set; }
        public virtual DbSet<Util> Utils { get; set; }
        public virtual DbSet<Util_Profession> Util_Profession { get; set; }
        public virtual DbSet<Ref_Contrat> Ref_Contrat { get; set; }
        public virtual DbSet<Ref_Experience> Ref_Experience { get; set; }
        public virtual DbSet<Util_Contrat> Util_Contrat { get; set; }
        public virtual DbSet<Util_Experience> Util_Experience { get; set; }
        public virtual DbSet<Ref_Culture> Ref_Culture { get; set; }
        public virtual DbSet<Ref_Pays> Ref_Pays { get; set; }
        public virtual DbSet<Util_Email> Util_Email { get; set; }
        public virtual DbSet<Util_Dispo> Util_Dispo { get; set; }
        public virtual DbSet<Ref_Mailing> Ref_Mailing { get; set; }
        public virtual DbSet<Ref_TypeConsentement> Ref_TypeConsentement { get; set; }
        public virtual DbSet<UE_envoi> UE_envoi { get; set; }
        public virtual DbSet<Util_Consentement> Util_Consentement { get; set; }
        public virtual DbSet<Ref_Departement> Ref_Departement { get; set; }
        public virtual DbSet<Ref_Region> Ref_Region { get; set; }
        public virtual DbSet<Ref_Dispo> Ref_Dispo { get; set; }
        public virtual DbSet<Ref_Ville> Ref_Ville { get; set; }
        public virtual DbSet<Util_Postal> Util_Postal { get; set; }
        public virtual DbSet<Util_Info> Util_Info { get; set; }
        public virtual DbSet<Util_Message> Util_Message { get; set; }
        public virtual DbSet<Util_Contact> Util_Contact { get; set; }
        public virtual DbSet<Util_Geo> Util_Geo { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Util_Favoris> Util_Favoris { get; set; }
        public virtual DbSet<Ref_EtatReservation> Ref_EtatReservation { get; set; }
        public virtual DbSet<Ref_Declinaison_Culture> Ref_Declinaison_Culture { get; set; }
        public virtual DbSet<Ref_Domaine> Ref_Domaine { get; set; }
        public virtual DbSet<Ref_From> Ref_From { get; set; }
        public virtual DbSet<Util_Info_Entreprise> Util_Info_Entreprise { get; set; }
        public virtual DbSet<Abonnement> Abonnements { get; set; }
        public virtual DbSet<Util_Android> Util_Android { get; set; }
    
        public virtual ObjectResult<Util> SearchByVilleProfession(string ville, string profession)
        {
            var villeParameter = ville != null ?
                new ObjectParameter("ville", ville) :
                new ObjectParameter("ville", typeof(string));
    
            var professionParameter = profession != null ?
                new ObjectParameter("profession", profession) :
                new ObjectParameter("profession", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Util>("SearchByVilleProfession", villeParameter, professionParameter);
        }
    
        public virtual ObjectResult<Util> SearchByVilleProfession(string ville, string profession, MergeOption mergeOption)
        {
            var villeParameter = ville != null ?
                new ObjectParameter("ville", ville) :
                new ObjectParameter("ville", typeof(string));
    
            var professionParameter = profession != null ?
                new ObjectParameter("profession", profession) :
                new ObjectParameter("profession", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Util>("SearchByVilleProfession", mergeOption, villeParameter, professionParameter);
        }
    
        public virtual ObjectResult<Util> SearchByVilleProfessionExperienceContrat(string ville, string profession, string experience, string contrat)
        {
            var villeParameter = ville != null ?
                new ObjectParameter("ville", ville) :
                new ObjectParameter("ville", typeof(string));
    
            var professionParameter = profession != null ?
                new ObjectParameter("profession", profession) :
                new ObjectParameter("profession", typeof(string));
    
            var experienceParameter = experience != null ?
                new ObjectParameter("experience", experience) :
                new ObjectParameter("experience", typeof(string));
    
            var contratParameter = contrat != null ?
                new ObjectParameter("contrat", contrat) :
                new ObjectParameter("contrat", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Util>("SearchByVilleProfessionExperienceContrat", villeParameter, professionParameter, experienceParameter, contratParameter);
        }
    
        public virtual ObjectResult<Util> SearchByVilleProfessionExperienceContrat(string ville, string profession, string experience, string contrat, MergeOption mergeOption)
        {
            var villeParameter = ville != null ?
                new ObjectParameter("ville", ville) :
                new ObjectParameter("ville", typeof(string));
    
            var professionParameter = profession != null ?
                new ObjectParameter("profession", profession) :
                new ObjectParameter("profession", typeof(string));
    
            var experienceParameter = experience != null ?
                new ObjectParameter("experience", experience) :
                new ObjectParameter("experience", typeof(string));
    
            var contratParameter = contrat != null ?
                new ObjectParameter("contrat", contrat) :
                new ObjectParameter("contrat", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Util>("SearchByVilleProfessionExperienceContrat", mergeOption, villeParameter, professionParameter, experienceParameter, contratParameter);
        }
    
        public virtual ObjectResult<Util_Email> SetUtilEmail(string email)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Util_Email>("SetUtilEmail", emailParameter);
        }
    
        public virtual ObjectResult<Util_Email> SetUtilEmail(string email, MergeOption mergeOption)
        {
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Util_Email>("SetUtilEmail", mergeOption, emailParameter);
        }
    
        public virtual ObjectResult<Util_Dispo> GetUtilDispoByIdrdIdu(Nullable<int> idu)
        {
            var iduParameter = idu.HasValue ?
                new ObjectParameter("idu", idu) :
                new ObjectParameter("idu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Util_Dispo>("GetUtilDispoByIdrdIdu", iduParameter);
        }
    
        public virtual ObjectResult<Util_Dispo> GetUtilDispoByIdrdIdu(Nullable<int> idu, MergeOption mergeOption)
        {
            var iduParameter = idu.HasValue ?
                new ObjectParameter("idu", idu) :
                new ObjectParameter("idu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Util_Dispo>("GetUtilDispoByIdrdIdu", mergeOption, iduParameter);
        }
    
        public virtual ObjectResult<Util> GetVilleByCentreDistance(Nullable<double> longitude, Nullable<double> latitude, Nullable<int> distance, Nullable<System.DateTime> dateDebut, Nullable<System.DateTime> dateFin)
        {
            var longitudeParameter = longitude.HasValue ?
                new ObjectParameter("longitude", longitude) :
                new ObjectParameter("longitude", typeof(double));
    
            var latitudeParameter = latitude.HasValue ?
                new ObjectParameter("latitude", latitude) :
                new ObjectParameter("latitude", typeof(double));
    
            var distanceParameter = distance.HasValue ?
                new ObjectParameter("distance", distance) :
                new ObjectParameter("distance", typeof(int));
    
            var dateDebutParameter = dateDebut.HasValue ?
                new ObjectParameter("dateDebut", dateDebut) :
                new ObjectParameter("dateDebut", typeof(System.DateTime));
    
            var dateFinParameter = dateFin.HasValue ?
                new ObjectParameter("dateFin", dateFin) :
                new ObjectParameter("dateFin", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Util>("GetVilleByCentreDistance", longitudeParameter, latitudeParameter, distanceParameter, dateDebutParameter, dateFinParameter);
        }
    
        public virtual ObjectResult<Util> GetVilleByCentreDistance(Nullable<double> longitude, Nullable<double> latitude, Nullable<int> distance, Nullable<System.DateTime> dateDebut, Nullable<System.DateTime> dateFin, MergeOption mergeOption)
        {
            var longitudeParameter = longitude.HasValue ?
                new ObjectParameter("longitude", longitude) :
                new ObjectParameter("longitude", typeof(double));
    
            var latitudeParameter = latitude.HasValue ?
                new ObjectParameter("latitude", latitude) :
                new ObjectParameter("latitude", typeof(double));
    
            var distanceParameter = distance.HasValue ?
                new ObjectParameter("distance", distance) :
                new ObjectParameter("distance", typeof(int));
    
            var dateDebutParameter = dateDebut.HasValue ?
                new ObjectParameter("dateDebut", dateDebut) :
                new ObjectParameter("dateDebut", typeof(System.DateTime));
    
            var dateFinParameter = dateFin.HasValue ?
                new ObjectParameter("dateFin", dateFin) :
                new ObjectParameter("dateFin", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Util>("GetVilleByCentreDistance", mergeOption, longitudeParameter, latitudeParameter, distanceParameter, dateDebutParameter, dateFinParameter);
        }
    
        public virtual ObjectResult<Util> GetUtilSearchByLongLatIddepRayonDate(Nullable<double> longitude, Nullable<double> latitude, string idDepartement, Nullable<int> distance, Nullable<System.DateTime> dateDebut, Nullable<System.DateTime> dateFin)
        {
            var longitudeParameter = longitude.HasValue ?
                new ObjectParameter("longitude", longitude) :
                new ObjectParameter("longitude", typeof(double));
    
            var latitudeParameter = latitude.HasValue ?
                new ObjectParameter("latitude", latitude) :
                new ObjectParameter("latitude", typeof(double));
    
            var idDepartementParameter = idDepartement != null ?
                new ObjectParameter("idDepartement", idDepartement) :
                new ObjectParameter("idDepartement", typeof(string));
    
            var distanceParameter = distance.HasValue ?
                new ObjectParameter("distance", distance) :
                new ObjectParameter("distance", typeof(int));
    
            var dateDebutParameter = dateDebut.HasValue ?
                new ObjectParameter("dateDebut", dateDebut) :
                new ObjectParameter("dateDebut", typeof(System.DateTime));
    
            var dateFinParameter = dateFin.HasValue ?
                new ObjectParameter("dateFin", dateFin) :
                new ObjectParameter("dateFin", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Util>("GetUtilSearchByLongLatIddepRayonDate", longitudeParameter, latitudeParameter, idDepartementParameter, distanceParameter, dateDebutParameter, dateFinParameter);
        }
    
        public virtual ObjectResult<Util> GetUtilSearchByLongLatIddepRayonDate(Nullable<double> longitude, Nullable<double> latitude, string idDepartement, Nullable<int> distance, Nullable<System.DateTime> dateDebut, Nullable<System.DateTime> dateFin, MergeOption mergeOption)
        {
            var longitudeParameter = longitude.HasValue ?
                new ObjectParameter("longitude", longitude) :
                new ObjectParameter("longitude", typeof(double));
    
            var latitudeParameter = latitude.HasValue ?
                new ObjectParameter("latitude", latitude) :
                new ObjectParameter("latitude", typeof(double));
    
            var idDepartementParameter = idDepartement != null ?
                new ObjectParameter("idDepartement", idDepartement) :
                new ObjectParameter("idDepartement", typeof(string));
    
            var distanceParameter = distance.HasValue ?
                new ObjectParameter("distance", distance) :
                new ObjectParameter("distance", typeof(int));
    
            var dateDebutParameter = dateDebut.HasValue ?
                new ObjectParameter("dateDebut", dateDebut) :
                new ObjectParameter("dateDebut", typeof(System.DateTime));
    
            var dateFinParameter = dateFin.HasValue ?
                new ObjectParameter("dateFin", dateFin) :
                new ObjectParameter("dateFin", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Util>("GetUtilSearchByLongLatIddepRayonDate", mergeOption, longitudeParameter, latitudeParameter, idDepartementParameter, distanceParameter, dateDebutParameter, dateFinParameter);
        }
    
        public virtual ObjectResult<Ref_Ville> RefVilleByNom(string debut)
        {
            var debutParameter = debut != null ?
                new ObjectParameter("debut", debut) :
                new ObjectParameter("debut", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Ref_Ville>("RefVilleByNom", debutParameter);
        }
    
        public virtual ObjectResult<Ref_Ville> RefVilleByNom(string debut, MergeOption mergeOption)
        {
            var debutParameter = debut != null ?
                new ObjectParameter("debut", debut) :
                new ObjectParameter("debut", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Ref_Ville>("RefVilleByNom", mergeOption, debutParameter);
        }
    
        public virtual ObjectResult<SetReservation_Result> SetReservation(Nullable<int> idU, Nullable<int> idUEntreprise, Nullable<System.DateTime> debut, Nullable<System.DateTime> fin, Nullable<int> etatDemande)
        {
            var idUParameter = idU.HasValue ?
                new ObjectParameter("idU", idU) :
                new ObjectParameter("idU", typeof(int));
    
            var idUEntrepriseParameter = idUEntreprise.HasValue ?
                new ObjectParameter("idUEntreprise", idUEntreprise) :
                new ObjectParameter("idUEntreprise", typeof(int));
    
            var debutParameter = debut.HasValue ?
                new ObjectParameter("debut", debut) :
                new ObjectParameter("debut", typeof(System.DateTime));
    
            var finParameter = fin.HasValue ?
                new ObjectParameter("fin", fin) :
                new ObjectParameter("fin", typeof(System.DateTime));
    
            var etatDemandeParameter = etatDemande.HasValue ?
                new ObjectParameter("etatDemande", etatDemande) :
                new ObjectParameter("etatDemande", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SetReservation_Result>("SetReservation", idUParameter, idUEntrepriseParameter, debutParameter, finParameter, etatDemandeParameter);
        }
    
        public virtual ObjectResult<SetUtilFavoris_Result> SetUtilFavoris(Nullable<int> idU, Nullable<int> idUEntreprise)
        {
            var idUParameter = idU.HasValue ?
                new ObjectParameter("idU", idU) :
                new ObjectParameter("idU", typeof(int));
    
            var idUEntrepriseParameter = idUEntreprise.HasValue ?
                new ObjectParameter("idUEntreprise", idUEntreprise) :
                new ObjectParameter("idUEntreprise", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SetUtilFavoris_Result>("SetUtilFavoris", idUParameter, idUEntrepriseParameter);
        }
    
        public virtual ObjectResult<Ref_Ville> GetRefVilleByLongLatRayon(Nullable<double> longitude, Nullable<double> latitude, Nullable<int> distance)
        {
            var longitudeParameter = longitude.HasValue ?
                new ObjectParameter("longitude", longitude) :
                new ObjectParameter("longitude", typeof(double));
    
            var latitudeParameter = latitude.HasValue ?
                new ObjectParameter("latitude", latitude) :
                new ObjectParameter("latitude", typeof(double));
    
            var distanceParameter = distance.HasValue ?
                new ObjectParameter("distance", distance) :
                new ObjectParameter("distance", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Ref_Ville>("GetRefVilleByLongLatRayon", longitudeParameter, latitudeParameter, distanceParameter);
        }
    
        public virtual ObjectResult<Ref_Ville> GetRefVilleByLongLatRayon(Nullable<double> longitude, Nullable<double> latitude, Nullable<int> distance, MergeOption mergeOption)
        {
            var longitudeParameter = longitude.HasValue ?
                new ObjectParameter("longitude", longitude) :
                new ObjectParameter("longitude", typeof(double));
    
            var latitudeParameter = latitude.HasValue ?
                new ObjectParameter("latitude", latitude) :
                new ObjectParameter("latitude", typeof(double));
    
            var distanceParameter = distance.HasValue ?
                new ObjectParameter("distance", distance) :
                new ObjectParameter("distance", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Ref_Ville>("GetRefVilleByLongLatRayon", mergeOption, longitudeParameter, latitudeParameter, distanceParameter);
        }
    
        public virtual ObjectResult<Util> GetUtilSearchByLongLatIddepRayonDateAndParam(Nullable<double> longitude, Nullable<double> latitude, string idDepartement, Nullable<int> distance, Nullable<System.DateTime> dateDebut, Nullable<System.DateTime> dateFin, string experience, string contrat)
        {
            var longitudeParameter = longitude.HasValue ?
                new ObjectParameter("longitude", longitude) :
                new ObjectParameter("longitude", typeof(double));
    
            var latitudeParameter = latitude.HasValue ?
                new ObjectParameter("latitude", latitude) :
                new ObjectParameter("latitude", typeof(double));
    
            var idDepartementParameter = idDepartement != null ?
                new ObjectParameter("idDepartement", idDepartement) :
                new ObjectParameter("idDepartement", typeof(string));
    
            var distanceParameter = distance.HasValue ?
                new ObjectParameter("distance", distance) :
                new ObjectParameter("distance", typeof(int));
    
            var dateDebutParameter = dateDebut.HasValue ?
                new ObjectParameter("dateDebut", dateDebut) :
                new ObjectParameter("dateDebut", typeof(System.DateTime));
    
            var dateFinParameter = dateFin.HasValue ?
                new ObjectParameter("dateFin", dateFin) :
                new ObjectParameter("dateFin", typeof(System.DateTime));
    
            var experienceParameter = experience != null ?
                new ObjectParameter("experience", experience) :
                new ObjectParameter("experience", typeof(string));
    
            var contratParameter = contrat != null ?
                new ObjectParameter("contrat", contrat) :
                new ObjectParameter("contrat", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Util>("GetUtilSearchByLongLatIddepRayonDateAndParam", longitudeParameter, latitudeParameter, idDepartementParameter, distanceParameter, dateDebutParameter, dateFinParameter, experienceParameter, contratParameter);
        }
    
        public virtual ObjectResult<Util> GetUtilSearchByLongLatIddepRayonDateAndParam(Nullable<double> longitude, Nullable<double> latitude, string idDepartement, Nullable<int> distance, Nullable<System.DateTime> dateDebut, Nullable<System.DateTime> dateFin, string experience, string contrat, MergeOption mergeOption)
        {
            var longitudeParameter = longitude.HasValue ?
                new ObjectParameter("longitude", longitude) :
                new ObjectParameter("longitude", typeof(double));
    
            var latitudeParameter = latitude.HasValue ?
                new ObjectParameter("latitude", latitude) :
                new ObjectParameter("latitude", typeof(double));
    
            var idDepartementParameter = idDepartement != null ?
                new ObjectParameter("idDepartement", idDepartement) :
                new ObjectParameter("idDepartement", typeof(string));
    
            var distanceParameter = distance.HasValue ?
                new ObjectParameter("distance", distance) :
                new ObjectParameter("distance", typeof(int));
    
            var dateDebutParameter = dateDebut.HasValue ?
                new ObjectParameter("dateDebut", dateDebut) :
                new ObjectParameter("dateDebut", typeof(System.DateTime));
    
            var dateFinParameter = dateFin.HasValue ?
                new ObjectParameter("dateFin", dateFin) :
                new ObjectParameter("dateFin", typeof(System.DateTime));
    
            var experienceParameter = experience != null ?
                new ObjectParameter("experience", experience) :
                new ObjectParameter("experience", typeof(string));
    
            var contratParameter = contrat != null ?
                new ObjectParameter("contrat", contrat) :
                new ObjectParameter("contrat", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Util>("GetUtilSearchByLongLatIddepRayonDateAndParam", mergeOption, longitudeParameter, latitudeParameter, idDepartementParameter, distanceParameter, dateDebutParameter, dateFinParameter, experienceParameter, contratParameter);
        }
    }
}
