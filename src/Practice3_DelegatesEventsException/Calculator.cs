using Microsoft.Extensions.Logging;
using System.Collections.Generic;
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
        private ILogger logger;

        public Calculator() : this(LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
            builder.SetMinimumLevel(LogLevel.Error);
        }).CreateLogger<Calculator<T>>()) { }
        public Calculator(ILogger logger)
        {
            this.logger = logger;
        }

        private double Add(T x, T y) => (double)Convert.ChangeType(x + y, typeof(double));
        private double Subtract(T x, T y) => (double)Convert.ChangeType(x - y, typeof(double));
        private double Mult(T x, T y) => (double)Convert.ChangeType(x * y, typeof(double));
        private double Divide(T x, T y) => (double)Convert.ChangeType(x / y, typeof(double));

        private Operation<T> SelectOperation(OperationType _operationType)
        {
            switch (_operationType)
            {
                case OperationType.Add: return Add;
                case OperationType.Subtract: return Subtract;
                case OperationType.Multiply: return Mult;
                case OperationType.Divide: return Divide;
                default: throw new InvalidOperationException("Enter correct operation!");
            }
        }
        private void ParseExpression(string expression)
        {
            string[] splittedExpr = expression.Split(' ');
            //string[] splittedExpr = expression.Split(new string[] { "+", "-", "*", "/" }, StringSplitOptions.None);
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
            try
            {
                ParseExpression(expression);
                Operation<T> operation = SelectOperation(operationType);
                return operation(number1, number2);
            }
            catch (InvalidInputException e)
            {
                logger.LogError(e, e.Message);
            }
            catch (InvalidCastException e)
            {
                logger.LogError(e, e.Message);
            }
            catch (DivideByZeroException e)
            {
                logger.LogError(e, e.Message);
            }
            catch (InvalidOperationException e)
            {
                logger.LogError(e, e.Message);
            }
            return double.NaN;
        }
    }
}
