using System;

namespace SemaExp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Semafori problem (traffic lights)
            // https://open.kattis.com/problems/semafori
            // this is somebody solution.. it is not mine!!
            // solution's source:
            // https://github.com/iandioch/solutions/blob/master/kattis/semafori/solution.c 
            // .............................................................................

            int dist = 0, time = 0;

            int d, r, g;

            int numlights, totdist;

            var two = Enter2Num();
            numlights = two[0];
            totdist = two[1];

            int lastd = 0;
            int[] three = new int[3];
            for (int i = 0; i < numlights; ++i)
            {
                three = Enter3Num();
                d = three[0];
                r = three[1];
                g = three[2];

                //dist += d - lastd;

                time += d - lastd;

                int cycles = time / (r + g);

                int ready = cycles * (r + g) + r;

                while (time < ready)
                {
                    ++time;
                }
                lastd = d;
            } // ---- End FOR LOOP ----
            
            time += totdist - lastd;

            Console.WriteLine(time);



        } // -- end main --
        
        private static int[] Enter2Num()
        {
            var strArr = Console.ReadLine().Split(' ', 2);
            int[] res = new int[2] { 0, 0 };
            res[0] = int.Parse(strArr[0]);
            res[1] = int.Parse(strArr[1]);
            return res;
        }
        private static int[] Enter3Num()
        {
            var strArr = Console.ReadLine().Split(' ', 3);
            int[] res = new int[3] { 0, 0, 0 };
            res[0] = int.Parse(strArr[0]);
            res[1] = int.Parse(strArr[1]);
            res[2] = int.Parse(strArr[2]);
            return res;
        }
    }
}
