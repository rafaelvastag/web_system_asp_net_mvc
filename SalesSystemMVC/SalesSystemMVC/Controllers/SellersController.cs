﻿using Microsoft.AspNetCore.Mvc;
using SalesSystemMVC.Models;
using SalesSystemMVC.Models.ViewModels;
using SalesSystemMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesSystemMVC.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }

        public IActionResult Index()
        {
            var sellers = _sellerService.FindAll();

            return View(sellers);
        }

        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            var viewModel = new SellerFormViewModel() { Departments = departments };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller sel)
        {
            _sellerService.Insert(sel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (null == id)
            {
                return NotFound();
            }

            var seller = _sellerService.FindById(id.Value);

            if (null == seller)
            {
                return NotFound();
            }

            return View(seller);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _sellerService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (null == id)
            {
                return NotFound();
            }

            var seller = _sellerService.FindById(id.Value);

            if (null == seller)
            {
                return NotFound();
            }

            return View(seller);
        }
    }

}
