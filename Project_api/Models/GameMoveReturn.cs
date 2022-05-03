using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_api.Models
{
    public class GameMoveReturn
    {
        public bool state { get; set; }
        public int NumOfMatchesRemaining { get; set; }
        public string NamePlayerTurn { get; set; }
        public string Winner { get; set; }
    }
}