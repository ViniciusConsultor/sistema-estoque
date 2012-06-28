using System;
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
    private string _categoria;
    private int _idCategoria;
    private string _valorAPrazo;
    private string _valorBase;
    private string _valorCrediario;
    private bool _disponivel;
    private string _codigoBarras;
    private int _idFornecedor;
    private string _nomeFornecedor;
    #endregion

    #region Construtor

    public Produto()
    {
    }

    #endregion

    #region Properties

    public string Categoria
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

    public string ValoraVista
    {
      get { return _valor; }
      set { _valor = value; }
    }

    public int IdCategoria
    {
      get { return _idCategoria; }
      set { _idCategoria = value; }
    }

    public string ValorAPrazo
    {
      get { return _valorAPrazo; }
      set { _valorAPrazo = value; }
    }

    public string ValorBase
    {
      get { return _valorBase; }
      set { _valorBase = value; }
    }

    public string ValorCrediario
    {
      get { return _valorCrediario; }
      set { _valorCrediario = value; }
    }

    public bool Disponivel
    {
      get { return _disponivel; }
      set { _disponivel = value; }
    }

    public string CodigoBarras
    {
      get { return _codigoBarras; }
      set { _codigoBarras = value; }
    }

    public int IdFornecedor
    {
      get { return _idFornecedor; }
      set { _idFornecedor = value; }
    }

    public string NomeFornecedor
    {
      get { return _nomeFornecedor; }
      set { _nomeFornecedor = value; }
    }

    #endregion

  }
}
