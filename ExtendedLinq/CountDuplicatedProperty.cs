using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedLinq
{
    public static partial class ExtendedLinqExtension
    {
        public static Dictionary<TResult, int> CountDuplicatedProperty<TSource, TResult>(this IEnumerable<TSource> sources, Func<TSource,TResult> selector )
        {
            //Validate parameter

            //Get output
            Dictionary<TResult, int> output = new Dictionary<TResult, int>();

            foreach (var item in sources)
            {
                var result = selector.Invoke(item);

                if (output.ContainsKey(result))
                {
                    output[result]++;
                }
                else
                {
                    output.Add(result, 1);
                }
            }

            return output;
        }
    }


}
