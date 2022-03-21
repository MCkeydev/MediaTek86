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
        private readonly FrmAuth FrmAuth;
        public Controle()
        {
            this.FrmAuth = new FrmAuth(this);
            this.FrmAuth.ShowDialog();
        }
    }
}
