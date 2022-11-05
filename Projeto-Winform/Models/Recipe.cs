
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoWinform.Models
{
    internal class Recipe
    {
        public string descricao;
        public Product product;
        public int qt_produce;
        public List<RawMaterial> list_rawMaterials;
        public int qt_material;
        public Recipe()
        {
            list_rawMaterials = new List<RawMaterial>();
        }
    }
}
