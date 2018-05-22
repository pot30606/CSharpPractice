using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork05Luwei
{
    class Program
    {

        static void Main(string[] args)
        {
            CreateDishes();
            //高麗菜 1 份 30
            //豆干   2 片 15
            //海帶   2 片 15
            //肉片   1 份 40


        }

        private static List<LuWei> CreateDishes()
        {
            List<LuWei> dishes = new List<LuWei>()
            {
                new LuWei{Name="高麗菜1份",Price=30 },
                new LuWei{Name="豆干2片",Price=15 },
                new LuWei{Name="海帶2片",Price=15 },
                new LuWei{Name="肉片1份",Price=40 }
            };
            return dishes;
        }

    }
}
