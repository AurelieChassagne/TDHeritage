using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libBanque;

namespace TP3_Heritage
{
    class CompteEpargneLogement : CompteBancaire
    {
        //Attributs privés


        private Decimal versement;
        private DateTime ouverture;

        public decimal Versement
        {
            get
            {
                return versement;
            }

            set
            {
                versement = value;
            }
        }

        public DateTime Ouverture
        {
            get
            {
                return ouverture;
            }

            set
            {
                ouverture = value;
            }
        }

        //Constructeur

        public CompteEpargneLogement(string unNumero, string unTitulaire, Decimal unSolde, Decimal unVersement, DateTime uneDate)
            :base(unNumero, unTitulaire, unSolde)
        {
            Versement = unVersement;
            Ouverture = uneDate;
        }

        public void verserMontant (Decimal unMontant)
        {
            SoldeCompte = unMontant;
        }



    }
}
