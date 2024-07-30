using System;

public class Celular
{
    // Atributos
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Cor { get; set; }
    public int CapacidadeBateria { get; set; }
    private bool Ligado { get; set; }

    // Construtor
    public Celular(string marca, string modelo, string cor, int capacidadeBateria)
    {
        Marca = marca;
        Modelo = modelo;
        Cor = cor;
        CapacidadeBateria = capacidadeBateria;
        Ligado = false; // O celular começa desligado
    }

    // Método para ligar o celular
    public void Ligar()
    {
        if (!Ligado)
        {
            Ligado = true;
            Console.WriteLine("O celular está ligado.");
        }
        else
        {
            Console.WriteLine("O celular já está ligado.");
        }
    }

    // Método para desligar o celular
    public void Desligar()
    {
        if (Ligado)
        {
            Ligado = false;
            Console.WriteLine("O celular está desligado.");
        }
        else
        {
            Console.WriteLine("O celular já está desligado.");
        }
    }

    // Método para fazer uma chamada
    public void FazerChamada(string numero)
    {
        if (Ligado)
        {
            Console.WriteLine($"Fazendo chamada para {numero}...");
        }
        else
        {
            Console.WriteLine("O celular está desligado. Não é possível fazer chamadas.");
        }
    }

    // Método para enviar uma mensagem
    public void EnviarMensagem(string numero, string mensagem)
    {
        if (Ligado)
        {
            Console.WriteLine($"Enviando mensagem para {numero}: {mensagem}");
        }
        else
        {
            Console.WriteLine("O celular está desligado. Não é possível enviar mensagens.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Criação de um objeto Celular
        Celular meuCelular = new Celular("Samsung", "Galaxy S21", "Preto", 4000);

        // Uso dos métodos do objeto Celular
        meuCelular.Ligar();
        meuCelular.FazerChamada("123456789");
        meuCelular.EnviarMensagem("123456789", "Olá, como você está?");
        meuCelular.Desligar();
    }
}
