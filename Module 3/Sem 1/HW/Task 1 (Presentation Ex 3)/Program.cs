using System;

namespace Task_1__Presentation_Ex_3_
{
    public delegate double delegateConvertTempereture(double d);
    class TemperatureConvertlmp
    {
        public double FromCelciusToFarenheit(double c)
        {
            return 1.8 * c + 32;
        }

        public double FromFarenheinToCelcius(double f)
        {
            return (f - 32) * 5 / 9;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureConvertlmp t = new TemperatureConvertlmp();
            delegateConvertTempereture cTof = new delegateConvertTempereture(t.FromCelciusToFarenheit);
            delegateConvertTempereture fToc = new delegateConvertTempereture(t.FromFarenheinToCelcius);
            Console.WriteLine(cTof?.Invoke(30));
            Console.WriteLine(fToc?.Invoke(100));
        }
    }
}
