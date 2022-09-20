using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class elsuma
    {
        //campo propiedades, como es
        private int n1;
        private int n2;

       
          public elsuma(int n1, int n2)
          {
              this.n1 = n1;
              this.n2 = n2;
          }

         
          public int sumar()
          {
              return (n1 + n2);
          }

          public double meno()
          {
              return (n1 - n2);
          }
          public double dividir()
          {
              return (n1 / n2);
          }
          public double multi()
          {
              return (n1 * n2);
          }
    }
}
