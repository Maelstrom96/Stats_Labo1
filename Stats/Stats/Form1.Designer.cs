namespace Stats
{
    partial class Main
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
            this.BTN_Open = new System.Windows.Forms.Button();
            this.TXB_OpenPath = new System.Windows.Forms.TextBox();
            this.GB_Type = new System.Windows.Forms.GroupBox();
            this.RB_Syst = new System.Windows.Forms.RadioButton();
            this.RB_Simple = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NUD_Nbechantillon = new System.Windows.Forms.NumericUpDown();
            this.GB_Taille = new System.Windows.Forms.GroupBox();
            this.TXB_Taille = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RB_Different = new System.Windows.Forms.RadioButton();
            this.RB_Fixe = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TXB_SaveFile = new System.Windows.Forms.TextBox();
            this.CB_Copy = new System.Windows.Forms.CheckBox();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.TXB_SavePath = new System.Windows.Forms.TextBox();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.GB_Type.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Nbechantillon)).BeginInit();
            this.GB_Taille.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_Open
            // 
            this.BTN_Open.Location = new System.Drawing.Point(12, 9);
            this.BTN_Open.Name = "BTN_Open";
            this.BTN_Open.Size = new System.Drawing.Size(75, 23);
            this.BTN_Open.TabIndex = 0;
            this.BTN_Open.Text = "Ouvrir";
            this.BTN_Open.UseVisualStyleBackColor = true;
            this.BTN_Open.Click += new System.EventHandler(this.BTN_Open_Click);
            // 
            // TXB_OpenPath
            // 
            this.TXB_OpenPath.Location = new System.Drawing.Point(93, 12);
            this.TXB_OpenPath.Name = "TXB_OpenPath";
            this.TXB_OpenPath.ReadOnly = true;
            this.TXB_OpenPath.Size = new System.Drawing.Size(323, 20);
            this.TXB_OpenPath.TabIndex = 1;
            // 
            // GB_Type
            // 
            this.GB_Type.Controls.Add(this.RB_Syst);
            this.GB_Type.Controls.Add(this.RB_Simple);
            this.GB_Type.Location = new System.Drawing.Point(13, 52);
            this.GB_Type.Name = "GB_Type";
            this.GB_Type.Size = new System.Drawing.Size(200, 51);
            this.GB_Type.TabIndex = 2;
            this.GB_Type.TabStop = false;
            this.GB_Type.Text = "Type échantillon";
            // 
            // RB_Syst
            // 
            this.RB_Syst.AutoSize = true;
            this.RB_Syst.Location = new System.Drawing.Point(98, 20);
            this.RB_Syst.Name = "RB_Syst";
            this.RB_Syst.Size = new System.Drawing.Size(88, 17);
            this.RB_Syst.TabIndex = 0;
            this.RB_Syst.TabStop = true;
            this.RB_Syst.Text = "Systematique";
            this.RB_Syst.UseVisualStyleBackColor = true;
            // 
            // RB_Simple
            // 
            this.RB_Simple.AutoSize = true;
            this.RB_Simple.Location = new System.Drawing.Point(7, 20);
            this.RB_Simple.Name = "RB_Simple";
            this.RB_Simple.Size = new System.Drawing.Size(56, 17);
            this.RB_Simple.TabIndex = 0;
            this.RB_Simple.TabStop = true;
            this.RB_Simple.Text = "Simple";
            this.RB_Simple.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nb échantillon";
            // 
            // NUD_Nbechantillon
            // 
            this.NUD_Nbechantillon.Location = new System.Drawing.Point(94, 116);
            this.NUD_Nbechantillon.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.NUD_Nbechantillon.Name = "NUD_Nbechantillon";
            this.NUD_Nbechantillon.Size = new System.Drawing.Size(57, 20);
            this.NUD_Nbechantillon.TabIndex = 5;
            // 
            // GB_Taille
            // 
            this.GB_Taille.Controls.Add(this.TXB_Taille);
            this.GB_Taille.Controls.Add(this.label2);
            this.GB_Taille.Controls.Add(this.RB_Different);
            this.GB_Taille.Controls.Add(this.RB_Fixe);
            this.GB_Taille.Location = new System.Drawing.Point(255, 52);
            this.GB_Taille.Name = "GB_Taille";
            this.GB_Taille.Size = new System.Drawing.Size(161, 97);
            this.GB_Taille.TabIndex = 6;
            this.GB_Taille.TabStop = false;
            this.GB_Taille.Text = "Taille";
            // 
            // TXB_Taille
            // 
            this.TXB_Taille.Location = new System.Drawing.Point(48, 57);
            this.TXB_Taille.Name = "TXB_Taille";
            this.TXB_Taille.Size = new System.Drawing.Size(100, 20);
            this.TXB_Taille.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Taille";
            // 
            // RB_Different
            // 
            this.RB_Different.AutoSize = true;
            this.RB_Different.Location = new System.Drawing.Point(77, 20);
            this.RB_Different.Name = "RB_Different";
            this.RB_Different.Size = new System.Drawing.Size(71, 17);
            this.RB_Different.TabIndex = 1;
            this.RB_Different.TabStop = true;
            this.RB_Different.Text = "Différente";
            this.RB_Different.UseVisualStyleBackColor = true;
            // 
            // RB_Fixe
            // 
            this.RB_Fixe.AutoSize = true;
            this.RB_Fixe.Location = new System.Drawing.Point(7, 20);
            this.RB_Fixe.Name = "RB_Fixe";
            this.RB_Fixe.Size = new System.Drawing.Size(44, 17);
            this.RB_Fixe.TabIndex = 0;
            this.RB_Fixe.TabStop = true;
            this.RB_Fixe.Text = "Fixe";
            this.RB_Fixe.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nom de l\'enregistrement";
            // 
            // TXB_SaveFile
            // 
            this.TXB_SaveFile.Location = new System.Drawing.Point(139, 195);
            this.TXB_SaveFile.Name = "TXB_SaveFile";
            this.TXB_SaveFile.Size = new System.Drawing.Size(100, 20);
            this.TXB_SaveFile.TabIndex = 8;
            // 
            // CB_Copy
            // 
            this.CB_Copy.AutoSize = true;
            this.CB_Copy.Location = new System.Drawing.Point(12, 155);
            this.CB_Copy.Name = "CB_Copy";
            this.CB_Copy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CB_Copy.Size = new System.Drawing.Size(108, 17);
            this.CB_Copy.TabIndex = 9;
            this.CB_Copy.Text = "Copie de l\'original";
            this.CB_Copy.UseVisualStyleBackColor = true;
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(15, 245);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(75, 23);
            this.BTN_Save.TabIndex = 10;
            this.BTN_Save.Text = "Enregistrer";
            this.BTN_Save.UseVisualStyleBackColor = true;
            this.BTN_Save.Click += new System.EventHandler(this.BTN_Save_Click);
            // 
            // TXB_SavePath
            // 
            this.TXB_SavePath.Location = new System.Drawing.Point(96, 247);
            this.TXB_SavePath.Name = "TXB_SavePath";
            this.TXB_SavePath.ReadOnly = true;
            this.TXB_SavePath.Size = new System.Drawing.Size(323, 20);
            this.TXB_SavePath.TabIndex = 1;
            // 
            // BTN_Start
            // 
            this.BTN_Start.Location = new System.Drawing.Point(13, 292);
            this.BTN_Start.Name = "BTN_Start";
            this.BTN_Start.Size = new System.Drawing.Size(75, 23);
            this.BTN_Start.TabIndex = 11;
            this.BTN_Start.Text = "Démarrer";
            this.BTN_Start.UseVisualStyleBackColor = true;
            this.BTN_Start.Click += new System.EventHandler(this.BTN_Start_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 327);
            this.Controls.Add(this.BTN_Start);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.CB_Copy);
            this.Controls.Add(this.TXB_SaveFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GB_Taille);
            this.Controls.Add(this.NUD_Nbechantillon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GB_Type);
            this.Controls.Add(this.TXB_SavePath);
            this.Controls.Add(this.TXB_OpenPath);
            this.Controls.Add(this.BTN_Open);
            this.MaximumSize = new System.Drawing.Size(457, 366);
            this.MinimumSize = new System.Drawing.Size(457, 366);
            this.Name = "Main";
            this.Text = "Statistiques";
            this.GB_Type.ResumeLayout(false);
            this.GB_Type.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Nbechantillon)).EndInit();
            this.GB_Taille.ResumeLayout(false);
            this.GB_Taille.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Open;
        private System.Windows.Forms.TextBox TXB_OpenPath;
        private System.Windows.Forms.GroupBox GB_Type;
        private System.Windows.Forms.RadioButton RB_Syst;
        private System.Windows.Forms.RadioButton RB_Simple;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NUD_Nbechantillon;
        private System.Windows.Forms.GroupBox GB_Taille;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RB_Different;
        private System.Windows.Forms.RadioButton RB_Fixe;
        private System.Windows.Forms.TextBox TXB_Taille;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXB_SaveFile;
        private System.Windows.Forms.CheckBox CB_Copy;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.TextBox TXB_SavePath;
        private System.Windows.Forms.Button BTN_Start;
    }
}

