using System.Web.Services;

namespace WebService
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]

    public class FibonacciService : System.Web.Services.WebService
    {

        [WebMethod]
        public int Fibonacci(int n)
        {
            if (n < 1 || n > 100)
            {
                return -1;
            }

            int a = 0;
            int b = 1;

            for (int i = 2; i <= n; ++i)
            {
                int cache = a + b;
                a = b;
                b = cache;
            }

            return b;
        }
    }
}
