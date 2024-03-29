﻿using BookStores.Domain;
using System;
using System.Collections.Generic;

namespace BookStores.Repositories.Contracts
{
    public interface IAuthorRepository : IDisposable
    {
        List<Autor> Get();
        Autor Get(int id);
        List<Autor> GetByName(string name);
        bool Create(Autor autor);
        bool Update(Autor autor);
        void Delete(int id);
    }
}