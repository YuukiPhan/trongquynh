using Microsoft.AspNetCore.Mvc;

namespace tuan4.Models
{
    public class FutureDate : Controller
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value),"dd/m/yyyy",
            CultureInfo..CurrentCulture,
            DateTimeStyles.None,
                out dateTime);
                return (isValid && dateTime>DateTime.Now);
        }
    }
}
