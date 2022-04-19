using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eks
{
    public class LoadList
    {
        public List<Books> books;
        public LoadList()
        {
            books = BaseConnect.BaseModel.Books.ToList();//заполняем лист книгами
        }
    }
}
