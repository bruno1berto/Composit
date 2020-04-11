using System;

namespace Composicao.Entities
{
    class HouerContract
    {
        public DateTime Date { get; set; }
        public double  ValuePerHouer { get; set; }
        public int Hours { get; set; }

        public HouerContract() 
        { 
        }
        public HouerContract(DateTime date, double valuePerHouer, int hours)
        {
            Date = date;
            ValuePerHouer = valuePerHouer;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHouer;
        }
    }
}
