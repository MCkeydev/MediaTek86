
namespace PROJET1.View
{
    partial class Main
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
            this.dataPersonnel = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new MaterialSkin.Controls.MaterialButton();
            this.btnModifier = new MaterialSkin.Controls.MaterialButton();
            this.btnSupprimer = new MaterialSkin.Controls.MaterialButton();
            this.btnAbsences = new MaterialSkin.Controls.MaterialButton();
            this.grpAjout = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.btnAjoutConfirmer = new MaterialSkin.Controls.MaterialButton();
            this.btnAjoutAnnuler = new MaterialSkin.Controls.MaterialButton();
            this.cbService = new MaterialSkin.Controls.MaterialComboBox();
            this.txtMail = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTel = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrenom = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNom = new MaterialSkin.Controls.MaterialTextBox();
            this.lblAjoutInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonnel)).BeginInit();
            this.grpAjout.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPersonnel
            // 
            this.dataPersonnel.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataPersonnel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPersonnel.Location = new System.Drawing.Point(6, 67);
            this.dataPersonnel.Name = "dataPersonnel";
            this.dataPersonnel.Size = new System.Drawing.Size(501, 371);
            this.dataPersonnel.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAjouter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAjouter.Depth = 0;
            this.btnAjouter.HighEmphasis = true;
            this.btnAjouter.Icon = null;
            this.btnAjouter.Location = new System.Drawing.Point(6, 447);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAjouter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAjouter.Size = new System.Drawing.Size(85, 36);
            this.btnAjouter.TabIndex = 1;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAjouter.UseAccentColor = false;
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModifier.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModifier.Depth = 0;
            this.btnModifier.HighEmphasis = true;
            this.btnModifier.Icon = null;
            this.btnModifier.Location = new System.Drawing.Point(99, 447);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModifier.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnModifier.Size = new System.Drawing.Size(88, 36);
            this.btnModifier.TabIndex = 2;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModifier.UseAccentColor = false;
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSupprimer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSupprimer.Depth = 0;
            this.btnSupprimer.HighEmphasis = true;
            this.btnSupprimer.Icon = null;
            this.btnSupprimer.Location = new System.Drawing.Point(195, 447);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSupprimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSupprimer.Size = new System.Drawing.Size(102, 36);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSupprimer.UseAccentColor = false;
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAbsences
            // 
            this.btnAbsences.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbsences.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAbsences.Depth = 0;
            this.btnAbsences.HighEmphasis = true;
            this.btnAbsences.Icon = null;
            this.btnAbsences.Location = new System.Drawing.Point(304, 447);
            this.btnAbsences.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAbsences.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAbsences.Size = new System.Drawing.Size(202, 36);
            this.btnAbsences.TabIndex = 4;
            this.btnAbsences.Text = "Gestionnaire Absences";
            this.btnAbsences.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAbsences.UseAccentColor = false;
            this.btnAbsences.UseVisualStyleBackColor = true;
            // 
            // grpAjout
            // 
            this.grpAjout.AllowDrop = true;
            this.grpAjout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpAjout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.grpAjout.CancelButtonText = "";
            this.grpAjout.CausesValidation = false;
            this.grpAjout.Controls.Add(this.lblAjoutInfo);
            this.grpAjout.Controls.Add(this.btnAjoutConfirmer);
            this.grpAjout.Controls.Add(this.btnAjoutAnnuler);
            this.grpAjout.Controls.Add(this.cbService);
            this.grpAjout.Controls.Add(this.txtMail);
            this.grpAjout.Controls.Add(this.txtTel);
            this.grpAjout.Controls.Add(this.txtPrenom);
            this.grpAjout.Controls.Add(this.txtNom);
            this.grpAjout.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.grpAjout.Depth = 0;
            this.grpAjout.Description = "PERSONNEL";
            this.grpAjout.Dock = System.Windows.Forms.DockStyle.Right;
            this.grpAjout.Enabled = false;
            this.grpAjout.ExpandHeight = 425;
            this.grpAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grpAjout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpAjout.Location = new System.Drawing.Point(517, 64);
            this.grpAjout.Margin = new System.Windows.Forms.Padding(16);
            this.grpAjout.MouseState = MaterialSkin.MouseState.HOVER;
            this.grpAjout.Name = "grpAjout";
            this.grpAjout.Padding = new System.Windows.Forms.Padding(24, 64, 24, 50);
            this.grpAjout.ShowValidationButtons = false;
            this.grpAjout.Size = new System.Drawing.Size(280, 425);
            this.grpAjout.TabIndex = 5;
            this.grpAjout.Title = "AJOUT";
            this.grpAjout.ValidationButtonText = "";
            // 
            // btnAjoutConfirmer
            // 
            this.btnAjoutConfirmer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAjoutConfirmer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAjoutConfirmer.Depth = 0;
            this.btnAjoutConfirmer.HighEmphasis = true;
            this.btnAjoutConfirmer.Icon = null;
            this.btnAjoutConfirmer.Location = new System.Drawing.Point(148, 368);
            this.btnAjoutConfirmer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAjoutConfirmer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAjoutConfirmer.Name = "btnAjoutConfirmer";
            this.btnAjoutConfirmer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAjoutConfirmer.Size = new System.Drawing.Size(104, 36);
            this.btnAjoutConfirmer.TabIndex = 8;
            this.btnAjoutConfirmer.Text = "Confirmer";
            this.btnAjoutConfirmer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnAjoutConfirmer.UseAccentColor = true;
            this.btnAjoutConfirmer.UseVisualStyleBackColor = true;
            this.btnAjoutConfirmer.Click += new System.EventHandler(this.btnAjoutConfirmer_Click);
            // 
            // btnAjoutAnnuler
            // 
            this.btnAjoutAnnuler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAjoutAnnuler.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAjoutAnnuler.Depth = 0;
            this.btnAjoutAnnuler.HighEmphasis = true;
            this.btnAjoutAnnuler.Icon = null;
            this.btnAjoutAnnuler.Location = new System.Drawing.Point(27, 368);
            this.btnAjoutAnnuler.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAjoutAnnuler.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAjoutAnnuler.Name = "btnAjoutAnnuler";
            this.btnAjoutAnnuler.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAjoutAnnuler.Size = new System.Drawing.Size(87, 36);
            this.btnAjoutAnnuler.TabIndex = 7;
            this.btnAjoutAnnuler.Text = "Annuler";
            this.btnAjoutAnnuler.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnAjoutAnnuler.UseAccentColor = true;
            this.btnAjoutAnnuler.UseVisualStyleBackColor = true;
            this.btnAjoutAnnuler.Click += new System.EventHandler(this.btnAjoutAnnuler_Click);
            // 
            // cbService
            // 
            this.cbService.AutoResize = false;
            this.cbService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbService.Depth = 0;
            this.cbService.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbService.DropDownHeight = 174;
            this.cbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbService.DropDownWidth = 121;
            this.cbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbService.FormattingEnabled = true;
            this.cbService.IntegralHeight = false;
            this.cbService.ItemHeight = 43;
            this.cbService.Location = new System.Drawing.Point(28, 294);
            this.cbService.MaxDropDownItems = 4;
            this.cbService.MouseState = MaterialSkin.MouseState.OUT;
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(225, 49);
            this.cbService.StartIndex = 0;
            this.cbService.TabIndex = 6;
            // 
            // txtMail
            // 
            this.txtMail.AnimateReadOnly = false;
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Depth = 0;
            this.txtMail.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMail.Hint = "Mail";
            this.txtMail.LeadingIcon = null;
            this.txtMail.Location = new System.Drawing.Point(28, 237);
            this.txtMail.MaxLength = 50;
            this.txtMail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMail.Multiline = false;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(225, 50);
            this.txtMail.TabIndex = 5;
            this.txtMail.Text = "";
            this.txtMail.TrailingIcon = null;
            // 
            // txtTel
            // 
            this.txtTel.AnimateReadOnly = false;
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTel.Depth = 0;
            this.txtTel.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTel.Hint = "Téléphone";
            this.txtTel.LeadingIcon = null;
            this.txtTel.Location = new System.Drawing.Point(28, 180);
            this.txtTel.MaxLength = 50;
            this.txtTel.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTel.Multiline = false;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(225, 50);
            this.txtTel.TabIndex = 4;
            this.txtTel.Text = "";
            this.txtTel.TrailingIcon = null;
            // 
            // txtPrenom
            // 
            this.txtPrenom.AnimateReadOnly = false;
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrenom.Depth = 0;
            this.txtPrenom.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrenom.Hint = "Prenom";
            this.txtPrenom.LeadingIcon = null;
            this.txtPrenom.Location = new System.Drawing.Point(27, 123);
            this.txtPrenom.MaxLength = 50;
            this.txtPrenom.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrenom.Multiline = false;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(226, 50);
            this.txtPrenom.TabIndex = 3;
            this.txtPrenom.Text = "";
            this.txtPrenom.TrailingIcon = null;
            // 
            // txtNom
            // 
            this.txtNom.AnimateReadOnly = false;
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNom.Depth = 0;
            this.txtNom.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNom.Hint = "Nom";
            this.txtNom.LeadingIcon = null;
            this.txtNom.Location = new System.Drawing.Point(27, 67);
            this.txtNom.MaxLength = 50;
            this.txtNom.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNom.Multiline = false;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(226, 50);
            this.txtNom.TabIndex = 2;
            this.txtNom.Text = "";
            this.txtNom.TrailingIcon = null;
            // 
            // lblAjoutInfo
            // 
            this.lblAjoutInfo.AutoSize = true;
            this.lblAjoutInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAjoutInfo.Location = new System.Drawing.Point(27, 346);
            this.lblAjoutInfo.Name = "lblAjoutInfo";
            this.lblAjoutInfo.Size = new System.Drawing.Size(0, 16);
            this.lblAjoutInfo.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.grpAjout);
            this.Controls.Add(this.btnAbsences);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.dataPersonnel);
            this.DrawerUseColors = true;
            this.MaximumSize = new System.Drawing.Size(800, 492);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Gestion du personnel";
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonnel)).EndInit();
            this.grpAjout.ResumeLayout(false);
            this.grpAjout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPersonnel;
        private MaterialSkin.Controls.MaterialButton btnAjouter;
        private MaterialSkin.Controls.MaterialButton btnModifier;
        private MaterialSkin.Controls.MaterialButton btnSupprimer;
        private MaterialSkin.Controls.MaterialButton btnAbsences;
        private MaterialSkin.Controls.MaterialExpansionPanel grpAjout;
        private MaterialSkin.Controls.MaterialTextBox txtMail;
        private MaterialSkin.Controls.MaterialTextBox txtTel;
        private MaterialSkin.Controls.MaterialTextBox txtPrenom;
        private MaterialSkin.Controls.MaterialTextBox txtNom;
        private MaterialSkin.Controls.MaterialComboBox cbService;
        private MaterialSkin.Controls.MaterialButton btnAjoutAnnuler;
        private MaterialSkin.Controls.MaterialButton btnAjoutConfirmer;
        private System.Windows.Forms.Label lblAjoutInfo;
    }
}

