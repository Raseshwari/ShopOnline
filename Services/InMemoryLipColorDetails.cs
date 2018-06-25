using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopOnline.Models;

namespace ShopOnline.Services
{
    /*public class InMemoryLipColorDetails : ILipColorsDetails
    {
        List <LipColor> _lipcolordetails;

        public InMemoryLipColorDetails()
        {
            _lipcolordetails = new List<LipColor>
            {
                new LipColor{ Cprodid = 87, Cprodname = "Lakme 9 to 5"},
                new LipColor{ Cprodid = 66, Cprodname = "Maybelline"},
                new LipColor{ Cprodid = 45, Cprodname = "Revlon"}
            };
        }

        public LipColor AddLipColor(LipColor lipColor)
        {
            lipColor.Cprodid = _lipcolordetails.Max(l => l.Cprodid) + 1;
            _lipcolordetails.Add(lipColor);
            return lipColor;
        }

        public IEnumerable<LipColor> GetAll()
        {
            return _lipcolordetails.OrderBy(l => l.Cprodid);
        }

        public LipColor GetLipColorById(int id)
        {
            return _lipcolordetails.FirstOrDefault(l => l.Cprodid == id);
        }
    }*/
}
