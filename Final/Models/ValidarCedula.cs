using Final.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Final.Models
{
    public class ValidarCedula : ValidationAttribute
    {
        private readonly ApplicationDbContext context;

        public ValidarCedula() : base("La cédula es inválida")
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string cedula = Convert.ToString(value);
            var mensajeDeError = FormatErrorMessage(validationContext.DisplayName);
            if (value != null)
            {
                //Declaración de variables a nivel de método o función.
                int verificador = 0;
                int digito = 0;
                int digitoVerificador = 0;
                int digitoImpar = 0;
                int sumaPar = 0;
                int sumaImpar = 0;
                int longitud = Convert.ToInt32(cedula.Length);
                /*Control de errores en el código*/
                try
                {
                    //verificamos que la longitud del parametro sea igual a 11
                    if (longitud == 11)
                    {

                        if ((int.Parse(cedula.Substring(0, 3)) < 122 && int.Parse(cedula.Substring(0, 3)) > 0 || int.Parse(cedula.Substring(0, 3)) == 402))
                        {
                            digitoVerificador = Convert.ToInt32(cedula.Substring(10, 1));
                            //recorremos en un ciclo for cada dígito de la cédula
                            for (int i = 9; i >= 0; i--)
                            {
                                //si el digito no es par multiplicamos por 2
                                digito = Convert.ToInt32(cedula.Substring(i, 1));
                                if ((i % 2) != 0)
                                {
                                    digitoImpar = digito * 2;
                                    //si el digito obtenido es mayor a 10, restamos 9
                                    if (digitoImpar >= 10)
                                    {
                                        digitoImpar = digitoImpar - 9;
                                    }
                                    sumaImpar = sumaImpar + digitoImpar;
                                }
                                /*En los demás casos sumamos el dígito y lo aculamos 
                                 en la variable */
                                else
                                {
                                    sumaPar = sumaPar + digito;
                                }
                            }
                            /*Obtenemos el verificador restandole a 10 el modulo 10 
                            de la suma total de los dígitos*/
                            verificador = 10 - ((sumaPar + sumaImpar) % 10);
                            /*si el verificador es igual a 10 y el dígito verificador
                              es igual a cero o el verificador y el dígito verificador 
                              son iguales retorna verdadero*/
                            if (((verificador == 10) && (digitoVerificador == 0))
                                 || (verificador == digitoVerificador))
                            {
                                return ValidationResult.Success;
                            }
                        }
                    }
                    else
                    {
                        //sConsole.WriteLine("La cédula debe contener once(11) digitos");
                    }
                }
                catch
                {
                    //Console.WriteLine("No se pudo validar la cédula");
                }

                
                return new ValidationResult(mensajeDeError);
            }
            return ValidationResult.Success;
        }
    }
}