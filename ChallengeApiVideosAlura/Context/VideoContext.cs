using ChallengeApiVideosAlura.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChallengeApiVideosAlura.Context
{
    public class VideoContext : DbContext
    {
        public VideoContext(DbContextOptions<VideoContext> opt) : base(opt)
        {

        }

        public DbSet<Video> videos { get; set; }
    }
}
