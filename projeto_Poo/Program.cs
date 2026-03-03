namespace projeto_Poo
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public string Categoria;
        public double Peso;
    }

    public class Cliente
    {
        public string Nome;
        public string Cidade;
        public int Idade;
    }

    public class Pedido
    {
        public int NumeroPedido;
        public int Quantidade;
        public double DescontoPercentual;
    }
    public class Loja
    {
        public string Nome;
        public string Cidade;
        public double TaxaEntrega;
    }



class Program
    {
        static void Main(string[] args)
        {
           
            Produto produto = new Produto();
            Cliente cliente = new Cliente();
            Pedido pedido = new Pedido();
            Loja loja = new Loja();

            
            produto.Nome = "Notebook";
            produto.Preco = 3000.00;
            produto.Categoria = "Eletrônicos";
            produto.Peso = 2.5;

            cliente.Nome = "João";
            cliente.Cidade = "São Paulo";
            cliente.Idade = 17; 

            pedido.NumeroPedido = 1;
            pedido.Quantidade = 5;
            pedido.DescontoPercentual = 10;

            loja.Nome = "Tech Store";
            loja.Cidade = "São Paulo";
            loja.TaxaEntrega = 50.00;

            
            double valorBruto = produto.Preco * pedido.Quantidade;
            double valorDesconto = valorBruto * (pedido.DescontoPercentual / 100);
            double valorFinal = valorBruto - valorDesconto;
            double pesoTotal = produto.Peso * pedido.Quantidade;

            
            if (cliente.Idade < 18)
            {
                double descontoExtra = valorFinal * 0.05;
                valorFinal -= descontoExtra;
            }

            if (pesoTotal > 10)
            {
                loja.TaxaEntrega += 20; // aumento fixo de exemplo
            }

            double valorTotal = valorFinal + loja.TaxaEntrega;

         
            Console.WriteLine("===== DADOS DO PEDIDO =====");
            Console.WriteLine("Cliente: " + cliente.Nome);
            Console.WriteLine("Produto: " + produto.Nome);
            Console.WriteLine("Quantidade: " + pedido.Quantidade);

            Console.WriteLine("\n===== VALORES =====");
            Console.WriteLine("Valor Bruto: R$ " + valorBruto);
            Console.WriteLine("Valor Desconto: R$ " + valorDesconto);
            Console.WriteLine("Valor Final: R$ " + valorFinal);
            Console.WriteLine("Taxa Entrega: R$ " + loja.TaxaEntrega);
            Console.WriteLine("Valor Total: R$ " + valorTotal);
            Console.WriteLine("Peso Total: " + pesoTotal + " kg");
        }
    }


}

