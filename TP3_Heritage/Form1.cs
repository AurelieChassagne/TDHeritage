using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP3_Heritage
{
    public partial class FrmCompteEpargneLogement : Form
    {
        List<CompteEpargneLogement> lesComptes;
        public FrmCompteEpargneLogement()
        {
            InitializeComponent();
        }

        private void FrmCompteEpargneLogement_Load(object sender, EventArgs e)
        {
            lesComptes = new List<CompteEpargneLogement>();

            CompteEpargneLogement CEL = new CompteEpargneLogement("12345H", "Saroyan", 5000, 100, new DateTime(2001, 08, 04));
            lesComptes.Add(CEL);

            dgvComptes.Rows.Add(CEL.NumCompte, CEL.NomTitulaire, CEL.SoldeCompte, CEL.Versement,CEL.Ouverture);
        }

        private void btnCreerCompte_Click(object sender, EventArgs e)
        {
            CompteEpargneLogement compte = new CompteEpargneLogement(txBNumCompte.Text, txBNomTitulaire.Text,
               Decimal.Parse(txBSoldeInitial.Text), Decimal.Parse(txbVersementMensuel.Text), DateTime.Now.Date);

            dgvComptes.Rows.Add(compte.NumCompte,compte.NomTitulaire,compte.SoldeCompte,compte.Versement,compte.Ouverture);
        }
    }
}
