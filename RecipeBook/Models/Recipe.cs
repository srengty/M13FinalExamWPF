using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Components { get; set; } = new List<string>();
        public List<string> Images { get; set; } = new List<string>();
        public string Instruction { get; set; } = "";
        public string Cuisine { get; set; } = "";
    }
}
