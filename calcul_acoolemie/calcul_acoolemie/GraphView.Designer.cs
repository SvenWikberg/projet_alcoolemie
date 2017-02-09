namespace calcul_acoolemie {
    partial class GraphView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.timRefresh = new System.Windows.Forms.Timer(this.components);
            this.lblBloodAlcohol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timRefresh
            // 
            this.timRefresh.Interval = 1000;
            this.timRefresh.Tick += new System.EventHandler(this.timRefresh_Tick);
            // 
            // lblBloodAlcohol
            // 
            this.lblBloodAlcohol.AutoSize = true;
            this.lblBloodAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloodAlcohol.Location = new System.Drawing.Point(520, 9);
            this.lblBloodAlcohol.Name = "lblBloodAlcohol";
            this.lblBloodAlcohol.Size = new System.Drawing.Size(185, 20);
            this.lblBloodAlcohol.TabIndex = 0;
            this.lblBloodAlcohol.Text = "Votre taux d\'alcoolémie : ";
            // 
            // GraphView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 254);
            this.Controls.Add(this.lblBloodAlcohol);
            this.MaximumSize = new System.Drawing.Size(807, 292);
            this.MinimumSize = new System.Drawing.Size(807, 292);
            this.Name = "GraphView";
            this.Text = "GraphView";
            this.Load += new System.EventHandler(this.GraphView_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphView_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timRefresh;
        private System.Windows.Forms.Label lblBloodAlcohol;
    }
}