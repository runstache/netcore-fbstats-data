using System;
using System.Collections.Generic;
using System.Text;
using FbStats.Data.DataObjects;
using System.Linq;

namespace FbStats.Data.Repositories
{
    public interface IRepository
    {
        #region Insert Methods

        Team Insert(Team team);
        ScheduleItem Insert(ScheduleItem item);
        Quarterback Insert(Quarterback qb);
        GameStat Insert(GameStat stat);

        #endregion

        #region Update Methods 

        Team Update(Team team);
        ScheduleItem Update(ScheduleItem item);
        Quarterback Update(Quarterback qb);
        GameStat Update(GameStat stat);

        #endregion

        #region Retrieval Methods

        Team GetTeam(int id);
        Team GetTeam(string code);
        IQueryable<Team> GetTeams();

        ScheduleItem GetScheduleItem(long id);
        IQueryable<ScheduleItem> GetScheduleItems();

        Quarterback GetQuarterback(int id);
        IQueryable<Quarterback> GetQuarterbacks();

        GameStat GetGameStat(long id);
        IQueryable<GameStat> GetGameStats();

        #endregion

        #region Delete Methods

        void Delete(Team team);
        void Delete(ScheduleItem item);
        void Delete(Quarterback qb);
        void Delete(GameStat stat);

        #endregion
    }
}
