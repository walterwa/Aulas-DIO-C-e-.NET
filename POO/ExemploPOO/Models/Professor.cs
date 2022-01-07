namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public int Salario { get; set; }

        //polimorfismo em tempo de execução (sobrescrita/override)
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, mundo. Meu nome é {Nome} e sou professor, tenho um salário de R${Salario}");
        }
    }
}