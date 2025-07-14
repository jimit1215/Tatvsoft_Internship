//using Microsoft.AspNetCore.Mvc;
//using Mission.Entities.ViewModels;
//using Mission.Services.IService;
//using Mission.Services.Service;

//namespace Mission.Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class MissionController(IMissionService missionService) : ControllerBase
//    {
//        private readonly IMissionService _missionService = missionService;


//        [HttpGet]
//        [Route("GetMissionSkillList")]
//        public async Task<IActionResult> GetMissionSkill()
//        {
//            var response = await _missionService.GetMissionSkillAsync();

//            var result = new ResponseResult()
//            {
//                data = response,
//                Result = ResponseStatus.Success
//            };

//            return Ok(result);
//        }

//        [HttpGet]
//        [Route("GetMissionThemeList")]
//        public async Task<IActionResult> GetMissionTheme()
//        {
//            var response = await _missionService.GetMissionThemeAsync();

//            var result = new ResponseResult()
//            {
//                data = response,
//                Result = ResponseStatus.Success
//            };

//            return Ok(result);
//        }

//        [HttpGet]
//        [Route("MissionList")]

//        //public async Task<IActionResult> GetMissionList() 
//        {
//            var response = await _missionService.GetMissionList();

//            var result = new ResponseResult()
//            {
//                data = response,
//                Result = ResponseStatus.Success
//            };

//            return Ok(result);

//        }
//    }
//}
