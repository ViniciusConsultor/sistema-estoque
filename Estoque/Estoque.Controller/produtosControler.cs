using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Estoque.Module;
using Estoque.Dados;

namespace Estoque.Controller
{
    public class produtosControler
    {

      #region Construtor
      
      public produtosControler()
      {

      }

      #endregion

      #region Métodos

      public List<Categoria> categoriaBanco(Configuracoes config)
      {

        #region Declaração
        produtosDAO produto = null;
        #endregion

        #region Implementação
        produto = new produtosDAO();

        return produto.carregaCatProd(config);

        #endregion
      }
      #endregion

    }
}
