namespace _021_资源访问冲突
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StateObject state = new StateObject();
            for (int i = 0; i < 100; i++)
            {
                Thread t1 = new Thread(state.ChangeState1);
                t1.Start();
                Thread t2 = new Thread(state.ChangeState2);
                t2.Start();
            }
        }
    }
}