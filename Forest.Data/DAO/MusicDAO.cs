using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forest.Data;
using Forest.Data.IDAO;
using Forest.Data.DAO;
using Forest.Data.BEANS;

namespace Forest.Data.DAO
{
    public class MusicDAO : IMusicDAO
    {
        private ForestEntities _context;
        //data context
        public MusicDAO()
        {
            _context = new ForestEntities();
        }
        //queries the data to select the genre chosen by user
        //public IList<Music_Recording> GetMusicRecordings(string genre)
        //{
        //    IQueryable<Music_Recording> _recordings;
        //    _recordings = from recording
        //                  in _context.Music_Recording
        //                  where recording.Genre == genre
        //                  select recording;
        //    return _recordings.ToList<Music_Recording>();
        //}
        //change to MusicBEAN
        public IList<MusicBEAN> GetMusicRecordings(int genre)
        {
            IQueryable<MusicBEAN> _MusicBEANs;
            _MusicBEANs =
                from recs in _context.Music_Recording
                from cats in _context.Music_category
                where recs.Genre == genre
                where cats.Id == genre
                select new MusicBEAN
                {
                    Id = recs.Id,
                    Artist = recs.Artist,
                    Title = recs.Title,
                    Genre = cats.Genre,
                    Image_Name = recs.ImageName,
                    Num_Tracks = recs.NumTracks,
                    Price = recs.Price,
                    Stock_Count = recs.StockCount,
                    Released = recs.Released
                };
            return _MusicBEANs.ToList<MusicBEAN>();
        }
        
        //queries the data to show a list of all categories
        public IList<Music_category> GetMusicCategories(string genre)
        {
            IQueryable<Music_category> _categories;
            _categories = from category
                          in _context.Music_category
                          select category;
            return _categories.ToList<Music_category>();
        }
        //queries the data to show one recording selected by user, the return runs before all other methods when chosen
        public Music_Recording GetMusicRecording(int Id)
        {
            IQueryable<Music_Recording> _recording;
            _recording = from recording
                         in _context.Music_Recording
                         where recording.Id == Id
                         select recording;
            return _recording.ToList<Music_Recording>().First();
        }
        //queries the existing recordings ready to edit
        public void EditMusicRecording(Music_Recording recording)
        {
            Music_Recording record = 
               (from rec
                in _context.Music_Recording
                where rec.Id == recording.Id
                select rec).ToList<Music_Recording>().First();
            //change from context of record to equal recording 
            record.ImageName = recording.ImageName;
            record.NumTracks = recording.NumTracks;
            record.Price = recording.Price;
            record.Released = recording.Released;
            record.StockCount = recording.StockCount;
            record.Title = recording.Title;
            record.Genre = recording.Genre;
            record.Artist = recording.Artist;
            //in the original context, save these changes
            _context.SaveChanges();
        }
        public void AddMusicRecording(Music_Recording recording)
        {
            Music_Recording record =
                (from rec
                 in _context.Music_Recording
                 where rec.Id == recording.Id
                 select rec).ToList<Music_Recording>().First();
            //change from context of record to equal recording 
            record.ImageName = recording.ImageName;
            record.NumTracks = recording.NumTracks;
            record.Price = recording.Price;
            record.Released = recording.Released;
            record.StockCount = recording.StockCount;
            record.Title = recording.Title;
            record.Genre = recording.Genre;
            record.Artist = recording.Artist;
            _context.Music_Recording.Add(recording);
            _context.SaveChanges();
        }
        public void DeleteMusicRecording(Music_Recording recording)
        {
            _context.Music_Recording.Remove(GetMusicRecording(recording.Id));
            _context.SaveChanges();
        }
    }
}
