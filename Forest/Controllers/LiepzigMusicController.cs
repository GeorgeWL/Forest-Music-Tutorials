using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Liepzig.Services.IService;
using Liepzig.Services;
using Liepzig.Services.Service;

namespace Forest.Controllers
{
    public class LiepzigMusicController : Controller
    {
        private Liepzig.Services.Service.LiepzigMusicService _LiepzigMusicService;
        public LiepzigMusicController()
        {
            _LiepzigMusicService = new Liepzig.Services.Service.LiepzigMusicService();
        }
        //
        // GET: /LiepzigMusic/
        public ActionResult Index()
        {
            return View();
        }
	}
}