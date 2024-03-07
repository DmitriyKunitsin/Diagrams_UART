namespace TestConsoleReadUART
{
    internal class SplitKeyAndValue
    {
        public static string[] GetValueForKey(string[] array)
        {
            int count = 0;
            string[] buffer = new string[3];
            foreach (string pair in array)
            {
                //Разбиваю строку на ключ, значение
                string[] parts = pair.Split(':');
                if (parts.Length == 2)
                {
                    buffer[count] = parts[1].Trim();
                    count++;
                }
                else
                {
                    Console.WriteLine("Все плохо, пришла не корректная строка с порта");
                }
            }
            return buffer;
        }
        public static string[] GetSplitKey(string stingValue)
        {
            return stingValue.Split(";");
        }
    }
}
