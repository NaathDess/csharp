public abstract class Animal
{
    private string especie;
    private string nome;
    public Animal(string especie, string nome)
    {
        this.especie = especie;
        this.nome = nome;
    }
    public string GetEspecie() {
        return especie;
    }
    public void SetEspecie(string especie){
        this.especie = especie;
    }
    public string GetNome() {
        return nome;
    }
    public void SetNome(string nome){
        this.nome = nome;
    }
    public abstract void EmitirSom();
    public abstract void Comer();
    public void Acordar();
    {
        Console.WriteLine($"{Nome} está acordando");
    }
    public void Descansar()
    {
        Console.WriteLine($"{Nome} está descançando")
    }
}
public class Mamífero : Animal 
{
    public Mamífero (string especie, string nome) : base (especie,nome){}
    public override void EmitirSom()
    {
        Console.WriteLine ($"{GetNome()} emitir som");
    }
    public override void Comer()
    {
        Console.WriteLine($"{GetNome()} esté comendo");
    }
}  
 public class Aves : Animal 
{
    public Ave (string especie, string nome) : base (especie,nome){}
    public override void EmitirSom()
    {
        Console.WriteLine ($"{GetNome()} emitir som");
    }
    public override void Comer()
    {
        Console.WriteLine($"{GetNome()} esté comendo");
    }
}  