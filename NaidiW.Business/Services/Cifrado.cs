using System;
using Microsoft.VisualBasic;
using NaidiW.Business.Interfaces;

namespace NaidiW.Business.Services;

public class Cifrado : ICifrado
{
    public string DecodificadorNumerico(string palabraClave)
    {
        var palabra = string.Empty;
        var temp = palabraClave.Split('-');

        foreach(var pal in temp)
        {
            if(int.Parse(pal) == 1)
            {
                palabra += "a";
            }
            if(int.Parse(pal) == 2)
            {
                palabra += "b";
            }
            if(int.Parse(pal) == 3)
            {
                palabra += "c";
            }
            if(int.Parse(pal) == 4)
            {
                palabra += "d";
            }
            if(int.Parse(pal) == 5)
            {
                palabra += "e";
            }
        }

        return palabra;
    }
}
