
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
            this.txtNom = new MaterialSkin.Controls.MaterialTextBox();
            this.txtPrenom = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTel = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMail = new MaterialSkin.Controls.MaterialTextBox();
            this.cbService = new MaterialSkin.Controls.MaterialComboBox();
            this.btnAjoutAnnuler = new MaterialSkin.Controls.MaterialButton();
            this.btnAjoutConfirmer = new MaterialSkin.Controls.MaterialButton();
            this.lblAjoutInfo = new System.Windows.Forms.Label();
            this.grpAjout = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPersonnel = new System.Windows.Forms.TabPage();
            this.tabAb = new System.Windows.Forms.TabPage();
            this.lblDateMotif = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.lblDateFin = new MaterialSkin.Controls.MaterialLabel();
            this.lblDateDeb = new MaterialSkin.Controls.MaterialLabel();
            this.btnAbCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnAbSupprimer = new MaterialSkin.Controls.MaterialButton();
            this.btnAbModifier = new MaterialSkin.Controls.MaterialButton();
            this.btnAbAjouter = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAbsenceNom = new MaterialSkin.Controls.MaterialLabel();
            this.lblAbsence1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnAbSave = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonnel)).BeginInit();
            this.grpAjout.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPersonnel.SuspendLayout();
            this.tabAb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPersonnel
            // 
            this.dataPersonnel.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataPersonnel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPersonnel.Location = new System.Drawing.Point(0, 0);
            this.dataPersonnel.Name = "dataPersonnel";
            this.dataPersonnel.Size = new System.Drawing.Size(501, 380);
            this.dataPersonnel.TabIndex = 0;
            // 
            // btnAjouter
            // 
            this.btnAjouter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAjouter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAjouter.Depth = 0;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAjouter.HighEmphasis = true;
            this.btnAjouter.Icon = null;
            this.btnAjouter.Location = new System.Drawing.Point(7, 389);
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
            this.btnModifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModifier.HighEmphasis = true;
            this.btnModifier.Icon = null;
            this.btnModifier.Location = new System.Drawing.Point(97, 389);
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
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSupprimer.HighEmphasis = true;
            this.btnSupprimer.Icon = null;
            this.btnSupprimer.Location = new System.Drawing.Point(189, 389);
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
            this.btnAbsences.BackColor = System.Drawing.Color.White;
            this.btnAbsences.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAbsences.Depth = 0;
            this.btnAbsences.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAbsences.HighEmphasis = true;
            this.btnAbsences.Icon = null;
            this.btnAbsences.Location = new System.Drawing.Point(299, 389);
            this.btnAbsences.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAbsences.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAbsences.Size = new System.Drawing.Size(202, 36);
            this.btnAbsences.TabIndex = 4;
            this.btnAbsences.Text = "Gestionnaire Absences";
            this.btnAbsences.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAbsences.UseAccentColor = false;
            this.btnAbsences.UseVisualStyleBackColor = false;
            this.btnAbsences.Click += new System.EventHandler(this.btnAbsences_Click);
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
            // btnAjoutAnnuler
            // 
            this.btnAjoutAnnuler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAjoutAnnuler.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAjoutAnnuler.Depth = 0;
            this.btnAjoutAnnuler.HighEmphasis = true;
            this.btnAjoutAnnuler.Icon = null;
            this.btnAjoutAnnuler.Location = new System.Drawing.Point(42, 368);
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
            // lblAjoutInfo
            // 
            this.lblAjoutInfo.AutoSize = true;
            this.lblAjoutInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAjoutInfo.Location = new System.Drawing.Point(27, 346);
            this.lblAjoutInfo.Name = "lblAjoutInfo";
            this.lblAjoutInfo.Size = new System.Drawing.Size(0, 16);
            this.lblAjoutInfo.TabIndex = 9;
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
            this.grpAjout.DrawShadows = false;
            this.grpAjout.Enabled = false;
            this.grpAjout.ExpandHeight = 400;
            this.grpAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grpAjout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.grpAjout.Location = new System.Drawing.Point(502, 3);
            this.grpAjout.Margin = new System.Windows.Forms.Padding(16);
            this.grpAjout.MouseState = MaterialSkin.MouseState.HOVER;
            this.grpAjout.Name = "grpAjout";
            this.grpAjout.Padding = new System.Windows.Forms.Padding(24, 64, 24, 50);
            this.grpAjout.ShowValidationButtons = false;
            this.grpAjout.Size = new System.Drawing.Size(282, 400);
            this.grpAjout.TabIndex = 5;
            this.grpAjout.Title = "AJOUT";
            this.grpAjout.ValidationButtonText = "";
           
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPersonnel);
            this.tabControl.Controls.Add(this.tabAb);
            this.tabControl.Depth = 0;
            this.tabControl.Location = new System.Drawing.Point(6, 67);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(795, 432);
            this.tabControl.TabIndex = 6;
            // 
            // tabPersonnel
            // 
            this.tabPersonnel.BackColor = System.Drawing.Color.White;
            this.tabPersonnel.Controls.Add(this.grpAjout);
            this.tabPersonnel.Controls.Add(this.btnAbsences);
            this.tabPersonnel.Controls.Add(this.dataPersonnel);
            this.tabPersonnel.Controls.Add(this.btnAjouter);
            this.tabPersonnel.Controls.Add(this.btnModifier);
            this.tabPersonnel.Controls.Add(this.btnSupprimer);
            this.tabPersonnel.Location = new System.Drawing.Point(4, 22);
            this.tabPersonnel.Name = "tabPersonnel";
            this.tabPersonnel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonnel.Size = new System.Drawing.Size(787, 406);
            this.tabPersonnel.TabIndex = 0;
            this.tabPersonnel.Text = "Personnels";
            // 
            // tabAb
            // 
            this.tabAb.BackColor = System.Drawing.Color.White;
            this.tabAb.Controls.Add(this.materialCard1);
            this.tabAb.Controls.Add(this.btnAbSupprimer);
            this.tabAb.Controls.Add(this.btnAbModifier);
            this.tabAb.Controls.Add(this.btnAbAjouter);
            this.tabAb.Controls.Add(this.dataGridView1);
            this.tabAb.Controls.Add(this.lblAbsenceNom);
            this.tabAb.Controls.Add(this.lblAbsence1);
            this.tabAb.Location = new System.Drawing.Point(4, 22);
            this.tabAb.Name = "tabAb";
            this.tabAb.Padding = new System.Windows.Forms.Padding(3);
            this.tabAb.Size = new System.Drawing.Size(787, 406);
            this.tabAb.TabIndex = 1;
            this.tabAb.Text = "Absences";
            // 
            // lblDateMotif
            // 
            this.lblDateMotif.AutoSize = true;
            this.lblDateMotif.Depth = 0;
            this.lblDateMotif.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDateMotif.Location = new System.Drawing.Point(17, 151);
            this.lblDateMotif.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDateMotif.Name = "lblDateMotif";
            this.lblDateMotif.Size = new System.Drawing.Size(43, 19);
            this.lblDateMotif.TabIndex = 10;
            this.lblDateMotif.Text = "Motif ";
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(20, 173);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(426, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 9;
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Depth = 0;
            this.lblDateFin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDateFin.Location = new System.Drawing.Point(243, 82);
            this.lblDateFin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(57, 19);
            this.lblDateFin.TabIndex = 8;
            this.lblDateFin.Text = "Date fin";
         
            // 
            // lblDateDeb
            // 
            this.lblDateDeb.AutoSize = true;
            this.lblDateDeb.Depth = 0;
            this.lblDateDeb.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDateDeb.Location = new System.Drawing.Point(14, 82);
            this.lblDateDeb.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDateDeb.Name = "lblDateDeb";
            this.lblDateDeb.Size = new System.Drawing.Size(80, 19);
            this.lblDateDeb.TabIndex = 7;
            this.lblDateDeb.Text = "Date Début";
            // 
            // btnAbCancel
            // 
            this.btnAbCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnAbCancel.Depth = 0;
            this.btnAbCancel.HighEmphasis = true;
            this.btnAbCancel.Icon = null;
            this.btnAbCancel.Location = new System.Drawing.Point(264, 260);
            this.btnAbCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAbCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbCancel.Name = "btnAbCancel";
            this.btnAbCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAbCancel.Size = new System.Drawing.Size(87, 36);
            this.btnAbCancel.TabIndex = 2;
            this.btnAbCancel.Text = "Annuler";
            this.btnAbCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnAbCancel.UseAccentColor = true;
            this.btnAbCancel.UseVisualStyleBackColor = true;
            // 
            // btnAbSupprimer
            // 
            this.btnAbSupprimer.AutoSize = false;
            this.btnAbSupprimer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbSupprimer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAbSupprimer.Depth = 0;
            this.btnAbSupprimer.HighEmphasis = true;
            this.btnAbSupprimer.Icon = null;
            this.btnAbSupprimer.Location = new System.Drawing.Point(598, 37);
            this.btnAbSupprimer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAbSupprimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbSupprimer.Name = "btnAbSupprimer";
            this.btnAbSupprimer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAbSupprimer.Size = new System.Drawing.Size(149, 36);
            this.btnAbSupprimer.TabIndex = 5;
            this.btnAbSupprimer.Text = "Supprimer";
            this.btnAbSupprimer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAbSupprimer.UseAccentColor = true;
            this.btnAbSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAbModifier
            // 
            this.btnAbModifier.AutoSize = false;
            this.btnAbModifier.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbModifier.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAbModifier.Depth = 0;
            this.btnAbModifier.HighEmphasis = true;
            this.btnAbModifier.Icon = null;
            this.btnAbModifier.Location = new System.Drawing.Point(424, 37);
            this.btnAbModifier.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAbModifier.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbModifier.Name = "btnAbModifier";
            this.btnAbModifier.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAbModifier.Size = new System.Drawing.Size(166, 36);
            this.btnAbModifier.TabIndex = 4;
            this.btnAbModifier.Text = "Modifier";
            this.btnAbModifier.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAbModifier.UseAccentColor = false;
            this.btnAbModifier.UseVisualStyleBackColor = true;
            // 
            // btnAbAjouter
            // 
            this.btnAbAjouter.AutoSize = false;
            this.btnAbAjouter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbAjouter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAbAjouter.Depth = 0;
            this.btnAbAjouter.HighEmphasis = true;
            this.btnAbAjouter.Icon = null;
            this.btnAbAjouter.Location = new System.Drawing.Point(277, 37);
            this.btnAbAjouter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAbAjouter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbAjouter.Name = "btnAbAjouter";
            this.btnAbAjouter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAbAjouter.Size = new System.Drawing.Size(139, 36);
            this.btnAbAjouter.TabIndex = 3;
            this.btnAbAjouter.Text = "Ajouter";
            this.btnAbAjouter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAbAjouter.UseAccentColor = false;
            this.btnAbAjouter.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(9, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(251, 363);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblAbsenceNom
            // 
            this.lblAbsenceNom.AutoSize = true;
            this.lblAbsenceNom.Depth = 0;
            this.lblAbsenceNom.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAbsenceNom.Location = new System.Drawing.Point(110, 15);
            this.lblAbsenceNom.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAbsenceNom.Name = "lblAbsenceNom";
            this.lblAbsenceNom.Size = new System.Drawing.Size(158, 19);
            this.lblAbsenceNom.TabIndex = 1;
            this.lblAbsenceNom.Text = "COURREJOU Matthieu";
            // 
            // lblAbsence1
            // 
            this.lblAbsence1.AutoSize = true;
            this.lblAbsence1.BackColor = System.Drawing.Color.White;
            this.lblAbsence1.Depth = 0;
            this.lblAbsence1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAbsence1.Location = new System.Drawing.Point(6, 15);
            this.lblAbsence1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAbsence1.Name = "lblAbsence1";
            this.lblAbsence1.Size = new System.Drawing.Size(98, 19);
            this.lblAbsence1.TabIndex = 0;
            this.lblAbsence1.Text = "Absences de :";
            
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btnAbSave);
            this.materialCard1.Controls.Add(this.dateTimePicker2);
            this.materialCard1.Controls.Add(this.dateTimePicker1);
            this.materialCard1.Controls.Add(this.lblDateDeb);
            this.materialCard1.Controls.Add(this.btnAbCancel);
            this.materialCard1.Controls.Add(this.lblDateFin);
            this.materialCard1.Controls.Add(this.lblDateMotif);
            this.materialCard1.Controls.Add(this.materialComboBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(277, 84);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(470, 316);
            this.materialCard1.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 104);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(246, 104);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // btnAbSave
            // 
            this.btnAbSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAbSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnAbSave.Depth = 0;
            this.btnAbSave.HighEmphasis = true;
            this.btnAbSave.Icon = null;
            this.btnAbSave.Location = new System.Drawing.Point(359, 260);
            this.btnAbSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAbSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAbSave.Name = "btnAbSave";
            this.btnAbSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAbSave.Size = new System.Drawing.Size(104, 36);
            this.btnAbSave.TabIndex = 13;
            this.btnAbSave.Text = "Confirmer";
            this.btnAbSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnAbSave.UseAccentColor = false;
            this.btnAbSave.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tabControl);
            this.DrawerUseColors = true;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Gestion du personnel";
            ((System.ComponentModel.ISupportInitialize)(this.dataPersonnel)).EndInit();
            this.grpAjout.ResumeLayout(false);
            this.grpAjout.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPersonnel.ResumeLayout(false);
            this.tabPersonnel.PerformLayout();
            this.tabAb.ResumeLayout(false);
            this.tabAb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataPersonnel;
        private MaterialSkin.Controls.MaterialButton btnAjouter;
        private MaterialSkin.Controls.MaterialButton btnModifier;
        private MaterialSkin.Controls.MaterialButton btnSupprimer;
        private MaterialSkin.Controls.MaterialButton btnAbsences;
        private MaterialSkin.Controls.MaterialTextBox txtNom;
        private MaterialSkin.Controls.MaterialTextBox txtPrenom;
        private MaterialSkin.Controls.MaterialTextBox txtTel;
        private MaterialSkin.Controls.MaterialTextBox txtMail;
        private MaterialSkin.Controls.MaterialComboBox cbService;
        private MaterialSkin.Controls.MaterialButton btnAjoutAnnuler;
        private MaterialSkin.Controls.MaterialButton btnAjoutConfirmer;
        private System.Windows.Forms.Label lblAjoutInfo;
        private MaterialSkin.Controls.MaterialExpansionPanel grpAjout;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage tabPersonnel;
        private System.Windows.Forms.TabPage tabAb;
        private MaterialSkin.Controls.MaterialLabel lblAbsence1;
        private MaterialSkin.Controls.MaterialLabel lblAbsenceNom;
        private MaterialSkin.Controls.MaterialButton btnAbSupprimer;
        private MaterialSkin.Controls.MaterialButton btnAbModifier;
        private MaterialSkin.Controls.MaterialButton btnAbAjouter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton btnAbCancel;
        private MaterialSkin.Controls.MaterialLabel lblDateFin;
        private MaterialSkin.Controls.MaterialLabel lblDateDeb;
        private MaterialSkin.Controls.MaterialLabel lblDateMotif;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btnAbSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

