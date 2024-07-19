using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advc_1
{
    internal class range<T> where T : IComparable<T>
    {



        public T min { get; set; }
        public T max { get; set; }
        public range(T min, T max)
        {
            this.min = min;
            this.max = max;
        }


        public bool IsInRange(T value)
        {
            return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
        }

        public T Length()
        {
            dynamic min = this.min;
            dynamic max = this.max;
            dynamic diffrence = max - min;
            return diffrence;
        }
    }

}

