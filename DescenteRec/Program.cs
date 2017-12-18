using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescenteRec
{
    class Program
    {

        string chaine = "1+1-1*2/5#";
        char tc, ts;
        int index = 1;
       
       
        public void Z()  
        {
            Console.WriteLine("Start");

            tc = chaine[0];
            ts = chaine[1];
            Console.WriteLine(tc);
            if (tc=='('|tc=='0'|tc=='1'|tc=='2'|tc=='3'|tc=='4'|tc=='5'|tc=='6'|tc=='7'|tc=='8'|tc=='9')
            {
                E();
                if (tc == '#')
                    {
                        Console.Write("Z. result = succès");
                    }
                    else
                    {
                        Console.WriteLine("Z. result = erreur");
                    }
            }
            else
            {
                Console.WriteLine("Z.erreur");
            }
                    
        }
        public void E()
        {
            if (tc == '(' | tc == '0' | tc == '1' | tc == '2' | tc == '3' | tc == '4' | tc == '5' | tc == '6' | tc == '7' | tc == '8' | tc == '9')
            {
                T();
                E2();
                
            }
            else
            {
                Console.WriteLine("E.erreur");
            }

        }

        public void T()
        {
            if (tc == '(' | tc == '0' | tc == '1' | tc == '2' | tc == '3' | tc == '4' | tc == '5' | tc == '6' | tc == '7' | tc == '8' | tc == '9')
            {
                F();
                T2();

            }
            else
            {
                Console.WriteLine("T.erreur");
            }

        }
        public void E2()
        {
            switch(tc)
            {
                case '+':
                    tc = ts;
                    index++;
                    if (index < chaine.Length) ts = chaine[index];
                    T();
                    E2();
                    break;
                case '-' :
                    tc = ts;
                    index++;
                    if (index < chaine.Length) ts = chaine[index];
                    T();
                    E2();
                    break;
                case '#' :
                    ;
                    break;
                case')':
                    ;
                    break;
            default:
                    Console.WriteLine("E2.erreur");
                    break;
            }

        }


        public void F()
        {
            if (tc == '(' | tc == '0' | tc == '1' | tc == '2' | tc == '3' | tc == '4' | tc == '5' | tc == '6' | tc == '7' | tc == '8' | tc == '9')
            {
                tc = ts;
                index++;
                if (index < chaine.Length) ts = chaine[index];
                
            }
            else
            {
               if (tc=='(')
               {
                   tc = ts;
                   index++;
                   if (index < chaine.Length) ts = chaine[index];
                   E();
                   if (tc==')')
                   {
                       tc = ts;
                       index++;
                       if (index < chaine.Length) ts = chaine[index];
                   }
                   else
                   {
                       Console.WriteLine("F.erreur");
                   }

               }
               else
               {
                   Console.WriteLine("F.erreur");
               }
            }

        }

        public void T2()
        {
            Console.WriteLine("T2 " + tc);
            switch (tc)
            {
                case '*':
                    tc = ts;
                    index++;
                    if (index < chaine.Length) ts = chaine[index];
                    F();
                    T2();
                    break;
                case '/':
                    tc = ts;
                    index++;
                    if (index < chaine.Length) ts = chaine[index];
                    F();
                    T2();
                    break;
                case '#':
                    ;
                    break;
                case ')':
                    ;
                    break;
                case '+':
                    ;
                    break;
                case '-':
                    ;
                    break;
                default:
                    Console.WriteLine("T2.erreur");
                    break;
            }
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.Z();
            Console.ReadKey();

        }
    }
}
