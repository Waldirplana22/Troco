using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("----Troco----");
  Decimal valorDaCompra, valorPago, valorDoTroco;

Console.Write("Valor da compra (R$)...: ");
valorDaCompra = Convert.ToDecimal(Console.ReadLine());

Console.Write("Valor pago (R$)........: ");
valorPago = Convert.ToDecimal(Console.ReadLine());

valorDoTroco = valorPago - valorDaCompra;

Console.WriteLine($"\nTroco: R{valorDoTroco:C}");

  }
}
