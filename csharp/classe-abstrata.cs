using System;
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
    public void Acordar(){
        Console.WriteLine($"{GetNome()} está acordando");
    }
    public void Descansar(){
        Console.WriteLine($"{GetNome()} está descançando");
    }
}
public class Mamifero : Animal 
{
    public Mamifero(string especie, string nome) : base (especie, nome){}
    public override void EmitirSom()
    {
        Console.WriteLine($"{GetNome()} fuummm uuuuhh");
    }
    public override void Comer()
    {
        Console.WriteLine($"{GetNome()} esté comendo");
    }
}  
 public class Ave : Animal 
{
    public Ave (string especie, string nome) : base (especie,nome){}
    public override void EmitirSom()
    {
        Console.WriteLine ($"{GetNome()} emitir som");
    }
    public override void Comer()
    {
        Console.WriteLine($"{GetNome()} está comendo");
    }
}  

public class Program {
    public static void Main(string[] args) {
        Mamifero mamifero = new Mamifero("Mamífero","Jeremias");
        mamifero.Comer();
        mamifero.EmitirSom();
        mamifero.Acordar();
        mamifero.Descansar();
        
        Ave ave = new Ave ("Ave","Gust");
        ave.Comer();
        ave.EmitirSom();
        ave.Acordar();
        ave.Descansar();
    }
}