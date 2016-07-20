﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using first.Data;
using first.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace first.Api
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        private ApplicationDbContext _db;

        // GET: api/values
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _db.Movies.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public MoviesController(ApplicationDbContext db)
        {
            this._db = db;
        }

    }
}
