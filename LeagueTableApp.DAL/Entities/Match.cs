﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueTableApp.DAL.Entities
{
    public class Match
    {
        public int Id { get; set; }
        /*public string Location { get; set; }

        public Match(string location)
        {
            Location = location;
        }*/

        public int LeagueId { get; set; }
        public League? League { get; set; }
        public int? HomeTeamId { get; set; }
        public Team? HomeTeam { get; set; }
        public int? ForeignTeamId { get; set; }
        public Team? ForeignTeam { get; set; }
        public double HomeTeamScore { get; set; } = 0;
        public double ForeignTeamScore { get; set; } = 0;
        public bool IsEnded { get; set; } = false;
        public bool IsDeleted { get; set; } 
        public byte[] RowVersion { get; set; } = null!;
    }
}
