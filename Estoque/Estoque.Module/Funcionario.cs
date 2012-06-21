using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estoque.Module
{
    public class Funcionario
    {
      private int _id;
      private string _nome;
      private string _usuario;
      private string _senha;
      private string _perfil;
      private string _email;
      private string _cpf;
      private string _rg;
      private string _ctps;
      private string _ctpsSerie;
      private string _telefone;
      private string _celular;
      private string _rua;
      private int _casaNmero;
      private int _idCidade;
      private int _idEstado;
      private string _cidade;
      private string _estado;
      private string _cargo;
      private DateTime _cadastradoEm;
      private bool _ativo;
      
      #region Propriedades

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

      public string Usuario
      {
        get { return _usuario; }
        set { _usuario = value; }
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

      public string Email
      {
        get { return _email; }
        set { _email = value; }
      }

      public string Cpf
      {
        get { return _cpf; }
        set { _cpf = value; }
      }

      public string Rg
      {
        get { return _rg; }
        set { _rg = value; }
      }

      public string Ctps
      {
        get { return _ctps; }
        set { _ctps = value; }
      }

      public string CtpsSerie
      {
        get { return _ctpsSerie; }
        set { _ctpsSerie = value; }
      }

      public string Telefone
      {
        get { return _telefone; }
        set { _telefone = value; }
      }

      public string Celular
      {
        get { return _celular; }
        set { _celular = value; }
      }

      public string Rua
      {
        get { return _rua; }
        set { _rua = value; }
      }

      public int CasaNmero
      {
        get { return _casaNmero; }
        set { _casaNmero = value; }
      }

      public int IdCidade
      {
        get { return _idCidade; }
        set { _idCidade = value; }
      }

      public string Cidade
      {
        get { return _cidade; }
        set { _cidade = value; }
      }

      public int IdEstado
      {
        get { return _idEstado; }
        set { _idEstado = value; }
      }

      public string Estado
      {
        get { return _estado; }
        set { _estado = value; }
      }

      public string Cargo
      {
        get { return _cargo; }
        set { _cargo = value; }
      }

      public DateTime CadastradoEm
      {
        get { return _cadastradoEm; }
        set { _cadastradoEm = value; }
      }

      public bool Ativo
      {
        get { return _ativo; }
        set { _ativo = value; }
      }

      #endregion

    }
}
