using Liepzig.Services.IService;
using Liepzig.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liepzig.Services.Service
{
   public class LiepzigMusicService : ILiepzigMusicService
        {
            private LiepzigServices.ForestWebService _proxy;
            public LiepzigMusicService()
            {
                _proxy = new LiepzigServices.ForestWebService();
            }

            public IList<LiepzigServices.MusicBEAN> GetLiepzigMusicRecordings(int genre)
            {
                return _proxy.GetMusicRecordings(genre);
            }
        }
}
