using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolCanteen.BE.Data.Entities;

namespace SchoolCanteen.BE.Data.Services
{
    public class MenuService
    {
        private static List<Menu> _menus;

        public MenuService()
        {
            _menus = new List<Menu>();

            _menus.Add(new Menu()
            {
                Id = 1,
                Date = DateTime.Now,
                FoodPackets = new List<FoodPacket>()
                {
                    new FoodPacket
                    {
                        Id = 1,
                        Title = "Meal #1",
                        Price = 10,
                        Desc = "",
                    },
                    new FoodPacket
                    {
                        Id = 2,
                        Title = "Meal #2",
                        Price = 10,
                        Desc = "",
                    },
                    new FoodPacket
                    {
                        Id = 3,
                        Title = "Meal #3",
                        Price = 10,
                        Desc = "",
                    },
                }
            });
            _menus.Add(new Menu()
            {
                Id = 2,
                Date = DateTime.Now,
                FoodPackets = new List<FoodPacket>()
                {
                    new FoodPacket
                    {
                        Id = 4,
                        Title = "Meal #4",
                        Price = 10,
                        Desc = "",
                    },
                    new FoodPacket
                    {
                        Id = 5,
                        Title = "Meal #5",
                        Price = 10,
                        Desc = "",
                    },
                    new FoodPacket
                    {
                        Id = 6,
                        Title = "Meal #6",
                        Price = 10,
                        Desc = "",
                    },
                }
            });
        }

        public IEnumerable<Menu> GetAll()
        {
            return _menus;
        }
    }
}
