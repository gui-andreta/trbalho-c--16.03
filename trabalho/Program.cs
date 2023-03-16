using ClassLibrary1;

internal class Program {
    private static void Main(string[] args) {
        /* 
            Crie uma classe Pessoa com os atributos:
             nome;
             cpf;
             data nascimento;

             metodo para retornar boolean para validar se o CPF tem 11 digitos;
             criar um metodo para setar nome;
             criar metodo que retorne idade

             no console imprima a classe, chamar os metodos e imprimir os retornos;
         */

        Pessoa people = new Pessoa();

        Console.WriteLine("Digite seu Nome: ");
        string name = people.setName(Console.ReadLine());

        Console.WriteLine("Digite seu CPF");
        string CPF = people.cpf = Console.ReadLine();

        people.valCPF(CPF);

        Console.WriteLine("Digite sua data de nascimento (yyyy/mm/dd): ");
        people.nas = DateTime.Parse(Console.ReadLine());

        int idade = people.age(people.nas);

        Console.WriteLine("Seu nome: " + name);
        Console.WriteLine("Seu CPF: " + CPF + "\n");

        if (people.valCPF(CPF) == true) {
            Console.WriteLine("CPF: VALIDO\n");
        } else {
            Console.WriteLine("CPF: INVALIDO\n");
        }

        Console.WriteLine("Sua data de nascimento: " + people.nas);
        Console.WriteLine("Sua idade: " + idade);
    }
}