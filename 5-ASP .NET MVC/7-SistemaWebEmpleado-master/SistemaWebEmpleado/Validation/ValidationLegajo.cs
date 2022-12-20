using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace SistemaWebEmpleado.Validations
{
    public class CheckLegajo : ValidationAttribute
    {
        public CheckLegajo()
        {
            ErrorMessage = "El formato del legajo debe comenzar con dos A seguido de 5 números. Por ejemplo: AA15789";
        }

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }
            else
            {
                string legajoValidation = value.ToString();

                if (legajoValidation.Length != 7)
                {
                    return false;
                }
                else
                {
                    if (legajoValidation[0] == 'A' && legajoValidation[1] == 'A')
                    {
                        string resultNumbers = Regex.Match(legajoValidation, @"\d+").Value;
                        if (resultNumbers.Length == 5)
                        {
                            return true;
                        }
                    }

                    return false;
                }
            }
            

        }
    }
}