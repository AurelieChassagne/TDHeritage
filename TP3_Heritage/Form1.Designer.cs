namespace TP3_Heritage
{
    partial class FrmCompteEpargneLogement
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumCompte = new System.Windows.Forms.Label();
            this.lblNomTitulaire = new System.Windows.Forms.Label();
            this.lblSoldeInitial = new System.Windows.Forms.Label();
            this.lblVersementMensuel = new System.Windows.Forms.Label();
            this.btnCreerCompte = new System.Windows.Forms.Button();
            this.dgvComptes = new System.Windows.Forms.DataGridView();
            this.txBNumCompte = new System.Windows.Forms.TextBox();
            this.txBNomTitulaire = new System.Windows.Forms.TextBox();
            this.txBSoldeInitial = new System.Windows.Forms.TextBox();
            this.txbVersementMensuel = new System.Windows.Forms.TextBox();
            this.NumCompte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomTitulaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoldeCompte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Versement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ouverture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComptes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumCompte
            // 
            this.lblNumCompte.AutoSize = true;
            this.lblNumCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCompte.Location = new System.Drawing.Point(232, 64);
            this.lblNumCompte.Name = "lblNumCompte";
            this.lblNumCompte.Size = new System.Drawing.Size(173, 20);
            this.lblNumCompte.TabIndex = 0;
            this.lblNumCompte.Text = "Numéro du Compte :";
            // 
            // lblNomTitulaire
            // 
            this.lblNomTitulaire.AutoSize = true;
            this.lblNomTitulaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomTitulaire.Location = new System.Drawing.Point(232, 103);
            this.lblNomTitulaire.Name = "lblNomTitulaire";
            this.lblNomTitulaire.Size = new System.Drawing.Size(149, 20);
            this.lblNomTitulaire.TabIndex = 1;
            this.lblNomTitulaire.Text = "Nom du Titulaire :";
            // 
            // lblSoldeInitial
            // 
            this.lblSoldeInitial.AutoSize = true;
            this.lblSoldeInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldeInitial.Location = new System.Drawing.Point(232, 143);
            this.lblSoldeInitial.Name = "lblSoldeInitial";
            this.lblSoldeInitial.Size = new System.Drawing.Size(114, 20);
            this.lblSoldeInitial.TabIndex = 2;
            this.lblSoldeInitial.Text = "Solde Initial :";
            // 
            // lblVersementMensuel
            // 
            this.lblVersementMensuel.AutoSize = true;
            this.lblVersementMensuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersementMensuel.Location = new System.Drawing.Point(232, 179);
            this.lblVersementMensuel.Name = "lblVersementMensuel";
            this.lblVersementMensuel.Size = new System.Drawing.Size(178, 20);
            this.lblVersementMensuel.TabIndex = 3;
            this.lblVersementMensuel.Text = "Versement Mensuel :";
            // 
            // btnCreerCompte
            // 
            this.btnCreerCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreerCompte.Location = new System.Drawing.Point(290, 292);
            this.btnCreerCompte.Name = "btnCreerCompte";
            this.btnCreerCompte.Size = new System.Drawing.Size(312, 38);
            this.btnCreerCompte.TabIndex = 4;
            this.btnCreerCompte.Text = "Créer le Compte Épargne Logement";
            this.btnCreerCompte.UseVisualStyleBackColor = true;
            this.btnCreerCompte.Click += new System.EventHandler(this.btnCreerCompte_Click);
            // 
            // dgvComptes
            // 
            this.dgvComptes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComptes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumCompte,
            this.NomTitulaire,
            this.SoldeCompte,
            this.Versement,
            this.Ouverture});
            this.dgvComptes.Location = new System.Drawing.Point(103, 397);
            this.dgvComptes.Name = "dgvComptes";
            this.dgvComptes.Size = new System.Drawing.Size(544, 150);
            this.dgvComptes.TabIndex = 5;
            // 
            // txBNumCompte
            // 
            this.txBNumCompte.Location = new System.Drawing.Point(418, 63);
            this.txBNumCompte.Name = "txBNumCompte";
            this.txBNumCompte.Size = new System.Drawing.Size(100, 20);
            this.txBNumCompte.TabIndex = 6;
            // 
            // txBNomTitulaire
            // 
            this.txBNomTitulaire.Location = new System.Drawing.Point(418, 102);
            this.txBNomTitulaire.Name = "txBNomTitulaire";
            this.txBNomTitulaire.Size = new System.Drawing.Size(100, 20);
            this.txBNomTitulaire.TabIndex = 7;
            // 
            // txBSoldeInitial
            // 
            this.txBSoldeInitial.Location = new System.Drawing.Point(418, 142);
            this.txBSoldeInitial.Name = "txBSoldeInitial";
            this.txBSoldeInitial.Size = new System.Drawing.Size(100, 20);
            this.txBSoldeInitial.TabIndex = 8;
            // 
            // txbVersementMensuel
            // 
            this.txbVersementMensuel.Location = new System.Drawing.Point(418, 178);
            this.txbVersementMensuel.Name = "txbVersementMensuel";
            this.txbVersementMensuel.Size = new System.Drawing.Size(100, 20);
            this.txbVersementMensuel.TabIndex = 9;
            // 
            // NumCompte
            // 
            this.NumCompte.HeaderText = "Numéro de Compte";
            this.NumCompte.Name = "NumCompte";
            // 
            // NomTitulaire
            // 
            this.NomTitulaire.HeaderText = "Nom du Titulaire";
            this.NomTitulaire.Name = "NomTitulaire";
            // 
            // SoldeCompte
            // 
            this.SoldeCompte.HeaderText = "Solde du Compte";
            this.SoldeCompte.Name = "SoldeCompte";
            // 
            // Versement
            // 
            this.Versement.HeaderText = "Versement";
            this.Versement.Name = "Versement";
            // 
            // Ouverture
            // 
            this.Ouverture.HeaderText = "Ouverture";
            this.Ouverture.Name = "Ouverture";
            // 
            // FrmCompteEpargneLogement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 602);
            this.Controls.Add(this.txbVersementMensuel);
            this.Controls.Add(this.txBSoldeInitial);
            this.Controls.Add(this.txBNomTitulaire);
            this.Controls.Add(this.txBNumCompte);
            this.Controls.Add(this.dgvComptes);
            this.Controls.Add(this.btnCreerCompte);
            this.Controls.Add(this.lblVersementMensuel);
            this.Controls.Add(this.lblSoldeInitial);
            this.Controls.Add(this.lblNomTitulaire);
            this.Controls.Add(this.lblNumCompte);
            this.Name = "FrmCompteEpargneLogement";
            this.Text = "Compte Epargne Logement";
            this.Load += new System.EventHandler(this.FrmCompteEpargneLogement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComptes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumCompte;
        private System.Windows.Forms.Label lblNomTitulaire;
        private System.Windows.Forms.Label lblSoldeInitial;
        private System.Windows.Forms.Label lblVersementMensuel;
        private System.Windows.Forms.Button btnCreerCompte;
        private System.Windows.Forms.DataGridView dgvComptes;
        private System.Windows.Forms.TextBox txBNumCompte;
        private System.Windows.Forms.TextBox txBNomTitulaire;
        private System.Windows.Forms.TextBox txBSoldeInitial;
        private System.Windows.Forms.TextBox txbVersementMensuel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumCompte;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomTitulaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoldeCompte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Versement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ouverture;
    }
}

