using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class BicycleController(BicycleSharingContext context) : ControllerBase
{
    [HttpGet("{id:guid}")]
    public BicycleModel? Get(Guid id) => context.Bicycles.FirstOrDefault(b => b.BicycleId == id);

    [HttpPost]
    public async Task<IActionResult> Post(IEnumerable<BicycleModel> bicycles)
    {
        try
        {
            context.Bicycles.AddRange(bicycles);

            var changes = await context.SaveChangesAsync().ConfigureAwait(false);

            return Ok(changes);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Put(Guid id, BicycleModel bicycle)
    {
        var dbBicycle = context.Bicycles.FirstOrDefault(x => x.BicycleId == id);

        if (dbBicycle is null)
        {
            return NotFound(bicycle);
        }

        try
        {
            context.Bicycles.Remove(dbBicycle);
            context.Bicycles.Add(bicycle);

            return await context.SaveChangesAsync().ConfigureAwait(false) > 0
                ? Accepted()
                : StatusCode(StatusCodes.Status500InternalServerError);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var dbBicycle = context.Bicycles.FirstOrDefault(x => x.BicycleId == id);

        if (dbBicycle is null)
        {
            return NotFound(id);
        }

        try
        {
            context.Bicycles.Remove(dbBicycle);

            return await context.SaveChangesAsync().ConfigureAwait(false) > 0
                ? Accepted()
                : StatusCode(StatusCodes.Status500InternalServerError);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}