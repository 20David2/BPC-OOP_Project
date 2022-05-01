﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_web_app2.App.Models
{
    public class GameCreated
    {
        public string gameName { get; set; }

        public Guid player1Id { get; set; }

        public int matchStartCount { get; set; }

        public int matchRoundCount { get; set; }
    }
}