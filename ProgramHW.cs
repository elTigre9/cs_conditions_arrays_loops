using System;

namespace hw92519
{
    class ProgramHW
    {
        static void Main(string[] args)
        {

            string[] slist = { "hi", "hello", "bye" };
            float[] flist = { 4f, 6f, 12f, 0f };

            foreach(string x in slist)
            {
                string greeting = x + " " + "Ben";
                Console.WriteLine(greeting);
                // keep coding
            }

            foreach(float x in flist)
            {
                Console.WriteLine(x);
            }

            for(int i = 0; i < flist.Length; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(flist[i]);
            }

            foreach(float x in flist)
            {
                float y = x * 10f;
                if(x > 15f)
                {
                    Console.WriteLine("x is greater than 15");
                    // more code
                } else
                {
                    Console.WriteLine("x is not greater than 15");
                }
            }

        }
    }
}
