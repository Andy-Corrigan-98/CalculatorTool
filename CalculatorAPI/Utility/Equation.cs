using CalculatorTest;
using Newtonsoft.Json.Linq;

namespace CalculatorAPI.Utility
{
    public class Equation
    {
        private float startOperand; //use floats to cater for all calculator operations
        private float endOperand;
        private Operator calcType;
        private bool hasNested;
        private Equation? nestedEquation; //capacity for handling subequations. 

        public Equation(JObject equation)
        {
            startOperand = float.Parse((equation.GetValue("Operand1") ?? "").ToString());

            hasNested = bool.Parse((equation.GetValue("HasNested") ?? "").ToString());

            string opToken = (equation.GetValue("Operation") ?? "").ToString().ToLowerInvariant();

            switch (opToken)
            {
                case "add":
                    calcType = Operator.Add;
                    break;
                case "subtract":
                    calcType = Operator.Subtract;
                    break;
                case "divide":
                    calcType = Operator.Divide;
                    break;
                case "multiply":
                    calcType = Operator.Multiply;
                    break;
            }

            if (hasNested)
            {
                nestedEquation = new Equation(JObject.Parse((equation.GetValue("NestedEquation") ?? "").ToString()));
            }
            else
            {
                nestedEquation = null;
                endOperand = float.Parse((equation.GetValue("Operand2") ?? "").ToString());
            }
        }

        public float CalculateResult()
        {
            if (hasNested) // recurse for any subequations
            {
                endOperand = nestedEquation.CalculateResult(); //complains about potential null reference, but if it hits here it shouldn't be null so can ignore that warning
            }

            SimpleCalculator calculator = new();

            return calcType switch
            {
                Operator.Add => calculator.Add((int)startOperand, (int)endOperand),
                Operator.Subtract => calculator.Subtract((int)startOperand, (int)endOperand),
                Operator.Divide => calculator.Divide((int)startOperand, (int)endOperand),
                _ => calculator.Multiply((int)startOperand, (int)endOperand)
            };

        }
    }
}
