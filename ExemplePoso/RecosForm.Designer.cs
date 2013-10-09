namespace ExemplePoso
{
    partial class RecosForm
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
            this.recoslistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // recoslistBox
            // 
            this.recoslistBox.DisplayMember = "name";
            this.recoslistBox.FormattingEnabled = true;
            this.recoslistBox.Location = new System.Drawing.Point(35, 47);
            this.recoslistBox.Name = "recoslistBox";
            this.recoslistBox.Size = new System.Drawing.Size(329, 199);
            this.recoslistBox.TabIndex = 0;
            this.recoslistBox.ValueMember = "name";
            this.recoslistBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // RecosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 547);
            this.Controls.Add(this.recoslistBox);
            this.Name = "RecosForm";
            this.Text = "RecosForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox recoslistBox;
    }
}