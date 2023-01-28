var connection = new FakeDB<Usuario>();
var criptografia = new CriptografiaPBKDF2();
var repo = new UsuarioRepository(connection, criptografia);

class Usuario
{
    public string Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}

interface IDbConnection<T>
{
    List<T> Data { get; set; }
}

class FakeDB<T> : IDbConnection<T>
{
    public List<T> Data { get; set; }
}

interface ICriptografia
{
    string Encrypt(string text);
}

class CriptografiaMD5 : ICriptografia
{
    // Imaginem que está criptografando
    public string Encrypt(string text) => text;
}

class CriptografiaPBKDF2 : ICriptografia
{
    // Imaginem que está criptografando
    public string Encrypt(string text) => text;
}

class UsuarioRepository
{
    private readonly IDbConnection<Usuario> _dbConnection;
    private readonly ICriptografia _criptografia;

    public UsuarioRepository(IDbConnection<Usuario> dbConnection,
        ICriptografia criptografia)
    {
        _dbConnection = dbConnection;
        _criptografia = criptografia;
    }

    public void Add(Usuario obj)
    {
        obj.Password = _criptografia.Encrypt(obj.Password);
        _dbConnection.Data.Add(obj);
    }

    public Usuario Get(string id)
    {
        return _dbConnection.Data.FirstOrDefault(x => x.Id == id);
    }

    public IEnumerable<Usuario> List()
    {
        return _dbConnection.Data;
    }

    public void Remove(Usuario obj)
    {
        _dbConnection.Data.Remove(obj);
    }

    public void Remove(string id)
    {
        var usuario = Get(id);

        if (usuario != null)
            Remove(usuario);
    }
}