namespace ExemplePoso
{
    partial class CircuitMedic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeViewCM = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.warningServiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compositionListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compositionListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.compositionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.compositionListBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.treeViewCompo = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.warningServiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionListBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewCM
            // 
            this.treeViewCM.Location = new System.Drawing.Point(55, 80);
            this.treeViewCM.Name = "treeViewCM";
            this.treeViewCM.Size = new System.Drawing.Size(316, 451);
            this.treeViewCM.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // warningServiceBindingSource
            // 
            this.warningServiceBindingSource.DataSource = typeof(VidalAPI.Services.WarningService);
            // 
            // compositionListBindingSource
            // 
            this.compositionListBindingSource.DataSource = typeof(VidalAPI.Domain.CompositionList);
            // 
            // compositionListBindingSource1
            // 
            this.compositionListBindingSource1.DataSource = typeof(VidalAPI.Domain.CompositionList);
            // 
            // compositionBindingSource
            // 
            this.compositionBindingSource.DataSource = typeof(VidalAPI.Domain.Composition);
            // 
            // compositionListBindingSource2
            // 
            this.compositionListBindingSource2.DataSource = typeof(VidalAPI.Domain.CompositionList);
            // 
            // treeViewCompo
            // 
            this.treeViewCompo.Location = new System.Drawing.Point(438, 80);
            this.treeViewCompo.Name = "treeViewCompo";
            this.treeViewCompo.Size = new System.Drawing.Size(395, 196);
            this.treeViewCompo.TabIndex = 2;
            // 
            // CircuitMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 569);
            this.Controls.Add(this.treeViewCompo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeViewCM);
            this.Name = "CircuitMedic";
            this.Text = "CircuitMedic";
            this.Load += new System.EventHandler(this.CircuitMedic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.warningServiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compositionListBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewCM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource compositionBindingSource;
        private System.Windows.Forms.BindingSource warningServiceBindingSource;
        private System.Windows.Forms.BindingSource compositionListBindingSource;
        private System.Windows.Forms.BindingSource compositionListBindingSource1;
        private System.Windows.Forms.BindingSource compositionListBindingSource2;
        private System.Windows.Forms.TreeView treeViewCompo;
    }
}