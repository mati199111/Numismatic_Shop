using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Numismatic_Shop
{
    public delegate int Calculate(object ob1, object ob2);
    public class event_test
    {
        static public event Calculate kalk;
        static public int Add(int x, int y)
        {
            int result = x * y;
            return result;
        }
        static public int onCalculate(object ob1, object ob2)
        {
            int result = 0;
            if(kalk != null)
            {
                result = kalk(ob1, ob2);
            }
            return result;
        }

    }
}
