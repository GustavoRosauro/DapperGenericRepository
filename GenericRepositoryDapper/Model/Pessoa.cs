using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepositoryDapper.Model
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
