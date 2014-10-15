using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Mod
    {
        public class ModelFornecedores
        {
            private string eid_fornecedor;
            private string eNome;
            private string eCNPJ;


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
            public string Cnpj
            {
                get { return eCNPJ; }
                set { eCNPJ = value; }
            }
        }

        public class ModelUsuarios
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

        public class ModelPedidos
        {
            private string eIDPedido;
            private string eCRastreamento;
            private string eListaItens;
            private string eid_nome;
            private string eid_status;
            private string eDataPedido;
            private string eQntEst;
            private string eQntFin;
            private string eDataChegada;
            private string eDataRetirada;
            private string eValorEst;
            private string eValorPago;
            private bool eCancelado;
            private string eDataPrevisao;

            public string IDPedido
            {
                get { return eIDPedido; }
                set { eIDPedido = value; }
            }
            public string CRastreamento
            {
                get { return eCRastreamento; }
                set { eCRastreamento = value; }
            }
            public string ListaItens
            {
                get { return eListaItens; }
                set { eListaItens = value; }
            }
            public string Id_nome
            {
                get { return eid_nome; }
                set { eid_nome = value; }
            }
            public string Id_status
            {
                get { return eid_status; }
                set { eid_status = value; }
            }
            public string DataPedido
            {
                get { return eDataPedido; }
                set { eDataPedido = value; }
            }
            public string QntEst
            {
                get { return eQntEst; }
                set { eQntEst = value; }
            }
            public string QntFin
            {
                get { return eQntFin; }
                set { eQntFin = value; }
            }
            public string DataChegada
            {
                get { return eDataChegada; }
                set { eDataChegada = value; }
            }
            public string DataRetirada
            {
                get { return eDataRetirada; }
                set { eDataRetirada = value; }
            }
            public string ValorEst
            {
                get { return eValorEst; }
                set { eValorEst = value; }
            }
            public string ValorPago
            {
                get { return eValorPago; }
                set { eValorPago = value; }
            }
            public bool Cancelado
            {
                get { return eCancelado; }
                set { eCancelado = value; }
            }
            public string DataPrevisao
            {
                get { return eDataPrevisao; }
                set { eDataPrevisao = value; }
            }

        }

        public class ModelClientes
        {
            private string _idclientes;
            private string _Nome;
            private string _Endereco;
            private string _Telefone;
            private string _Email;

            public string idclientes
            {
                get { return _idclientes; }
                set { _idclientes = value; }
            }
            public string Nome
            {
                get { return _Nome; }
                set { _Nome = value; }
            }
            public string Endereco
            {
                get { return _Endereco; }
                set { _Endereco = value; }
            }
            public string Telefone
            {
                get { return _Telefone; }
                set { _Telefone = value; }
            }
            public string Email
            {
                get { return _Email; }
                set { _Email = value; }
            }
        }

        public class ModelBancos
        {
            private string _idbanco;
            private string _nome;

            public string idbanco
            {
                get { return _idbanco; }
                set { _idbanco = value; }
            }
            public string nome
            {
                get { return _nome; }
                set { _nome = value; }
            }
        }
        public class ModelContas
        {
            private string _idconta;
            private string _nome;
            private string _idbanco;
            private string _nconta;
            private string _nagencia;

            public string idconta
            {
                get { return _idconta; }
                set { _idconta = value; }
            }
            public string nome
            {
                get { return _nome; }
                set { _nome = value; }
            }
            public string idbanco
            {
                get { return _idbanco; }
                set { _idbanco = value; }
            }
            public string nconta
            {
                get { return _nconta; }
                set { _nconta = value; }
            }
            public string nagencia
            {
                get { return _nagencia; }
                set { _nagencia = value; }
            }
        }
        public class ModelContasPagar
        {
            private string _idcontapagar;
            private string _idfornecedor;
            private string _datadecompra;
            private string _datadevencimento;
            private decimal _valorTotal;
            private string _valorpago;
            private string _tipo;
            private string _categoria;
            private string _grupo;
            private string _subgrupo;
            private float __value;

            public float value
            {
                get { return __value; }
                set { __value = value; }
            }

            public string idcontapagar
            {
                get { return _idcontapagar; }
                set { _idcontapagar = value; }
            }
            public string idfornecedor
            {
                get { return _idfornecedor; }
                set { _idfornecedor = value; }
            }
            public string datadecompra
            {
                get { return _datadecompra; }
                set { _datadecompra = value; }
            }
            public string datadevencimento
            {
                get { return _datadevencimento; }
                set { _datadevencimento = value; }
            }
            public decimal valorTotal
            {
                get { return _valorTotal; }
                set { _valorTotal = value; }
            }
            public string valorpago
            {
                get { return _valorpago; }
                set { _valorpago = value; }
            }
            public string tipo
            {
                get { return _tipo; }
                set { _tipo = value; }
            }
            public string classificacao
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
        public class ModelFatPagar
        {
            private string _idfatpagar;
            private string _iddespesas;
            private decimal _valorparcela;
            private string _valorpago;
            //private string _idconta;
            private string _datapagamento;
            private string _datadevencimento;


            public string idfatpagar
            {
                get { return _idfatpagar; }
                set { _idfatpagar = value; }
            }
            public string iddespesas
            {
                get { return _iddespesas; }
                set { _iddespesas = value; }
            }
            public decimal vlrparcela
            {
                get { return _valorparcela; }
                set { _valorparcela = value; }
            }
            public string valorpago
            {
                get { return _valorpago; }
                set { _valorpago = value; }
            }
            private string datapagamento
            {
                get { return _datapagamento; }
                set { _datapagamento = value; }
            }
            public string datavencimento
            {
                get { return _datadevencimento; }
                set { _datadevencimento = value; }
            }

        }
        public class ModelDespCondPgto
        {
            private string _id_d_cond_pgto;
            private string _descricao;
            private string _qnt_parc;
            private string _qnt_dias;

            public string iddcondpagto
            {
                get { return _id_d_cond_pgto; }
                set { _id_d_cond_pgto = value; }
            }
            public string descricao
            {
                get { return _descricao; }
                set { _descricao = value; }
            }
            public string qntparcela
            {
                get { return _qnt_parc;}
                set { _qnt_parc = value; }
            }
            public string qntdias
            {
                get { return _qnt_dias; }
                set { _qnt_dias = value; }
            }
        }
        
    }
}
