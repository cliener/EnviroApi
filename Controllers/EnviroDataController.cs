using Microsoft.AspNetCore.Mvc;

namespace EnviroApi.Controllers;

[ApiController]
[Route("[controller]")]
public class EnviroDataController : ControllerBase
{

    private readonly ILogger<EnviroDataController> _logger;

    public EnviroDataController(ILogger<EnviroDataController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetEnviroData")]
    public IEnumerable<EnviroData> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new EnviroData
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Temperature = Random.Shared.Next(-20, 55),
            Humidity = Random.Shared.Next(20, 100),
            Pressure = Random.Shared.Next(900, 1100)
        })
        .ToArray();
    }

}