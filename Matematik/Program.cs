using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(8, 9);
            dortIslem.Topla(-8, 9);
            dortIslem.Cıkar(-8, -9);
            dortIslem.Cıkar(-8, 0);
            dortIslem.Carp(-8, -9);
            dortIslem.Carp(-8, 9);
            
        }
    }
}
