using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Conta
    {
        public static float inss, irrf;
        public static float calculoinss(float valor)
        {
            if (valor < 1556.94)
            {
                inss = (float)(valor * 0.08);
            }
            else if (valor > 1556.95 && valor < 2594.92)
            {
                inss = (float)(valor * 0.09);

            }
            else if(valor>2594.93 && valor< 5189.82)
            {
                inss = (float)(valor * 0.11);
            }
            else
            {
                inss =(float) 570.88;
            }
            return inss;
            
        }
        public static float calculoirrf(float basecal)
        {
            if (basecal > 1903.99 && basecal < 2826.65)
            {
                irrf = (float)(basecal * 0.075 - 142.80);
            }
            else if (basecal > 2826.66 && basecal < 3751.05)
            {
                irrf = (float)(basecal * 0.15 - 354.8);

            }
            else if (basecal > 3751.06 && basecal < 4664.68)
            {
                irrf = (float)(basecal * 0.225 - 636.13);

            }
            else if (basecal > 4664.68)
            {
                irrf = (float)(basecal * 0.275 - 869.36);

            }
            return irrf;
        }
    }
} 
