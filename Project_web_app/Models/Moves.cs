using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_api.Models
{
    public class Moves
    {
        public int gameid { get; set; }
        public int moveNumber { get; set; }    
        public int movePlayet { get; set; }
        public int moveMatchCount { get; set; }
    }
}