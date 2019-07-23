using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleArraySum
{
    class Program
    {
    static int simpleArraySum(int[] arCount) {
            int sum = 0;
            for (int i = 0; i < arCount.Length; i++)
            {
                sum += Convert.ToInt32(arCount[i]);
            }
            return sum;
    }
    static void Main(string[] args) {
        int arCount = Convert.ToInt32(Console.ReadLine());
        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
        int result = simpleArraySum(ar);
        Console.WriteLine(result);
    }
    }
}
