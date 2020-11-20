using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StringCalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalcController : ControllerBase
    {
        [HttpGet]
        public int GetSumValue(string numbersString)
        {
            return StringCalculator.Add(numbersString);
        }
    }
}