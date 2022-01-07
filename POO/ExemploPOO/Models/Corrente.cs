namespace ExemploPOO.Models
{
    //herdando de conta
    public class Corrente : Conta
    {
        public override void Creditar(double valor)
        {
            //base significa que é um elemento da classe Pai
            base.saldo = valor;
        }
    }
}