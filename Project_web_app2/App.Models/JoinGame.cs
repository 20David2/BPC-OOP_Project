using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_web_app2.App.Models
{
    public class JoinGame
    {
        public Guid gameId { get; set; }

        public Guid player2Id { get; set; }
    }
}