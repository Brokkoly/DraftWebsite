using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace DraftWebsite.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CubeLoadController : ControllerBase
    {
        private readonly IMemoryCache _cache;

        CubeLoadController(IMemoryCache memoryCache)
        {
            _cache = memoryCache;
        }



        [HttpGet]
        public ActionResult GetCubeFromCubeCobra(string id)
        {

            return Ok();
        }

        public void GetCubeCobraCsv(string id)
        {
            string url = "https://cubecobra.com/cube/download/csv/" + id + "?primary=Color%20Category&secondary=Types-Multicolor&tertiary=CMC2";
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "Get";
            webRequest.ContentType = "application/json";
            //webRequest.Headers.Add("Authorization", "Bearer " + accessToken);
            var webResponse = webRequest.GetResponse();
            var responseStream = webResponse.GetResponseStream();
            if (responseStream == null) return;
            var streamReader = new StreamReader(responseStream, Encoding.Default);
        }

    }
}
