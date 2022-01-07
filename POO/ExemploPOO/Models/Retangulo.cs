namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double comprimento;
        private double largura;
        private bool valido;

        public void DefinirMedidas(double comprimento, double largura)
        {
            if(comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento; //acessando os atributos privados
                this.largura = largura;
                valido = true;
            }
            else
            {
                Console.WriteLine("Valor inválidos!");
            }
            
        }
        public double ObterArea() 
        {
            if(valido)
            {
                return comprimento * largura;
            }
            else
            {
                Console.WriteLine("Preencha com valores válidos!");
                return 0;
            }
        }
    }
}