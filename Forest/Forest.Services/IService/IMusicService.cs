using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data;
using Forest.Data.DAO;
using Forest.Data.IDAO;
using Forest.Data.BEANS;
using Forest.Services;
using Forest.Services.Service;
using Forest.Services.IService;

namespace Forest.Services.IService
{
    public interface IMusicService
    {
        IList<Music_category> GetMusicCategories(string genre);
        //IList<Music_Recording> GetMusicRecordings(string genre);
        //changed to beans
        IList<MusicBEAN> GetMusicRecordings(int genre);
        Music_Recording GetMusicRecording(int id);
        //void to add the edit method to the Music_recording.cs
        void EditMusicRecording(Music_Recording recording);
       // void AddMusicRecording(Music_Recording recording);
        //to implement next
    }  
}

