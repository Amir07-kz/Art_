using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KonohagoWebApp.Helpers;
using KonohagoWebApp.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using KonohagoWebApp.Models;
using Microsoft.AspNetCore.Http;

namespace KonohagoWebApp.Pages
{
    public class TitlePageModel : PageModel
    {
        public art anime = new art();
        public bool isLike;
        public Like like = new Like();
        public async Task<RedirectResult> OnGet()
        {
            string string_id = HttpContext.Request.Query["anime_id"];
            var rep = HttpContext.RequestServices.GetService<IArtRepository>();
            var rep2 = HttpContext.RequestServices.GetService<ILikedArtRepository>();
            if (string_id == null)
                return Redirect("/Index");
            else
            {
                anime = await rep.GetArtById(Convert.ToInt32(string_id));
                if (HttpContext.Session.GetString("role") == Roles.Guest.ToString())
                {
                    isLike = true;

                }
                else
                {
                    like = new Like(HttpContext.Session.Get<User>("Current_user").Id);
                    like.Art_id = Convert.ToInt32(HttpContext.Request.Query["anime_id"]);
                    isLike = rep2.IsLiked(like);
                }
                return null;
            }
                
            
        }
        public async Task<RedirectResult> OnPost()
        {
            var rep = HttpContext.RequestServices.GetService<ILikedArtRepository>();
            like = new Like(HttpContext.Session.Get<User>("Current_user").Id);
            like.Art_id = Convert.ToInt32(HttpContext.Request.Query["anime_id"]);
            await rep.AddLikeArt(like);
            return Redirect($"/TitlePage?anime_id={Convert.ToInt32(HttpContext.Request.Query["anime_id"])}");
        }
    }
}
