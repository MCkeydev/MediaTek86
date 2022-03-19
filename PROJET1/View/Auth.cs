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
using PROJET1.Controller;

namespace PROJET1.View

{
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
        public void Init()
        {
            lblLoginInfo.Visible = false;
        }

   
    }
}
