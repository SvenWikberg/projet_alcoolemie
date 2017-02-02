namespace calcul_acoolemie
{
    partial class MainView
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
            this.lblSexe = new System.Windows.Forms.Label();
            this.lblPoid = new System.Windows.Forms.Label();
            this.cbxSexe = new System.Windows.Forms.ComboBox();
            this.nudPoid = new System.Windows.Forms.NumericUpDown();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.lstbxBoissons = new System.Windows.Forms.ListBox();
            this.lstbxBu = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSexe
            // 
            this.lblSexe.AutoSize = true;
            this.lblSexe.Location = new System.Drawing.Point(12, 9);
            this.lblSexe.Name = "lblSexe";
            this.lblSexe.Size = new System.Drawing.Size(37, 13);
            this.lblSexe.TabIndex = 0;
            this.lblSexe.Text = "Sexe :";
            // 
            // lblPoid
            // 
            this.lblPoid.AutoSize = true;
            this.lblPoid.Location = new System.Drawing.Point(246, 9);
            this.lblPoid.Name = "lblPoid";
            this.lblPoid.Size = new System.Drawing.Size(70, 13);
            this.lblPoid.TabIndex = 1;
            this.lblPoid.Text = "Poid (en kg) :";
            // 
            // cbxSexe
            // 
            this.cbxSexe.FormattingEnabled = true;
            this.cbxSexe.Items.AddRange(new object[] {
            "Homme",
            "Femme"});
            this.cbxSexe.Location = new System.Drawing.Point(55, 6);
            this.cbxSexe.Name = "cbxSexe";
            this.cbxSexe.Size = new System.Drawing.Size(115, 21);
            this.cbxSexe.TabIndex = 2;
            // 
            // nudPoid
            // 
            this.nudPoid.Location = new System.Drawing.Point(322, 7);
            this.nudPoid.Name = "nudPoid";
            this.nudPoid.Size = new System.Drawing.Size(120, 20);
            this.nudPoid.TabIndex = 3;
            // 
            // btnCalculer
            // 
            this.btnCalculer.Location = new System.Drawing.Point(507, 4);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(75, 23);
            this.btnCalculer.TabIndex = 4;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            // 
            // lstbxBoissons
            // 
            this.lstbxBoissons.FormattingEnabled = true;
            this.lstbxBoissons.Location = new System.Drawing.Point(15, 33);
            this.lstbxBoissons.Name = "lstbxBoissons";
            this.lstbxBoissons.Size = new System.Drawing.Size(200, 420);
            this.lstbxBoissons.TabIndex = 5;
            // 
            // lstbxBu
            // 
            this.lstbxBu.FormattingEnabled = true;
            this.lstbxBu.Location = new System.Drawing.Point(382, 33);
            this.lstbxBu.Name = "lstbxBu";
            this.lstbxBu.Size = new System.Drawing.Size(200, 420);
            this.lstbxBu.TabIndex = 6;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 463);
            this.Controls.Add(this.lstbxBu);
            this.Controls.Add(this.lstbxBoissons);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.nudPoid);
            this.Controls.Add(this.cbxSexe);
            this.Controls.Add(this.lblPoid);
            this.Controls.Add(this.lblSexe);
            this.Name = "MainView";
            this.Text = "Calcul Alcoolémie";
            ((System.ComponentModel.ISupportInitialize)(this.nudPoid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSexe;
        private System.Windows.Forms.Label lblPoid;
        private System.Windows.Forms.ComboBox cbxSexe;
        private System.Windows.Forms.NumericUpDown nudPoid;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.ListBox lstbxBoissons;
        private System.Windows.Forms.ListBox lstbxBu;
    }
}

