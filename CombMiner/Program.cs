using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace CombMiner
{
    class Program
    {
        static void Main(string[] args)
        {
            var ZilMiner = new MainPrg();
            ZilMiner.Path = @"C:\Users\Daniel_Klauser\Desktop\ZilMiner\zilminer.exe";
            ZilMiner.Arguments = "-P zil://zil1aazxenlf0298vp7z24rvyp5kk4fyveakg353aq.daniel@eu1-zil.shardpool.io:5000/api --report-hr=1 --work-timeout=99998 --retry-delay=998 --farm-retries=99998";

            var VtcMiner = new MainPrg();
            VtcMiner.Path = @"C:/Users/Daniel_Klauser/Desktop/ZilMiner/Vertcoin/vertcoin-ocm.exe";

            var cancellationTokenSource = new CancellationTokenSource();

            var canCelTokeSrcVtc = new CancellationTokenSource();

            var t1 = new Task(() => ZilMiner.Start(),
                    cancellationTokenSource.Token,
                    TaskCreationOptions.LongRunning);

            var t2 = new Task(() => VtcMiner.Start(),
                    canCelTokeSrcVtc.Token,
                    TaskCreationOptions.LongRunning);
            t1.Start();
            t2.Start();
            while (true)
            {
                var text = Console.ReadLine();
            }
        }
    }
}
