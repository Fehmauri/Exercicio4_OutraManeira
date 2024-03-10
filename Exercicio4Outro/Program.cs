using System;

public class Program
{
    static void Main(string[] args)
    {
        string tipoCarne = "";
        double quantidadeCarne = 0;
        double precoTotal = 0;
        bool pagamentoCartaoTabajara = false;
        string mensagem = "Até 5 Kg Acima de 5 Kg\r\nFile Duplo R$ 4,90 por Kg R$ 5,80 por Kg\r\nAlcatra R$ 5,90 por Kg R$ 6,80 por Kg\r\nPicanha R$ 6,90 por Kg R$ 7,80 por Kg";

        Console.WriteLine(mensagem);
        Console.WriteLine("--------------------------------------");
        Console.WriteLine("Selecione o tipo de carne desejada:");
        Console.WriteLine("1 - File Duplo");
        Console.WriteLine("2 - Alcatra");
        Console.WriteLine("3 - Picanha");
        int opcaoCarne = int.Parse(Console.ReadLine());

        switch (opcaoCarne)
        {
            case 1:
                tipoCarne = "File Duplo";
                precoTotal = 4.90;
                break;
            case 2:
                tipoCarne = "Alcatra";
                precoTotal = 5.90;
                break;
            case 3:
                tipoCarne = "Picanha";
                precoTotal = 6.90;
                break;
            default:
                Console.WriteLine("Opção inválida!");
                return;
        }

        Console.WriteLine("Digite a quantidade de carne desejada (kg):");
        quantidadeCarne = double.Parse(Console.ReadLine());

        if (quantidadeCarne <= 5)
        {
            precoTotal *= quantidadeCarne;
        }
        else
        {
            if (tipoCarne == "File Duplo")
            {
                precoTotal = 5.80;
                precoTotal *= quantidadeCarne;
            }
            if (tipoCarne == "Alcatra")
            {
                precoTotal = 6.80;
                precoTotal *= quantidadeCarne;
            }
            if (tipoCarne == "Picanha")
            {
                precoTotal = 7.80;
                precoTotal *= quantidadeCarne;
            }

        }

        Console.WriteLine("Pagamento com cartão Tabajara? (Sim/Nao)");
        string respostaCartao = Console.ReadLine().ToLower();

        if (respostaCartao == "sim")
        {
            pagamentoCartaoTabajara = true;
        }

        double desconto = 0;
        double valorAPagar = precoTotal;

        if (pagamentoCartaoTabajara)
        {
            desconto = precoTotal * 0.05;
            valorAPagar -= desconto;
        }

        Console.WriteLine("\n---------------------------------------");
        Console.WriteLine("Cupom Fiscal");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Tipo da carne: {0}", tipoCarne);
        Console.WriteLine("Quantidade: {0} kg", quantidadeCarne);
        Console.WriteLine("Preço por total: R$ {0}", precoTotal.ToString("F2"));
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Subtotal: R$ {0}", precoTotal.ToString("F2"));

        if (pagamentoCartaoTabajara)
        {
            Console.WriteLine("Desconto (cartão Tabajara): R$ {0}", desconto.ToString("F2"));
        }

        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Valor a pagar: R$ {0}", valorAPagar.ToString("F2"));
        Console.WriteLine("---------------------------------------");

        Console.WriteLine("\nObrigado pela sua compra!");
    }
}