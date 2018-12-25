using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderForJD
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpHelper helper = new HttpHelper();
            HttpItem item = new HttpItem();
            item.Url = "https://www.jd.com/";
            HttpResult result = new HttpResult();
            result = helper.GetHtml(item);
            //Console.WriteLine(result.Cookie);
            Console.WriteLine(result.Header);
            //Console.WriteLine(result.Html);
            Console.WriteLine(result.StatusCode);
        }
    }
}
