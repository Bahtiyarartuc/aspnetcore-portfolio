﻿using Microsoft.AspNetCore.Mvc;
using PortfolioCore1.Context;
using PortfolıoCore1.Entities;


namespace PortfolioCore.Controllers
{
    public class ContactController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult ContactList()
        {
            var value = context.Contacts.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }

        public IActionResult DeleteContact(int id)
        {
            var value = context.Contacts.Find(id);
            context.Contacts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }

        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            var value = context.Contacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            context.Contacts.Update(contact);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}
