using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Entities.ViewModels.Mission
{
    public class MissionResponseModel
    {
        public string MissionTitle {  get; set; } = string.Empty;

        public string MissionTheme { get; set; } = string.Empty;

        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }

        public string Action { get; set; } = string.Empty;
    }
}
