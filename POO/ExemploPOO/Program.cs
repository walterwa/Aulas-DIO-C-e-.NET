using System;
using System.IO;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho, "Pasta Teste 3");
            var caminhoArquivo = Path.Combine(caminho, "Arquivo-teste-stream.txt");
            var caminhoArquivoTeste = Path.Combine(caminho, "Arquivo teste.txt");
            var caminhoArquivoTesteCopia = Path.Combine(caminho, "Arquivo teste bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "Arquivo-teste-stream.txt");

            var listaString = new List<String> {"Linha 1", "Linha 2", "Linha 3"};
            var listaStringContinuacao = new List<String> {"Linha 4", "Linha 5", "Linha 6"};

            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorios(caminho);
            //helper.CriarArquivoTexto(caminhoArquivo, "Olá teste de escrita de arquivo");
            // helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
            // helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            //helper.LerArquivoStream(caminhoArquivo);
            //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
            //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);

            //System.Console.WriteLine("Criando diretório: " + caminhoPathCombine);
            //helper.CriarDiretorio(caminhoPathCombine);
            //helper.ApagarDiretorio(caminhoPathCombine, true);

            //criando uma nova calculadora que usa a interface (não há implementação direta da interface)
            // ICalculadora calc = new Calculadora();
            // System.Console.WriteLine(calc.Somar(20,20));

            //Computador comp = new Computador();
            

            // Corrente c = new Corrente();
            // c.Creditar(100);

            // c.ExibirSaldo();
            // Calculadora calc = new Calculadora();
            // System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(2,2));
            // System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(2,2,2));

            // Aluno p1 = new Aluno();
            // p1.Nome = "Bob";
            // p1.Idade = 20;
            // p1.Nota = 10;
            // p1.Documento = "012.345.678-91";
            // p1.Apresentar();

            // Professor p2 = new Professor();
            // p2.Nome = "Bob";
            // p2.Idade = 20;
            // p2.Documento = "012.345.678-91";
            // p2.Salario = 4000;
            // p2.Apresentar();


            // Retangulo r = new Retangulo();
            // r.DefinirMedidas(30, 30);
            
            // Console.WriteLine($"Área: {r.ObterArea()}"); 


            // Retangulo r2 = new Retangulo();
            // r2.DefinirMedidas(0, 0);
            
            // Console.WriteLine($"Área: {r2.ObterArea()}"); 

            // Pessoa p1 = new Pessoa();
            // Pessoa p2 = new Pessoa();

            // p1.Nome = "Bob";
            // p1.Idade = 20;

            // p2.Nome = "Marley";
            // p2.Idade = 20;

            // p1.Apresentar();
            // p2.Apresentar();
        }
    }
}