using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Honours_Project_Test.Models.ViewModels.Talk;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Honours_Project_Test.Controllers
{
    [Route("api/talk")]
    public class TalkController : Controller
    {
        private readonly ITalkService _talkService;

        public TalkController(ITalkService talkService)
        {
            _talkService = talkService;
        }

        [HttpGet]
        [Route("get/all")]
        public List<Basic_Talk_Info> Get_All_Talks()
        {
            return _talkService.Get_All_Talks();
        }

        [HttpGet]
        [Route("get/all/for/user/{userID}/{option}/{optionID}")]
        public List<Basic_Talk_Info> Get_All_Talks_For_User(string userID, string option, string optionID)
        {
            return _talkService.Get_All_Talks_For_User(userID, option, optionID);
        }

        [HttpPost]
        [Route("mark/interested")]
        public Interest_Result Mark_Interested([FromBody] Interest_Request model)
        {
            return _talkService.Log_Interest(model, false);
        }

        [HttpPost]
        [Route("mark/interested/overwrite")]
        public Interest_Result Mark_Interested_Overwrite([FromBody] Interest_Request model)
        {
            return _talkService.Log_Interest(model, true);
        }

        [HttpPost]
        [Route("unmark/interested")]
        public bool Unmark_Interested([FromBody] Interest_Request model)
        {
            return _talkService.Unmark_Interest(model);
        }

        [HttpPost]
        [Route("user/rate/talk")]
        public bool Rate_Talk([FromBody] User_Rating_Request model)
        {
            return _talkService.Rate_Talk(model);
        }
    }
}
