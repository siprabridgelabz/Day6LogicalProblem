using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LogicalProblem
{
    public class CouponNumber
    {
        static Random random = new Random();
        public static void FindCouponNumber()
        {
            int vouchersToGenerate = 10;
            int lengthOfVoucher = 10;


            List<string> generatedVouchers = new List<string>();
            char[] keys = "ABCDEFGHIJKLMNOPQRSTUVWXYZ01234567890".ToCharArray();


            Console.WriteLine("Vouchers: ");
            while (generatedVouchers.Count < vouchersToGenerate)
            {
                var voucher = GenerateVoucher(keys, lengthOfVoucher);
                if (!generatedVouchers.Contains(voucher))
                {
                    generatedVouchers.Add(voucher);
                    Console.WriteLine("\t[#{0}] {1}", generatedVouchers.Count, voucher);
                }
            }

            Console.WriteLine("done");

            Console.ReadLine();
        }

        private static string GenerateVoucher(char[] keys, int lengthOfVoucher)
        {
            return Enumerable
                .Range(1, lengthOfVoucher)  
                .Select(k => keys[random.Next(0, keys.Length - 1)])  
                .Aggregate("", (e, c) => e + c); 
        }
    }
          
        


      
}
        
            
            
    

