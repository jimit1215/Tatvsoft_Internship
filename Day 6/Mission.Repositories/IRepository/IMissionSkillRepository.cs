using Mission.Entities.ViewModels.Mission;
using Mission.Entities.ViewModels.MissionSkill;
using Mission.Repositories.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Repositories.IRepository
{
    public interface IMissionSkillRepository
    {
        Task AddMissionSkillAsync(UpsertMissionSkillRequestModel model);

        Task<List<MissionSkillResponseModel>> GetMissionSkillAsync();

        Task<MissionSkillResponseModel?> GetMissionSkillByIdAsync(int missionSkillId);

        Task<bool> UpdateMissionSkillAsync(UpsertMissionSkillRequestModel model);

        Task<bool> DeleteMissionSkillAsync(int missionSkillId);
    }
}
