namespace ExemploPOO.Models
{
    //declarando uma classe abstrata
    public abstract class Conta
    {
        protected double saldo;

        //método abstrato
        public abstract void Creditar(double valor);

        public void ExibirSaldo()
        {
            System.Console.WriteLine("Seu saldo é: " + saldo);
        }
    }
}