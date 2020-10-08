using GenericRepositoryDapper.Model;
using GenericRepositoryDapper.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace GenericRepositoryDapper
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var pessoaRepository = new PessoaRepository("Pessoa");
            Console.WriteLine("Salvando na tabela de usuários");
            var guid = Guid.NewGuid();
            await pessoaRepository.InsertAsync(new Pessoa()
            {
                Nome = "Gustavo",
                Id = guid,
                Idade = 27
            });
            await pessoaRepository.UpdateAsync(new Pessoa()
            {
                Nome = "Gustavo Rosauro",
                Id = guid,
                Idade = 28
            });
            List<Pessoa> pessoas = new List<Pessoa>();
            for (int i = 0; i < 100000; i++)
            {
                var id = Guid.NewGuid();
                pessoas.Add(new Pessoa()
                {
                    Id = id,
                    Nome = $"Gustavo {i}",
                    Idade = i
                });
            }
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine($"Inserido {await pessoaRepository.SaveRangeAsync(pessoas)}");

            stopwatch.Stop();

            var elapsedTime = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"tempo {elapsedTime} ms");
            Console.Read();
        }
    }
}
