using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROJET1.View;
namespace PROJET1.Controller
{
    public class Controle
    {
        private readonly FrmAuth frmAuth;
        public Controle()
        {
            this.frmAuth = new FrmAuth(this);
            this.frmAuth.ShowDialog();
        }
    }
}
