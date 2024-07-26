namespace Practice3_DelegatesEventsExceptions
{
    delegate double QuadraticTrinomial(double x);

    internal class Task3
    {
        public static QuadraticTrinomial CalcExpression(double a, double b, double c) =>
            (x) => a * x * x + b * x + c;
    }
}
