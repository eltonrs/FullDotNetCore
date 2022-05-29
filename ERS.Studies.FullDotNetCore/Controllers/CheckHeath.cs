using ERS.Studies.FullDotNetCore.API.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace ERS.Studies.FullDotNetCore.API.Controllers
{
    public class CheckHeath : ControllerDefault
    {
        /// <summary>
        /// Get status of heath of application.
        /// </summary>
        /// <returns>An string like "Heath ok!!!"</returns>
        [HttpGet("heath")]
        public async Task<IActionResult> GetHeathAsync() => await Task.FromResult(Ok("Heath ok!!!"));

        /// <summary>
        /// Get status detailed of heath of application.
        /// </summary>
        /// <returns>An string like "Heath details!!!"</returns>
        [HttpGet("heath/details")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<HeathDetail>> GetHeathDetailsAsync() =>
            await Task.FromResult(Ok(new HeathDetail(3, "teste")));
    }

    public readonly record struct HeathDetail(int id, string name)
    {
        public DateTime DateTimeNow => DateTime.Now;

        public string IdExtended => id.ToString() + "ERS";

        public string NameExtented => name + "ERS";
    }
}
