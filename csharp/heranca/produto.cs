public class Produto {
    private string nome:
    private int preco:
    private string descricao:
    private string categoria:

    public Produto(string nome, int preco, string descricao, string categoria){
        Nome = nome:
        Preco = preco:
        Descricao = descricao:
        Categoria = categoria:
    }
    public string Nome {
        get {return nome;}
        set {nome = value;}
    }
    public int Preco {
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

public ConsoleGame(string nome, int preco, string descricao, string categoria, int armazenamento){
    Armazenamento = armazenamento:
}
public string Armazenamento {
        get {return armazenamento;}
        set {armazenamento = value;}
 }
}

public class Jogo : Produto{
    private string Genero:

public Jogo(string nome, int preco, string descricao, string categoria, string genero){
    Genero = genero:
}
public string Genero {
        get {return genero;}
        set {genero = value;}
 }
}

public class Acessorio : Produto{
    private string acessorio:

public Acessorio(string nome, int preco, string descricao, string categoria, string acessorio){
   acessorio = acessorio:
}
public string Acessorio {
        get {return acessorio;}
        set {acessorio = value;}
 }
}
public class colecionavel : Produto{
    private bool edicaolimitada:

public ConsoleGame(string nome, int preco, string descricao, string categoria, bool edicaolimitada){
   EdicaoLimitada = edicaolimitada:
}
public string EdicaoLimitada{
        get {return edicaolimitada;}
        set {edicaolimitada = value;}
 }
}