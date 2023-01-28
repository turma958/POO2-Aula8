//ListarProdutos(new List<Produto>
//{
//    new Produto
//    {
//        Descricao = "XPTO",
//        Preco = 10
//    },
//    new Produto
//    {
//        Descricao = "XPTO2",
//        Preco = 5
//    },
//    new ProdutoCelular
//    {
//        Preco = 10000
//    }
//});
//Console.ReadLine();

//void ListarProdutos(List<Produto> produtos)
//{
//    foreach (var p in produtos)
//    {
//        string descricao = p.ObterDescricao();
//        Console.WriteLine(descricao);
//    }
//}

//class Produto
//{
//    public string Descricao { get; set; }
//    public decimal Preco{ get; set; }

//    public virtual string ObterDescricao()
//    {
//        return $"{Descricao} - {Preco}";
//    }
//}

//class ProdutoCelular : Produto
//{
//    public override string ObterDescricao()
//    {
//        if (string.IsNullOrEmpty(Descricao))
//            throw new Exception("Descricao está nula!");

//        return base.ObterDescricao();
//    }
//}