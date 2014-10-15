using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuDestinatario
{
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
}
