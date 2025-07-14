using Mission.Entities.ViewModels.Mission;
using Mission.Entities.ViewModels.MissionSkill;
using Mission.Entities.ViewModels.MissionTheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Services.IService
{
    public interface IMissionService
    {
        Task<List<MissionThemeResponseModel>> GetMissionThemeAsync();

        Task<List<MissionSkillResponseModel>> GetMissionSkillAsync();

        Task<List<MissionResponseModel>> GetMissionListAsync();
    }
}
