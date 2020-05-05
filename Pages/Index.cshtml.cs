using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ProyectoPrueba.Data;
using ProyectoPrueba.Models;
using Microsoft.EntityFrameworkCore;

namespace ProyectoPrueba.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ProyectoPruebaContext db;
        public IndexModel(ProyectoPruebaContext db) => this.db = db;
        public List<Product> Products { get; set; }
        public Product FeaturedProduct { get; set; }

        public async Task OnGetAsync()
        {
            Products = await db.Products.ToListAsync();
            FeaturedProduct = Products.ElementAt(new Random().Next(Products.Count));            
        }
    }
}
