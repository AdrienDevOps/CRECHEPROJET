//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRECHEPROJET
{
    using System;
    using System.Collections.Generic;
    
    public partial class acceuil
    {
        public int IDacceuil { get; set; }
        public Nullable<System.DateTime> PrevuArriver { get; set; }
        public Nullable<System.DateTime> PrevuDepart { get; set; }
        public Nullable<System.DateTime> ReelArriver { get; set; }
        public Nullable<System.DateTime> ReelDepart { get; set; }
        public int Contrat_IDContrat { get; set; }
    
        public virtual contrat contrat { get; set; }
    }
}