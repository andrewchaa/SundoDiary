using Machine.Specifications;
using SundoDiary.Domain;

namespace SundoDiary.Test
{

    [Subject(typeof(Domain.Downloader))]
    public class When_the_downloader_retrieve_an_index
    {
        public static Domain.Downloader _downloader;
        private static DownloadedPage result;

        private Establish context = () =>
                                        {
                                            _downloader = new Domain.Downloader();

                                        };

        Because the_page_is_retrieved = () => result = _downloader.GetIndex("http://www.myhand.kr/new/sdt01_ix.htm");

        It should_get_the_html_content = () => result.Html.ShouldNotBeEmpty();
        It should_parse_the_content_and_return_page_urls = () => result.PageUrls.ShouldNotBeEmpty();
    }

    
}
