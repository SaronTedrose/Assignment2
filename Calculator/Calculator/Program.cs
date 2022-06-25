// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class Program
{
    
    static void Main(string[] args)
    {
        double firstnum;
        double secondnum;
        double answer;
        string ops;
        string a;
        Console.WriteLine("\t\t\tConsole Calculator\r");
        Console.WriteLine("\t\t\t-------------------\r");
        do
        {
            
            Console.WriteLine("\t\t\tEnter first number\n");
            firstnum = Double.Parse(Console.ReadLine());
            Console.WriteLine("\t\t\tSelect an operator(+,-,*,/,%)\n");
            ops = Console.ReadLine();
            Console.WriteLine("\t\t\tEnter second number\n");
            secondnum = Double.Parse(Console.ReadLine());

            if (ops == "+")
            {
                answer = firstnum + secondnum;
                Console.Write("The answer is "+answer);
             
            }
            else if (ops == "-")
            {
                answer = firstnum - secondnum;
                Console.Write("The answer is " + answer);
               
            }
            else if (ops == "*")
            {
                answer = firstnum * secondnum;
                Console.Write("The answer is " + answer);
               
            }
            else if (ops == "/")
            {
                answer = firstnum / secondnum;
                if (secondnum == 0)
                {
                    Console.Write("Number can not be divided by 0");
                }
                else
                {
                    Console.Write("The answer is " + answer);
                }

            }
            else if (ops == "%")
            {
                answer = firstnum % secondnum;
                Console.Write("The answer is " + answer);
               
            }
            else
            {
                while (ops != "+"&& ops != "-" && ops != "*" && ops != "/" && ops != "%")
                {
                    Console.WriteLine("\t\t\tYou entered a wrong operation.Enter again!\n");
                
                    Console.WriteLine("\t\t\tEnter first number\n");
                    firstnum = Double.Parse(Console.ReadLine());
                    Console.WriteLine("\t\t\tSelect an operator(+,-,*,/,%)\n");
                    ops = Console.ReadLine();
                    Console.WriteLine("\t\t\tEnter second number\n");
                    secondnum = Double.Parse(Console.ReadLine());

                    if (ops == "+")
                    {
                        answer = firstnum + secondnum;
                        Console.Write("The answer is " + answer);
                       
                    }
                    else if (ops == "-")
                    {
                        answer = firstnum - secondnum;
                        Console.Write("The answer is " + answer);
                      
                    }
                    else if (ops == "*")
                    {
                        answer = firstnum * secondnum;
                        Console.Write("The answer is " + answer);
                        
                    }
                    else if (ops == "/")
                    {
                        answer = firstnum / secondnum;
                        if (secondnum == 0)
                        {
                            Console.Write("Number can not be divided by 0");
                        }
                        else
                        {
                            Console.Write("The answer is " + answer);
                        }
                    }
                    else if (ops == "%")
                    {
                        answer = firstnum % secondnum;
                        Console.Write("The answer is " + answer);

                    }
                }
            }

            Console.WriteLine("\t\t\tDo you want to continue?(Y/N)\n");
            a = Console.ReadLine();


            


        } while (a=="y"||a=="Y");

      
        Console.WriteLine("\t\t\tThank you!!\n");
        Console.ReadKey();
    }



}