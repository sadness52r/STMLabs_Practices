using System.Numerics;

namespace Practice3_DelegatesEventsException
{
    delegate double Operation<T>(T x, T y) where T : INumber<T>;
    enum OperationType
    {
        Add = '+',
        Subtract = '-',
        Multiply = '*',
        Divide = '/',
    }

    internal class Calculator<T> where T : INumber<T>
    {
        private T? number1, number2;
        private OperationType operationType;

        private double Add(T x, T y) => (double)Convert.ChangeType(x + y, typeof(double));
        private double Subtract(T x, T y) => (double)Convert.ChangeType(x - y, typeof(double));
        private double Mult(T x, T y) => (double)Convert.ChangeType(x * y, typeof(double));
        private double Divide(T x, T y) => (double)Convert.ChangeType(x / y, typeof(double));

        private Operation<T> SelectOperation(OperationType _operationType) => _operationType switch
        {
            OperationType.Add => Add,
            OperationType.Subtract => Subtract,
            OperationType.Multiply => Mult,
            OperationType.Divide => Divide,
            _ => throw new InvalidOperationException("Enter correct operation!")
        };
        private void ParseExpression(string expression)
        {
            string[] splittedExpr = expression.Split(' ');
            if (splittedExpr.Length != 3)
            {
                throw new InvalidInputException("Invalid format of expression!");
            }
            number1 = (T)Convert.ChangeType(splittedExpr[0], typeof(T));
            number2 = (T)Convert.ChangeType(splittedExpr[2], typeof(T));
            operationType = (OperationType)splittedExpr[1][0];
        }

        public double Calculate(string expression)
        {
            ParseExpression(expression);
            Operation<T> operation = SelectOperation(operationType);
            return operation(number1, number2);
        }
    }
}
