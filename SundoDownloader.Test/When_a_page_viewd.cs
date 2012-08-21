using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;
using SundoDiary.Domain;
using SundoDiary.Models;

namespace SundoDiary.Test
{
    public class When_a_page_viewd
    {
        private static ReadViewModel _viewModel;
        private static IEnumerable<ContentLink> _links;
        private static DataPage _dataPage;
        private static ContentLink _aa1;
        private static ContentLink _aa2;
        private static ContentLink _aa3;
        private static ContentLink _aa4;
        private static ContentLink _aa5;

        private Establish context = () =>
                                        {
                                            _aa1 = new ContentLink {Link = "aa1.htm", Text = "aa1"};
                                            _aa2 = new ContentLink {Link = "aa2.htm", Text = "aa2"};
                                            _aa3 = new ContentLink {Link = "aa3.htm", Text = "aa3"};
                                            _aa4 = new ContentLink {Link = "", Text = "aa4"};
                                            _aa5 = new ContentLink {Link = "aa5.htm", Text = "aa5"};

                                            _links = new List<ContentLink> { _aa1, _aa2, _aa3, _aa4, _aa5 };
                                            _dataPage = new DataPage();
                                        };

        private It should_have_ContentLink_As_Value_Object = () => new ContentLink {Link = "a", Text = "a"}.ShouldEqual(new ContentLink {Link = "a", Text = "a"});

        private It should_set_the_next_page = () =>
                                                  {
                                                      _viewModel = new ReadViewModel(_links, new DataPage(), "aa2.htm");
                                                      _viewModel.NextPage.ShouldEqual(_aa3);
                                                  };

        private It should_skip_the_empty_link = () =>
                                                    {
                                                        _viewModel = new ReadViewModel(_links, new DataPage(), "aa3.htm");
                                                        _viewModel.NextPage.ShouldEqual(_aa5);
                                                    };

        private It should_set_previous_page = () =>
                                                  {
                                                      _viewModel = new ReadViewModel(_links, new DataPage(), "aa5.htm");
                                                      _viewModel.PreviousPage.ShouldEqual(_aa3);
                                                  };
    }
}
