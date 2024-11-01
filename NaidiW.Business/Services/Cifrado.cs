using System;
using Microsoft.VisualBasic;
using NaidiW.Business.Interfaces;

namespace NaidiW.Business.Services;

public class Cifrado : ICifrado
{
    public string CodificadorNumerico(string palabra)
    {
        //TODO: codificar lo que viene en palabra a números
        // TODO: divididos por guiones, respetar los espacios.
        return "";
    }

    public string DecodificadorNumerico(string palabraClave)
    {
        var palabra = string.Empty;
        var temp = palabraClave.Split(' ');

        foreach (var item in temp)
        {
            var guionesPicados = item.Split("-");

            foreach (var pal in guionesPicados)
            {
                if (int.Parse(pal) == 1)
                {
                    palabra += "a";
                }
                if (int.Parse(pal) == 2)
                {
                    palabra += "b";
                }
                if (int.Parse(pal) == 3)
                {
                    palabra += "c";
                }
                if (int.Parse(pal) == 4)
                {
                    palabra += "d";
                }
                if (int.Parse(pal) == 5)
                {
                    palabra += "e";
                }
                if (int.Parse(pal) == 6)
                {
                    palabra += "f";
                }
                if (int.Parse(pal) == 7)
                {
                    palabra += "g";
                }
                if (int.Parse(pal) == 8)
                {
                    palabra += "h";
                }
                if (int.Parse(pal) == 9)
                {
                    palabra += "i";
                }
                if (int.Parse(pal) == 10)
                {
                    palabra += "j";
                }
                if (int.Parse(pal) == 11)
                {
                    palabra += "k";
                }
                if (int.Parse(pal) == 12)
                {
                    palabra += "l";
                }
                if (int.Parse(pal) == 13)
                {
                    palabra += "m";
                }
                if (int.Parse(pal) == 14)
                {
                    palabra += "n";
                }
                if (int.Parse(pal) == 15)
                {
                    palabra += "o";
                }
                if (int.Parse(pal) == 16)
                {
                    palabra += "p";
                }
                if (int.Parse(pal) == 17)
                {
                    palabra += "q";
                }
                if (int.Parse(pal) == 18)
                {
                    palabra += "r";
                }
                if (int.Parse(pal) == 19)
                {
                    palabra += "s";
                }
                if (int.Parse(pal) == 20)
                {
                    palabra += "t";
                }
                if (int.Parse(pal) == 21)
                {
                    palabra += "u";
                }
                if (int.Parse(pal) == 22)
                {
                    palabra += "v";
                }
                if (int.Parse(pal) == 23)
                {
                    palabra += "w";
                }
                if (int.Parse(pal) == 24)
                {
                    palabra += "x";
                }
                if (int.Parse(pal) == 25)
                {
                    palabra += "y";
                }
                if (int.Parse(pal) == 26)
                {
                    palabra += "z";
                }
                if (int.Parse(pal) == 27)
                {
                    palabra += "ñ";
                }

            }

            palabra += " ";
        }
        return palabra.TrimEnd();
    }
}
