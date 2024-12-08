using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public sealed class RentalOfficeController : ControllerBase
{
    [HttpGet]
    public IEnumerable<RentalOfficeModel> GetAll() => Enumerable.Empty<RentalOfficeModel>();

    [HttpGet("{name}")]
    public object? Get(string name) => default;

    [HttpPost]
    public async Task<IActionResult> Post(IEnumerable<RentalOfficeModel> rentalOffices) => Ok();

    [HttpPut("{name}")]
    public async Task<IActionResult> Put(string name, RentalOfficeModel updateRentalOffice) => Ok();

    [HttpDelete("{name}")]
    public async Task<IActionResult> Delete(string name) => Ok();
}