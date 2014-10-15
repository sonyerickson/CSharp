using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDestinatario
{
    public class ModelFornecedores
    {
        private string eid_fornecedor;
        private string eNome;
        private DateTime eDateTime;

        public string id_fornecedor
        {
            get { return eid_fornecedor; }
            set { eid_fornecedor = value; }
        }
        public string nome
        {
            get { return eNome; }
            set { eNome = value; }
        }
        public DateTime DateTime
        {
            get { return eDateTime; }
            set { eDateTime = value; }
        }
    }
}
