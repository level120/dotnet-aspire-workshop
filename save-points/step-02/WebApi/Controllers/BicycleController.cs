using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public sealed class BicycleController : ControllerBase
{
    [HttpGet("{id:guid}")]
    public BicycleModel? Get(Guid id) => default;

    [HttpPost]
    public async Task<IActionResult> Post(IEnumerable<BicycleModel> bicycles) => Ok();

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Put(Guid id, BicycleModel bicycle) => Ok();

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id) => Ok();
}