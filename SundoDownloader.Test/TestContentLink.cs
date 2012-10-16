using System.Collections.Generic;
using NUnit.Framework;
using SundoDiary.Domain;
using SundoDiary.Models;

namespace SundoDiary.Test
{
    public class TestContentLink
    {
        private ReadViewModel _viewModel;
        private IEnumerable<ContentLink> _links;
        private DataPage _dataPage;
        private ContentLink _aa1;
        private ContentLink _aa2;
        private ContentLink _aa3;
        private ContentLink _aa4;
        private ContentLink _aa5;

        [SetUp]
        public void Before_Each_Test()
        {
            _aa1 = new ContentLink {Link = "aa1.htm", Text = "aa1"};
            _aa2 = new ContentLink {Link = "aa2.htm", Text = "aa2"};
            _aa3 = new ContentLink {Link = "aa3.htm", Text = "aa3"};
            _aa4 = new ContentLink {Link = "", Text = "aa4"};
            _aa5 = new ContentLink {Link = "aa5.htm", Text = "aa5"};
            
            _links = new List<ContentLink> { _aa1, _aa2, _aa3, _aa4, _aa5 };
            _dataPage = new DataPage();
            
        }

        [Test]
        public void ContentLink_Is_A_Value_Object()
        {
            var link1 = new ContentLink { Link = "a", Text = "a" };
            var link2 = new ContentLink { Link = "a", Text = "a" };
    
            Assert.That(link1, Is.EqualTo(link2));
        }
        
//        [Test]
//        public void ViewMode_Knows_Nexxt_Page_Given_The_Current_Page()
//        {
//            _viewModel = new ReadViewModel(_links, _dataPage, "aa2.htm");
//            Assert.That(_viewModel.NextPage, Is.EqualTo(_aa3));
//        }

//
//        private It should_skip_the_empty_link = () =>
//                                                    {
//                                                        _viewModel = new ReadViewModel(_links, new DataPage(), "aa3.htm");
//                                                        _viewModel.NextPage.ShouldEqual(_aa5);
//                                                    };
//
//        private It should_set_previous_page = () =>
//                                                  {
//                                                      _viewModel = new ReadViewModel(_links, new DataPage(), "aa5.htm");
//                                                      _viewModel.PreviousPage.ShouldEqual(_aa3);
//                                                  };
    }
}
