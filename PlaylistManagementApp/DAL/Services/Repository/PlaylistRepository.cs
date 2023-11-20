using PlaylistManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PlaylistManagementApp.DAL.Services.Repository
{
    public class PlaylistRepository : IPlaylistRepository
    {
        private readonly DatabaseContext _dbContext;
        public PlaylistRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Song> AddSongs(Song song)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteSongById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Song> GetPlaylist()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Song> GetSongById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public async Task<Song> UpdatePlaylist(Song model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}