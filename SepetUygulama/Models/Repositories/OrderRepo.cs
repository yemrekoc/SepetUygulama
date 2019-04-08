using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SepetUygulama.Models.Repositories
{
    public class OrderRepo
    {
        private readonly SepetAppContext _context;

        public OrderRepo(SepetAppContext context)
        {
            _context = context;
        }
        public void SaveChanges()
        {
            _context.SaveChanges();   
        }

        public List<Order> GetAllOrderWithCustomerAndProduct()
        {
            return _context.Orders
                .Include(s=>s.Customer)
                .Include(s=>s.Product)
                .ToList();
        }

        public Order GetOrderByIdWithCustomerAndProduct(int Id)
        {
            return _context.Orders
                .Include(s => s.Customer)
                .Include(s => s.Product)
                .FirstOrDefault(i => i.Id == Id);
        }


        ///<summary>
        ///Veri tabanında sipariş oluşturan metod. Geriye Order tipinde nesne döndürür.
        ///</summary>
        public Order CreateOrderwithCustomerandProduct(Order order)
        {
            _context.Add(order);
            SaveChanges();
            return order;

        }


    }
}
