using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estoque.Module
{ 
    public class Fornecedor
    {
        private int _idFornecedor;
        private string _nome;
        private string _empresa;
        private string _rua;

        #region Construtor
        public Fornecedor()
        {
        }
        #endregion

        #region Atributos


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


        #endregion

    }
    
}
