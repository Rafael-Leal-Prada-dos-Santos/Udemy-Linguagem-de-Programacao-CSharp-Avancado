using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ValidacaoCustomizada
{
    public class MinhaValidacaoAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string texto = (string)value;

            if (texto.Length == 10)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
