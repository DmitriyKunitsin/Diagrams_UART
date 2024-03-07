using System.IO.Ports;
using TestConsoleReadUART;

class Program
{
    static void Main(string[] args)
    {
        // Создание объекта SerialPort
        SerialPort serialPort = new SerialPort("COM7", 115200);
        try
        {
            // Открытие порта
            serialPort.Open();
            // Установка обработчика события при получении данных
            serialPort.DataReceived += SerialPort_DataReceived;
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
        finally
        {
            // Закрытие порта при выходе из программы
            serialPort.Close();
        }
    }
    private static void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
        // Приведение объекта sender к типу SerialPort
        SerialPort serialPort = (SerialPort)sender;
        // Чтение данных из порта
        string data = serialPort.ReadLine();
        // возвращаем в массив ключи 
        string[] keyValuePairs = SplitKeyAndValue.GetSplitKey(data);
        // возвращаем значения по ключам
        string[] resultValue = SplitKeyAndValue.GetValueForKey(keyValuePairs);
        // Обработка принятых данных
        Print.printXYZ(resultValue);
    }
}
