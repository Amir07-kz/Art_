using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonohagoWebApp.Models;
namespace KonohagoWebApp.Repository.Interfaces
{
    interface ILikedArtRepository
    {
        Task<List<art>> GetLikedAnimes(int user_id);
        Task AddLikeArt(Like like);
        bool IsLiked(Like like);
    }
}
