﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeLib
{
    public static class PrimeCalc
    {
        public static string GetPrimesAsJson(long min, long max)
        {
            List<long> primes = GetPrimes(min, max);

            return JsonConvert.SerializeObject(primes);
        }

        public static List<long> GetPrimes(long min, long max)
        {
            var primes = new List<long>();
            for (long x = min; x <= max; x++)
            {
                if (IsPrime(x))
                {
                    primes.Add(x);
                }
            }

            return primes;
        }

        public static bool IsPrime(long n)
        {
            if (n < 2) return false;
            if (n < 4) return true;
            if (n % 2 == 0) return false;

            double sqrt = System.Math.Sqrt(n);
            int sqrtCeiling = (int)System.Math.Ceiling(sqrt);

            for (int i = 3; i <= sqrtCeiling; i += 2)
                if (n % i == 0) return false;
            return true;
        }
    }
}
