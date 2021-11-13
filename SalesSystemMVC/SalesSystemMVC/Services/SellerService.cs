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
            sel.Department = _context.Department.First();
            _context.Add(sel);
            _context.SaveChanges();
        }
    }
}
