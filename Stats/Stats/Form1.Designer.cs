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
            this.lb_Max = new System.Windows.Forms.Label();
            this.lb_Min = new System.Windows.Forms.Label();
            this.lb_Taille = new System.Windows.Forms.Label();
            this.RB_Different = new System.Windows.Forms.RadioButton();
            this.RB_Fixe = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TXB_SaveFile = new System.Windows.Forms.TextBox();
            this.CB_Copy = new System.Windows.Forms.CheckBox();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.TXB_SavePath = new System.Windows.Forms.TextBox();
            this.BTN_Start = new System.Windows.Forms.Button();
            this.num_TailleMin = new System.Windows.Forms.NumericUpDown();
            this.num_TailleMax = new System.Windows.Forms.NumericUpDown();
            this.num_Taille = new System.Windows.Forms.NumericUpDown();
            this.GB_Type.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Nbechantillon)).BeginInit();
            this.GB_Taille.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TailleMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TailleMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Taille)).BeginInit();
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
            this.RB_Syst.Click += new System.EventHandler(this.RB_Click);
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
            this.RB_Simple.Click += new System.EventHandler(this.RB_Click);
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
            9999,
            0,
            0,
            0});
            this.NUD_Nbechantillon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Nbechantillon.Name = "NUD_Nbechantillon";
            this.NUD_Nbechantillon.Size = new System.Drawing.Size(57, 20);
            this.NUD_Nbechantillon.TabIndex = 5;
            this.NUD_Nbechantillon.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Nbechantillon.ValueChanged += new System.EventHandler(this.NUD_Nbechantillon_ValueChanged);
            // 
            // GB_Taille
            // 
            this.GB_Taille.Controls.Add(this.lb_Max);
            this.GB_Taille.Controls.Add(this.lb_Taille);
            this.GB_Taille.Controls.Add(this.RB_Different);
            this.GB_Taille.Controls.Add(this.lb_Min);
            this.GB_Taille.Controls.Add(this.RB_Fixe);
            this.GB_Taille.Controls.Add(this.num_Taille);
            this.GB_Taille.Controls.Add(this.num_TailleMax);
            this.GB_Taille.Controls.Add(this.num_TailleMin);
            this.GB_Taille.Location = new System.Drawing.Point(255, 52);
            this.GB_Taille.Name = "GB_Taille";
            this.GB_Taille.Size = new System.Drawing.Size(161, 97);
            this.GB_Taille.TabIndex = 6;
            this.GB_Taille.TabStop = false;
            this.GB_Taille.Text = "Taille";
            // 
            // lb_Max
            // 
            this.lb_Max.AutoSize = true;
            this.lb_Max.Location = new System.Drawing.Point(85, 61);
            this.lb_Max.Name = "lb_Max";
            this.lb_Max.Size = new System.Drawing.Size(27, 13);
            this.lb_Max.TabIndex = 12;
            this.lb_Max.Text = "Max";
            this.lb_Max.Visible = false;
            this.lb_Max.Click += new System.EventHandler(this.lb_Max_Click);
            // 
            // lb_Min
            // 
            this.lb_Min.AutoSize = true;
            this.lb_Min.Location = new System.Drawing.Point(12, 61);
            this.lb_Min.Name = "lb_Min";
            this.lb_Min.Size = new System.Drawing.Size(24, 13);
            this.lb_Min.TabIndex = 12;
            this.lb_Min.Text = "Min";
            this.lb_Min.Visible = false;
            this.lb_Min.Click += new System.EventHandler(this.lb_Min_Click);
            // 
            // lb_Taille
            // 
            this.lb_Taille.AutoSize = true;
            this.lb_Taille.Location = new System.Drawing.Point(29, 59);
            this.lb_Taille.Name = "lb_Taille";
            this.lb_Taille.Size = new System.Drawing.Size(32, 13);
            this.lb_Taille.TabIndex = 3;
            this.lb_Taille.Text = "Taille";
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
            this.RB_Different.Click += new System.EventHandler(this.RB_Click);
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
            this.RB_Fixe.Click += new System.EventHandler(this.RB_Click);
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
            // num_TailleMin
            // 
            this.num_TailleMin.Location = new System.Drawing.Point(38, 58);
            this.num_TailleMin.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_TailleMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_TailleMin.Name = "num_TailleMin";
            this.num_TailleMin.Size = new System.Drawing.Size(41, 20);
            this.num_TailleMin.TabIndex = 5;
            this.num_TailleMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_TailleMax
            // 
            this.num_TailleMax.Location = new System.Drawing.Point(112, 58);
            this.num_TailleMax.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.num_TailleMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_TailleMax.Name = "num_TailleMax";
            this.num_TailleMax.Size = new System.Drawing.Size(41, 20);
            this.num_TailleMax.TabIndex = 5;
            this.num_TailleMax.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_Taille
            // 
            this.num_Taille.Location = new System.Drawing.Point(67, 57);
            this.num_Taille.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.num_Taille.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Taille.Name = "num_Taille";
            this.num_Taille.Size = new System.Drawing.Size(57, 20);
            this.num_Taille.TabIndex = 5;
            this.num_Taille.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_Taille.ValueChanged += new System.EventHandler(this.NUD_Nbechantillon_ValueChanged);
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
            ((System.ComponentModel.ISupportInitialize)(this.num_TailleMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TailleMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Taille)).EndInit();
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
        private System.Windows.Forms.Label lb_Taille;
        private System.Windows.Forms.RadioButton RB_Different;
        private System.Windows.Forms.RadioButton RB_Fixe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXB_SaveFile;
        private System.Windows.Forms.CheckBox CB_Copy;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.TextBox TXB_SavePath;
        private System.Windows.Forms.Button BTN_Start;
        private System.Windows.Forms.Label lb_Max;
        private System.Windows.Forms.Label lb_Min;
        private System.Windows.Forms.NumericUpDown num_TailleMax;
        private System.Windows.Forms.NumericUpDown num_TailleMin;
        private System.Windows.Forms.NumericUpDown num_Taille;
    }
}

