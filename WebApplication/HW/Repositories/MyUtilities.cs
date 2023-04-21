using System;

namespace HW.Repositories
{
    public class MyUtilities
    {
        public int GetAge(DateTime? inDateTime)
        {
            var dateTime = inDateTime.HasValue ? inDateTime : DateTime.UtcNow;

            return
                (DateTime.UtcNow.Year - dateTime.Value.Year - 1) +
                (((DateTime.UtcNow.Month > dateTime.Value.Month) ||
                ((DateTime.UtcNow.Month == dateTime.Value.Month) && (DateTime.UtcNow.Day >= dateTime.Value.Day))) ? 1 : 0);
        }
    }
}
