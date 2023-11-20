using PlaylistManagementApp.DAL.Interrfaces;
using PlaylistManagementApp.DAL.Services.Repository;
using PlaylistManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PlaylistManagementApp.DAL.Services
{
    public class PlaylistService : IPlaylistService
    {
        private readonly IPlaylistRepository _repository;

        public PlaylistService(IPlaylistRepository repository)
        {
            _repository = repository;
        }

        public Task<Song> AddSongs(Song song)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSongById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public List<Song> GetPlaylist()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Song> GetSongById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public Task<Song> UpdatePlaylist(Song model)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}