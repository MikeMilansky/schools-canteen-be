using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCanteen.BE.Data.Entities
{
    public class Menu
    {
        public int Id { get; set; }
        public IEnumerable<FoodPacket> FoodPackets { get; set; }
        public DateTime Date { get; set; }

        public Menu()
        {
            FoodPackets = new List<FoodPacket>();
        }
    }
}
