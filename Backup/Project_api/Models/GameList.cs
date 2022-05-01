using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_api.Models
{
    public class GameList
    {
        public Guid gameId { get; set; }
        public string gameName { get; set; }
        public int matchStartCount { get; set; }
        public int matchRoundCount { get; set; }
    }
}