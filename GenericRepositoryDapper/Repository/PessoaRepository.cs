using GenericRepositoryDapper.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace GenericRepositoryDapper.Repository
{
    public class PessoaRepository : GenericRepository<Pessoa>
    {
        public PessoaRepository(string tablename) : base(tablename){}
    }
}
