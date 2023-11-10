        //EDUARDO DOMENES KNIPHOFF DA SILVEIRA RU 37638302
        


        //PRIMEIRO DEFINIMOS AS VARIAVEIS QUE VAMOS USAR

        int a, b, c;

        double delta, x1, x2;


        //Primeiro numero do RU
        Console.Write("Digite o valor para A:");

        a=int.Parse(Console.ReadLine());

        //Segundo numero do RU
        Console.Write("Digite o valor para B:");

        b=int.Parse(Console.ReadLine());


        //Terceiro numero de RU
        Console.Write("Digite o valor para C:");

        c=int.Parse(Console.ReadLine());


        //Usamos o comando "If/Else" para validarmos os valores que foram colocados
        //Valor de "a" nao pode ser zero
        if(a==0){
            Console.WriteLine("O valor de 'a' não pode ser zero. Impossivel calcular!");
        }
        else
        {
            //A equação para calcular Delta
            delta=(b* b) - (4* a* c);
            
            //O valor de delta não pode ser menor que zero
            if (delta < 0)
            {
                Console.WriteLine("O valor de 'Delta' não pode ser menor que zero. Impossivel calcular!");
            }

            //Calculos finais para X1 e X2
            else
            {
                x1 = -b + (Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine(String.Format($"Valor de X1: {x1}"));
                Console.WriteLine();

                x2 = -b - (Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine(String.Format($"Valor de X2: {x2}"));
            }
                }
         
        

