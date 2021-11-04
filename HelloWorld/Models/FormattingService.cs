using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Models
{
    public class FormattingService
    {
        public string DateTimeFormat(DateTime dt)
        {
            return DateTime.Now.ToString("d");
        }
    }
}
