namespace Générateur_SQL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAfficherfichier = new System.Windows.Forms.Button();
            this.lbxContenuFichier = new System.Windows.Forms.ListBox();
            this.tbxChemin = new System.Windows.Forms.TextBox();
            this.btnConvertirSQL = new System.Windows.Forms.Button();
            this.btnSauvegarder = new System.Windows.Forms.Button();
            this.tbxEmplacementSauvegarde = new System.Windows.Forms.TextBox();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.FBD1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnAfficherfichier
            // 
            this.btnAfficherfichier.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAfficherfichier.Location = new System.Drawing.Point(77, 31);
            this.btnAfficherfichier.Name = "btnAfficherfichier";
            this.btnAfficherfichier.Size = new System.Drawing.Size(120, 61);
            this.btnAfficherfichier.TabIndex = 0;
            this.btnAfficherfichier.Text = "Fichiers";
            this.btnAfficherfichier.UseVisualStyleBackColor = false;
            this.btnAfficherfichier.Click += new System.EventHandler(this.btnAfficherfichier_Click);
            // 
            // lbxContenuFichier
            // 
            this.lbxContenuFichier.FormattingEnabled = true;
            this.lbxContenuFichier.ItemHeight = 15;
            this.lbxContenuFichier.Location = new System.Drawing.Point(77, 163);
            this.lbxContenuFichier.Name = "lbxContenuFichier";
            this.lbxContenuFichier.Size = new System.Drawing.Size(120, 169);
            this.lbxContenuFichier.TabIndex = 1;
            // 
            // tbxChemin
            // 
            this.tbxChemin.Location = new System.Drawing.Point(77, 110);
            this.tbxChemin.Name = "tbxChemin";
            this.tbxChemin.Size = new System.Drawing.Size(120, 23);
            this.tbxChemin.TabIndex = 2;
            this.tbxChemin.TextChanged += new System.EventHandler(this.tbxChemin_TextChanged);
            // 
            // btnConvertirSQL
            // 
            this.btnConvertirSQL.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnConvertirSQL.Location = new System.Drawing.Point(296, 31);
            this.btnConvertirSQL.Name = "btnConvertirSQL";
            this.btnConvertirSQL.Size = new System.Drawing.Size(120, 61);
            this.btnConvertirSQL.TabIndex = 3;
            this.btnConvertirSQL.Text = "Convertir en SQL";
            this.btnConvertirSQL.UseVisualStyleBackColor = false;
            // 
            // btnSauvegarder
            // 
            this.btnSauvegarder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSauvegarder.Location = new System.Drawing.Point(568, 31);
            this.btnSauvegarder.Name = "btnSauvegarder";
            this.btnSauvegarder.Size = new System.Drawing.Size(120, 61);
            this.btnSauvegarder.TabIndex = 6;
            this.btnSauvegarder.Text = "Sauvegarder";
            this.btnSauvegarder.UseVisualStyleBackColor = false;
            // 
            // tbxEmplacementSauvegarde
            // 
            this.tbxEmplacementSauvegarde.Location = new System.Drawing.Point(568, 125);
            this.tbxEmplacementSauvegarde.Name = "tbxEmplacementSauvegarde";
            this.tbxEmplacementSauvegarde.Size = new System.Drawing.Size(120, 23);
            this.tbxEmplacementSauvegarde.TabIndex = 7;
            // 
            // OFD
            // 
            this.OFD.FileName = "OFD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxEmplacementSauvegarde);
            this.Controls.Add(this.btnSauvegarder);
            this.Controls.Add(this.btnConvertirSQL);
            this.Controls.Add(this.tbxChemin);
            this.Controls.Add(this.lbxContenuFichier);
            this.Controls.Add(this.btnAfficherfichier);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAfficherfichier;
        private ListBox lbxContenuFichier;
        private TextBox tbxChemin;
        private Button btnConvertirSQL;
        private Button btnSauvegarder;
        private TextBox tbxEmplacementSauvegarde;
        private FolderBrowserDialog FBD;
        private OpenFileDialog OFD;
        private FolderBrowserDialog FBD1;
    }
}