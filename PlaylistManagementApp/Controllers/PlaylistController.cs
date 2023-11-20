using PlaylistManagementApp.DAL.Interrfaces;
using PlaylistManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace PlaylistManagementApp.Controllers
{
    public class PlaylistController : ApiController
    {
        private readonly IPlaylistService _service;
        public PlaylistController(IPlaylistService service)
        {
            _service = service;
        }
        public PlaylistController()
        {
            // Constructor logic, if needed
        }

        [HttpPost]
        [Route("api/Playlist/CreatePlaylist")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreatePlaylist([FromBody] Song model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("api/Playlist/UpdatePlaylist")]
        public async Task<IHttpActionResult> UpdatePlaylist([FromBody] Song model)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Playlist/DeletePlaylist")]
        public async Task<IHttpActionResult> DeletePlaylist(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Playlist/GetSongById")]
        public async Task<IHttpActionResult> GetSongById(long id)
        {
            //write your code here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Playlist/GetAllSongs")]
        public async Task<IEnumerable<Song>> GetAllSongs()
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}
