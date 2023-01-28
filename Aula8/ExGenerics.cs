////Crie um overload de métodos para comparar se string, int e double são iguais.

////Agora faça o mesmo que acima criando um método capaz de comparar qualquer objeto utilizando generics

//var a = new Pessoa { Id = 1, Nome = "" };
//var b = new Pessoa { Id = 1, Nome = "" };

//Console.WriteLine(ComprareGeneric(a, b));
//Console.ReadLine();

//bool Compare(string a, string b) => a == b;

//bool CompareInt(int a, int b) => a == b;

//bool CompareDouble(double a, double b) => a == b;

//bool ComprareGeneric<T>(T a, T b)
//{
//    return a.Equals(b);
//}

//bool ComprareGenericConstraint<T>(T a, T b) where T : IEquatable<T>
//{
//    return a.Equals(b);
//}

//bool ComprareGenericEquatable<T>(T a, T b)
//{
//    return EqualityComparer<T>.Default.Equals(a, b);
//}

//class Pessoa : IEquatable<Pessoa>
//{
//    public int Id { get; set; }
//    public string Nome { get; set; }

//    public bool Equals(Pessoa? other)
//    {
//        var pessoaType = typeof(Pessoa);
//        var properties = pessoaType.GetProperties();
//        foreach (var property in properties)
//        {
//            var valueA = property.GetValue(this);
//            var valueB = property.GetValue(other);

//            if (!valueA.Equals(valueB))
//                return false;
//        }

//        return true;
//    }

//    //public bool Equals(Pessoa? other)
//    //{
//    //    return Id == other.Id;
//    //}
//}