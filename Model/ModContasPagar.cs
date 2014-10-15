using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModContasPagar
    {
        public class ModeladdConta
        {
            private int _codigo;
            private string _fornecedores;
            private decimal _vlrparcela;
            private decimal _vlrtotal;
            private decimal _qntparcela;
            private int _qntdias;
            private DateTime _dtVencimento;
            private DateTime _dtCompra;
            private string _condPgto;
            private string _formPgto;
            private string _conta;
            private string _categoria;
            private string _grupo;
            private string _subgrupo;
            
            public int codigo
            {
                get { return _codigo; }
                set { _codigo = value; }
            }
            public string fornecedores
            {
                get { return _fornecedores; }
                set { _fornecedores = value; }
            }
            public decimal vlrParcela
            {
                get { return _vlrparcela; }
                set { _vlrparcela = value; }
            }
            public decimal vlrTotal
            {
                get { return _vlrtotal; }
                set { _vlrtotal = value; }
            }
            public decimal qntParcela
            {
                get { return _qntparcela; }
                set { _qntparcela = value; }
            }
            public int qntDias
            {
                get { return _qntdias; }
                set { _qntdias = value; }
            }
            public DateTime dtVencimento
            {
                get { return _dtVencimento; }
                set { _dtVencimento = value; }
            }
            public DateTime dtCompra
            {
                get { return _dtCompra; }
                set { _dtCompra = value; }
            }
            public string condPgto
            {
                get { return _condPgto; }
                set { _condPgto = value; }
            }
            public string formPgto
            {
                get { return _formPgto; }
                set { _formPgto = value; }
            }
            public string conta
            {
                get { return _conta; }
                set { _conta = value; }
            }
            public string categoria
            {
                get { return _categoria; }
                set { _categoria = value; }
            }
            public string grupo
            {
                get { return _grupo; }
                set { _grupo = value; }
            }
            public string subgrupo
            {
                get { return _subgrupo; }
                set { _subgrupo = value; }
            }
        }
    }
}
