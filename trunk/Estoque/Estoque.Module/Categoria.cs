namespace Estoque.Module
{
  public class Categoria
  {
    private string _categoria;
    private int _idCategoria;

    #region Propriedades

    public string CategoriaP
    {
      get { return _categoria; }
      set { _categoria = value; }
    }

    public int IdCategoria
    {
      get { return _idCategoria; }
      set { _idCategoria = value; }
    }

    #endregion Propriedades
  }
}