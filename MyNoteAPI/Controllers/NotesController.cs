using MyNoteAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyNoteAPI.Controllers
{
    public class NotesController : BaseApiController
    {
        [HttpGet]
        public IQueryable<Note> List() { 
        
            return db.Notes;
        }

    }
}
