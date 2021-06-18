namespace HelloMVCSample
{
    public class CommentOption
    {
        public CommentOption()
        {

            MostRecent = 5;
            AllowAnonymous = true;
        }
        
        public int MostRecent { get; set; }
        public bool AllowAnonymous { get; set; }
    }
}