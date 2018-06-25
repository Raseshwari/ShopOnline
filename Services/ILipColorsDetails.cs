using ShopOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopOnline.Services
{
   public interface ILipColorsDetails
    {
        IEnumerable<LipColor> GetAll();

        LipColor GetLipColorById(int id);

        LipColor AddLipColor(LipColor lipColor);

        LipColor Update(LipColor lipColor);
    }
}
