using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estoque.Module
{
  public class Usuario
  {

    #region Atributos

    private string _user;
    private string _senha;
    private string _perfil;
    private bool _acesso;
    private int _idFuncionario;
    private bool _ativo;

    #endregion

    #region Propriedades

    public string User
    {
      get { return _user; }
      set { _user = value; }
    }

    public string Senha
    {
      get { return _senha; }
      set { _senha = value; }
    }

    public string Perfil
    {
      get { return _perfil; }
      set { _perfil = value; }
    }

    public bool Acesso
    {
      get { return _acesso; }
      set { _acesso = value; }
    }

    public int IdFuncionario
    {
      get { return _idFuncionario; }
      set { _idFuncionario = value; }
    }

    public bool Ativo
    {
      get { return _ativo; }
      set { _ativo = value; }
    }

    #endregion

  }
}
