using CalculatorAPI.Utility;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorAPI.Controllers
{
    [Route("api/calculate")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpPost]
        public JObject CalculateResult([FromBody]string requestJson)
        {
            JObject equation = JObject.Parse(requestJson);

            Equation parsedEquation = new(equation);
            var result = parsedEquation.CalculateResult();
            equation.Add("Result", result);
            return equation;
        }
    }
}
