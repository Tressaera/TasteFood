﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TasteFood.Context;
using TasteFood.Entity;

namespace TasteFood.Controllers
{
    public class AdminContactController : Controller
    {
        // GET: AdminContact
        TasteContext context = new TasteContext();

        public ActionResult ContactList()
        {
            ViewBag.name = "İletişim";
            var values = context.Contacts.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateContact(Contact Contact)
        {
            context.Contacts.Add(Contact);
            context.SaveChanges();
            return RedirectToAction("ContactList");

        }
        public ActionResult DeleteContact(int id)
        {
            var values = context.Contacts.Find(id);
            context.Contacts.Remove(values);
            context.SaveChanges();
            return RedirectToAction("ContactList");
        }
        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var value = context.Contacts.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateContact(Contact Contact)
        {
            var value = context.Contacts.Find(Contact.ContactId);
            value.NameSurname = Contact.NameSurname;
            value.Email = Contact.Email;
            value.Subject = Contact.Subject;
            value.Message = Contact.Message;
            value.SendDate = Contact.SendDate;
            context.SaveChanges();
            return RedirectToAction("ContactList");

        }
        public ActionResult StatusChange(int id)
        {
            var value = context.Contacts.Find(id);
            if (value.IsRead == true)
            {
                value.IsRead = false;
            }
            else
            {
                value.IsRead = true;
            }
            context.SaveChanges();
            return RedirectToAction("ContactList", "AdminContact");
        }
    }
}