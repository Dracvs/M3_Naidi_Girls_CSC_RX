namespace NaidiW.Business.Interfaces;
public interface ICifrado
{
    public string DecodificadorNumerico(string palabraClave);
    public string CodificadorNumerico(string palabra);
}