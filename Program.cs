using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igraNaKarte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int zbroj =0, broj= 0;


            while(zbroj <31){

                Console.Write("Unesi broj karte: ");
                broj = Convert.ToInt32(Console.ReadLine());
                if (broj < 1 || broj > 13)
                {
                    broj = 0;
                    Console.WriteLine("Upisali ste pogresan broj. Raspon 1-13!!");
                }
                zbroj = zbroj+broj;
             }

            if(zbroj == 31)
            {
                Console.WriteLine("Svaka cast zbroj je 31!!");
            }
            else
            {
                Console.WriteLine("Niste uspjesno odigrali POkuSaj PoNoVo! -->" + zbroj);
            }

            Console.ReadKey();



        }
    }
}
