﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueTableApp.DAL.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Coach { get; set; }
        public string? Captain { get; set; }
        public string Players { get; set; }
        public int LeagueId { get; set; }

        public Team(string name, string players, string coach = "-NA-", string captain = "-NA-")
        {
            Name = name;
            Players = players;
            Coach = coach;
            Captain = captain;
        }
    }
}
