using System;

namespace LAB_6_1_
{
    class TwoVariablesFunction : ManyVariablesFunction
    {
        private double[] variables; // Значення змінних функції
        private readonly int variablesNumber; // Кількість змінних

        public TwoVariablesFunction(double[] variables)
        {
            variablesNumber = 2;
            // Пробуємо встановити значення отриманих змінних
            SetVariables(variables); 
        }

        public override double Calculate()
        {
            var result = (variables[0] * variables[0] + Math.Sqrt(3 * Math.Pow(variables[1], 3)));
            // Заокруглення до трьох знаків після коми
            return Math.Round(result, 3);
        }

        public override bool AreCorrectVariables(double[] variables)
        {
            // Значення під квадратним коренем має бути невід'ємним, а
            // кількість змінних має бути рівною 2
            return (variables.Length == variablesNumber && variables[1] >= 0);
        }

        public override void SetVariables(double[] variables)
        {
            if (AreCorrectVariables(variables))
                this.variables = variables.Clone() as double[];
            else
                throw (new Exception("Incorrect parameters!\n")); // Якщо щось не так, то кидаємо помилку
        }
    }
}
