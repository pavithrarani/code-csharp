namespace codingBat
{
    public class warmup1
    {
        public bool sleep(bool weekday, bool vacation)
        {
            if (!weekday && !vacation)
                return true;
            else if (weekday && !vacation)
                return false;
            else
            {
                return true;
            }

        }

        //smile
        public bool smile(bool aSmile, bool bSmile)
        {
            if (aSmile && bSmile)
            {
                return true;
            }
            else if (aSmile && !bSmile) return false;
            else return true;
        }
        //sum
        public int compute(int n1, int n2)
        {

            if (n1 != n2)
            {
                return n1 + n2;

            }
            else return 2 * (n1 + n2);
        }
        static void Main(string[] args)
        {
            System.Console.Write("hello");
        }
    }
}
