using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iShopOdataWebApi.Hubs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace iShopOdataWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public class LoginModel
        {
            public string PhoneNumber { get; set; }
            public string Otp { get; set; }
        }

        private IHubContext<CentralMessagingHub> _hubContext { get; set; }
        public static Random random = new Random(101);
        public static ConcurrentDictionary<string, string> PhoneNumbersWithOtp = new ConcurrentDictionary<string, string>();

        public LoginController(IHubContext<CentralMessagingHub> hubcontext)
        {
            _hubContext = hubcontext;
        }

        [HttpGet]
        [Route("Getotp/{phoneNumber}")]
        public ActionResult<bool> GetOtp(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;
            
            var newOtp = random.Next(100001, 999999).ToString("D6");
            PhoneNumbersWithOtp.AddOrUpdate(phoneNumber, newOtp, (k, v) => newOtp);
            _hubContext.Clients.All.SendAsync("ReceiveMessage", newOtp);

            return true;
        }

        [HttpPost]
        [Route("usingotp")]
        public ActionResult<bool> LoginWithOtp([FromBody] LoginModel loginModel)
        {
            if (string.IsNullOrWhiteSpace(loginModel.PhoneNumber)
                || !PhoneNumbersWithOtp.TryGetValue(loginModel.PhoneNumber, out string currentOtp)
                || !currentOtp.Equals(loginModel.Otp))
                return false;
            PhoneNumbersWithOtp.AddOrUpdate(loginModel.PhoneNumber, string.Empty, (k, v) => string.Empty);
            return true;
        }
    }
}
