using ChallengeApiVideosAlura.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeApiVideosAlura.Controllers
{
    [ApiController]
    [Route("controller")]
    public class VideosController : ControllerBase
    {
        VideoContext _context;

        public VideosController(VideoContext context)
        {
            _context = context;
        }

        [HttpGet("/filmes")]
        public IActionResult GetFilmes()
        {
            return Ok(_context.videos.ToList());
        }
    }
}
