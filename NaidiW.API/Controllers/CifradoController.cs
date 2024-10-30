using Microsoft.AspNetCore.Mvc;
using NaidiW.Business.Services;

[Controller]
[Route("api/[controller]")]
public class CifradoController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> DecodeNumeric(string palabra)
    {
        var cifrado = new Cifrado();
        var decifrado = cifrado.DecodificadorNumerico(palabra);
        return Ok(decifrado);
    }
}