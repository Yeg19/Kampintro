using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi " + product.Name + " " + product.Description + " " + product.Price + " " + product.Stock);
        }

        public void Ekle2()
        {

        }
    }
}
