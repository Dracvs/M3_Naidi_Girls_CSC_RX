using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;
using NaidiW.Business.Interfaces;

namespace NaidiW.Business.Services;

public class Cifrado : ICifrado
{
    public string CodificadorNumerico(string palabra)
    {
        var palabraEncriptada = String.Empty;

        var lista = palabra.Split(' ');
        foreach (var valor in lista)
        {
            foreach (var item in valor)
            {
                if(item.Equals('a'))
                {
                    palabraEncriptada+= "1";
                }
                else if(item.Equals('b'))
                {
                    palabraEncriptada += "2";
                }
                else if(item.Equals('c'))
                {
                    palabraEncriptada += "3";
                }
                else if(item.Equals('d'))
                {
                    palabraEncriptada += "4";
                }
                else if(item.Equals('e'))
                {
                    palabraEncriptada += "5";
                }
                else if(item.Equals('f'))
                {
                    palabraEncriptada += "6";
                }
                else if(item.Equals('g'))
                {
                    palabraEncriptada += "7";
                }
                else if(item.Equals('h'))
                {
                    palabraEncriptada += "8";
                }
                else if(item.Equals('i'))
                {
                    palabraEncriptada += "9";
                }
                else if(item.Equals('j'))
                {
                    palabraEncriptada += "10";
                }
                else if(item.Equals('k'))
                {
                    palabraEncriptada += "11";
                }
                else if(item.Equals('l'))
                {
                    palabraEncriptada += "12";
                }
                else if(item.Equals('m'))
                {
                    palabraEncriptada += "13";
                }
                else if(item.Equals('n'))
                {
                    palabraEncriptada += "14";
                }
                else if(item.Equals('o'))
                {
                    palabraEncriptada += "15";
                }
                else if(item.Equals('p'))
                {
                    palabraEncriptada += "16";
                }
                else if(item.Equals('q'))
                {
                    palabraEncriptada += "17";
                }
                else if(item.Equals('r'))
                {
                    palabraEncriptada += "18";
                }
                else if(item.Equals('s'))
                {
                    palabraEncriptada += "19";
                }
                else if(item.Equals('t'))
                {
                    palabraEncriptada += "20";
                }
                else if(item.Equals('u'))
                {
                    palabraEncriptada += "21";
                }
                else if(item.Equals('v'))
                {
                    palabraEncriptada += "22";
                }
                else if(item.Equals('w'))
                {
                    palabraEncriptada += "23";
                }
                else if(item.Equals('x'))
                {
                    palabraEncriptada += "24";
                }
                else if(item.Equals('y'))
                {
                    palabraEncriptada += "25";
                }
                else if(item.Equals('z'))
                {
                    palabraEncriptada += "26";
                }
                else if(item.Equals('ñ'))
                {
                    palabraEncriptada += "27";
                }
                palabraEncriptada+="-";
            }
            ;
            palabraEncriptada = palabraEncriptada.Remove(palabraEncriptada.LastIndexOf('-'),1);
            palabraEncriptada+=" ";
        }

        return palabraEncriptada.TrimEnd();
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

    public void AñademeAquel()
    {
        string nombre = "";
        nombre = nombre + " Abedul";
        Console.WriteLine(nombre); // " Abedul"

        int numero = 0;
        numero = numero + 18;
        numero = numero + 10 - 1;
        Console.WriteLine(numero); 
        // 0189
        // 189
        // 01810-1
        // 018 10 - 1
        // 27

    }

}
