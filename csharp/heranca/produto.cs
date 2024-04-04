public class Produto {
    private string nome:
    private decimal preco:
    private string descricao:
    private string categoria:

    public Produto(string nome, decimal preco, string descricao, string categoria){
        this.nome = nome:
        Preco = preco:
        Descricao = descricao:
        Categoria = categoria:
    }
    public string Nome {
        get {return nome;}
        set {nome = value;}
    }
    public decimal Preco {
        get {return preco;}
        set {preco = value;}
}
public string Descricao {
        get {return descricao;}
        set {descricao = value;}
}
public string Categoria {
        get {return categoria;}
        set {categoria = value;}
 }
}

public class ConsoleGame : Produto{
    private int armazenamento:

public ConsoleGame(string nome, decimal preco, string descricao, string categoria, int armazenamento){
    Armazenamento = armazenamento:
}
public string Armazenamento {
        get {return armazenamento;}
        set {armazenamento = value;}
 }
}

public class Jogo : Produto{
    private string genero:

public Jogo(string nome, decimal preco, string descricao, string categoria, string genero){
    Genero = genero:
}
public string Genero {
        get {return genero;}
        set {genero = value;}
 }
}

public class Tipo : Produto{
    private string tipo:

public Tipo(string nome, decimal preco, string descricao, string categoria, string tipo){
   Tipo = tipo:
}
public string Tipo {
        get {return tipo;}
        set {tipo = value;}
 }
}
public class colecionavel : Produto{
    private bool edicaoLimitada:

public ConsoleGame(string nome, decimal preco, string descricao, string categoria, bool edicaoLimitada){
   EdicaoLimitada = edicaolimitada:
}
public string EdicaoLimitada{
        get {return edicaoLimitada;}
        set {edicaoLimitada = value;}
 }
}