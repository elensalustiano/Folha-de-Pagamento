using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Conta
    {
        public static float inss, irrf,basee;
        public static string aliquotaIrrf, aliquotaInss,valorDeduzir;

        public static float calculoinss(float valor)
        {
            if (valor <= 1556.94)
            {
                inss = (float)Math.Round(valor * 0.08,2);//round arredonda para 2 casas 
                aliquotaInss = "Alíquota do INSS: 8%";                                            //decimais(num, casas)
            }
            else if (valor >= 1556.95 && valor <= 2594.92)
            {
                inss = (float)Math.Round(valor * 0.09,2);
                aliquotaInss = "Alíquota do INSS: 9%";  

            }
            else if(valor>=2594.93 && valor<= 5189.82)
            {
                inss = (float)Math.Round(valor * 0.11,2);
                aliquotaInss = "Alíquota do INSS: 11%";  
            }
            else
            {
                inss =(float) 570.88;
                aliquotaInss = "Contribuição máxima";  
            }
            return inss;
            
            
        }
       
        public static float calculoirrf(float basecal)
        {
            if(basecal<=1903.98)
            {
                irrf = 0;
                aliquotaIrrf = "Aliquota IRRF: -";
                valorDeduzir = "Valor a deduzir: -";
            }
            else if (basecal >= 1903.99 && basecal <= 2826.65)
            {
                irrf = (float)Math.Round(basecal * 0.075 - 142.80,2);
                aliquotaIrrf = "Aliquota IRRF: 7,5%";
                valorDeduzir = "Valor a deduzir: R$ 142.80";
            }
            else if (basecal >= 2826.66 && basecal <= 3751.05)
            {
                irrf = (float)Math.Round(basecal * 0.15 - 354.8,2);
                aliquotaIrrf = "Aliquota IRRF: 15%";
                valorDeduzir = "Valor a deduzir: R$ 354.8";

            }
            else if (basecal >= 3751.06 && basecal <= 4664.68)
            {
                irrf = (float)Math.Round(basecal * 0.225 - 636.13,2);
                aliquotaIrrf = "Aliquota IRRF: 22,5%";
                valorDeduzir = "Valor a deduzir: R$ 636.13";

            }
            else if (basecal >= 4664.68)
            {
                irrf = (float)Math.Round(basecal * 0.275 - 869.36,2);
                aliquotaIrrf = "Aliquota IRRF: 27,5%";
                valorDeduzir = "Valor a deduzir: R$ 869.36";

            }
            return irrf;

        }
        public static float baseDeCalculo(float valorr)
        {
            basee = (float)Math.Round(valorr - inss,2);
            return basee;

        }
    }
} 
