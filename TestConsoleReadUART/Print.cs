namespace TestConsoleReadUART
{
    internal class Print
    {
        private const int MaxRight = 80;
        public static void printXYZ(string[] array)
        {
            int xval = Convert.ToInt32(array[0]);
            int yval = Convert.ToInt32(array[1]);
            int zval = Convert.ToInt32(array[2]);
            int maxValue = 65000; // Максимальное значение для шкалы диаграммы

            int xBarLength = (int)Math.Round((double)xval / maxValue * MaxRight);
            int yBarLength = (int)Math.Round((double)yval / maxValue * MaxRight);
            int zBarLength = (int)Math.Round((double)zval / maxValue * MaxRight);

            Console.WriteLine(new string('_', MaxRight));

            Console.WriteLine("X: " + new string('*', xBarLength) + " (" + xval + ")");
            Console.WriteLine("Y: " + new string('*', yBarLength) + " (" + yval + ")");
            Console.WriteLine("Z: " + new string('*', zBarLength) + " (" + zval + ")");
        }
    }
}
