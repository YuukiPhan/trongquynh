using Microsoft.AspNetCore.Mvc;

namespace tuan4.Models
{
    public class ValidTime : Controller
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), "HH:mm",
                CultureInfo.CurrentCulture.
                DateTimeStyles.None,
                out dateTime);
            return isValid;
        }
    }
}
