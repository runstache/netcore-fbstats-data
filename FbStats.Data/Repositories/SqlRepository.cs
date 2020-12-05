using FbStats.Data.Contexts;
using FbStats.Data.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace FbStats.Data.Repositories
{
    public class SqlRepository : IRepository
    {
        private SqlContext ctx;

        public SqlRepository(SqlContext ctx)
        {
            this.ctx = ctx;
        }

        public SqlRepository(string connectionString)
        {
            ctx = new SqlContext(connectionString);
        }

        public void Delete(Team team)
        {
            ctx.Teams.Remove(team);
            ctx.SaveChanges();
        }

        public void Delete(ScheduleItem item)
        {
            ctx.ScheduleItems.Remove(item);
            ctx.SaveChanges();
        }

        public void Delete(Quarterback qb)
        {
            ctx.Quarterbacks.Remove(qb);
            ctx.SaveChanges();
        }

        public void Delete(GameStat stat)
        {
            ctx.Stats.Remove(stat);
            ctx.SaveChanges();
        }

        public GameStat GetGameStat(long id)
        {
            return ctx.Stats.Where(c => c.Id == id).FirstOrDefault();
        }

        public IQueryable<GameStat> GetGameStats()
        {
            return ctx.Stats;
        }

        public Quarterback GetQuarterback(int id)
        {
            return ctx.Quarterbacks.Where(c => c.Id == id).FirstOrDefault();
        }

        public IQueryable<Quarterback> GetQuarterbacks()
        {
            return ctx.Quarterbacks;
        }

        public ScheduleItem GetScheduleItem(long id)
        {
            return ctx.ScheduleItems.Where(c => c.Id == id).FirstOrDefault();
        }

        public IQueryable<ScheduleItem> GetScheduleItems()
        {
            return ctx.ScheduleItems;
        }

        public Team GetTeam(int id)
        {
            return ctx.Teams.Where(c => c.Id == id).FirstOrDefault();
        }

        public Team GetTeam(string code)
        {
            return ctx.Teams.Where(c => c.Code == code).FirstOrDefault();
        }

        public IQueryable<Team> GetTeams()
        {
            return ctx.Teams;
        }

        public Team Insert(Team team)
        {
            EntityEntry<Team> entity = ctx.Teams.Add(team);
            ctx.SaveChanges();
            return entity.Entity;
        }

        public ScheduleItem Insert(ScheduleItem item)
        {
            EntityEntry<ScheduleItem> entry = ctx.ScheduleItems.Add(item);
            ctx.SaveChanges();
            return entry.Entity;
        }

        public Quarterback Insert(Quarterback qb)
        {
            EntityEntry<Quarterback> entry = ctx.Quarterbacks.Add(qb);
            ctx.SaveChanges();
            return entry.Entity;
        }

        public GameStat Insert(GameStat stat)
        {
            EntityEntry<GameStat> entry = ctx.Stats.Add(stat);
            ctx.SaveChanges();
            return entry.Entity;
        }

        public Team Update(Team team)
        {
            if (team.Id > 0)
            {
                Team orig = GetTeam(team.Id);
                if (!orig.Equals(team))
                {
                    ctx.Entry(orig).CurrentValues.SetValues(team);
                    ctx.SaveChanges();
                }
                return GetTeam(team.Id);
            }
            else
            {
                return Insert(team);
            }
        }

        public ScheduleItem Update(ScheduleItem item)
        {
            if (item.Id > 0)
            {
                ScheduleItem orig = GetScheduleItem(item.Id);
                if (!orig.Equals(item))
                {
                    ctx.Entry(orig).CurrentValues.SetValues(item);
                    ctx.SaveChanges();
                }
                return GetScheduleItem(item.Id);
            }
            else
            {
                return Insert(item);
            }
        }

        public Quarterback Update(Quarterback qb)
        {
            if (qb.Id > 0)
            {
                Quarterback orig = GetQuarterback(qb.Id);
                if (!orig.Equals(qb))
                {
                    ctx.Entry(orig).CurrentValues.SetValues(qb);
                    ctx.SaveChanges();
                }
                return GetQuarterback(qb.Id);
            }
            else
            {
                return Insert(qb);
            }
        }

        public GameStat Update(GameStat stat)
        {
            if (stat.Id > 0)
            {
                GameStat orig = GetGameStat(stat.Id);
                if (!orig.Equals(stat))
                {
                    ctx.Entry(orig).CurrentValues.SetValues(stat);
                    ctx.SaveChanges();
                }
                return GetGameStat(stat.Id);
            }
            else
            {
                return Insert(stat);
            }
        }
    }
}
