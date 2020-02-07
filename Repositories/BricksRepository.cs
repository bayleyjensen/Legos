using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using Legos.Models;

namespace Legos.Repositories
{
  public class BricksRepository
  {
    private readonly IDbConnection _db;
    public BricksRepository(IDbConnection db)
    {
      _db = db;
    }

    internal IEnumerable<Brick> Get()
    {
      string sql = "SELECT * FROM bricks";
      return _db.Query<Brick>(sql);
    }

    internal Brick GetById(int id)
    {
      throw new NotImplementedException();
    }

    internal void Create(Brick newData)
    {
      throw new NotImplementedException();
    }

    internal Brick Edit(Brick update)
    {
      throw new NotImplementedException();
    }

    internal void Delete(int id)
    {
      throw new NotImplementedException();
    }
  }
}