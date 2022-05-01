using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_api.Models
{
    public class JoinGame
    {
        public Guid gameId { get; set; }

        public Guid player2Id { get; set; }
    }
}