using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        //readonly previne que a dependência não possa ser alterada
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            //Retornando do DB todos os vendedores
            //Sellers acessa fonte da tabela de vendedores e converte para uma lista
            return _context.Seller.ToList();
        }
    }
}
