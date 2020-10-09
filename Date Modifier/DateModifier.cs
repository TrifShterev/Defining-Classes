using System;
using System.Collections.Generic;
using System.Text;

namespace Date_Modifier
{
    class DateModifier
    {
        public int GetsdaysDiference(string startDayString, string endDayString)
        {
            DateTime startDay = DateTime.Parse(startDayString);
            DateTime endDay = DateTime.Parse(endDayString);
            int totalDays =(int)Math.Abs((endDay - startDay).TotalDays);
            return totalDays;
        }
    }
}
