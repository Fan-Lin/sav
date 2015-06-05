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
            switch (Type)
            {
                case 1:
                    int Typeofv;
                    Console.WriteLine("圆柱（1）或圆锥（2）？");
                    Typeofv = Convert.ToInt16(Console.ReadLine());
                    switch (Typeofv)
                    {
                        case 1:
                            //圆柱保留位置
                            break;
                        case 2:
                            //圆锥保留位置
                            break;
                        default:
                            //goto语句保留位置
                            break;
                    }

                break;
                case 2:
                    //表面积保留位置
                break;
                default:
                    //goto语句保留位置
                break;
            }

        }
    }
}
