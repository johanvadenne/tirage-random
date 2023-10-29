namespace tirage_interface
{
    partial class Form1
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
            this.btn_tirage = new System.Windows.Forms.Button();
            this.label_utilisateur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_tirage
            // 
            this.btn_tirage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_tirage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.1F);
            this.btn_tirage.Location = new System.Drawing.Point(309, 314);
            this.btn_tirage.Name = "btn_tirage";
            this.btn_tirage.Size = new System.Drawing.Size(165, 59);
            this.btn_tirage.TabIndex = 0;
            this.btn_tirage.TabStop = false;
            this.btn_tirage.Text = "Cliquez-moi!";
            this.btn_tirage.UseVisualStyleBackColor = true;
            this.btn_tirage.Click += new System.EventHandler(this.btn_tirage_Click);
            // 
            // label_utilisateur
            // 
            this.label_utilisateur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_utilisateur.AutoSize = true;
            this.label_utilisateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label_utilisateur.Location = new System.Drawing.Point(212, 178);
            this.label_utilisateur.Name = "label_utilisateur";
            this.label_utilisateur.Size = new System.Drawing.Size(381, 47);
            this.label_utilisateur.TabIndex = 1;
            this.label_utilisateur.Text = "QUI VA GAGNER ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_utilisateur);
            this.Controls.Add(this.btn_tirage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_tirage;
        private System.Windows.Forms.Label label_utilisateur;
    }
}

