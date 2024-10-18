using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SimpleConfigModuleFlyoutMenuItem
    {
        public SimpleConfigModuleFlyoutMenuItem()
        {
            TargetType = typeof(SimpleConfigModuleFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}