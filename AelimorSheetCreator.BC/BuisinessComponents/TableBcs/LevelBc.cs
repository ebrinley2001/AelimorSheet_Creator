using AelimorSheetCreator.Data;
using AelimorSheetCreator.Models;
using EthanFramework.BC.BuisinessComponents;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AelimorSheetCreator.BC
{
    public class LevelBc : BaseEfBc<Level, ILevelRepository>, ILevelBc
    {
        private readonly ILevelRepository _repo;

        private Level actualLevel;

        public LevelBc(ILevelRepository repo) : base(repo)
        {
            _repo = repo;
        }

        public async Task<Level> GetLevelByXp(int Xp)
        {
            IEnumerable<Level> allLevels = await _repo.GetCollectionAsync();

            foreach (var level in allLevels)
            {
                if (Xp >= level.XpAmount)
                {
                    actualLevel = level;
                }
                else if (Xp! >= level.XpAmount)
                {
                    break;
                }
            }

            return actualLevel;
        }
    }
}
