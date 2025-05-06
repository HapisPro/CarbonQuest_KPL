using CarbonQuest.API.Models;
using CarbonQuest.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarbonQuest.API.Controllers
{
    [ApiController]
    [Route("api/Calculator")]
    public class CalculatorController : ControllerBase
    {
        private readonly CalculatorService _calculatorService;

        public CalculatorController()
        {
            _calculatorService = new CalculatorService();
        }

        [HttpGet("questions")]
        public IActionResult GetQuestions()
        {
            var questions = _calculatorService.GetQuestions();
            return Ok(questions);
        }

        [HttpPost("submit")]
        public IActionResult SubmitAnswers([FromBody] List<string> answers)
        {
            try
            {
                var totalScore = _calculatorService.CalculateAndSaveScore(answers);
                return Ok(new { message = "Jawaban diterima.", totalScore });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}