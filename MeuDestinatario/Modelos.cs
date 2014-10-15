using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDestinatario
{
    public class Modelos
    {
        private string nCodigo;
        private string nNome;
        private string nEmail;
        private string nEndereco;
        private string nNumero;
        private string nComplemento;
        private string nSenha;

        public string Codigo
        {
            get { return nCodigo; }
            set { nCodigo = value; }
        }
        public string Nome
        {
            get { return nNome; }
            set { nNome = value; }
        }
        public string Email
        {
            get { return nEmail; }
            set { nEmail = value; }
        }
        public string Endereco
        {
            get { return nEndereco; }
            set { nEndereco = value; }
        }
        public string Numero
        {
            get { return nNumero; }
            set { nNumero = value; }
        }
        public string Complemento
        {
            get { return nComplemento; }
            set { nComplemento = value; }
        }
        public string Senha
        {
            get { return nSenha; }
            set { nSenha = value; }
        }
    }
}
