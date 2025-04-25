using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_atm_yap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*kullanıcıya nasıl bir işelem yapmak istefdiğini soracağız
             * 1 para görüntüleme
             * 2 para çekmek ve eğer kullanıcının çekeceği miktar bakiyesinden düşükse kullanıcıya bakiyesininn yetersiz olduğunu belirteceğiz
             * 3 para yatırma
             * q çıkış yapmak
             * değer girilmediyse lüten yapmak istediğiniz işlemi belirtiniz diyecegiz*/
             
            
            int bakiye = 1000;
            Console.WriteLine("ATMye hoşgeldiniz:");
            Console.WriteLine("yapmak istediğiniz işlemi belirtiniz:");
            string seçim = Console.ReadLine();
            if (seçim == "1")
            {
                Console.WriteLine("kullanıcı bakiyesi:" + bakiye);
            }
            else if (seçim == "2")
            {
                Console.WriteLine("lütfen çekmek istediğiniz miktarı belirtiniz");
                int cekilecek_tutar = int.Parse(Console.ReadLine());
            
             if (cekilecek_tutar <= bakiye)

            {
                Console.WriteLine("kalan tutar" + (bakiye - cekilecek_tutar));
                Console.ReadLine();
            }
                else
                {
                    Console.WriteLine();
                }

            
               
            }  
        }
    }
}
