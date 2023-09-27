namespace Frete;

public static class CalculadorDeFrete
{
    public static decimal Calcular(this int qtdItens)
    {
        var valorSorteado = new Random().Next(5, 10);

        return qtdItens * valorSorteado;
    }
}