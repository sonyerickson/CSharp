using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MeuDestinatario.Comercial;
using System.Drawing.Drawing2D;

namespace MeuDestinatario
{
    public class RetornoEvents : EventArgs  // ExemploEventHandler
    {
        private int mvalor;

        public RetornoEvents(int valor)
        {
            mvalor = valor;
        }

        public int Valor
        {
            get {return mvalor;}
            set {mvalor = value;}
        }
    }
    public delegate void RetornoEventsHandler(object sender, RetornoEvents e);
}
