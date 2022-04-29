using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;

namespace Project_api.Models
{
    public class MatchData
    {
        string gameId { get; set; }
        string playerId { get; set; }
        int matchRoundCount { get; set; }
        
    }
}