
namespace PROJET1.View

{
    partial class FrmAuth
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
            this.txtLogin = new MaterialSkin.Controls.MaterialTextBox();
            this.lblLogin = new MaterialSkin.Controls.MaterialLabel();
            this.lblPwd = new MaterialSkin.Controls.MaterialLabel();
            this.txtPwd = new MaterialSkin.Controls.MaterialTextBox2();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.btnLoginAnnuler = new MaterialSkin.Controls.MaterialButton();
            this.lblLoginInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.AnimateReadOnly = false;
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Depth = 0;
            this.txtLogin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLogin.LeadingIcon = null;
            this.txtLogin.Location = new System.Drawing.Point(17, 105);
            this.txtLogin.MaxLength = 50;
            this.txtLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.txtLogin.Multiline = false;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLogin.Size = new System.Drawing.Size(267, 50);
            this.txtLogin.TabIndex = 0;
            this.txtLogin.Text = "";
            this.txtLogin.TrailingIcon = null;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Depth = 0;
            this.lblLogin.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblLogin.Location = new System.Drawing.Point(17, 83);
            this.lblLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(73, 19);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Identifiant";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Depth = 0;
            this.lblPwd.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPwd.Location = new System.Drawing.Point(17, 169);
            this.lblPwd.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(96, 19);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "Mot de passe";
            // 
            // txtPwd
            // 
            this.txtPwd.AnimateReadOnly = true;
            this.txtPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPwd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPwd.Depth = 0;
            this.txtPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPwd.HideSelection = true;
            this.txtPwd.LeadingIcon = null;
            this.txtPwd.Location = new System.Drawing.Point(17, 192);
            this.txtPwd.MaxLength = 32767;
            this.txtPwd.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '\0';
            this.txtPwd.PrefixSuffixText = null;
            this.txtPwd.ReadOnly = false;
            this.txtPwd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPwd.SelectedText = "";
            this.txtPwd.SelectionLength = 0;
            this.txtPwd.SelectionStart = 0;
            this.txtPwd.ShortcutsEnabled = true;
            this.txtPwd.Size = new System.Drawing.Size(267, 48);
            this.txtPwd.TabIndex = 3;
            this.txtPwd.TabStop = false;
            this.txtPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPwd.TrailingIcon = null;
            this.txtPwd.UseSystemPasswordChar = false;
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = null;
            this.btnLogin.Location = new System.Drawing.Point(17, 286);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(128, 36);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Se Connecter";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnLoginAnnuler
            // 
            this.btnLoginAnnuler.AutoSize = false;
            this.btnLoginAnnuler.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoginAnnuler.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLoginAnnuler.Depth = 0;
            this.btnLoginAnnuler.ForeColor = System.Drawing.Color.Maroon;
            this.btnLoginAnnuler.HighEmphasis = true;
            this.btnLoginAnnuler.Icon = null;
            this.btnLoginAnnuler.Location = new System.Drawing.Point(156, 286);
            this.btnLoginAnnuler.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoginAnnuler.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLoginAnnuler.Name = "btnLoginAnnuler";
            this.btnLoginAnnuler.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLoginAnnuler.Size = new System.Drawing.Size(128, 36);
            this.btnLoginAnnuler.TabIndex = 5;
            this.btnLoginAnnuler.Text = "Annuler";
            this.btnLoginAnnuler.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLoginAnnuler.UseAccentColor = false;
            this.btnLoginAnnuler.UseVisualStyleBackColor = true;
            this.btnLoginAnnuler.Click += new System.EventHandler(this.btnLoginAnnuler_Click);
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.AutoSize = true;
            this.lblLoginInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginInfo.ForeColor = System.Drawing.Color.Red;
            this.lblLoginInfo.Location = new System.Drawing.Point(17, 243);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(156, 20);
            this.lblLoginInfo.TabIndex = 6;
            this.lblLoginInfo.Text = "Identifians incorrects";
            // 
            // FrmAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(302, 362);
            this.Controls.Add(this.lblLoginInfo);
            this.Controls.Add(this.btnLoginAnnuler);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "FrmAuth";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Se Connecter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtLogin;
        private MaterialSkin.Controls.MaterialLabel lblLogin;
        private MaterialSkin.Controls.MaterialLabel lblPwd;
        private MaterialSkin.Controls.MaterialTextBox2 txtPwd;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialButton btnLoginAnnuler;
        private System.Windows.Forms.Label lblLoginInfo;
    }
}