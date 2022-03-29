using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Personnel.Controller;

namespace Personnel.View

{/// <summary>
/// Formulaire WinForms qui permet l'authentification d'un utilisateur.
/// </summary>
    public partial class FrmAuth : MaterialForm
    {
        private readonly Controle controle;
        public FrmAuth(Controle controle)
        {
            this.controle = controle;
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            Init();
        }

        /// <summary>
        /// Cacher le label permettant d'informer l'utilisateur.
        /// </summary>
        public void Init()
        {
            lblLoginInfo.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == "" || txtPwd.Text == "")
            {
                MaterialSnackBar message = new MaterialSnackBar("Veuillez renseigner tous les champs", "OK", true);
                
                message.Show(this);
            }
            else
            {
                if(controle.Authentification(txtLogin.Text, txtPwd.Text))
                {


                }
                else
                {
                    MaterialSnackBar message = new MaterialSnackBar("Identifiants incorrects.", "OK", true);
                    message.Show(this);

                }
            }
        }

        private void btnLoginAnnuler_Click(object sender, EventArgs e)
        {
            
           
          var result =  MessageBox.Show(this, "Voulez-vous quitter l'application ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            if(result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

    }
}
