using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SundoDiary.Downloader
{
    public class Program
    {
        static void Main(string[] args)
        {

            var uris = GetUris();

            var downloader = new Domain.Downloader();
            foreach (var uri in uris)
            {
                var page = downloader.GetIndex(uri);

                if (string.IsNullOrEmpty(page.Html))
                {
                    Console.WriteLine("failed: {0}", uri);
                    continue;
                    
                }

                File.WriteAllText(string.Format("c:\\temp\\{0}", uri.Replace("http://www.myhand.kr/new/", string.Empty)), page.Html, Encoding.Default);
                Console.WriteLine("success: {0}", uri);
            }

        }

        private static IEnumerable<string> GetUris()
        {
            IList<string> uris = new List<string>();
            uris.Add("http://www.myhand.kr/new/sdt84_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt84_98.htm");
            uris.Add("http://www.myhand.kr/new/sdt00_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt02_90.htm");
            uris.Add("http://www.myhand.kr/new/sdt22_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt23_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt24_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt25_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt26_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt27_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt28_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt29_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt31_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt32_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt33_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt34_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt35_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt36_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt37_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt38_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt39_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt40_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt41_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt42_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt43_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt44_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt45_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt46_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt47_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt48_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt49_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt49_91.htm");
            uris.Add("http://www.myhand.kr/new/sdt50_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt51_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt52_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt53_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt54_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt55_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt56_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt57_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt58_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt59_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt60_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt61_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt62_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt63_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt64_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt65_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt66_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt67_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt68_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt69_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt69_98.htm");
            uris.Add("http://www.myhand.kr/new/sdt70_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt71_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt72_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt73_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt74_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt75_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt76_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt76_98.htm");
            uris.Add("http://www.myhand.kr/new/sdt77_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt78_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt79_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt81_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt82_99.htm");
            uris.Add("http://www.myhand.kr/new/sdt83_99.htm");


            return uris;
        }

//        private static IEnumerable<string> GetUris()
//        {
//            IList<string> uris = new List<string>();// {"http://www.myhand.kr/new/sdt01_ix.htm"};
//
//            for (int chapter = 0; chapter < 85; chapter++)
//            {
//                uris.Add(string.Format("http://www.myhand.kr/new/sdt{0:0#}_ix.htm", chapter));
//                for (int page = 0; page < 20; page++)
//                {
//                    uris.Add(string.Format("http://www.myhand.kr/new/sdt{0:0#}_{1:0#}.htm", chapter, page));
//                }
//
//            }
//            return uris;
//        }
    }
}
