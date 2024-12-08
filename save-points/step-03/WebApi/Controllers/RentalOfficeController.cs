using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class RentalOfficeController(BicycleSharingContext context) : ControllerBase
{
    [HttpGet]
    public IEnumerable<RentalOfficeModel> GetAll() => context.RentalOffices;

    [HttpGet("{name}")]
    public object? Get(string name)
    {
        var rentalOffice = context.RentalOffices.FirstOrDefault(o => o.Name == name);

        if (rentalOffice == null)
        {
            return default;
        }

        return new
        {
            OfficeId = rentalOffice.OfficeId,
            Name = rentalOffice.Name,
            Region = rentalOffice.Region,
            Latitude = rentalOffice.Latitude,
            Longitude = rentalOffice.Longitude,
            Bicycles = context.Bicycles.Where(x => x.RentalOfficeId == rentalOffice.OfficeId)
        };
    }

    [HttpPost]
    public async Task<IActionResult> Post(IEnumerable<RentalOfficeModel> rentalOffices)
    {
        try
        {
            context.RentalOffices.AddRange(rentalOffices);

            var changes = await context.SaveChangesAsync().ConfigureAwait(false);

            return Ok(changes);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Put(Guid id, RentalOfficeModel updateRentalOffice)
    {
        var rentalOffice = context.RentalOffices.FirstOrDefault(o => o.OfficeId == id);

        if (rentalOffice is null)
        {
            return NotFound($"\"{id}\" cannot be found.");
        }

        try
        {
            context.RentalOffices.Remove(rentalOffice);
            context.RentalOffices.Add(updateRentalOffice);

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
        var previousOffice = context.RentalOffices.FirstOrDefault(o => o.OfficeId == id);

        if (previousOffice is null)
        {
            return NotFound($"\"{id}\" cannot be found.");
        }

        try
        {
            context.RentalOffices.Remove(previousOffice);

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