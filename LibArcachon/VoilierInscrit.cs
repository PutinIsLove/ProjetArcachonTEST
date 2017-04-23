//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibArcachon
{
    using System;
    using System.Collections.Generic;
    
    public partial class VoilierInscrit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VoilierInscrit()
        {
            this.Penalite = new HashSet<Penalite>();
            this.Sponsoring = new HashSet<Sponsoring>();
            this.Tps = new HashSet<Tps>();
        }
    
        public int Id_VoilierInscrit { get; set; }
        public string NumeroSerie { get; set; }
        public int NumeroInscription { get; set; }
        public int Barreur { get; set; }
        public int Equipier1 { get; set; }
        public int Equipier2 { get; set; }
        public int idCourse { get; set; }
    
        public virtual Course Course { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Penalite> Penalite { get; set; }
        public virtual Personne Personne { get; set; }
        public virtual Personne Personne1 { get; set; }
        public virtual Personne Personne2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sponsoring> Sponsoring { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tps> Tps { get; set; }
        public virtual Voilier Voilier { get; set; }
    }
}
