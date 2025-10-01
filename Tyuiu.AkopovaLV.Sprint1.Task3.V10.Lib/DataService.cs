using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AkopovaLV.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            double roundedNumber = Math.Round(number, 3);

            // Получаем рубли (целая часть)
            int rub = (int)roundedNumber;

            // Получаем копейки (дробная часть * 100)
            double fractionalPart = roundedNumber - rub;
            int kop = (int)Math.Round(fractionalPart * 100);

            // Корректируем, если копеек получилось 100
            if (kop >= 100)
            {
                rub += kop / 100;
                kop %= 100;
            }

            return $"{rub} руб. {kop:D2} коп.";
        }
    }
}
