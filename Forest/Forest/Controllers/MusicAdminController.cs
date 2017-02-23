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
        
        //create object of music_recording 
        //using id from MusicRecording(int Id)
        [HttpGet]
        public ActionResult EditMusicRecording(int id)
        {
            
            return View(_musicService.GetMusicRecording(id));
            //when it says "passing the recording object" it means the _musicservice
        }
        [HttpPost]
        public ActionResult EditMusicRecording(Music_Recording recording)
        {
            try
            {
            //music search method
                _musicService.EditMusicRecording(recording);
            //return redirecttoaction back to recordings action
                return RedirectToAction("Recordings", "Music", new { id = recording.Genre});
            //recording.genre as genre
            }
            catch
            {
                return View();
            }
        }
        [HttpGet]
        public ActionResult AddMusicRecording(string genre)
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMusicRecording(Music_Recording recording)
        {
            try 
            {
                _musicService.AddMusicRecording(recording);
                return RedirectToAction("Recordings", "Music", new { id = recording.Genre });
            }
            catch 
            {
            return View();
            }        
        }
    }
}
