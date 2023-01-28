//var produtoRepositorio = new ProdutoRepository();

//var usuarioRepositorio = new UsuarioRepository();
//var usuario = usuarioRepositorio.Get();

//class Produto
//{
//    public int Id { get; set; }
//}

//class Usuario
//{
//    public string Id { get; set; }
//}

//interface IRepository<T>
//{
//    IEnumerable<T> List();
//    void Add(T obj);
//    void Remove(T obj);
//}

//interface IRepositoryInt<T> : IRepository<T>
//{
//    T Get(int id);
//    void Remove(int id);
//}

//interface IRepositoryString<T> : IRepository<T>
//{
//    T Get(string id);
//    void Remove(string id);
//}

//class ProdutoRepository : IRepositoryInt<Produto>
//{
//    public void Add(Produto obj)
//    {
//    }

//    public Produto Get(int id)
//    {
//        return new Produto();
//    }

//    public IEnumerable<Produto> List()
//    {
//        throw new NotImplementedException();
//    }

//    public void Remove(Produto obj)
//    {
//    }

//    public void Remove(int id)
//    {
//        throw new NotImplementedException();
//    }
//}

//class UsuarioRepository : IRepositoryString<Usuario>
//{
//    public void Add(Usuario obj)
//    {
//    }

//    public Usuario Get(string id)
//    {
//        return new Usuario();
//    }

//    public IEnumerable<Usuario> List()
//    {
//        throw new NotImplementedException();
//    }

//    public void Remove(Usuario obj)
//    {
//    }

//    public void Remove(string id)
//    {
//        throw new NotImplementedException();
//    }
//}