//using Mission.Entities.ViewModels.Mission;
//using Mission.Entities.ViewModels.MissionSkill;
//using Mission.Entities.ViewModels.MissionTheme;
//using Mission.Repositories.IRepository;
//using Mission.Services.IService;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Mission.Services.Service
//{
//    public class MissionService : IMissionService
//    {
//        private readonly IMissionRepository _missionRepository;

//        public MissionService(IMissionRepository missionRepository)
//        {
//            _missionRepository = missionRepository ?? throw new ArgumentNullException(nameof(missionRepository));
//        }

//        public async Task<List<MissionThemeResponseModel>> GetMissionThemeAsync()
//        {
//            return await _missionRepository.GetMissionThemeAsync();
//        }

//        public async Task<List<MissionSkillResponseModel>> GetMissionSkillAsync()
//        {
//            return await _missionRepository.GetMissionSkillAsync();
//        }

//       public async Task<List<MissionResponseModel>> GetMissionListAsync()
//        {
//            return await _missionRepository.GetMissionListAsync();
//        }
//    }

//}
