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
    public void Promocao (){
        Console.WriteLine("Promoção")
    }
    public void Promocao (double desconto){
        Console.WriteLine("Promoção "+ desconto)
    }
}

public class ConsoleGame : Produto{
    private int armazenamento:

    public ConsoleGame(string nome, decimal preco, string descricao, string categoria, int armazenamento) : base(nome, preco, descricao, categoria){
        Armazenamento = armazenamento:
    }
    public string Armazenamento {
        get {return armazenamento;}
        set {armazenamento = value;}
    }
    public void Promocao (){
        Console.WriteLine("Promoção PlayStation 4 com 40% de desconto");
    }
    public void Promocao (double desconto){
        Console.WriteLine("Promoção PlayStation 4 com "+ desconto + "reais de desconto");
    }
}

public class Jogo : Produto{
    private string genero:

    public Jogo(string nome, decimal preco, string descricao, string categoria, string genero) : base(nome, preco, descricao, categoria){
        Genero = genero:
    }
    public string Genero {
        get {return genero;}
        set {genero = value;}
    }
    public void Promocao (){
        Console.WriteLine("Promoção God of War Ragnarök com 15% de desconto")
    }
    public void Promocao (double desconto){
        Console.WriteLine("Promoção God of War Ragnarök com "+ desconto + "reais de desconto");
    }
}

public class Acessorio : Produto{
     private string tipo:

    public Acessorio(string nome, decimal preco, string descricao, string categoria, string tipo) : base(nome, preco, descricao, categoria){
        Tipo = tipo:
    }
    public string Tipo {
            get {return tipo;}
            set {tipo = value;}
    }
    public void Promocao (){
        Console.WriteLine("Promoção JBL bluetooth Fone com 10% de desconto")
    }
     public void Promocao (double desconto){
        Console.WriteLine("Promoção JBL bluetooth Fone com "+ desconto + "reais de desconto");
    }
}

public class Colecionavel : Produto{
    private bool edicaoLimitada:

    public Colecionavel(string nome, decimal preco, string descricao, string categoria, bool edicaoLimitada) : base(nome, preco, descricao, categoria){
        EdicaoLimitada = edicaolimitada:
    }
    public string EdicaoLimitada{
            get {return edicaoLimitada;}
            set {edicaoLimitada = value;}
    }
    public void Promocao (){
        Console.WriteLine("Promoção Figure do Zoro com 25% de desconto")
    }
     public void Promocao (double desconto){
        Console.WriteLine("Promoção Figure do Zoro com "+ desconto + "reais de desconto");
    }
}

public class Program {
    public static void main (string[] args) {
        ConsoleGame consoleGame = new ConsoleGame ("PlayStation 4", 3.099 , "Console de Vídeo Game PlayStation 4","Console","1 Tera");
        consoleGame.Promocao();
        consoleGame.Promocao(100.00);

        Jogo jogo = new Jogo ("God of War Ragnarök", 199, "Jogo completo  God of War Ragnarök para Playstation 4", "jogo PS4", "roguelite");
        jogo.Promocao();
        consoleGame.Promocao(100.00);

        Produto produto;
        produto = new Acessorio ("JBL bluetooth Fone", 226, "Fone via Bluetooth JBL da cor azul", "Acessório", "Tipo: Fone");
        produto.Promocao();
        consoleGame.Promocao(100.00);
        
        Colecionavel colecionavel = new Colecionavel ("Figure do Zoro", 130, "Boneco do Zoro, um dos principais personagens de One Piece",
        " Colecionável", true);
        colecionavel.Promocao();
        consoleGame.Promocao(100.00);
    }
}

