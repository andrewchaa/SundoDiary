using System.IO;
using System.Text;
using NUnit.Framework;
using SundoDiary.Domain;
using SundoDiary.Domain.Repositories;

namespace SundoDiary.Test
{
    public class When_A_Data_Page_Is_Parsed
    {
        private static IParse<DataPage> pages;
        private static DataPage page;
        private static string fileContent;

//        Establish context = () => {
//            pages = new DataPageParser();
//            fileContent = File.ReadAllText(@".\Resource\sdt01_00.htm", Encoding.Default);
//        };
//
//        Because Parser_parse_the_content = () => page = pages.Parse(fileContent);
//
//        It title_should_be_populated = () => page.Title.ShouldNotBeEmpty();
//
//        It content_should_be_populated = () => page.Content.ShouldNotBeEmpty();

    }

    [Ignore]
    public class Temp
    {
        private static byte[] _utfBytes;
        private static string _result;

//        Because encoding = () =>
//                               {
//                                   var bytes = File.ReadAllBytes(@".\Resource\sdt01_00.htm");
//                                   var encodedBytes = UTF8Encoding.Convert(Encoding.GetEncoding(949), Encoding.UTF8, bytes);
//                                   _result = Encoding.UTF8.GetString(encodedBytes);
//                               };
//
//        It should_be_converted_to_utf8 = () => { _result.ShouldEqual("test"); };
    }

}
