using System;
using System.Linq;

namespace Calk
{
    struct Sign {
        private readonly char _sign;
        public Sign(char c) { _sign = c; }
        public static bool IsSign(char c)
        {
            return "+-/*^".Contains(c);
        }
        public int Priority()
        {
            switch (_sign)
            {
                case '+': return 1;
                case '-': return 1;
                case '*': return 2;
                case '/': return 2;
                case '^': return 3;
                default: return 0;
            }
        }
        public Double Compute(Double left, Double right)
        {
            switch (_sign)
            {
                case '+': return left + right;
                case '-': return left - right;
                case '*': return left * right;
                case '/': return right != 0 ? (left / right): Double.NaN;
                case '^': return Math.Pow(left, right);
                default: return 0.0;
            }
        }
        public override string ToString()
        {
            return _sign.ToString();
        }
    }

    interface ICalcExpressionTree
    {
        Double Evalute();
        int Priority();
        ICalcExpressionTree Append(char c);
        ICalcExpressionTree RemoveLast();
    }

    class NodeExpressionTree : ICalcExpressionTree
    {
        private Double _value;
        
        public NodeExpressionTree()
        {
            _value = 0;
        }
        public NodeExpressionTree(double value)
        {
            _value = value;
        }
        public static bool IsDigit(char c) {
            return "0123456789".Contains(c);
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        public double Evalute()
        {
            return _value;
        }
        public int Priority() {
            return 0;
        }

        public ICalcExpressionTree Append(char c)
        {
            if (Sign.IsSign(c))
            {
                return new BinaryExpressionTree(new Sign(c), this, new NodeExpressionTree());
            }
            if (IsDigit(c))
            {
                if (_value == 0)
                {
                    _value = Double.Parse(c.ToString());
                    return this;
                }
                if (_value.ToString().EndsWith(".0")) {
                    _value = Double.Parse(c.ToString().Replace(".0", "." + c));
                    return this;
                }
                try
                {
                    _value = Double.Parse(this.ToString() + c);
                }
                catch { }
                return this;
            }
            if (c == '.' && !_value.ToString().Contains('.'))
            {
                try
                {
                    _value = Double.Parse(this.ToString() + c + '0');
                }
                catch { }
                return this;
            }

            return this;
        }

        public ICalcExpressionTree RemoveLast()
        {
            if (_value == 0)
            {
                return null;
            }
            try
            {
                string s = _value.ToString();
                s = s.Remove(s.Length - 1);
                if (s.EndsWith("."))
                {
                    s = s.Remove(s.Length - 1);
                }
                _value = Double.Parse(s);
                return this;
            }
            catch
            {
                return null;
            }
        }
    }

    class BinaryExpressionTree : ICalcExpressionTree
    {
        private ICalcExpressionTree _left;
        private ICalcExpressionTree _right;
        private Sign _sign;
        private bool _hasBraces;

        public BinaryExpressionTree(Sign sign, ICalcExpressionTree left, ICalcExpressionTree right)
        {
            _left = left;
            _right = right;
            _sign = sign;
            _hasBraces = false;
        }

        public override string ToString()
        {
            string s = $"{_left} ${_sign} ${_right}";
            if (_hasBraces)
            {
                s = $"({s})";
            }
            return s;
        }

        public double Evalute()
        {
            return _sign.Compute(_left.Evalute(), _right.Evalute());
        }

        public int Priority() {
            return _sign.Priority();
        }

        public ICalcExpressionTree Append(char c)
        {
            ICalcExpressionTree element = _right.Append(c);
            if (this.Priority() < element.Priority())
            {
                this._hasBraces = true;
            }
            _right = element;
            return this;
        }

        public ICalcExpressionTree RemoveLast()
        {
            ICalcExpressionTree element = _right.RemoveLast();
            if (element == null) {
                return _left;
            }
            _right = element;
            return this;
        }
    }

    class FuncExpressionTree : ICalcExpressionTree
    {
        private ICalcExpressionTree _expr;
        private bool _isSinus;
        private FuncExpressionTree(ICalcExpressionTree expr, bool isSinus)
        {
            _expr = expr;
            _isSinus = isSinus;
        }
        public static FuncExpressionTree SinExpressionTree(ICalcExpressionTree expr)
        {
            return new FuncExpressionTree(expr, true);
        }
        public static FuncExpressionTree CosExpressionTree(ICalcExpressionTree expr)
        {
            return new FuncExpressionTree(expr, false);
        }

        public override string ToString()
        {
            string funcName = "cos";
            if (_isSinus) {
                funcName = "sin";
            }
            return $"{funcName}({_expr})";
        }

        public double Evalute()
        {
            if (_isSinus) {
                return Math.Sin(_expr.Evalute());
            }
            return Math.Cos(_expr.Evalute());
        }

        public int Priority()
        {
            return 0;
        }

        public ICalcExpressionTree Append(char c)
        {
            if (Sign.IsSign(c))
            {
                return new BinaryExpressionTree(new Sign(c), this, new NodeExpressionTree());
            }
            return this;
        }

        public ICalcExpressionTree RemoveLast()
        {
            return _expr;
        }
    }

    
    // Ядро калькулятора. Вызов методов позволяет менять состояние калькулятора
    public class CalcKernel
    {
        private ICalcExpressionTree _expr;

        public CalcKernel()
        {
            _expr = new NodeExpressionTree();
        }

        // Этот метод возвращает строку, которую необходимо вывести в текстовое поле
        public override string ToString()
        {
            return _expr.ToString() ?? "";
        }

        // Посчитать значение выражения и сбросить все действия (При нажатии равно)
        public string Evalute() 
        {
            Double result = _expr.Evalute();
            _expr = new NodeExpressionTree(result);
            return result.ToString();
        }

        // Ввод символа (Только числа от 0 до 9 и знаки + - * / ^ )
        public string Push(char c) {
            _expr = _expr.Append(c);
            return _expr.ToString();
        }
        
        // Удаление последнего введеного символа
        public string Pop()
        {
            _expr = _expr.RemoveLast();
            if (_expr == null)
            {
                _expr = new NodeExpressionTree();
            }
            return _expr.ToString();
        }

        // Сброс калькулятора
        public string Clear()
        {
            _expr = new NodeExpressionTree();
            return _expr.ToString();
        }
    }
}
