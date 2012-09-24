namespace SundoDiary.Domain
{
    public class ContentLink
    {
        public string Link { get; set; }
        public string Text { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (GetType() != obj.GetType()) return false;

            var contentLink = obj as ContentLink;

            return Link == contentLink.Link && Text == contentLink.Text;
        }

        public override string ToString()
        {
            return Text;

        }
    }
}
