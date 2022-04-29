using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_api.Models
{
    public class Games
    {
        public int gameid { get; set; }
        public string name { get; set; }
        public int playerid_1 { get; set}
        public int playerid_2 { get; set}
        public int matchStartCount { get;set }
        public int matchRoundCound { get;set }
        public int lastMoveNumber { get;set }  
    }
}