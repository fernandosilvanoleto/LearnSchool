using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnSchool.Entities;
using LearnSchool.Entities.Enums;
using System.Collections.Generic;
using System.Globalization;

namespace LearnSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * PRIMEIRA PARTE 01
             * 
            Account account = new Account(1001, "Fernando Silva Noleto", 1000);
            BusinessAccount bacc = new BusinessAccount(1002, "Leide", 0.00, 500.00);

            //Console.WriteLine(account.Balance);

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Boob", 1000, 200);
            Account acc3 = new SavingsAccount(1004, "Anna", 1000, 1000);
            Account fer = new Account(10, "Boloteca", 1000);

            fer.Withdraw(10.00);
            acc2.Withdraw(10.00);
            acc3.Withdraw(10.00);
            Console.WriteLine("Nome do Cliente: " + fer.Holder + " Conta account: " + fer.Balance);
            Console.WriteLine("Nome do Cliente: " + acc2.Holder + " Conta acc2: " + acc2.Balance);
            Console.WriteLine("Nome do Cliente: " + acc3.Holder + " Conta acc3: " + acc3.Balance);

            //DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //BusinessAccount acc5 = (BusinessAccount)acc3;

            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.00);
                Console.WriteLine("Loan!!!");
            }
            else if (acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!!!");
            }
            */

            /*
             * SEGUNDA PARTE 02            
             *          

           List<Employee> listaFuncionario = new List<Employee>();

            Console.WriteLine("Quantidade de funcionários para serem cadastrados: ");
            int quantidadeFuncionario = int.Parse(Console.ReadLine());

            for(int i = 1; i <= quantidadeFuncionario; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");

                Console.Write("OutSourced (y/n)? ");
                char Terceirizado = char.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.WriteLine("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // CultureInfo.InvariantCulture é usado para especificar que o usuário deve inserir pontos e não vírgulas em double

                if(Terceirizado == 'y')
                {
                    Console.WriteLine("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listaFuncionario.Add(new OutSourcedEmployee(name, hours, valueperhour, additionalCharge));

                    Console.WriteLine("Funcionário Terceirizado cadastrado com sucesso!!!");

                }
                else
                {
                    listaFuncionario.Add(new Employee(name, hours, valueperhour));

                    Console.WriteLine("Funcionário Padrão cadastrado com sucesso!!!");

                }                
            }

            Console.WriteLine();
            Console.WriteLine("PAYAMENTS");

            foreach (Employee funcionario in listaFuncionario)
            {
                Console.WriteLine("Nome do Funcionario: " + funcionario.Name + " - $ " 
                    + funcionario.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

           */

            /*
             *  TERCEIRA PARTE - 03
             *           

            List<Product> listaProdutos = new List<Product>();

            Console.WriteLine("Quantidade de produtos para serem cadastrados: ");
            int quantidaderodutos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantidaderodutos; i++)
            {
                Console.WriteLine($"Product #{i} data: ");

                Console.WriteLine("Common, used or imported (c/u/i)?: ");
                char opcao = char.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(opcao == 'c')
                {
                    listaProdutos.Add(new Product(name, price));
                    Console.WriteLine("Produto Comum Adicionado com sucesso!!!");
                }
                else if (opcao == 'u')
                {
                    Console.Write("Data (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    listaProdutos.Add(new UsedProduct(name, price, date));
                    Console.WriteLine("Produto Used adicionado com sucesso!!!");
                }
                else if (opcao == 'i')
                {
                    Console.WriteLine("Value of Customs fee: ");
                    double customsfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine(customsfee);
                    listaProdutos.Add(new ImportedProduct(name, price, customsfee));
                    Console.WriteLine("Produto Importado cadastrado com sucesso!!!");
                }
                else
                {
                    Console.WriteLine("Informe o código de produto corretamente. Por favor!!!");
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");
            Console.WriteLine();

            foreach (Product produtos in listaProdutos)
            {
                Console.WriteLine("Item: " + produtos.Name + " - $ " + produtos.PriceTag());
            }
             */

            /*
             * QUARTA PARTE - 04
             * CLASSES ABSTRATAS - NÃO PODE SER INSTANCIADA - SÓ AS SUBCLASSES NÃO ABSTRACT
             

            List<Account> list = new List<Account>(); // NÃO ESTOU INICIANDO EM ACCOUNT

            list.Add(new SavingsAccount(1001, "Fernando", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Leide", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Rogerio", 500.00, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account clients in list)
            {
                sum += clients.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account listClients in list)
            {
                listClients.Withdraw(10.00);
            }

            foreach (Account listClients in list)
            {
                Console.WriteLine("Updated balance for account "
                    + listClients.Number
                    + ": "
                    + listClients.Balance.ToString("F2", CultureInfo.InvariantCulture)
                    );
            }
            */

            /*
             * QUINTA PARTE - 05
             *              

            List<Shape> listShape = new List<Shape>();

            Console.WriteLine("Enter the number of shapes: ");
            int quant = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quant; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Shape #{i} data: ");
                Console.WriteLine("Rectangle or Cicle (r/c): ");
                char ch = char.Parse(Console.ReadLine());

                Console.WriteLine("Color:  (Black/Blue/Red): ");
                Color color = (Color)Enum.Parse(typeof(Color), Console.ReadLine()); // VERSÕES ATUAIS DO C# em relãção ao Enum
                //OrderSalesStatus statusorder = (OrderSalesStatus)Enum.Parse(typeof(OrderSalesStatus), Console.ReadLine()); // VERSÕES ATUAIS DO C#

                if (ch == 'r')
                {
                    Console.WriteLine("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.WriteLine("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); ;

                    listShape.Add(new Rectangle(width, height, color));
                    Console.WriteLine("Rectangle Inserted with sucess!!!");
                    Console.WriteLine();
                } else if(ch == 'c')
                {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listShape.Add(new Circle(radius, color));
                    Console.WriteLine("Radius Inserted with sucess!!!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("DADOS INCORRETOS. INSERE NOVAMENTE!!!");
                    Console.WriteLine();
                }

            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS: ");

            foreach (Shape shape in listShape)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
            */

            List<Pessoa> listPessoas = new List<Pessoa>();

            Console.WriteLine("Enter the number of tax payers: ");
            int quant = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quant; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.WriteLine("Individual or Company (i/c): ");
                char ch = char.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Name: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Anual income: ");
                double rendaanual = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

                if (ch == 'i')
                {
                    Console.WriteLine("Gastos com saúde: ");
                    double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listPessoas.Add(new PessoaFisica(nome, rendaanual, gastoSaude));
                    Console.WriteLine("Pessoa Física cadastrado com sucesso!!!");
                }
                else if(ch == 'c')
                {
                    Console.WriteLine("Número de Funcionários: ");
                    int numerofuncionario = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listPessoas.Add(new PessoaJuridica(nome, rendaanual, numerofuncionario));
                    Console.WriteLine("Pessoa Jurídica cadastrado com sucesso!!");

                } else
                {
                    Console.WriteLine("Insere dados corretos, por favor!!!!");
                }

            }

            Console.WriteLine();
            Console.WriteLine("Taxes Paid:");
            double gastosTotal = 0.00;
            foreach (Pessoa pessoas in listPessoas)
            {
                Console.WriteLine(pessoas.Nome + ": $ " + pessoas.CalculoImposto());
                Console.WriteLine();
                gastosTotal += pessoas.CalculoImposto();
            }

            Console.WriteLine("Total Taxes: $ " + gastosTotal);

            }
    }
}
