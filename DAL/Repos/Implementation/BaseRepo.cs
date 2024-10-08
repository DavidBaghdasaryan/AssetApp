﻿using DAL.DBContex;
using DAL.Repos.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos.Implementation
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        private readonly AssetDBContex _dbContext;
        internal DbSet<T> dbSet;
        public BaseRepo(AssetDBContex dbContext)
        {
            _dbContext = dbContext;
            this.dbSet = dbContext.Set<T>();

        }
        public void Add(T item)
        {
            _dbContext.Add(item);
            Save();
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var property in includeProperties
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(property);
                }
            }
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll(string? includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var property in includeProperties
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(property);
                }
            }
            return query.ToList();
        }

        public void Remove(T item)
        {
            dbSet.Remove(item);
            Save();
        }
        public void Update(T item)
        {
            dbSet.Update(item);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
        public void RemoveRange(IEnumerable<T> items)
        {
            dbSet.RemoveRange(items);
        }
        
    }
}
