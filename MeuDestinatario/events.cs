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
using System.Drawing.Drawing2D;

namespace MeuDestinatario
{
    public class events
    {
        public event System.EventHandler eventhead;
          

        public event RetornoEventsHandler EventoExemplo;


        public void OnEventoExemplo(RetornoEvents e)
        {
            if (EventoExemplo != null)
                EventoExemplo(this, e);
        }
        public void UmMetodo()
        {
            for (int i = 1; i <= 100; i++)
            {
                OnEventoExemplo(new RetornoEvents(i));
                //System.Threading.Thread.Sleep(200);
            }
        }


        public void OnEventoExemplo2(EventArgs e)
        {
            if (eventhead != null)
                eventhead(this, e);
        }

        public void metodoteste()
        {
            for (int i = 1; i <= 100; i++)
            {
                OnEventoExemplo2(new EventArgs());
            }
        }
    }
}
