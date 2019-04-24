using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp.Models
{
    public class DailyModel
    {
        public string summary { get; set; }
        public string icon { get; set; }
        public List<DailyDataModel> data { get; set; }
    }
}
