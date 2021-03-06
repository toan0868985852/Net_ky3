﻿using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using web_api.Models;

namespace web_api.Controllers
{
    public class BankController : ApiController
    {
        private readonly DB_BankEntities _context = new DB_BankEntities();

        [HttpPost]
        [Authorize]
        [Route("api/Bank/Create")]
        public IHttpActionResult Create(BankModel bankModel)
        {
            var bank = new Table_DB_Bank()
            {
                BankName = bankModel.BankName,
                IFSC = bankModel.IFSC
            };
            _context.Table_DB_Bank.Add(bank);
            _context.SaveChanges();
            return Ok("Success");
        }

        [HttpPost]
        [Authorize]
        [Route("api/Bank/GetAll")]
        public IHttpActionResult GetAll(BankModel bankModel)
        {
            var banks = _context.Table_DB_Bank.ToList();
            return Ok(banks);
        }

        [HttpPost]
        [Authorize]
        [Route("api/Bank/Modify")]
        public IHttpActionResult Modify(BankModel bankModel)
        {
            var bank = new Table_DB_Bank()
            {
                BankName = bankModel.BankName,
                Id = bankModel.Id,
                IFSC = bankModel.IFSC
            };
            _context.Entry(bank).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            return Ok("Success");
        }

        [HttpPost]
        [Authorize]
        [Route("api/Bank/Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var bank = _context.Table_DB_Bank.SingleOrDefault(e => e.Id == id);
            _context.Table_DB_Bank.Remove(bank);
            _context.SaveChanges();
            return Ok("Success");
        }
    }
}
