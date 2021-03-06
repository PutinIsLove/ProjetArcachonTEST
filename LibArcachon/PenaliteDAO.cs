﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibArcachon
{
    public class PenaliteDAO
    {

        public static List<Penalite> ListAll()
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            List<Penalite> penalite = db.Penalite.ToList();
            return penalite;
        }

        /// <summary>
        /// Cherche les penalites d'un voilier inscrit
        /// </summary>
        /// <param name="voilier"> Le voilier en question</param>
        /// <returns>Retourne une liste de penalite</returns>
       // public static List<Penalite> Select(VoilierInscrit voilier)
        //{
       //     ProjetArcachonEntities db = new ProjetArcachonEntities();
        //    List<Penalite> penalite = db.Entreprise.Find();
         //   return entreprise;
       // }
        public static string Edit(Penalite penalite)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.Penalite.Attach(penalite);
            db.Entry(penalite).State = System.Data.Entity.EntityState.Modified;
            string Retour = System.String.Format("La pénalite {0} pour le voilier {1} à bien été modifié", penalite.ListePenalite.Nom, penalite.VoilierInscrit1.Voilier.Nom);
            db.SaveChanges();
            return Retour;
        }

        public static string Delete(Penalite penalite)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();

            db.Penalite.Remove(penalite);
            string Retour = System.String.Format("La penalite {0} pour le voilier {1} à bien été supprimé", penalite.ListePenalite.Nom, penalite.VoilierInscrit1.Voilier.Nom);
            db.SaveChanges();
            return Retour;
        }

        public static void Add(Penalite penalite)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            db.Penalite.Add(penalite);
            db.SaveChanges();
        }

        public static TimeSpan? PenalParVoilier(string idvoilier, int id_Epreuve)
        {
            ProjetArcachonEntities db = new ProjetArcachonEntities();
            TimeSpan? tpsTotal = TimeSpan.Parse("00:00:00");
            var kek = from pen in db.Penalite
                      from vi in db.VoilierInscrit.Where(x => pen.VoilierInscrit == x.Id_VoilierInscrit)
                      from ep in db.Epreuve.Where(x => pen.idepreuve == x.Id_Epreuve)
                      where ep.Id_Epreuve == id_Epreuve && vi.NumeroSerie == idvoilier
                      select pen;


            foreach (var item in kek)
            {
                tpsTotal = tpsTotal+item.Duree;
            }
            return tpsTotal;
        }

      

    }
}
