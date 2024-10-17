namespace operaciones
{
    public class Op_arimetica
    {
        public double operacionmatematicas(double a, double b, string operacion)
        {
            switch (operacion)
            {
                case "+":
                    return Suma(a, b);
                case "-":
                    return Rectas(a, b);
                case "X":
                    return Multiplicacion(a, b);
                case "÷":
                    if (b == 0)
                        throw new DivideByZeroException("Error al dividir entre 0");
                    return Division(a, b);
                default:
                    throw new ArgumentException("Operación no reconocida.");
            }
        }

        public double operacionAritmeticas(double a, double b, string operacion)
        {
            switch (operacion)
            {
                case "%":
                    return Porcentaje(a, b);
                case "√x":
                    return Raiz(a);
                case "^2":
                    return Cuadrado(a);
                case "⅟":
                    return Uno_x(a);
                case "±":
                    return inversa(a);  
                default:
                    throw new ArgumentException("Operación aritmética no reconocida.");
            }
        }

        private double Suma(double x, double y)
        {
            return x + y;
        }

        private double Rectas(double x, double y)
        {
            return x -= y;
        }
        private double Multiplicacion(double x, double y)
        {
            return x *= y;
        }
        private double Division(double x, double y)
        {
            return x /= y;
        }
        private double Porcentaje(double x, double y)
        {
            return x *= y / 100;
        }
        private double Raiz(double x)
        {
            return Math.Sqrt(x);
        }
        private double Uno_x(double x)
        {
            return 1/x;
        }
        private double Cuadrado(double x)
        {
            return x * x ;
        }
        private double inversa(double x)
        { 
            return -x; 
        }
    }
}
