using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;
using NaidiW.Business.Interfaces;

namespace NaidiW.Business.Services;

public class Cifrado : ICifrado
{

    public string CharToNumber(string palabra)
    {
        //var arrayEspacios = palabra.Split(' ');
        var listaNumerica = new List<int>();
        var palabraCodificada = String.Empty;
        foreach (var letra in palabra)
        {
            palabraCodificada += Convert.ToInt32(letra).ToString() + "-";
        }

        return  palabraCodificada.Remove(palabraCodificada.LastIndexOf('-'),1);
    }

    public string NumberToChar(string palabra)
    {
        var arrayAMirar = palabra.Split('-');
        var frase = "";
        foreach (var item in arrayAMirar)
        {
            frase +=  Convert.ToChar(int.Parse(item));
        }
        return frase;
    }
}
