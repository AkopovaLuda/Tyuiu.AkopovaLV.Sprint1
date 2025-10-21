using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.AkopovaLV.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            int rub = (int)number;
            int cop = (int)((number - rub) * 100);
            return $"{rub} руб. {cop} коп.";
        }
    }
}
