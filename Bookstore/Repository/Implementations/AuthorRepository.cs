﻿using System;
using System.Data.Entity;
using Bookstore.Core;
using Bookstore.Entities.Implementations;
using Bookstore.Repository.Interfaces;

namespace Bookstore.Repository.Implementations
{
    public class AuthorRepository: GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(DatabaseContext context)
           : base(context)
        {

        }
    }
}
