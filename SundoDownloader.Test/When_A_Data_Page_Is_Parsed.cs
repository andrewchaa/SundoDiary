﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Machine.Specifications;
using SundoDiary.Domain;
using SundoDiary.Domain.Repositories;

namespace SundoDiary.Test
{
    [Subject(typeof(DataPageParser))]
    public class When_A_Data_Page_Is_Parsed
    {
        private static IParse<DataPage> pages;
        private static DataPage page;
        private static string fileContent;

        Establish context = () => {
            pages = new DataPageParser();
            fileContent = File.ReadAllText(@".\Resource\sdt01_00.htm", Encoding.Default);
        };

        Because Parser_parse_the_content = () => page = pages.Parse(fileContent);

        It title_should_be_populated = () => page.Title.ShouldNotBeEmpty();

        It content_should_be_populated = () => page.Content.ShouldNotBeEmpty();

    }

    public class Temp
    {
        private static byte[] _utfBytes;
        private static string _result;

        Because encoding = () =>
                               {
//                                   var asciiBytes = File.ReadAllBytes(@".\Resource\sdt01_00.htm");
//                                   _utfBytes = ASCIIEncoding.Convert(ASCIIEncoding.Default, UTF8Encoding.UTF8, asciiBytes);
//                                   _result = Encoding.UTF8.GetString(_utfBytes);
//                                   _result = Encoding.UTF8.GetString(asciiBytes);
//                                   var bytes = File.ReadAllBytes(@".\Resource\Copy of sdt01_00.htm");
                                   var bytes = File.ReadAllBytes(@".\Resource\sdt01_00.htm");
                                   var encodedBytes = UTF8Encoding.Convert(Encoding.GetEncoding(949), Encoding.UTF8, bytes);
                                   _result = Encoding.UTF8.GetString(encodedBytes);
                               };

        It should_be_converted_to_utf8 = () => { _result.ShouldEqual("test"); };
    }

}