using Microsoft.AspNetCore.Mvc;

namespace BuilderPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InsuranceController : ControllerBase
    {

        [HttpGet]
        [Route("GetCarInsuranceAmount")]
        public int GetCarInsuranceAmount()
        {
            var _client = new Client();
            var carInsuranceBuilder = new CarInsuranceBuilder();
            return _client.Construct(carInsuranceBuilder);
        }

        [HttpGet]
        [Route("GetHomeOwnerInsuranceAmount")]
        public int GetHomeOwnerInsuranceAmount()
        {
            var _client = new Client();
            var homeOwnerInsuranceBuilder = new HomeOwnerInsuranceBuilder();
            return _client.Construct(homeOwnerInsuranceBuilder);
        }
    }
}