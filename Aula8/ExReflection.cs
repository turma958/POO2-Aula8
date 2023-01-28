////Crie um método que receba um objeto genérico e liste as propriedades e métodos dele

////Crie um método que receba um objeto genérico e crie uma instância dele e a retorne

////ListMetadata(new Pessoa());

//var pessoa = CreateObject<Pessoa>();
//Console.ReadLine();

//void ListMetadata<T>(T obj)
//{
//    var objType = obj.GetType();
//    var properties = objType.GetProperties();
//    foreach (var item in properties)
//    {
//        Console.WriteLine($"{item.Name} - {item.GetValue(obj)}");
//    }

//    var methods = objType.GetMethods();
//    foreach (var item in methods)
//    {
//        Console.WriteLine($"{item.Name} - {item.ReturnType.Name}");
//    }
//}

//T CreateObject<T>()
//{
//    return Activator.CreateInstance<T>();
//}

//class Pessoa
//{
//    public required int Id { get; set; }
//}