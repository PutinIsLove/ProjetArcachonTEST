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
    
    public partial class Temps
    {
        public int idTemps { get; set; }
        public System.DateTime Temps1 { get; set; }
        public int idVoilierInscrit { get; set; }
        public int idEpreuve { get; set; }
    
        public virtual Epreuve Epreuve { get; set; }
        public virtual VoilierInscrit VoilierInscrit { get; set; }
    }
}