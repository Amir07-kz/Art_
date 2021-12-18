using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonohagoWebApp.Repository.Interfaces
{
    public interface IArtRepository
    { 
        Task<List<Models.art>> GetAllAnimeAsync();
        Task AddAnime(Models.art art);
        Task<List<Models.art>> SearchArt(string input);
        Task<Models.art> GetArtById(int id);
        List<Models.Studios> GetAllStudios();
    }
}
