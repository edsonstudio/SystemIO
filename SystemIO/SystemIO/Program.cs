using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using SystemIO.Entities;

namespace SystemIO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personagem> personagens = new List<Personagem>();

            try
            {
                string diretorio = @"C:\Senai\Personagens";
                string caminhoArquivoDestino = @"C:\Senai\Personagens\Personagens.txt";
                string[] listaDeArquivos = Directory.GetFiles(diretorio);

                if (listaDeArquivos.Length > 0)
                {
                    FileStream arquivoDestino = File.Open(caminhoArquivoDestino, FileMode.OpenOrCreate);
                    arquivoDestino.Close();

                    List<string> linhasDestino = new List<string>();
                    using (StreamWriter sw = File.AppendText(caminhoArquivoDestino))
                    {
                        foreach (string caminhoArquivo in listaDeArquivos)
                        {
                            var linhas = (File.ReadLines(caminhoArquivo));

                            string[] props = linhas.ToArray();
                            string nome = props[0];
                            string dataDeNascimento = props[1];

                            Personagem personagem = new Personagem(nome, dataDeNascimento);
                            personagens.Add(personagem);
                        }
                        var persona = personagens.OrderBy(p => p.Nome);

                        foreach (var p in persona)
                        {
                            Console.WriteLine(p);
                            sw.WriteLine(p);
                        }
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Ocorreu um erro!!!");
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
