﻿using MongoDBSampleCRUD.Models.MongoDBSampleCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MongoDBSampleCRUD.Services.Contracts
{
    public interface IBookService
    {
        List<Book> Get();
        Book Get(string id);
        Book Create(Book book);
        void Update(string id, Book bookIn);
        void Remove(Book bookIn);
        void Remove(string id);

    }
}
