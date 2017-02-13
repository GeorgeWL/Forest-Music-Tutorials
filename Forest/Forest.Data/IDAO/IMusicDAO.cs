using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data.IDAO;
using Forest.Data.DAO;
using Forest.Data;
using Forest.Data.BEANS;

namespace Forest.Data.IDAO  
{
    public interface IMusicDAO
    {
        //lists the categories
        IList<Music_category> GetMusicCategories(string genre);
        //lists all recordings of a genre
        //IList<Music_Recording> GetMusicRecordings(string genre);
        //change to MusicBEAN
        IList<MusicBEAN> GetMusicRecordings(int genre);
        //displays the details of a single recording
        Music_Recording GetMusicRecording(int id);
        //for the editing of any recording
        void EditMusicRecording(Music_Recording recording);
        void AddMusicRecording(Music_Recording recording);
    }
    
}
