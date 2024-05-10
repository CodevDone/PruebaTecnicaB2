namespace Avisame.UnitTest;
using Avisame.Core;
using Xunit.Abstractions;

public class UnitTest1
{
    private readonly ITestOutputHelper output;

    public UnitTest1(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Fact]
    public void Test1()
    {
        var prueba = new Prueba();
        // prueba.numero = 0;
        // output.WriteLine("This is output from {0}", prueba.salida);
        // prueba.Ejecuta();
        // output.WriteLine("This is output from {0}", prueba.salida);

        var salida =  Prueba.esPalindromoGPT("algo");
        output.WriteLine("This is output from {0}", salida);
        salida =  Prueba.esPalindromoGPT("ala");
        output.WriteLine("This is output from {0}", salida);
    }
}