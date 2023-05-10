using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo01
{
    public static class ConversorTemperatura
    {
        //metodo estatico para converter temperatura de celsius para fahreinheit.w
        public static float CelsiusParaFahrenheit(float temperaturaCelsius){
            return temperaturaCelsius * (9f/5f) + 32f;
        }

        public static float FahreinheitParaCelsius(float temperaturaFahreinheit){
            return ((temperaturaFahreinheit -32f) * (5f/9f));
        }
    }
}