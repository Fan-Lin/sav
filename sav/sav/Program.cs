using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sav
{
    class Program
    {
        static void Main(string[] args)
        {
            float r;
            float d;
            float s;
            float Result;
            int Type;
            int Type2;
            Console.WriteLine("你想要计算什么？\n体积请输入1 表面积请输入2\n----------------------------------------");
            Type = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("你知道什么条件？\n半径请键入1 直径请键入2 底面积请键入3\n----------------------------------------");
            Type2 = Convert.ToInt16(Console.ReadLine());
            //以下代码为Overdo*赋值的0只是为了清除错误，并无实际意义
            int Overdooftype2 = 0;
            do
            {
                switch (Type2)
                {
                    case 1:
                        //半径保留位置
                        break;
                    case 2:
                        //直径保留位置
                        break;
                    default:
                        Overdooftype2 = 0;
                        break;
                }

            } while (Overdooftype2 == 0);
            //以下代码为Overdo*赋值的0只是为了清除错误，并无实际意义
            int Overdooftype = 0;
            do
            {
                switch (Type)
                {
                    case 1:
                        Console.WriteLine("圆柱请键入1 圆锥请键入2\n----------------------------------------");
                        int Typeofv = Convert.ToInt16(Console.ReadLine());
                        Overdooftype = 1;

                        break;
                    case 2:
                        //表面积保留位置
                        break;
                    default:
                        Overdooftype = 0;
                        break;
                }
            } while (Overdooftype == 0);

        }
    }
}
