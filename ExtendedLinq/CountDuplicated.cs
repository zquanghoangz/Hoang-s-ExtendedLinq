using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedLinq
{
    public static  partial class ExtendedLinqExtension
    {
        public static Dictionary<TSource, int> CountDuplicated<TSource>(this IEnumerable<TSource> sources)
        {
            if (sources == null)
            {
                throw new ArgumentNullException();
            }

            Dictionary<TSource, int> output = new Dictionary<TSource, int>();

            foreach (var item in sources)
            {
                if (output.ContainsKey(item))
                {
                    output[item]++;
                }
                else
                {
                    output.Add(item, 1);
                }
            }

            return output;
        }
    }
}
