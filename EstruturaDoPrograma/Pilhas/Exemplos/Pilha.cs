using System;


namespace EstruturaDoPrograma.Exemplos
{
    public class Pilha //nome desse arquivo
    {
        Posicao primeiro; //classe aninhada
        public void Empilha(object item)
        {
            primeiro = new Posicao(primeiro, item);
        }

        public object Desempilha() //segunda classe aninhada
        {
            if (primeiro == null)
            {
                throw new InvalidOperationException("A pilha está vazia!"); //msg de erro
            }
            
            object resultado = primeiro.item; //resultado é o primeiro item na pilha
            primeiro = primeiro.proximo; //depois o primeiro item passa a ser (se tiver) o próximo item da pilha
            return resultado; //retornando o valor de resultado
        }

        class Posicao
        {
            public Posicao proximo;
            public object item;
            public Posicao(Posicao proximo, object item)
            {
                this.proximo = proximo; //passando que próximo é igual ao próximo recebido por parâmetro
                this.item = item;
            }
        }
    }
}