﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estoque.Module
{
    public class Produto
    {

        #region Atributos

        private int _id;
        private string _nome;
        private string _quantidade;
        private string _valor;
        private List<string> _categoria;
        #endregion

        #region Construtor

        public Produto()
        {
        }

        #endregion

        #region Properties

        public List<string> Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Quantidade
        {
            get { return _quantidade; }
            set { _quantidade = value; }
        }

        public string Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        #endregion

    }
}