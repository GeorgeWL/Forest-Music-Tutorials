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
    public class MusicAdminController : Controller
    {
        private IMusicService _musicService;
        public MusicAdminController()
        {
            _musicService = new MusicService();
        }
        // GET: MusicAdmin
        public ActionResult EditMusicRecording(Music_Recording recording)
        {
            return View(EditMusicRecording(recording));
        }
    }
}