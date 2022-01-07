//código só para exemplificação do conceito de herança

namespace Classes.Heranca
{
    public class Ponto
    {
        public int x, y;
        private int distancia;

        public Ponto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        protected void CalcularDistancia()
        {
            //faz alguma coisa...
            CalcularDistancia2();
        }

        private void CaclcularDistancia2();
        {
            //faz alguma coisa...
        }

        public virtual void CalcularDistancia3()
        {
            //faz alguma coisa
        }
    }
}