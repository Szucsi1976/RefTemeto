﻿using Microsoft.AspNetCore.Mvc;
using RefTemeto.Data;
using RefTemeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefTemeto.Controllers
{
    public class GraveController : Controller
    {
        private readonly ApplicationDbContext _db;
        public GraveController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Grave> objList = _db.Graves;
            return View(objList);
        }

        //GET-CREATE
        public IActionResult Create()
        {
            return View();
        }
        
        //Post-CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Grave obj)
        {
            if (ModelState.IsValid)
            {
                _db.Graves.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var obj = _db.Graves.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        //Post Edit
        public IActionResult Edit(Grave obj)
        {
            if (ModelState.IsValid)
            {
                _db.Graves.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        // Get Delete
        public IActionResult Delete(int? id)
        {
            if (id == null || id < 1)
            {
                return NotFound();
            }
            var obj = _db.Graves.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        //Post Delete
        public IActionResult DeletePost(int? GraveId)
        {
            var obj = _db.Graves.Find(GraveId);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Graves.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

