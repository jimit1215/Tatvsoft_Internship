//using Microsoft.EntityFrameworkCore;
//using Mission.Entities;
//using Mission.Entities.ViewModels.Mission;
//using Mission.Entities.ViewModels.MissionSkill;
//using Mission.Entities.ViewModels.MissionTheme;
//using Mission.Repositories.IRepository;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Mission.Repositories.Repository
//{
//    public class MissionRepository(MissionDbContext dbContext) :IMissionRepository
//    {
//        private readonly MissionDbContext _dbContext = dbContext;

//        public async Task<List<MissionSkillResponseModel>> GetMissionSkillAsync()
//        {
//            return await _dbContext.MissionSkills.Select(x => new MissionSkillResponseModel(x)).ToListAsync();
//        }

//        public async Task<List<MissionThemeResponseModel>> GetMissionThemeAsync()
//        {
//            return await _dbContext.MissionThemes.Select(x => new MissionThemeResponseModel(x)).ToListAsync();
//        }

//        public async Task<List<MissionResponseModel>> GetMissionListAsync()
//        {
//            var missionList = await _dbContext.Missions.Select(x => new MissionSkillResponseModel(x)).ToListAsync();
        
//        }
//    }
//}
