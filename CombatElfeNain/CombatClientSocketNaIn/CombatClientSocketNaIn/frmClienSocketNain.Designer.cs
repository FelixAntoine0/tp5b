namespace CombatClientSocketNaIn
{
    partial class frmClienSocketNain
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnFrappe = new System.Windows.Forms.Button();
            this.lblSortElfe = new System.Windows.Forms.Label();
            this.lblArmeNain = new System.Windows.Forms.Label();
            this.lblForceElfe = new System.Windows.Forms.Label();
            this.lblForceNain = new System.Windows.Forms.Label();
            this.lblVieElfe = new System.Windows.Forms.Label();
            this.lblVieNain = new System.Windows.Forms.Label();
            this.picElfe = new System.Windows.Forms.PictureBox();
            this.picNain = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PbGagnant = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picElfe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGagnant)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(681, 283);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(136, 28);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnFrappe
            // 
            this.btnFrappe.Location = new System.Drawing.Point(371, 81);
            this.btnFrappe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFrappe.Name = "btnFrappe";
            this.btnFrappe.Size = new System.Drawing.Size(128, 57);
            this.btnFrappe.TabIndex = 19;
            this.btnFrappe.Text = "Frapper   -->       <--Lancer Sort";
            this.btnFrappe.UseVisualStyleBackColor = true;
            this.btnFrappe.Click += new System.EventHandler(this.btnFrappe_Click);
            // 
            // lblSortElfe
            // 
            this.lblSortElfe.AccessibleDescription = "";
            this.lblSortElfe.AutoSize = true;
            this.lblSortElfe.Location = new System.Drawing.Point(529, 295);
            this.lblSortElfe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSortElfe.Name = "lblSortElfe";
            this.lblSortElfe.Size = new System.Drawing.Size(42, 17);
            this.lblSortElfe.TabIndex = 18;
            this.lblSortElfe.Text = "Sort: ";
            // 
            // lblArmeNain
            // 
            this.lblArmeNain.AutoSize = true;
            this.lblArmeNain.Location = new System.Drawing.Point(67, 298);
            this.lblArmeNain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArmeNain.Name = "lblArmeNain";
            this.lblArmeNain.Size = new System.Drawing.Size(49, 17);
            this.lblArmeNain.TabIndex = 17;
            this.lblArmeNain.Text = "Arme: ";
            // 
            // lblForceElfe
            // 
            this.lblForceElfe.AutoSize = true;
            this.lblForceElfe.Location = new System.Drawing.Point(529, 268);
            this.lblForceElfe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForceElfe.Name = "lblForceElfe";
            this.lblForceElfe.Size = new System.Drawing.Size(52, 17);
            this.lblForceElfe.TabIndex = 16;
            this.lblForceElfe.Text = "Force: ";
            // 
            // lblForceNain
            // 
            this.lblForceNain.AutoSize = true;
            this.lblForceNain.Location = new System.Drawing.Point(67, 271);
            this.lblForceNain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForceNain.Name = "lblForceNain";
            this.lblForceNain.Size = new System.Drawing.Size(48, 17);
            this.lblForceNain.TabIndex = 15;
            this.lblForceNain.Text = "Force:";
            // 
            // lblVieElfe
            // 
            this.lblVieElfe.AutoSize = true;
            this.lblVieElfe.Location = new System.Drawing.Point(529, 241);
            this.lblVieElfe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVieElfe.Name = "lblVieElfe";
            this.lblVieElfe.Size = new System.Drawing.Size(36, 17);
            this.lblVieElfe.TabIndex = 14;
            this.lblVieElfe.Text = "Vie: ";
            // 
            // lblVieNain
            // 
            this.lblVieNain.AutoSize = true;
            this.lblVieNain.Location = new System.Drawing.Point(67, 244);
            this.lblVieNain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVieNain.Name = "lblVieNain";
            this.lblVieNain.Size = new System.Drawing.Size(36, 17);
            this.lblVieNain.TabIndex = 13;
            this.lblVieNain.Text = "Vie: ";
            // 
            // picElfe
            // 
            this.picElfe.Location = new System.Drawing.Point(524, 31);
            this.picElfe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picElfe.Name = "picElfe";
            this.picElfe.Size = new System.Drawing.Size(293, 197);
            this.picElfe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picElfe.TabIndex = 12;
            this.picElfe.TabStop = false;
            // 
            // picNain
            // 
            this.picNain.Location = new System.Drawing.Point(52, 31);
            this.picNain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picNain.Name = "picNain";
            this.picNain.Size = new System.Drawing.Size(293, 197);
            this.picNain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNain.TabIndex = 11;
            this.picNain.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Gagnant:";
            // 
            // PbGagnant
            // 
            this.PbGagnant.Location = new System.Drawing.Point(370, 240);
            this.PbGagnant.Name = "PbGagnant";
            this.PbGagnant.Size = new System.Drawing.Size(128, 100);
            this.PbGagnant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbGagnant.TabIndex = 23;
            this.PbGagnant.TabStop = false;
            // 
            // frmClienSocketNain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 357);
            this.Controls.Add(this.PbGagnant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFrappe);
            this.Controls.Add(this.lblSortElfe);
            this.Controls.Add(this.lblArmeNain);
            this.Controls.Add(this.lblForceElfe);
            this.Controls.Add(this.lblForceNain);
            this.Controls.Add(this.lblVieElfe);
            this.Controls.Add(this.lblVieNain);
            this.Controls.Add(this.picElfe);
            this.Controls.Add(this.picNain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmClienSocketNain";
            this.Text = "CLIENT socket NAIN";
            ((System.ComponentModel.ISupportInitialize)(this.picElfe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbGagnant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnFrappe;
        private System.Windows.Forms.Label lblSortElfe;
        private System.Windows.Forms.Label lblArmeNain;
        private System.Windows.Forms.Label lblForceElfe;
        private System.Windows.Forms.Label lblForceNain;
        private System.Windows.Forms.Label lblVieElfe;
        private System.Windows.Forms.Label lblVieNain;
        private System.Windows.Forms.PictureBox picElfe;
        private System.Windows.Forms.PictureBox picNain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PbGagnant;
    }
}

