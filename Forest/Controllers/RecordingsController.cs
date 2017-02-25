using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Forest.Data;
using Forest.Services;
using Forest.Services.Service;
using Forest.Services.IService;

namespace Forest.Controllers
{
    public class RecordingsController : Controller
    {
        // GET: Recordings
        private IMusicService _musicService;
        public RecordingsController()
        {
            _musicService = new MusicService();
        }
        // GET: Music
        public ActionResult Recording(int id)
        {
            return View(_musicService.GetMusicRecording(id));
        }

        // GET: Recordings/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Recordings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Recordings/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Recordings/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Recordings/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Recordings/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Recordings/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
