using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estoque.Module
{
  public class Estado
  {
    private int _id;
    private string _estado;

    public int Id
    {
      get { return _id; }
      set { _id = value; }
    }

    public string Sigla
    {
      get { return _estado; }
      set { _estado = value; }
    }
  }
}
