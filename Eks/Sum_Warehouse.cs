using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eks
{
  public partial  class Books
    {
        public string Sum
        {
            get
            {
                if (Sum_Store > 5)
                {
                    return "Много";
                }
                else if (Sum_Store < 1)
                {
                    return "Нет";
                }
                else
                {
                    return Sum_Store.ToString();
                }
            }
            set { }
        }


        public string Sum1
        {
            get
            {
                if (Sum_Warehouse > 5)
                {
                    return "Много";
                }
                else if (Sum_Warehouse < 1)
                {
                    return "Нет";
                }
                else
                {
                    return Sum_Warehouse.ToString();
                }
            }
            set { }
        }
    }
}
