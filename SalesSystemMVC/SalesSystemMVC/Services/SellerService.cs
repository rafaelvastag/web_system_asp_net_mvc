﻿using SalesSystemMVC.Data;
using SalesSystemMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystemMVC.Services
{
    public class SellerService
    {
        private readonly SalesSystemMVCContext _context;

        public SellerService(SalesSystemMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller sel)
        {
            _context.Add(sel);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = FindById(id);
            _context.Seller.Remove(obj);
        }
    }
}
