namespace _041_方法的递归调用
{
    class Program
    {
        static int F(int n)
        {
            if (n == 0)
            {
                return 2;
            }
            if (n == 1)
            {
                return 3;
            }
            int res = F(n - 1) + F(n - 2);
            return res;
        }
        static void Main(string[] args)
        {
            ////f(n-1)
            //int n_1 = 3;
            ////f(n-2)
            //int n_2 = 2;
            //int n = 0;
            ////f(n) = f(n-1) + f(n-2)    求f(40)
            //for (int i = 2; i < 41; i++)
            //{
            //    n = n_1 + n_2;
            //    n_2 = n_1;
            //    n_1 = n;
            //}
            //System.Console.WriteLine(n);

            System.Console.WriteLine(F(40));

            System.Console.ReadKey();
        }
    }
}
