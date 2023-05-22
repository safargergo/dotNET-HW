﻿using LeagueTableApp.BLL.DTOs;

namespace LeagueTableApp.BLL.Interfaces;
public interface IMatchService
{
    public Match GetMatch(int matchId);
    public IEnumerable<Match> GetMatches();
    public Match InsertMatch(Match newMatch);
    public void UpdateMatch(int matchId, Match updatedMatch);
    public void DeleteMatch(int matchId);
}
