using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalV1
{
     public class BE
    {
           
        public int ValorDescuento;

        public int Cupon ()
        {

            return (ValorDescuento * 25) / 100; 
        }
       
      
    }
    
}

