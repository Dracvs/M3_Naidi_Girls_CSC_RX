using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using NaidiW.Business.Services;

[Controller]
[Route("api/[controller]")]
public class CifradoController : ControllerBase
{
    [HttpPost]
    [Route("DecodeNumeric")]
    public async Task<IActionResult> DecodeNumeric(string palabra)
    {
        var cifrado = new Cifrado();
        //var decifrado = cifrado.DecodificadorNumerico(palabra);
        var decifrado = cifrado.NumberToChar(palabra);
        return Ok(decifrado);
    }

    [HttpPost]
    [Route("EncodeNumeric")]
    public async Task<IActionResult> EncodeNumeric(string palabra)
    {
        var cifrado = new Cifrado();
        //var codificado = cifrado.CodificadorNumerico(palabra);
        var codificado = cifrado.CharToNumber(palabra);
        return Ok(codificado);
    }

    
}