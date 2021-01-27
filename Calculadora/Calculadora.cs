namespace Calculadora
{
    public static class Calculadora
    {
        public static int Calcular(string operador, int x, int y)
        {
            var resultado = 0;

            if (operador == "+")
                resultado = Soma(x, y);
            else if (operador == "-")
                resultado = Subtracao(x, y);
            else if (operador == "/")
                resultado = Divisao(x, y);
            else if (operador == "*")
                resultado = Multiplicacao(x, y);

            return resultado;
        }

        static int Soma(int x, int y)
        {
            return x + y;
        }
        
        static int Subtracao(int x, int y)
        {
            return x - y;
        }

        static int Divisao(int x, int y)
        {
            return x / y;
        }

        static int Multiplicacao(int x, int y)
        {
            return x * y;
        }
    }
}
