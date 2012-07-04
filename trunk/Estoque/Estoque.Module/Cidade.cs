using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estoque.Module
{
  public class Cidade
  {
    private int _id;
    private string _cidade;
    private int _idEstado;

    public int Id
    {
      get { return _id; }
      set { _id = value; }
    }

    public string Nome
    {
      get { return _cidade; }
      set { _cidade = value; }
    }

    public int IdEstado
    {
      get { return _idEstado; }
      set { _idEstado = value; }
    }
  }
}
