﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UniRitter.UniRitter2015.Models;
using UniRitter.UniRitter2015.Services;

namespace UniRitter.UniRitter2015.Controllers
{
    public class PostController : ApiController
    {
        private IPostRepository _repo;

        public PostController(IPostRepository repo)
        {
            this._repo = repo;
        }

        // GET: api/Post
        public IHttpActionResult Get()
        {
            return Json(_repo.GetAll());
        }

        // GET: api/Post/5
        public IHttpActionResult Get(Guid id)
        {
            var data = _repo.GetById(id);
            if (data != null)
            {
                return Json(data);
            }

            return NotFound();
        }

        // POST: api/Post
        public IHttpActionResult Post([FromBody]PostModel person)
        {
            if (ModelState.IsValid)
            {
                var data = _repo.Add(person);
                return Json(data);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // PUT: api/Post/5
        public IHttpActionResult Put(Guid id, [FromBody]PostModel post)
        {
            var data = _repo.Update(id, post);
            return Json(post);
        }

        // DELETE: api/Post/5
        public IHttpActionResult Delete(Guid id)
        {
            _repo.Delete(id);
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}