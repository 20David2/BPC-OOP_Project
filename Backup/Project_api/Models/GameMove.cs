using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_api.Models
{
    public class GameMove
    {
        public Guid gameId { get; set; }
        public Guid playerId { get; set; }
        public int move { get; set; }

    }
}