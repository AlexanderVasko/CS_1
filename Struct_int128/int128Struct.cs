using System;


namespace Struct_int128
{
    public struct Int128
    {
        private ulong high;
        private ulong low;
        // true >= 0; false < 0
        private bool sign;

        public Int128(long var)
        {
            low = (ulong)var;
            high = 0;
            sign = var >= 0;
        }

        public override string ToString()
        {
            if (sign)
                return high.ToString() + low.ToString();
            else
                return "-" + high.ToString() + low.ToString();
        }

        public static Int128 operator +(Int128 var1, Int128 var2)
        {            
            Int128 res;
            res.low = var1.low + var2.low;
            res.high = var1.high + var2.high;
            if (res.low < var1.low)
            {
                res.high++;
            }

            if (res.high < var1.high)
            {
                throw new OverflowException();
            }

            if (var1.sign && var2.sign)
            {
                res.sign = true;
                return res;
            }
            if (!var1.sign && !var2.sign)
            { 
                res.sign = false;
                return res;
            }

            if (var1.high == var2.high)
            {
                if (var1.low > var2.low)
                {
                    res.sign = var1.sign;
                    return res;
                }
                else
                {
                    res.sign = var2.sign; ;
                    return res;
                }
            }

            if (var1.high > var2.high)
            {
                res.sign = var1.sign;
                return res;
            }
            else
            {
                res.sign = var2.sign;
                return res;
            }            
        }
    }
}
