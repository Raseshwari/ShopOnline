using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ShopOnline.Data;
using ShopOnline.Models;

namespace ShopOnline.Services
{
    public class SqlLipColorData : ILipColorsDetails
    {
        private ShopOnlineDbContext _context;

        public SqlLipColorData(ShopOnlineDbContext context)
        {
            _context = context;
        }
        public LipColor AddLipColor(LipColor lipColor)
        {
            _context.LipColor.Add(lipColor);
            _context.SaveChanges();
            return lipColor;
        }

        public IEnumerable<LipColor> GetAll()
        {
           return _context.LipColor.OrderBy(l => l.CShade);
        }

        public LipColor GetLipColorById(int id)
        {
            return _context.LipColor.FirstOrDefault(l => l.Cprodid == id);
        }

        public LipColor Update(LipColor lipColor)
        {
            _context.Attach(lipColor).State = EntityState.Modified;
            _context.SaveChanges();
            return lipColor;
        }
    }
}
