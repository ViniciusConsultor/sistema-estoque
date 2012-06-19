using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estoque.Module
{ 
    public class Fornecedor
    {
        

        #region Construtor
        public Fornecedor()
        {
        }
        #endregion

        #region Atributos

        private int _idFornecedor;
        private string _nome;
        private string _empresa;
        private string _rua;
        private string _numCasa;
        private string _cidade;
        private string _estado;
        private string _cEP;
        private string _foneComercial;
        private string _celular;
        private string _marcasRep;

        #endregion

        #region Properties

        public int IdFornecedor
        {
            get { return _idFornecedor; }
            set { _idFornecedor = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }

        public string Rua
        {
            get { return _rua; }
            set { _rua = value; }
        }

        public string NumCasa
        {
            get { return _numCasa; }
            set { _numCasa = value; }
        }

        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public string CEP
        {
            get { return _cEP; }
            set { _cEP = value; }
        }

        public string FoneComercial
        {
            get { return _foneComercial; }
            set { _foneComercial = value; }
        }

        public string Celular
        {
            get { return _celular; }
            set { _celular = value; }
        }

        public string MarcasRep
        {
            get { return _marcasRep; }
            set { _marcasRep = value; }
        }

        #endregion

    }
    
}
