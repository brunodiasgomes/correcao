using System;

namespace Correcao /* Aluno: Bruno Dias Gomes RA 31827615*/
{    /*Questão 02*/
    class IMC
    {    /*Primeira Forma*/
        private double peso;
        private double altura;

        public IMC()
        {
            this.peso = 0.0;
            this.altura = 0.0;

        }
        /*Segunda Forma EX*/
        public IMC(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }
        public double Calcular(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        public double Classificar(double imc)
        {
            return 0.0;
        }
      
    }
}
