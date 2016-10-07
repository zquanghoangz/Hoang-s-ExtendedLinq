using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendedLinq
{
    public static partial class ExtendedLinqExtension
    {
        /// <summary>
        /// Count duplicated item
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="sources"></param>
        /// <param name="selecter"></param>
        /// <returns></returns>
        public static IEnumerable<KeyValuePair<TResult,int>> CountBy<TSource, TResult>
            (this IEnumerable<TSource> sources, Func<TSource,TResult> selecter )
        {
            //Validate parameter
            if (sources == null)
            {
                throw new ArgumentNullException();
            }

            //Get output
            Dictionary<TResult, int> output = new Dictionary<TResult, int>();

            foreach (var item in sources)
            {
                TResult result = selecter.Invoke(item);
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
