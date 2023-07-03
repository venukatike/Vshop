using System;
using System.Collections.Generic;
using System.Text;

namespace Vshop.view
{
    public class FlyoutPage1FlyoutMenuItem
    {
        public FlyoutPage1FlyoutMenuItem()
        {
            TargetType = typeof(FlyoutPage1FlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}
