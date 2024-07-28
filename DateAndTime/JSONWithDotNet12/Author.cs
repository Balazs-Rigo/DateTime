using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONWithDotNet12
{
    public class Author
    {
        public string Name { get; set; }
        public string[] Courses { get; set; }
        public List<Author> FavoriteAuthors { get; set; }
    }
}
