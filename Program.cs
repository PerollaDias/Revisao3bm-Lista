using REVISAO3B;
public class Program 
{
    static void Main(string[] args)
    {
        //ExemploLista1();
        ExemploListaObjeto();



    }
    static void ExemploLista1()
    {
        List<string> listastring = new List<string>();
        listastring.Add("Elias"); // Adicionar um elemento no final da lista
        listastring.Add("Júlia");
        listastring.Insert(1, "João"); // Adicionar um elemento em uma posição específica da lista

        //listastring.Remove("Júlia"); Remover um elemento passando o item que deseja remover.
        //listastring.RemoveAt(1); Remover um elemento pela posição
        //listastring.Clear(); Limpar a lista
        //listastring.Sort(); Comando responsáve por ordenar a lista

        // O foreach percorre todos os elementos da lista, da primeira posição até a ultima
        // Para cada repetição,copia o endereço atual da lista
        //ouseja, na primeira repetição a variável str recebe o valor da posição 0 da lista (elias)
        // na segunda posição, str recebe o valor da posição 1 da lista (joão)

        List<string> listab = new List<string> { "Maria a", "Maria b" };
        listastring.AddRange(listab); // Adicionar toda a listab no final da listastring

        //bool contem = listastring.Contains("Maria");
        //Console.WriteLine(contem);// verifica se existe na lista

        foreach (string str in listastring)
        {
            Console.WriteLine(str);
        }

        //listastring.Count retorna o tamanho da lista

        //Outra forma de fazer o foreach:
        //for(int i = 0; i < listastring.Count; i++)
        //{
        //    Console.WriteLine(listastring[i]);
        //}

        List<int> listaint = new List<int>();
        listaint.Add(1);
        listaint.Add(3);
        listaint.Insert(0, 4);
        foreach (int i in listaint)
        {
            Console.WriteLine(i);
        }

        //iniciando a lista com elementos
        List<double> listadouble = new List<double> { 2.5, 3, 8.2 };
        listadouble.Add(1);
    }
        

    static void ExemploListaObjeto()
    {
        //string nome = Console.ReadLine();
        List<Paciente> pacientes = new List<Paciente>();
        Paciente p1 = new Paciente(1, "Elias", "000", "elias.silva", new DateTime(1982, 07,22));
        Paciente p2 = new Paciente(2, "Pérolla", "111", "perolla.dias", new DateTime(2006, 07, 08));
        Paciente p3 = new Paciente(3, "Gaby", "222", "gaby.budim", new DateTime(2006, 09, 22));
        Paciente p4 = new Paciente(4, "Rhi", "333", "rhi.batista", new DateTime(2006, 04, 12));
        Paciente p5 = new Paciente(5, "Lucas", "444", "lucas.miranda", new DateTime(2007, 02, 21));
        //Paciente p6 = new Paciente();

        pacientes.Add(p1);
        pacientes.Add(p2);
        pacientes.Add(p3);
        pacientes.Add(p4);
        pacientes.Add(p5);
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // O método orderBy ordena uma lista a partir de um determinado atributo
        // Esse método retorna uma lista ordenada (precisa armazenar esse resultado)
        // ToList() converte o resultado para uma lista
        // Caso queira apresentar a nova lista ordenada, somente percorrê-la
        // No exemplo, x.Nome especifica que irá ordenar pelo atributo nome,
        // porém pode ser qualquer atributo do objeto.
        List<Paciente> pacientesOrdenados = pacientes.OrderBy(x => x.Nome).ToList();// ordenar atributos da lista
        List<Paciente> pacientesOrdenadosD = pacientes.OrderByDescending(x => x.Nome).ToList();

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //Recupera determinado elemento que contém o valor passado na expressão.
        //No exemplo, recupera o paciente que contém o cpf 000.
        Paciente pCpf0 = pacientes.SingleOrDefault(x => x.Cpf == "000");
        if( pCpf0 != null)
        {
            Console.WriteLine(pCpf0.Nome);
        }
        else
        {
            Console.WriteLine("Paciente não encontrado!");
        }

        //ou:
        //foreach(Paciente p in pacientesOrdenadosD)
        //{
        //    if (p.Cpf == "000")
        //    {
        //        Paciente pCpf00 = p;
        //    }
        //}

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////       
        //O método where é ultilizado para selecionar todos que atende alguma expressão
        //No exemplo abaixo, seleciona e armazena na lista e busca todos os pacientes que
        //possuem o valor de id_paciente maior que 2.
        Console.WriteLine("Digite o nome para realizar a busca: ");
        string nomeBusca = Console.ReadLine();
        List<Paciente> busca = pacientes.Where(x => x.Nome.ToUpper() == nomeBusca).ToList();

        //Buscar todos os nomes que inicia com determinada letra.
        List<Paciente> buscaL = pacientes.Where(x => x.Nome.ToUpper().StartsWith("A")).ToList();

        foreach (Paciente p in busca) 
        {
            Console.WriteLine(p.Nome +" "+p.Cpf); 
        }
        foreach (Paciente p in buscaL)
        {
            Console.WriteLine(p.Nome + " " + p.Cpf);
        }

        foreach (Paciente p in pacientesOrdenados) //Ordenar por nome de forma crescente
        {
        Console.WriteLine(p.Nome +" "+p.Cpf);
        }


        foreach (Paciente p in pacientesOrdenadosD) //Ordenar por nome de forma decrescente
        {
        Console.WriteLine(p.Nome + " " + p.Cpf);
        }
    }
}
    
