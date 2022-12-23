using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace WPFCreatePay.app.Model
{
    public partial class Operators
    {

        public int Id { get; set; }
        public string Phone { get; set; }
        public string Logo { get; set; }
        
        public string Name { get; set; }
        public float Precent { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
