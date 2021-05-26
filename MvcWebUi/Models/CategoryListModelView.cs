using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUi.Models
{
    public class CategoryListModelView
    {
        public List<Category> Categories { get; set; }
        public int CurrentCategory { get; set; }
    }
}
