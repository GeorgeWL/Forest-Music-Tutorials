using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Services.IService;
using Forest.Data.DAO;
using Forest.Data;
using Forest.Data.IDAO;
using Forest.Data.BEANS;

namespace Forest.Services.Service
{
    public class MusicService : IMusicService
    {
        private IMusicDAO _musicDAO;
        public MusicService() { _musicDAO = new MusicDAO(); }
        public IList<Music_category> GetMusicCategories(string genre)
        {
            return _musicDAO.GetMusicCategories(genre);
        }
        //public IList<Music_Recording> GetMusicRecordings(string genre)
        //{
        //    return _musicDAO.GetMusicRecordings(genre);
        //}
        //change to Beans
        public IList<MusicBEAN> GetMusicRecordings(int genre)
        {
            return _musicDAO.GetMusicRecordings(genre);
        }
        public Music_Recording GetMusicRecording(int id)
        {
            return _musicDAO.GetMusicRecording(id);
        }
        public void EditMusicRecording(Music_Recording recording)
        {
            _musicDAO.EditMusicRecording(recording);
        }
        public void AddMusicRecording(Music_Recording recording)
        {
            _musicDAO.AddMusicRecording(recording);
        }
        //that's a step ahead, knowing that edit works the same as add in many ways, I put that in ready.
        public void DeleteMusicRecording(Music_Recording recording)
        {
            _musicDAO.DeleteMusicRecording(recording);
        }
    }
}
