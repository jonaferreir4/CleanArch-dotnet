using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class ProductRepository: IProductRepository
    {
        private ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context){
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProducts() {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetById(int? id) {
            return await _context.Products.FindAsync(id);
        }

        public void Add(Product product) {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Update(Product product) {
            _context.Update(product);
            _context.SaveChanges();
        }

        public void Remove(Product product) {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}