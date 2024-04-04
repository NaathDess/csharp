public class Produto {
    private string nome:
    private decimal preco:
    private string descricao:
    private string categoria:

    public Produto(string nome, decimal preco, string descricao, string categoria){
        this.nome = nome:
        this.preco = preco:
        this.descricao = descricao:
        this.categoria = categoria:
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
public class Colecionavel : Produto{
    private bool edicaoLimitada:

public Colecionavel(string nome, decimal preco, string descricao, string categoria, bool edicaoLimitada){
   EdicaoLimitada = edicaolimitada:
}
public string EdicaoLimitada{
        get {return edicaoLimitada;}
        set {edicaoLimitada = value;}
 }
}

public class Program {
    public static void main (string[] args) {
        ConsoleGame consoleGame = new ConsoleGame ("PlayStation 4", 3.099 , "Console de Vídeo Game PlayStation 4","Console","1 Tera");
        Jogo jogo = new Jogo ("God of War Ragnarök", 199, "Jogo completo  God of War Ragnarök para Playstation 4", "jogo PS4", "roguelite");
        Tipo tipo = new Tipo ("JBL bluetooth Fone", 226, "Fone via Bluetooth JBL da cor azul", "Tipo", "Tipo: Fone");
        Colecionavel colecionavel = new Colecionavel ("Figure do Zoro", 130, "Boneco do Zoro, um dos principais personagens de One Piece",
        " Colecionável", "True");
    }
}