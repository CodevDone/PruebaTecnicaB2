namespace Avisame.Core;

public class Prueba
{

    public int numero { get; set; }
    public string salida { get; set; }
    public void Ejecuta ()
    {
        salida = $" la salida es {numero}";
    }

    public static bool esPalindromoGPT(string palabra)
    {
        palabra = palabra.ToLower();
        int longitud = palabra.Length;
    
        for (int i = 0; i <longitud/2; i++)
        {
            if (palabra[i] != palabra[longitud - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
