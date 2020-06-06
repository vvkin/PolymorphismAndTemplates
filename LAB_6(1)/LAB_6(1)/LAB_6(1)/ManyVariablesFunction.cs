namespace LAB_6_1_
{
    abstract class ManyVariablesFunction
    {
        private double[] variables; // Значення змінних функції
        private readonly int variablesNumber; // Кількість змінних

        /// <summary>
        /// Обчислення значення функції
        /// </summary>
        /// <returns>Обчислене значення</returns>
        public abstract double Calculate();

        /// <summary>
        /// Перевірка значення та кількості отриманих змінних
        /// </summary>
        /// <param name="variables">Вхідні змінні</param>
        /// <returns>Повертає булеве значення корректності вхідних даних</returns>
        public abstract bool AreCorrectVariables(double[] variables);

        /// <summary>
        /// Встановлення нових знвчень змінних або сповіщення про помилку
        /// </summary>
        /// <param name="variables">Вхідні змінні</param>
        public abstract void SetVariables(double[] variables);
    }
}
