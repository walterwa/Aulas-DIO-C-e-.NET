namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, mundo. Meu nome é {Nome} e tirei a nota {Nota}.");
        }
    }
}